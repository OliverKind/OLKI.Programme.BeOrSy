/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Editor Control to edit Reminders
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
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    /// <summary>
    /// Editor Control to edit Reminders
    /// </summary>
    public partial class ReminderEditor : UserControl
    {
        #region Events
        /// <summary>
        /// Raised if a Item was added
        /// </summary>
        public event EventHandler ItemAdded;
        #endregion

        #region Fields
        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Reminder Items for the Editor
        /// </summary>
        private Dictionary<int, ReminderItem> _items = null;
        /// <summary>
        /// Get or set the Reminder Items for the Editor
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ReminderItem> Items
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
        /// Selected Reminder Item
        /// </summary>
        [Browsable(false)]
        public ReminderItem SelectedItem { get; private set; } = null;
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Editor Control to edit Reminders
        /// </summary>
        public ReminderEditor()
        {
            InitializeComponent();
#if !DEBUG
            this.Width -= this.prgEditor.Width - this.prgEditor.Margin.Left - this.prgEditor.Right - this.grpReminderEdit.Margin.Right;
            this.prgEditor.Enabled = false;
            this.prgEditor.Visible = false;
#endif
        }

        #region Manage Reminders
        /// <summary>
        /// List Reminder Items to ListView
        /// </summary>
        private void ListItems()
        {
            this.lsvItems.Items.Clear();
            this.lsvItems_SelectedIndexChanged(this, EventArgs.Empty);
            if (this._items == null || this._items.Count == 0) return;

            foreach (ReminderItem ReminderItem in this._items.Values.OrderBy(o => o.Date))
            {
                if (ReminderItem.Delete == ItemBase.DeleteFlag.None)
                {
                    //Create empty item and fill up by update procedure
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvItems.FillUpSubItems(NewItem);
                    this.UpdateListViewItem(ReminderItem, NewItem);
                    this.lsvItems.Items.Add(NewItem);
                }
            }
            this.lsvItems.LastItemVisible();
        }

        /// <summary>
        /// Update the defined Reminder Item in ListView
        /// </summary>
        /// <param name="reminder">Reminder to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        private void UpdateListViewItem(ReminderItem reminder, ListViewItem listViewItem)
        {
            listViewItem.ImageIndex = reminder.Acknowledged ? 1 : 0;
            listViewItem.Tag = reminder.Id;
            listViewItem.Text = reminder.DateFormated;
            listViewItem.SubItems[1].Text = reminder.TitleNoText;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            int NewId = this.IdSet.GetNextId(this.IdSet.Remi);
            this.IdSet.Remi = NewId;
            ReminderItem NewRemi = new ReminderItem(NewId);
            this.Items.Add(NewId, NewRemi);

            ListViewItem NewItem = new ListViewItem();
            this.lsvItems.FillUpSubItems(NewItem);
            this.UpdateListViewItem(NewRemi, NewItem);
            this.lsvItems.Items.Add(NewItem);
            this.lsvItems.SelectItemByIdTag(NewId);
            this.lsvItems.LastItemVisible();
            this.ItemAdded?.Invoke(sender, e);
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.Items.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0025m, Stringtable._0x0025c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
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
            foreach (ListViewItem ReminderItem in this.lsvItems.SelectedItems)
            {
                this.Items[(int)ReminderItem.Tag].Delete = DeleteFlag;
                ReminderItem.Remove();
            }
        }

        private void lsvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._systemChanged = true;
            if (this.lsvItems.SelectedItems.Count == 1)
            {
                this.SelectedItem = this.Items[(int)this.lsvItems.SelectedItems[0].Tag];
                this.btnItemDelete.Enabled = true;
                this.chkReminderAcknowledge.Checked = this.SelectedItem.Acknowledged;
                this.grpReminderEdit.Enabled = true;
                this.prgEditor.SelectedObject = this.SelectedItem;
                this.mtbDate.Date = this.SelectedItem.Date;
                this.txtComment.Text = this.SelectedItem.Comment;
                this.txtTitle.Text = this.SelectedItem.Title;
            }
            else
            {
                this.SelectedItem = null;
                this.btnItemDelete.Enabled = this.lsvItems.SelectedItems.Count > 0;
                this.chkReminderAcknowledge.Checked = false;
                this.grpReminderEdit.Enabled = false;
                this.prgEditor.SelectedObject = null;
                this.mtbDate.Date = null;
                this.txtComment.Text = "";
                this.txtTitle.Text = "";
            }
            this._systemChanged = false;
        }
        #endregion

        #region Edit Reminder
        private void chkReminderAcknowledge_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Acknowledged = this.chkReminderAcknowledge.Checked;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void mtbDate_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Date = this.mtbDate.Date;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void prgEditor_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.lsvItems_SelectedIndexChanged(this, EventArgs.Empty);
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Comment = this.txtComment.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._systemChanged) return;
            this.SelectedItem.Title = this.txtTitle.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }
        #endregion
        #endregion
    }
}