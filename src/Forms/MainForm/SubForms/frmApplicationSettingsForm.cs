/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to change applicaiton settings
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

using OLKI.Programme.BeOrSy.src.PostcodeManger;
using OLKI.Programme.BeOrSy.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace OLKI.Programme.BeOrSy.src.Forms.MainForm.SubForms
{
    /// <summary>
    /// Form to change applicaiton settings
    /// </summary>
    public partial class ApplicationSettingsForm : Form
    {
        #region Fields
        /// <summary>
        /// BackgroundWorker to show PostcodeItems in ListView
        /// </summary>
        private BackgroundWorker _bgwListPostcodes;

        /// <summary>
        /// PostcodeManager to manage Postcodes
        /// </summary>
        private PostcodeManager _postcodeManager { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// True if clearing of the recent file list was requested
        /// </summary>
        private bool _clearRecentFiles = false;
        /// <summary>
        /// True if clearing of the recent file list was requested
        /// </summary>
        internal bool ClearRecentFiles
        {
            get
            {
                return this._clearRecentFiles;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to change applicaiton settings
        /// </summary>
        /// <param name="startUpTab">Tab to Show at Start Up</param>
        public ApplicationSettingsForm(int startUpTab = 0)
        {
            InitializeComponent();
            this._postcodeManager = Program.PostcodeManager.Clone();

            //Initial Postcode
            this._bgwListPostcodes = new BackgroundWorker();
            this._bgwListPostcodes.WorkerReportsProgress = true;
            this._bgwListPostcodes.WorkerSupportsCancellation = true;
            this._bgwListPostcodes.DoWork += new DoWorkEventHandler(this.bgwListPostcodes_DoWork);
            this._bgwListPostcodes.ProgressChanged += new ProgressChangedEventHandler(this.bgwListPostcodes_ProgressChanged);
            this._bgwListPostcodes.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.bgwListPostcodes_RunWorkerCompleted);
            this.btnPostcodeCancelShow.Visible = false;
            this.epbListPostcodeProgress.Location = this.lsvPostcodes.Location;
            this.epbListPostcodeProgress.Visible = false;
            this.nudPostcodeListItemsWarning.Maximum = int.MaxValue;
            this.tabSettings.SelectedTab = tabSettings.TabPages[startUpTab];

            Point BtnLocation = new Point();
            BtnLocation.X = this.epbListPostcodeProgress.Location.X;
            BtnLocation.Y = this.epbListPostcodeProgress.Location.Y + this.epbListPostcodeProgress.Size.Height + this.epbListPostcodeProgress.Margin.Bottom + this.btnPostcodeCancelShow.Margin.Top;
            this.btnPostcodeCancelShow.Location = BtnLocation;

            this.PostcodeSetAutocomplete();
            this.btnPostcodeFilter_Click(this, EventArgs.Empty);

            this.SetControlesFromSettings();
        }

        /// <summary>
        /// Set the properties of the controls from actual application settings
        /// </summary>
        private void SetControlesFromSettings()
        {
            //Initial common
            this.chkAppUpdateCheckAtStartUp.Checked = Settings.Default.AppUpdate_CheckAtStartUp;
            this.chkFileAssociationCheckOnStartup.Checked = Settings.Default.FileAssociation_CheckOnStartup;
            this.chkProgressAllowWeightOverride.Checked = Settings.Default.AllowApplicationWeightOverride;
            this.chkProgressNewSetActualDate.Checked = Settings.Default.ProgressNewSetActualDate;
            this.nudNumRecentFiles.Value = Settings.Default.RecentFiles_MaxLength;
            this.nudPostcodeListItemsWarning.Value = Settings.Default.PostcodeListItemsWarning;
            this.txtDateFormat.Text = Settings.Default.DateFormat;
            this.txtDateTimeFormat.Text = Settings.Default.DateTimeFormat;
            this.txtStartupDefaultFileOpen.Text = Settings.Default.Startup_DefaultFileOpen;
            this.txtDirectoryFileDefaultPath.Text = Settings.Default.DirectoryFile_DefaultPath;
            this.chkProgressAllowWeightOverride_CheckedChanged(this, EventArgs.Empty);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Settings.Default.AppUpdate_CheckAtStartUp = this.chkAppUpdateCheckAtStartUp.Checked;
            Settings.Default.DateFormat = this.txtDateFormat.Text;
            Settings.Default.DateTimeFormat = this.txtDateTimeFormat.Text;
            Settings.Default.DirectoryFile_DefaultPath = this.txtDirectoryFileDefaultPath.Text;
            Settings.Default.FileAssociation_CheckOnStartup = this.chkFileAssociationCheckOnStartup.Checked;
            Settings.Default.RecentFiles_MaxLength = (int)this.nudNumRecentFiles.Value;
            Settings.Default.PostcodeList = this._postcodeManager.PostcodeListAsBase64EncodetXML;
            Settings.Default.PostcodeListItemsWarning = (int)this.nudPostcodeListItemsWarning.Value;
            Settings.Default.AllowApplicationWeightOverride = this.chkProgressAllowWeightOverride.Checked;
            Settings.Default.ProgressNewSetActualDate = this.chkProgressNewSetActualDate.Checked;
            Settings.Default.Startup_DefaultFileOpen = this.txtStartupDefaultFileOpen.Text;
            Settings.Default.Save();

            this._postcodeManager.RemoveDeletedItems();
            Program.PostcodeManager.PostcodeList = this._postcodeManager.PostcodeList;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        #region General Settings
        /// <summary>
        /// Set the form OK button, debeding by the error states of the date format textbox contents
        /// </summary>
        private void ValidateDateFormats()
        {
            bool FormatValid = true;
            this.erpDateFormat.Clear();

            try
            {
                this.lblDateFormatPreview.Text = DateTime.Now.ToString(this.txtDateFormat.Text);
            }
            catch
            {
                lblDateFormatPreview.Text = "";
                this.erpDateFormat.SetError(this.txtDateFormat, Properties.Stringtable._0x0024);
                FormatValid = false;
            }

            try
            {
                this.lblDateTimeFormatPreview.Text = DateTime.Now.ToString(this.txtDateTimeFormat.Text);
            }
            catch
            {
                lblDateTimeFormatPreview.Text = "";
                this.erpDateFormat.SetError(this.lblDateTimeFormatPreview, Properties.Stringtable._0x0024);
                FormatValid = false;
            }

            this.btnOk.Enabled = FormatValid;
        }

        private void btnCheckFileAssociation_Click(object sender, EventArgs e)
        {
            Program.CheckFileAssociationAndSet(true);
        }

        private void btnDirectoryFileDefaultPath_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog
            {
                Description = Stringtable._0x0027,
                SelectedPath = this.txtDirectoryFileDefaultPath.Text
            };
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtStartupDefaultFileOpen.Text = FolderBrowserDialog.SelectedPath;
                Settings.Default.DirectoryFile_DefaultPath = FolderBrowserDialog.SelectedPath;
            }
        }

        private void btnDirectoryFileDefaultPath_Delete_Click(object sender, EventArgs e)
        {
            this.txtDirectoryFileDefaultPath.Text = "";
        }

        private void btnStartupDefaultFileOpen_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                DefaultExt = Settings_AppConst.Default.ProjectFile_DefaultExtension,
                Filter = Settings_AppConst.Default.ProjectFile_FilterList,
                InitialDirectory = this.txtStartupDefaultFileOpen.Text,
                Multiselect = false
            };
            if (OpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtStartupDefaultFileOpen.Text = OpenFileDialog.FileName;
            }
        }

        private void btnStartupDefaultFileOpen_Delete_Click(object sender, EventArgs e)
        {
            this.txtStartupDefaultFileOpen.Text = "";
        }

        private void btnRecentFilesClear_Click(object sender, EventArgs e)
        {
            this._clearRecentFiles = true;
        }

        private void btnSetDefaults_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            this.SetControlesFromSettings();
        }

        private void txtDateFormat_TextChanged(object sender, EventArgs e)
        {
            this.ValidateDateFormats();
        }

        private void txtDateTimeFormat_TextChanged(object sender, EventArgs e)
        {
            this.ValidateDateFormats();
        }
        #endregion

        #region Manage Postcodes
        /// <summary>
        /// Get if the Postcode is in Filter
        /// </summary>
        /// <param name="haystack">Postcode to check</param>
        /// <param name="needleCity">City to search for</param>
        /// <param name="needleNati">Nation to search for</param>
        /// <returns></returns>
        private bool PostcodeItemInFilter(PostcodeItem haystack, string needleCity, string needleNati)
        {
            if (haystack.Delete != src.Project.ItemBase.DeleteFlag.None) return false;
            if (!Toolbox.Common.Search.FullText(haystack.CodeCity, needleCity)) return false;
            if (!Toolbox.Common.Search.FullText(haystack.CodeNation, needleNati)) return false;
            return true;
        }

        /// <summary>
        /// Set Autocomplete Items for Postcode Filter Textboxes
        /// </summary>
        private void PostcodeSetAutocomplete()
        {
            this.txtPostcodeFilterCity.AutoCompleteCustomSource.Clear();
            this.txtPostcodeFilterNati.AutoCompleteCustomSource.Clear();
            List<string> CityList = new List<string>();
            List<string> NatiList = new List<string>();
            foreach (PostcodeItem PostcodeItem in this._postcodeManager.PostcodeList)
            {
                CityList.Add(PostcodeItem.CodeCity);
                NatiList.Add(PostcodeItem.CodeNation);
            }
            foreach (string CityItem in CityList.Distinct().ToList().OrderBy(o => o))
            {
                this.txtPostcodeFilterCity.AutoCompleteCustomSource.Add(CityItem);
            }
            foreach (string NatiItem in NatiList.Distinct().ToList().OrderBy(o => o))
            {
                this.txtPostcodeFilterNati.AutoCompleteCustomSource.Add(NatiItem);
            }
        }

        /// <summary>
        /// Update the defined Postcode ListViewItem
        /// </summary>
        /// <param name="postcodeItem">PostcoeItem to get Data from</param>
        /// <param name="listViewItem">ListViewItem to Update</param>
        private void UpdateListViewItemPostcode(PostcodeItem postcodeItem, ListViewItem listViewItem)
        {
            listViewItem.Checked = postcodeItem.CodeActive;
            listViewItem.Text = postcodeItem.CodePostcode;
            listViewItem.SubItems[1].Text = postcodeItem.CodeCity;
            listViewItem.SubItems[2].Text = postcodeItem.CodeState;
            listViewItem.SubItems[3].Text = postcodeItem.CodeNation;
        }

        private void bgwListPostcodes_DoWork(object sender, DoWorkEventArgs e)
        {
            List<PostcodeItem> PostcodeList = (List<PostcodeItem>)e.Argument;
            for (int i = 0; i < PostcodeList.Count; i++)
            {
                if (this._bgwListPostcodes.CancellationPending) break;
                if (this.PostcodeItemInFilter(PostcodeList[i], this.txtPostcodeFilterCity.Text, this.txtPostcodeFilterNati.Text))
                {
                    ListViewItem NewItem = new ListViewItem
                    {
                        Tag = PostcodeList[i]
                    };
                    this.lsvPostcodes.FillUpSubItems(NewItem);
                    this.UpdateListViewItemPostcode(PostcodeList[i], NewItem);
                    Toolbox.Widgets.Invoke.ListViewInv.AddItem(this.lsvPostcodes, NewItem);
                }
                this._bgwListPostcodes.ReportProgress(0, i + 1);
            }
        }

        private void bgwListPostcodes_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.epbListPostcodeProgress.DescriptionText = Stringtable._0x0026;
            this.epbListPostcodeProgress.Value = Convert.ToInt64(e.UserState);
            this.epbListPostcodeProgress.Refresh();
        }

        private void bgwListPostcodes_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.btnPostcodeCancelShow.Visible = false;
            this.epbListPostcodeProgress.Visible = false;
            this.grbPostcodeFilter.Enabled = true;
            this.lsvPostcodes.Visible = true;
            this.lsvPostcodes.EndUpdate();
            this.pnlManagePostcode.Enabled = true;
        }

        private void btnPostcodeAdd_Click(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy) return;

            PostcodeItem PostcodeItem = new PostcodeItem();
            this._postcodeManager.AddItem(PostcodeItem);

            ListViewItem NewItem = new ListViewItem
            {
                Tag = PostcodeItem
            };
            this.lsvPostcodes.FillUpSubItems(NewItem);
            this.UpdateListViewItemPostcode(PostcodeItem, NewItem);
            Toolbox.Widgets.Invoke.ListViewInv.AddItem(this.lsvPostcodes, NewItem);
            foreach (ListViewItem ListViewItem in this.lsvPostcodes.Items)
            {
                ListViewItem.Selected = false;
            }
            this.lsvPostcodes.Items[this.lsvPostcodes.Items.Count - 1].Selected = true;
            this.lsvPostcodes.LastItemVisible();
        }

        private void btnPostcodeCancelShow_Click(object sender, EventArgs e)
        {
            this._bgwListPostcodes.CancelAsync();
        }

        private void btnPostcodeCancelShow_VisibleChanged(object sender, EventArgs e)
        {
            this.btnPostcodeCancelShow.Enabled = this.btnPostcodeCancelShow.Visible;
        }

        private void btnPostcodeDelete_Click(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy || this.lsvPostcodes.SelectedItems.Count == 0) return;
            for (int i = 0; i < this._postcodeManager.PostcodeList.Count; i++)
            {
                for (int s = 0; s < this.lsvPostcodes.SelectedItems.Count; s++)
                {
                    if (this._postcodeManager.PostcodeList[i].Equals((PostcodeItem)this.lsvPostcodes.SelectedItems[s].Tag))
                    {
                        this._postcodeManager.PostcodeList[i].Delete = src.Project.ItemBase.DeleteFlag.DeleteOnlyEntry;
                        this.lsvPostcodes.SelectedItems[s].Remove();
                    }
                }
            }
        }

        private void btnPostcodeExport_Click(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy) return;

            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                DefaultExt = Settings_AppConst.Default.PostcodeFile_DefaultExtension,
                Filter = Settings_AppConst.Default.PostcodeFile_FilterList,
                FilterIndex = Settings_AppConst.Default.PostcodeFile_FilterIndex,
                InitialDirectory = Settings.Default.DirectoryFile_DefaultPath
            };
            DialogResult DialogResult = SaveFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    this._postcodeManager.WritePostcodesToFile(SaveFileDialog.FileName);
                    MessageBox.Show(this, string.Format(Stringtable._0x002Dm, new object[] { SaveFileDialog.FileName }), Stringtable._0x002Dc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format(Stringtable._0x002Bm, new object[] { SaveFileDialog.FileName, ex.Message }), Stringtable._0x002Bc, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPostcodeFilter_Click(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy) return;
            this.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;

            this.btnPostcodeCancelShow.Visible = true;
            this.epbListPostcodeProgress.MaxValue = 0;
            this.epbListPostcodeProgress.Value = 0;
            this.epbListPostcodeProgress.Visible = true;
            this.grbPostcodeFilter.Enabled = false;
            this.lsvPostcodes.BeginUpdate();
            this.lsvPostcodes.Items.Clear();
            this.lsvPostcodes.Visible = false;
            this.pnlManagePostcode.Enabled = false;
            this.Refresh();

            List<PostcodeItem> PostcodeListFilteres = new List<PostcodeItem>();
            foreach (PostcodeItem PostcodeItem in this._postcodeManager.PostcodeList.OrderBy(o => o.CodePostcode))
            {
                if (this.PostcodeItemInFilter(PostcodeItem, this.txtPostcodeFilterCity.Text, this.txtPostcodeFilterNati.Text))
                {
                    PostcodeListFilteres.Add(PostcodeItem);
                }
            }

            if (this.nudPostcodeListItemsWarning.Value > 0 && PostcodeListFilteres.Count > this.nudPostcodeListItemsWarning.Value)
            {
                if (MessageBox.Show(this, string.Format(Stringtable._0x002Am, new object[] { PostcodeListFilteres.Count }), Stringtable._0x002Ac, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                {
                    Cursor.Current = Cursors.Default;
                    this.Enabled = true;
                    this.bgwListPostcodes_RunWorkerCompleted(this, new RunWorkerCompletedEventArgs(null, null, false));
                    return;
                }
            }

            this.epbListPostcodeProgress.MaxValue = PostcodeListFilteres.Count;
            Cursor.Current = Cursors.Default;
            this.Enabled = true;
            this._bgwListPostcodes.RunWorkerAsync(PostcodeListFilteres);
        }

        private void btnPostcodeImport_Click(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy) return;

            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                DefaultExt = Settings_AppConst.Default.PostcodeFile_DefaultExtension,
                Filter = Settings_AppConst.Default.PostcodeFile_FilterList,
                FilterIndex = Settings_AppConst.Default.PostcodeFile_FilterIndex,
                InitialDirectory = Settings.Default.DirectoryFile_DefaultPath
            };
            DialogResult DialogResult = OpenFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    this.chkPostcodeSettAllActive.CheckState = CheckState.Indeterminate;
                    this._postcodeManager.LoadPostcodesFromFile(OpenFileDialog.FileName);
                    MessageBox.Show(this, string.Format(Stringtable._0x002Cm, new object[] { OpenFileDialog.FileName }), Stringtable._0x002Cc, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, string.Format(Stringtable._0x0028m, new object[] { OpenFileDialog.FileName, ex.Message }), Stringtable._0x0028c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.btnPostcodeFilter_Click(sender, EventArgs.Empty);
                }
            }
        }

        private void chkPostcodeSettAllActive_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.chkPostcodeSettAllActive.Enabled || this.chkPostcodeSettAllActive.CheckState == CheckState.Indeterminate) return;
            this._postcodeManager.SetAllActiveState(this.chkPostcodeSettAllActive.Checked);
            this.btnPostcodeFilter_Click(sender, EventArgs.Empty);
        }

        private void lsvPostcodes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control)
            {
                foreach (ListViewItem ListViewItem in this.lsvPostcodes.Items)
                {
                    ListViewItem.Selected = true;
                }
            }
        }

        private void lsvPostcodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this._bgwListPostcodes.IsBusy || this.lsvPostcodes.SelectedItems.Count == 0)
            {
                this.btnPostcodeDelete.Enabled = false;
                this.prgPostcodeData.SelectedObjects = null;
                return;
            }
            this.btnPostcodeDelete.Enabled = true;
            List<PostcodeItem> PostcodeList = new List<PostcodeItem>();
            for (int s = 0; s < this.lsvPostcodes.SelectedItems.Count; s++)
            {
                PostcodeList.Add((PostcodeItem)this.lsvPostcodes.SelectedItems[s].Tag);
            }
            this.prgPostcodeData.SelectedObjects = PostcodeList.ToArray();
        }

        private void lsvPostcodes_VisibleChanged(object sender, EventArgs e)
        {
            this.lsvPostcodes.Enabled = this.lsvPostcodes.Visible;
        }

        private void pnlManagePostcode_EnabledChanged(object sender, EventArgs e)
        {
            this.chkPostcodeSettAllActive.Enabled = this.pnlManagePostcode.Enabled;
        }

        private void prgPostcodeData_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            for (int i = 0; i < this.lsvPostcodes.SelectedItems.Count; i++)
            {
                this.UpdateListViewItemPostcode((PostcodeItem)this.lsvPostcodes.SelectedItems[i].Tag, this.lsvPostcodes.SelectedItems[i]);
            }
        }
        #endregion

        #region Manage Progress
        private void chkProgressAllowWeightOverride_CheckedChanged(object sender, EventArgs e)
        {
            this.lblAppProgressAllowWeightOverride.Enabled = this.chkProgressAllowWeightOverride.Checked;
        }
        #endregion
        #endregion
    }
}