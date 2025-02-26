/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Editor Control to edit the application Progress
 * 
 * 
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the LGPL General Public License as published by
 * the Free Software Foundation; either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * LGPL General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not check the GitHub-Repository.
 * 
 * */

using OLKI.Programme.BeOrSy.Properties;
using OLKI.Programme.BeOrSy.src.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    /// <summary>
    /// Editor Control to edit the application Progress
    /// </summary>
    public partial class ProgressEditor : UserControl
    {
        #region Events
        /// <summary>
        /// Raised if a Item was added
        /// </summary>
        public event EventHandler ItemAdded;
        #endregion

        #region Fields
        /// <summary>
        /// Color Dialog to change colors
        /// </summary>
        private readonly ColorDialog _colorDialog = new ColorDialog();

        /// <summary>
        /// Selector for Progress Templates
        /// </summary>
        private readonly ProgressTemplateSelectorForm _templateSelector = new ProgressTemplateSelectorForm();

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Progress Items for the Editor
        /// </summary>
        private Dictionary<int, ProgressItem> _items = null;
        /// <summary>
        /// Get or set the Progress Items for the Editor
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ProgressItem> Items
        {
            get => this._items;
            set
            {
                this._items = value;
                this.ListItems();
            }
        }

        /// <summary>
        /// Get or set the IdSet for this Editor
        /// </summary>
        [Browsable(false)]
        public IdSet IdSet { get; set; }

        /// <summary>
        /// Selected Progress Item
        /// </summary>
        [Browsable(false)]
        public ProgressItem SelectedItem { get; private set; } = null;

        /// <summary>
        /// Set the main Project
        /// </summary>
        [Browsable(false)]
        public src.Project.Project Project
        {
            set
            {
                this._templateSelector.Items = value.Settings.ProgressTemplateList;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Editor Control to edit the application Progress
        /// </summary>
        public ProgressEditor()
        {
            InitializeComponent();
#if !DEBUG
            this.Width -= this.prgEditor.Width - this.prgEditor.Margin.Left - this.prgEditor.Right - this.grpProgressEdit.Margin.Right;
            this.prgEditor.Enabled = false;
            this.prgEditor.Visible = false;
#endif
            this.nudWeight.Maximum = Settings_AppConst.Default.ProgressWeightMax;

            this.toolTip.ToolTipTitle = Stringtable._0x0030c;
            this.toolTip.SetToolTip(this.chkWeight, Stringtable._0x0030m);
            this.toolTip.SetToolTip(this.nudWeight, Stringtable._0x0030m);
            this.toolTip.SetToolTip(this.lblWeightActivateOverride, Stringtable._0x0030m);

            this.chkWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this.chkWeight_CheckedChanged(this, EventArgs.Empty);
        }

        #region Manage Progress
        /// <summary>
        /// Check the plausibility of the Progress Sequence and set the ErrorProvider
        /// </summary>
        private void CheckSequencePlausibility()
        {
            int ItemId;
            ProgressItem ProgBefore = new ProgressItem(0);
            erpItemsList.SetError(this.lsvItems, "");
            ProgBefore = new ProgressItem(0);
            foreach (ListViewItem ListViewItem in this.lsvItems.Items)
            {
                ItemId = (int)ListViewItem.Tag;
                if (!ProgressIsPlausible(this.Items[ItemId], ProgBefore))
                {
                    erpItemsList.SetError(this.lsvItems, Stringtable._0x0018);
                    break;
                }
                ProgBefore = this.Items[ItemId];
            }
        }

        /// <summary>
        /// Get if the ProgressItem sequence is plausible
        /// </summary>
        /// <param name="progress">Progress Item to compare with item beforce in sequence</param>
        /// <param name="progressBefore">Previous Progress Item  in sequence</param>
        /// <returns>False if the sequence seems to be not plausible</returns>
        internal static bool ProgressIsPlausible(ProgressItem progress, ProgressItem progressBefore)
        {
            if (progress.State >= progressBefore.State && progress.Weight > progressBefore.Weight) return true;
            if (progress.State > progressBefore.State && progress.Weight < progressBefore.Weight) return true;
            return false;
        }

        /// <summary>
        /// List Progress Items to ListView
        /// </summary>
        private void ListItems()
        {
            this.lsvItems.Items.Clear();
            this.lsvItemss_SelectedIndexChanged(this, EventArgs.Empty);
            if (this._items == null || this._items.Count == 0) return;

            foreach (ProgressItem ProgressItem in this._items.Values.OrderBy(o => o.Order))
            {
                if (ProgressItem.Delete == ItemBase.DeleteFlag.None)
                {
                    //Create empty item and fill up by update procedure
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvItems.FillUpSubItems(NewItem);
                    this.UpdateListViewItem(ProgressItem, NewItem);
                    this.lsvItems.Items.Add(NewItem);
                }
            }
            this.lsvItems.LastItemVisible();
        }

        /// <summary>
        /// Made a recalculation of the state weights
        /// </summary>
        private void RecalcProgressWeight()
        {
            int ItemId;
            ProgressItem ProgBefore = new ProgressItem(0);
            int SubWeight = 0;
            foreach (ListViewItem ListViewItem in this.lsvItems.Items)
            {
                ItemId = (int)ListViewItem.Tag;
                if (this.Items[ItemId].WeightBase100 != ProgBefore.WeightBase100)
                {
                    SubWeight = 0;
                }
                else
                {
                    SubWeight++;
                }
                if (SubWeight > Settings_AppConst.Default.ProgressWeightWidth) SubWeight = Settings_AppConst.Default.ProgressWeightWidth;
                int NewWeight = this.Items[ItemId].WeightBase100 + SubWeight;
                this.Items[ItemId].Weight = NewWeight > Settings_AppConst.Default.ProgressWeightMax ? Settings_AppConst.Default.ProgressWeightMax : NewWeight;
                ProgBefore = this.Items[ItemId];
            }
        }

        /// <summary>
        /// Update the defined Sate Item in ListView
        /// </summary>
        /// <param name="progress">State to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        private void UpdateListViewItem(ProgressItem progress, ListViewItem listViewItem)
        {
            listViewItem.BackColor = progress.Color;
            listViewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(listViewItem.BackColor);
            listViewItem.ImageIndex = (int)progress.State;
            listViewItem.Tag = progress.Id;
            listViewItem.Text = progress.Date == null ? "" : progress.DateFormated;

            if (Properties.Settings.Default.AllowApplicationWeightOverride)
            {
                listViewItem.SubItems[1].Text = string.Format("{0}-{1}", new object[] { progress.Weight, progress.TitleNoText });
            }
            else
            {
                listViewItem.SubItems[1].Text = progress.TitleNoText;
            }
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (this._templateSelector.ShowDialog(this) != DialogResult.OK) return;
            int NewId = this.IdSet.GetNextId(this.IdSet.Prog);
            this.IdSet.Prog = NewId;

            ProgressItem NewProg = this._templateSelector.SelectedTemplate.Clone(NewId);
            NewProg.Date = Properties.Settings.Default.ProgressNewSetActualDate ? (DateTime?)DateTime.Now : null;
            this.Items.Add(NewId, NewProg);

            ListViewItem NewItem = new ListViewItem();
            this.lsvItems.FillUpSubItems(NewItem);
            this.UpdateListViewItem(NewProg, NewItem);
            this.lsvItems.Items.Add(NewItem);
            this.lsvItems.SelectItemByIdTag(NewId);
            this.lsvItems.LastItemVisible();
            this.ItemAdded?.Invoke(sender, e);

            this.CheckSequencePlausibility();
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.Items.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0034m, Stringtable._0x0034c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            ItemBase.DeleteFlag DeleteFlag;
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteDirectory;
                    break;
                default:
                    DeleteFlag = ItemBase.DeleteFlag.None;
                    return;
            }
            foreach (ListViewItem StateItem in this.lsvItems.SelectedItems)
            {
                this.Items[(int)StateItem.Tag].Delete = DeleteFlag;
                StateItem.Remove();
            }

            this.CheckSequencePlausibility();
        }

        private void lsvItems_DragDrop(object sender, DragEventArgs e)
        {
            if (!Properties.Settings.Default.AllowApplicationWeightOverride || !this.chkWeight.Checked)
            {
                this.RecalcProgressWeight();
                this.CheckSequencePlausibility();
            }

            // Update Listview
            foreach (ListViewItem ListViewItem in this.lsvItems.Items)
            {
                this.UpdateListViewItem(this.Items[(int)ListViewItem.Tag], ListViewItem);
            }
        }

        private void lsvItemss_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._systemChanged = true;
            if (this.lsvItems.SelectedItems.Count == 1)
            {
                this.SelectedItem = this.Items[(int)this.lsvItems.SelectedItems[0].Tag];
                this.btnItemDelete.Enabled = true;
                this.btnColor.BackColor = this.SelectedItem.Color;
                this.grpProgressEdit.Enabled = true;
                this.prgEditor.SelectedObject = this.SelectedItem;
                this.mtbDate.Date = this.SelectedItem.Date;
                this.nudWeight.Value = this.SelectedItem.Weight;
                this.txtComment.Text = this.SelectedItem.Comment;
                this.txtTitle.Text = this.SelectedItem.Title;

                switch (this.SelectedItem.State)
                {
                    case ProgressItem.ProgressState.Active:
                        this.chkProgressFinished.Checked = false;
                        this.chkProgressFinishedLowPriority.Checked = false;
                        break;
                    case ProgressItem.ProgressState.Finished:
                        this.chkProgressFinished.Checked = true;
                        this.chkProgressFinishedLowPriority.Checked = false;
                        break;
                    case ProgressItem.ProgressState.FinishedLowPriority:
                        this.chkProgressFinished.Checked = true;
                        this.chkProgressFinishedLowPriority.Checked = true;
                        break;
                    default:
                        this.chkProgressFinished.Checked = false;
                        this.chkProgressFinishedLowPriority.Checked = false;
                        break;
                }
            }
            else
            {
                this.SelectedItem = null;
                this.btnItemDelete.Enabled = this.lsvItems.SelectedItems.Count > 0;
                this.btnColor.BackColor = SystemColors.Control;
                this.grpProgressEdit.Enabled = false;
                this.prgEditor.SelectedObject = null;
                this.nudWeight.Value = this.nudWeight.Minimum;
                this.mtbDate.Date = null;
                this.txtComment.Text = "";
                this.txtTitle.Text = "";
            }
            this.chkWeight.Checked = false;
            this.chkWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this._systemChanged = false;
        }
        #endregion

        #region Edit Progress
        private void btnColor_BackColorChanged(object sender, EventArgs e)
        {
            this.btnColor.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(this.btnColor.BackColor);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this._colorDialog.Color = this.SelectedItem.Color;
            if (this._colorDialog.ShowDialog(this) != DialogResult.OK) return;

            this.SelectedItem.Color = this._colorDialog.Color;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.btnColor.BackColor = this._colorDialog.Color;
            this.prgEditor.Refresh();
        }

        private void btnShowTemplateSelector_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            if (this._templateSelector.ShowDialog(this) != DialogResult.OK) return;

            ProgressItem ProgTemp = this._templateSelector.SelectedTemplate.Clone(this.SelectedItem.Id);
            DateTime? ItemDate = this.Items[this.SelectedItem.Id].Date;
            this.Items[this.SelectedItem.Id] = ProgTemp;
            this.Items[this.SelectedItem.Id].Date = ItemDate;
            this.UpdateListViewItem(ProgTemp, this.lsvItems.SelectedItems[0]);
            this.lsvItemss_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void chkProgressFinished_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.chkProgressFinishedLowPriority.Enabled = this.chkProgressFinished.Checked;
            this.chkProgressFinishedLowPriority_CheckedChanged(sender, e);
        }

        private void chkProgressFinishedLowPriority_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;

            if (!this.chkProgressFinished.Checked)
            {
                this.SelectedItem.State = ProgressItem.ProgressState.Active;
            }
            else if (this.chkProgressFinished.Checked && !this.chkProgressFinishedLowPriority.Checked)
            {
                this.SelectedItem.State = ProgressItem.ProgressState.Finished;
            }
            else if (this.chkProgressFinished.Checked && this.chkProgressFinishedLowPriority.Checked)
            {
                this.SelectedItem.State = ProgressItem.ProgressState.FinishedLowPriority;
            }

            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.CheckSequencePlausibility();
        }

        private void chkWeight_CheckedChanged(object sender, EventArgs e)
        {
            this.nudWeight.Enabled = this.chkWeight.Checked && Properties.Settings.Default.AllowApplicationWeightOverride;
        }

        private void lblWeightActivateOverride_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SubForms.ApplicationSettingsForm ApplicationSettingsForm = new MainForm.SubForms.ApplicationSettingsForm(2);
            ApplicationSettingsForm.ShowDialog(this);
            this.chkWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this.chkWeight_CheckedChanged(this, EventArgs.Empty);
        }

        private void mtbDate_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Date = string.IsNullOrEmpty(Regex.Replace(this.mtbDate.Text, @"\W+", "")) ? null : this.mtbDate.Date;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void nudWeigt_ValueChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Weight = (int)this.nudWeight.Value;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void prgEditor_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.lsvItemss_SelectedIndexChanged(this, EventArgs.Empty);
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Title = this.txtTitle.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Comment = this.txtComment.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }
        #endregion
        #endregion
    }
}