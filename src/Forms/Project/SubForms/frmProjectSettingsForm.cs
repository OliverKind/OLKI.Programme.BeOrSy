/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to change project settings
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

using OLKI.Programme.BeOrSy.src.Project;
using OLKI.Programme.BeOrSy.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using static OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ProgressEditor;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to change project settings
    /// </summary>
    public partial class ProjectSettingsForm : Form
    {
        #region Fields
        /// <summary>
        /// List with Progress Templates
        /// </summary>
        private Dictionary<int, ProgressItem> _progTempl = new Dictionary<int, ProgressItem>();

        /// <summary>
        /// Max Id of Progress Templates
        /// </summary>
        private int _progTemplMaxId = 0;

        /// <summary>
        /// Selected Progress Item
        /// </summary>
        public ProgressItem _selectedProgItem { get; private set; } = null;

        /// <summary>
        /// Project, with settings
        /// </summary>
        private src.Project.Project _project;

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to change project settings
        /// </summary>
        /// <param name="settings">Settings to change</param>
        public ProjectSettingsForm(src.Project.Project project)
        {
            InitializeComponent();
            this._progTemplMaxId = project.IdSet.Clone().ProT;
            this._project = project;
            this._systemChanged = true;


            this.txtApplTemplPath.Text = this._project.Settings.ApplTemplPath;
            this.txtCompTemplPath.Text = this._project.Settings.CompTemplPath;
            this.txtProjectDirPath.Text = this._project.Settings.ProjectDirPath;
            this.chkCheckRemindersOnOpen.Checked = this._project.Settings.CheckRemindersOnOpen;
            this.chkDirectoryAddTitle.Checked = this._project.Settings.DirectoryAddTitle;
            this.chkDirectoryTitleBeforeId.Checked = this._project.Settings.DirectoryTitleBeforeId;
            this.chkSettingsRenameAutosave.Checked = this._project.Settings.SettingsRenameAutosave;
            this.nudDirectoryTitleLength.Value = this._project.Settings.DirectoryTitleLength;
            this.nudTemplateWeight.Maximum = Settings_AppConst.Default.ProgressWeightMax;
            this.chkInstantSave.Checked = this._project.Settings.InstantSave;

            this.toolTip.ToolTipTitle = Stringtable._0x0030c;
            this.toolTip.SetToolTip(this.chkTemplateWeight, Stringtable._0x0030m);
            this.toolTip.SetToolTip(this.nudTemplateWeight, Stringtable._0x0030m);
            this.toolTip.SetToolTip(this.lblTemplateWeightActivateOverride, Stringtable._0x0030m);

            foreach (KeyValuePair<int, ProgressItem> ProgItem in this._project.Settings.ProgressTemplateList)
            {
                this._progTempl.Add(ProgItem.Key, ProgItem.Value.Clone());
            }
            this.lsvProgressTemplates.Items.Clear();
            foreach (ProgressItem ProgressItem in this._progTempl.Values.OrderBy(o => o.Order))
            {
                if (ProgressItem.Delete == ItemBase.DeleteFlag.None)
                {
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvProgressTemplates.FillUpSubItems(NewItem);
                    this.UpdateProgressListViewItem(ProgressItem, NewItem);
                    this.lsvProgressTemplates.Items.Add(NewItem);
                }
            }
            this.lsvProgressTemplates.LastItemVisible();
            this.chkTemplateWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this.chkTemplateWeight_CheckedChanged(this, EventArgs.Empty);
            this.lsvProgressTemplates_SelectedIndexChanged(this, EventArgs.Empty);
            this._systemChanged = false;

            this.chkDirectoryAddTitle_CheckedChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Save the Project Settings
        /// </summary>
        private void SaveSettings()
        {
            this._project.IdSet.ProT = this._progTemplMaxId;

            this._project.Settings.ApplTemplPath = this.txtApplTemplPath.Text;
            this._project.Settings.CheckRemindersOnOpen = this.chkCheckRemindersOnOpen.Checked;
            this._project.Settings.CompTemplPath = this.txtCompTemplPath.Text;
            this._project.Settings.ProjectDirPath = this.txtProjectDirPath.Text;
            this._project.Settings.DirectoryAddTitle = this.chkDirectoryAddTitle.Checked;
            this._project.Settings.DirectoryTitleBeforeId = this.chkDirectoryTitleBeforeId.Checked;
            this._project.Settings.DirectoryTitleLength = (int)this.nudDirectoryTitleLength.Value;
            this._project.Settings.InstantSave = this.chkInstantSave.Checked;
            this._project.Settings.SettingsRenameAutosave = this.chkSettingsRenameAutosave.Checked;

            this._project.Settings.ProgressTemplateList.Clear();
            foreach (ProgressItem ProgressItem in this._progTempl.Values.OrderBy(o => o.Order))
            {
                this._project.Settings.ProgressTemplateList.Add(ProgressItem.Id, ProgressItem.Clone());
            }
            this._project.Changed = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.SaveSettings();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region General
        private void btnApplTemplPath_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog
            {
                Description = Stringtable._0x0027,
                SelectedPath = this.txtApplTemplPath.Text
            };
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtApplTemplPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void btnApplTemplPath_Delete_Click(object sender, EventArgs e)
        {
            this.txtApplTemplPath.Text = "";
        }

        private void btnApplTemplPath_GoTo_Click(object sender, EventArgs e)
        {
            Toolbox.DirectoryAndFile.Directory.Open(this.txtApplTemplPath.Text, true);
        }

        private void btnCompTemplPath_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog
            {
                Description = Stringtable._0x0027,
                SelectedPath = this.txtCompTemplPath.Text
            };
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtCompTemplPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void btnCompTemplPath_Delete_Click(object sender, EventArgs e)
        {
            this.txtCompTemplPath.Text = "";
        }

        private void btnCompTemplPath_GoTo_Click(object sender, EventArgs e)
        {
            Toolbox.DirectoryAndFile.Directory.Open(this.txtCompTemplPath.Text, true);
        }

        private void btnDirectorysRename_Click(object sender, EventArgs e)
        {
            if (!this.chkSettingsRenameAutosave.Checked)
            {
                if (MessageBox.Show(this, Stringtable._0x0036m, Stringtable._0x0036c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes) return;
            }
            this.SaveSettings();

            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                List<RenameException> ExceptionList = new List<RenameException>();
                foreach (CompanyItem CompItem in this._project.Companies.Values.OrderBy(o => o.Id))
                {
                    if (string.IsNullOrEmpty(CompItem.Directory)) continue;
                    foreach (ApplicationItem ApplItem in CompItem.Applications.Values.OrderBy(o => o.Id))
                    {
                        if (string.IsNullOrEmpty(ApplItem.Directory)) continue;
                        DirectoryInfo DestAppPath = ApplItem.GetCalcDirectory(CompItem.Directory, this.chkDirectoryAddTitle.Checked, (int)this.nudDirectoryTitleLength.Value, this.chkDirectoryTitleBeforeId.Checked);
                        if (this.RenameDirectory(new DirectoryInfo(ApplItem.Directory), DestAppPath, ExceptionList, true)) ApplItem.Directory = DestAppPath.FullName;
                    }
                    DirectoryInfo DestCompPath = CompItem.GetCalcDirectory(this.txtProjectDirPath.Text, this.chkDirectoryAddTitle.Checked, (int)this.nudDirectoryTitleLength.Value, this.chkDirectoryTitleBeforeId.Checked);
                    if (this.RenameDirectory(new DirectoryInfo(CompItem.Directory), DestCompPath, ExceptionList, false)) CompItem.Directory = DestCompPath.FullName;
                }
                if (ExceptionList.Count == 0)
                {
                    MessageBox.Show(this, Stringtable._0x0035m, Stringtable._0x0035c, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, string.Format(Stringtable._0x0037m, new object[] { ExceptionList.Count }), Stringtable._0x0037c, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    RenameDirectoryExceptions ExceptionsForm = new RenameDirectoryExceptions(ExceptionList);
                    ExceptionsForm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0038m, new object[] { ex.Message }), Stringtable._0x0038c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;
            this.Enabled = true;
            this._project.Changed = true;
        }

        private void btnProjectDirPath_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog
            {
                Description = Stringtable._0x0027,
                SelectedPath = this.txtProjectDirPath.Text
            };
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtProjectDirPath.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void btnProjectDirPath_Delete_Click(object sender, EventArgs e)
        {
            this.txtProjectDirPath.Text = "";
        }

        private void btnProjectDirPath_GoTo_Click(object sender, EventArgs e)
        {
            Toolbox.DirectoryAndFile.Directory.Open(this.txtProjectDirPath.Text, true);
        }
        #endregion

        #region Manage Direcotry Names
        /// <summary>
        /// Rename the defined directory
        /// </summary>
        /// <param name="srcPath">Path to Directory to rename</param>
        /// <param name="destPath">Destination path to rename</param>
        /// <param name="exceptionList">Exception while renaming</param>
        /// <param name="isAppDir">Is the directory a application directory</param>
        /// <returns>True if sucessfull renamed</returns>
        private bool RenameDirectory(DirectoryInfo srcPath, DirectoryInfo destPath, List<RenameException> exceptionList, bool isAppDir)
        {
            try
            {
                if (srcPath.FullName.Equals(destPath.FullName)) return true;
                Directory.Move(srcPath.FullName, destPath.FullName);
                return true;
            }
            catch (Exception ex)
            {
                exceptionList.Add(new RenameException(srcPath, destPath, ex, isAppDir));
                return false;
            }
        }

        /// <summary>
        /// Set the Directory Preeview Textboxes
        /// </summary>
        private void SetDirectoryPreviews()
        {
            CompanyItem DumnmyComp = new CompanyItem(123)
            {
                Title = Stringtable._0x0031
            };
            CompanyItem DumnmyAppl = new CompanyItem(654)
            {
                Title = Stringtable._0x0032
            };
            DirectoryInfo DummyCompPath = DumnmyComp.GetCalcDirectory(this.txtProjectDirPath.Text, this.chkDirectoryAddTitle.Checked, (int)this.nudDirectoryTitleLength.Value, this.chkDirectoryTitleBeforeId.Checked);
            DirectoryInfo DummyApplPath = DumnmyAppl.GetCalcDirectory(DummyCompPath?.FullName, this.chkDirectoryAddTitle.Checked, (int)this.nudDirectoryTitleLength.Value, this.chkDirectoryTitleBeforeId.Checked);

            this.txtDirectoryPreviewComp.Text = DummyCompPath == null ? Stringtable._0x0033 : DummyCompPath.FullName;
            this.txtDirectoryPreviewAppl.Text = DummyApplPath == null ? Stringtable._0x0033 : DummyApplPath.FullName;
        }

        private void chkDirectoryAddTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.chkDirectoryTitleBeforeId.Enabled = this.chkDirectoryAddTitle.Checked;
            this.lblDirectoryTitleLength.Enabled = this.chkDirectoryAddTitle.Checked;
            this.nudDirectoryTitleLength.Enabled = this.chkDirectoryAddTitle.Checked;
            this.SetDirectoryPreviews();
        }

        private void chkDirectoryTitleBeforeId_CheckedChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.SetDirectoryPreviews();
        }

        private void nudDirectoryTitleLength_ValueChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.SetDirectoryPreviews();
        }

        #region Sub Classes
        /// <summary>
        /// Object to store Information, if renaming a directroy throws a Exception
        /// </summary>
        public class RenameException
        {
            #region Properties
            /// <summary>
            /// Exception while renaming
            /// </summary>
            public readonly Exception Exception;

            /// <summary>
            /// Destination path to rename
            /// </summary>
            public readonly DirectoryInfo DestPath;

            /// <summary>
            /// Is the directory a application director
            /// </summary>
            public readonly bool IsAppDir;

            /// <summary>
            /// Path to Directory to rename
            /// </summary>
            public readonly DirectoryInfo SrcPath;
            #endregion

            #region Methods
            /// <summary>
            /// Initial a new Object to store Information, if renaming a directroy throws a Exception
            /// </summary>
            /// <param name="srcPath">Directory Info to Directory to rename</param>
            /// <param name="destPath">Directory Info path to rename</param>
            /// <param name="exception">Exception while renaming</param>
            /// <param name="isAppDir">Is the directory a application directory</param>
            public RenameException(DirectoryInfo srcPath, DirectoryInfo destPath, Exception exception, bool isAppDir)
            {
                this.Exception = exception;
                this.DestPath = destPath;
                this.IsAppDir = isAppDir;
                this.SrcPath = srcPath;
            }
            #endregion
        }
        #endregion

        #endregion

        #region Manage Progress
        /// <summary>
        /// Check the plausibility of the Progress Sequence and set the ErrorProvider
        /// </summary>
        private void CheckSequencePlausibility()
        {
            int ItemId;
            ProgressItem ProgBefore = new ProgressItem(0);
            erpProgressList.SetError(this.lsvProgressTemplates, "");
            ProgBefore = new ProgressItem(0);
            foreach (ListViewItem ListViewItem in this.lsvProgressTemplates.Items)
            {
                ItemId = (int)ListViewItem.Tag;
                if (!ProgressIsPlausible(this._progTempl[ItemId], ProgBefore))
                {
                    erpProgressList.SetError(this.lsvProgressTemplates, Stringtable._0x0018);
                    break;
                }
                ProgBefore = this._progTempl[ItemId];
            }
        }

        /// <summary>
        /// Update the defined Progress Item in ListView
        /// </summary>
        /// <param name="progress">Progress to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        private void UpdateProgressListViewItem(ProgressItem progress, ListViewItem listViewItem)
        {
            listViewItem.BackColor = progress.Color;
            listViewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(listViewItem.BackColor);
            listViewItem.ImageIndex = (int)progress.State;
            listViewItem.Tag = progress.Id;
            listViewItem.Text = progress.TitleNoText;
            listViewItem.SubItems[1].Text = string.Format("{0} - {1}", new object[] { progress.Weight, progress.Weight + Settings_AppConst.Default.ProgressWeightWidth });
        }

        /// <summary>
        /// Made a recalculation of the state weights
        /// </summary>
        private void RecalcProgressWeightAndOrder()
        {
            int ItemId;
            int StartWeight = 100;
            //Get start value for weight, by checking State (relevance)
            foreach (ListViewItem ListViewItem in this.lsvProgressTemplates.Items)
            {
                ItemId = (int)ListViewItem.Tag;
                if (this._progTempl[ItemId].State == ProgressItem.ProgressState.FinishedLowPriority) StartWeight += 100;
            }

            //Calculate Weights
            int Order = 0;
            ProgressItem ProgBefore = new ProgressItem(0);
            bool Restarted = false;
            int Weight = StartWeight;
            foreach (ListViewItem ListViewItem in this.lsvProgressTemplates.Items)
            {
                ItemId = (int)ListViewItem.Tag;
                if (!Restarted && this._progTempl[ItemId].State == ProgressItem.ProgressState.FinishedLowPriority && Weight > StartWeight)
                {
                    Weight = 100;
                    Restarted = true;
                }
                this._progTempl[ItemId].Weight = Weight > Settings_AppConst.Default.ProgressWeightMax ? Settings_AppConst.Default.ProgressWeightMax : Weight;
                this._progTempl[ItemId].Order = Order;
                Weight += 100;
                Order++;
                this.UpdateProgressListViewItem(this._progTempl[ItemId], ListViewItem);
            }
        }

        private void btnProgressTemplateAdd_Click(object sender, EventArgs e)
        {
            this._progTemplMaxId += 1;
            ProgressItem NewProgressItem = new ProgressItem(this._progTemplMaxId);
            this._progTempl.Add(NewProgressItem.Id, NewProgressItem);
            ListViewItem NewItem = new ListViewItem();
            this.lsvProgressTemplates.FillUpSubItems(NewItem);
            this.UpdateProgressListViewItem(NewProgressItem, NewItem);
            this.lsvProgressTemplates.Items.Add(NewItem);
            this.RecalcProgressWeightAndOrder();
            this.CheckSequencePlausibility();
        }

        private void btnProgressTemplateDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvProgressTemplates.SelectedItems.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0034m, Stringtable._0x0034c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    break;
                default:
                    return;
            }
            for (int i = 0; i < this.lsvProgressTemplates.SelectedItems.Count; i++)
            {
                this._progTempl.Remove((int)this.lsvProgressTemplates.SelectedItems[i].Tag);
                this.lsvProgressTemplates.SelectedItems[i].Remove();
            }
            this.RecalcProgressWeightAndOrder();
            this.CheckSequencePlausibility();
        }

        private void chkTemplateWeight_CheckedChanged(object sender, EventArgs e)
        {
            this.nudTemplateWeight.Enabled = this.chkTemplateWeight.Checked && Properties.Settings.Default.AllowApplicationWeightOverride;
        }

        private void lblWeightActivateOverride_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.SubForms.ApplicationSettingsForm ApplicationSettingsForm = new MainForm.SubForms.ApplicationSettingsForm(2);
            ApplicationSettingsForm.ShowDialog(this);
            this.chkTemplateWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this.chkTemplateWeight_CheckedChanged(sender, EventArgs.Empty);
        }

        private void lsvProgressTemplates_DragDrop(object sender, DragEventArgs e)
        {
            if (!Properties.Settings.Default.AllowApplicationWeightOverride || !this.chkTemplateWeight.Checked)
            {
                this.RecalcProgressWeightAndOrder();
                this.CheckSequencePlausibility();
            }
        }

        private void lsvProgressTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._systemChanged = true;
            if (this.lsvProgressTemplates.SelectedItems.Count == 1)
            {
                this._selectedProgItem = this._progTempl[(int)this.lsvProgressTemplates.SelectedItems[0].Tag];
                this.btnProgressTemplateDelete.Enabled = true;
                this.prgProgressTemplateEditor.SelectedObject = this._selectedProgItem;
                this.nudTemplateWeight.Value = this._selectedProgItem.Weight;
            }
            else
            {
                this._selectedProgItem = null;
                this.btnProgressTemplateDelete.Enabled = this.lsvProgressTemplates.SelectedItems.Count > 0;
                this.prgProgressTemplateEditor.SelectedObject = null;
                this.nudTemplateWeight.Value = this.nudTemplateWeight.Minimum;
            }
            this.chkTemplateWeight.Checked = false;
            this.chkTemplateWeight.Enabled = Properties.Settings.Default.AllowApplicationWeightOverride;
            this._systemChanged = false;
        }

        private void nudTemplateWeight_ValueChanged(object sender, EventArgs e)
        {
            if (this.lsvProgressTemplates.SelectedItems.Count != 1 || this._systemChanged) return;
            this._selectedProgItem.Weight = (int)this.nudDirectoryTitleLength.Value;
            this.UpdateProgressListViewItem(this._selectedProgItem, this.lsvProgressTemplates.SelectedItems[0]);
            this.prgProgressTemplateEditor.Refresh();
        }
        #endregion
        #endregion
    }
}