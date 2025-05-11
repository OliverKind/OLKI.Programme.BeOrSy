/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form that contains Data and provide Methodes to search for Reminders
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
using OLKI.Programme.BeOrSy.src.Project.ReportCeator;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static OLKI.Programme.BeOrSy.src.Project.Filter.Reminder;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form that contains Data and provide Methodes to search for Reminders
    /// </summary>
    public partial class ReminderSearchForm : Form
    {
        #region Fields
        /// <summary>
        /// Get the root Project Form
        /// </summary>
        private readonly ProjectForm _projectForm;

        /// <summary>
        /// Id of the currently selected Reminder, refer to the selected Reminder
        /// </summary>
        private int _selectedApplId = 0;

        /// <summary>
        /// Id of the currently selected Company, refer to the selected Reminder
        /// </summary>
        private int _selectedCompId = 0;

        /// <summary>
        /// Id of the currently selected Reminder
        /// </summary>
        private int _selectedRemId = 0;

        /// <summary>
        /// The currently selected Reminder
        /// </summary>
        private ReminderItem _selectedReminder;

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;

        /// <summary>
        /// Original design text for the Toolstrip Application Id Label
        /// </summary>
        private readonly string _tolLA_lblAppId_OrgText;

        /// <summary>
        /// Original design text for the Toolstrip Company Id Label
        /// </summary>
        private readonly string _tolLA_lblComId_OrgText;

        /// <summary>
        /// Original design text for the Statusstrip Applications listed Label
        /// </summary>
        private readonly string _tslApplicationsList_OrgText;

        /// <summary>
        /// Original design text for the Statusstrip Applications selected Label
        /// </summary>
        private readonly string _tslApplicationsSelected_OrgText;

        /// <summary>
        /// Original design text for the Statusstrip Applications total Label
        /// </summary>
        private readonly string _tslApplicationsTotal_OrgText;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form that contains Data and provide Methodes to search for Reminders
        /// </summary>
        /// <param name="projectForm"></param>
        /// <param name="ShowActiveReminders"></param>
        public ReminderSearchForm(ProjectForm projectForm, bool ShowActiveReminders)
        {
            InitializeComponent();
            this._projectForm = projectForm;
            this._tolLA_lblAppId_OrgText = this.tolLR_lblApplId.Text;
            this._tolLA_lblComId_OrgText = this.tolLR_lblCompId.Text;
            this._tslApplicationsList_OrgText = this.tslApplicationsList.Text;
            this._tslApplicationsSelected_OrgText = this.tslApplicationsSelected.Text;
            this._tslApplicationsTotal_OrgText = this.tslApplicationsTotal.Text;

            this.Text = string.Format(this.Text, new object[] { this._projectForm.Project.ProjectTitle });
            this.tolListReminders.Enabled = false;

            int RemCount = 0;
            foreach (CompanyItem CompItem in this._projectForm.Project.Companies.Values)
            {
                foreach (ReminderItem RemiItem in CompItem.Reminders.Values) RemCount++;
                foreach (ApplicationItem ApplItem in CompItem.Applications.Values)
                {
                    foreach (ReminderItem RemiItem in ApplItem.Reminders.Values) RemCount++;
                }
            }
            this.tslApplicationsList.Text = string.Format(this._tslApplicationsList_OrgText, new object[] { 0 });
            this.tslApplicationsSelected.Text = string.Format(this._tslApplicationsSelected_OrgText, new object[] { 0 });
            this.tslApplicationsTotal.Text = string.Format(this._tslApplicationsTotal_OrgText, new object[] { RemCount });
            this.lsvReminders_SelectedIndexChanged(this, EventArgs.Empty);

            if (ShowActiveReminders)
            {
                this.chkFilterAcknowledge.CheckState = CheckState.Unchecked;
                this.mtbFilterDateTo.Date = DateTime.Now;
                this.btnListReminders_Click(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Update the defined Reminder Item in ListView
        /// </summary>
        /// <param name="reminder">Reminder to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        /// <param name="remIidSet">Id-Set for the Reminder</param>
        private void UpdateListViewItem(ReminderItem reminder, ListViewItem listViewItem, Dictionary<IdBelongingIndikator, int> remIidSet)
        {
            listViewItem.ImageIndex = remIidSet[IdBelongingIndikator.Application] == 0 ? !reminder.Acknowledged ? 0 : 1 : !reminder.Acknowledged ? 2 : 3;
            listViewItem.Tag = remIidSet;
            listViewItem.Text = reminder.TitleNoText;

            listViewItem.SubItems[1].Text = reminder.Comment;
            listViewItem.SubItems[2].Tag = reminder.Date;
            listViewItem.SubItems[2].Text = reminder.DateFormated;
            listViewItem.SubItems[3].Text = this._projectForm.Project.Companies[remIidSet[IdBelongingIndikator.Company]].TitleNoText;
            listViewItem.SubItems[4].Text = remIidSet[IdBelongingIndikator.Application] == 0 ? "" : this._projectForm.Project.Companies[remIidSet[IdBelongingIndikator.Company]].Applications[remIidSet[IdBelongingIndikator.Application]].TitleNoText;
            listViewItem.SubItems[5].Tag = remIidSet[IdBelongingIndikator.Company];
            listViewItem.SubItems[5].Text = remIidSet[IdBelongingIndikator.Company].ToString();
            listViewItem.SubItems[6].Tag = remIidSet[IdBelongingIndikator.Application];
            listViewItem.SubItems[6].Text = remIidSet[IdBelongingIndikator.Application].ToString();
            listViewItem.SubItems[7].Tag = remIidSet[IdBelongingIndikator.Reminder];
            listViewItem.SubItems[7].Text = remIidSet[IdBelongingIndikator.Reminder].ToString();
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListReminders_Click(object sender, EventArgs e)
        {
            this._systemChanged = true;
            this._selectedApplId = 0;
            this._selectedCompId = 0;
            this.lsvReminders.BeginUpdate();
            this.lsvReminders.Items.Clear();

            src.Project.Filter.Reminder ReminderFilter = new src.Project.Filter.Reminder
            {
                Acknowledged = this.chkFilterAcknowledge.CheckState,
                DateFrom = this.mtbFilterDateFrom.Date,
                DateTo = this.mtbFilterDateTo.Date,
                SourceApplication = this.chkFilterSourceApplication.CheckState,
                SourceCompany = this.chkFilterSourceCompany.CheckState,
                Text = this.txtFilterText.Text
            };

            List<Dictionary<IdBelongingIndikator, int>> ReminderList = ReminderFilter.Detail(this._projectForm.Project.Companies) ?? new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (Dictionary<IdBelongingIndikator, int> RemIdSet in ReminderList)
            {
                ReminderItem Reminder = new ReminderItem(0);
                if (RemIdSet[IdBelongingIndikator.Application] == 0) Reminder = this._projectForm.Project.Companies[RemIdSet[IdBelongingIndikator.Company]].Reminders[RemIdSet[IdBelongingIndikator.Reminder]];
                if (RemIdSet[IdBelongingIndikator.Application] != 0) Reminder = this._projectForm.Project.Companies[RemIdSet[IdBelongingIndikator.Company]].Applications[RemIdSet[IdBelongingIndikator.Application]].Reminders[RemIdSet[IdBelongingIndikator.Reminder]];

                ListViewItem ListViewItem = new ListViewItem();
                this.lsvReminders.FillUpSubItems(ListViewItem);
                this.UpdateListViewItem(Reminder, ListViewItem, RemIdSet);
                this.lsvReminders.Items.Add(ListViewItem);
            }
            this.lsvReminders.Sort();
            this.lsvReminders.EndUpdate();
            this.tslApplicationsList.Text = string.Format(this._tslApplicationsList_OrgText, new object[] { this.lsvReminders.Items.Count });
            this.lsvReminders_SelectedIndexChanged(this, EventArgs.Empty);
            this._systemChanged = false;
        }

        private void lsvReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._systemChanged = true;
            this.tolListReminders.Enabled = this.lsvReminders.SelectedItems.Count != 0;
            this.tolLR_btnGoToApplFolder.Enabled = this.tolListReminders.Enabled && this.lsvReminders.SelectedItems.Count == 1;
            this.tolLR_btnGoToCompFolder.Enabled = this.tolListReminders.Enabled && this.lsvReminders.SelectedItems.Count == 1;
            this.tslApplicationsSelected.Text = string.Format(this._tslApplicationsSelected_OrgText, new object[] { this.lsvReminders.SelectedItems.Count });

            if (this.lsvReminders.SelectedItems.Count != 1)
            {
                this.grbReminderEdit.Enabled = false;
                this._selectedApplId = 0;
                this._selectedCompId = 0;
                this._selectedReminder = null;
                this.tolLR_lblApplId.Text = string.Format(this._tolLA_lblAppId_OrgText, new object[] { 0 });
                this.tolLR_lblCompId.Text = string.Format(this._tolLA_lblComId_OrgText, new object[] { 0 });

                this.txtReminderApplication.Text = "";
                this.txtReminderCompany.Text = "";

                this.chkReminderAcknowledge.Checked = false;
                this.mtbReminderDate.Text = null;
                this.txtReminderComment.Text = "";
                this.txtReminderTitle.Text = "";
                return;
            }

            this.grbReminderEdit.Enabled = true;
            this._selectedApplId = ((Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag)[IdBelongingIndikator.Application];
            this._selectedCompId = ((Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag)[IdBelongingIndikator.Company];
            this._selectedRemId = ((Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag)[IdBelongingIndikator.Reminder];
            this.tolLR_lblApplId.Text = string.Format(this._tolLA_lblAppId_OrgText, new object[] { this._selectedApplId });
            this.tolLR_lblCompId.Text = string.Format(this._tolLA_lblComId_OrgText, new object[] { this._selectedCompId });

            this.tolLR_btnGoToCompFolder.Enabled = this._selectedCompId > 0;
            this._projectForm.lsvCompany.SetAllSelections(false);
            foreach (ListViewItem CompItem in this._projectForm.lsvCompany.Items)
            {
                if ((int)CompItem.Tag == this._selectedCompId)
                {
                    CompItem.Selected = true;
                    break;
                }
            }
            this.tolLR_btnGoToApplFolder.Enabled = this._selectedApplId > 0;
            this._projectForm.lsvApplication.SetAllSelections(false);
            foreach (ListViewItem ApplItem in this._projectForm.lsvApplication.Items)
            {
                if ((int)ApplItem.Tag == this._selectedApplId)
                {
                    ApplItem.Selected = true;
                    break;
                }
            }
            if (this._selectedApplId == 0) this._selectedReminder = this._projectForm.Project.Companies[this._selectedCompId].Reminders[this._selectedRemId];
            if (this._selectedApplId > 0) this._selectedReminder = this._projectForm.Project.Companies[this._selectedCompId].Applications[this._selectedApplId].Reminders[this._selectedRemId];

            this.txtReminderApplication.Text = this._selectedApplId == 0 ? "" : this._projectForm.Project.Companies[this._selectedCompId].Applications[this._selectedApplId].TitleNoText;
            this.txtReminderCompany.Text = this._projectForm.Project.Companies[this._selectedCompId].TitleNoText;

            this.chkReminderAcknowledge.Checked = this._selectedReminder.Acknowledged;
            this.mtbReminderDate.Text = this._selectedReminder.DateFormated;
            this.txtReminderComment.Text = this._selectedReminder.Comment;
            this.txtReminderTitle.Text = this._selectedReminder.Title;
            this._systemChanged = false;
        }

        private void tolLR_btnCreateReport_Click(object sender, EventArgs e)
        {
            if (this.lsvReminders.Items.Count == 0 || this.lsvReminders.SelectedItems.Count == 0) return;

            List<Dictionary<IdBelongingIndikator, int>> RemiIdSet = new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (ListViewItem RemiItem in this.lsvReminders.SelectedItems)
            {
                RemiIdSet.Add((Dictionary<IdBelongingIndikator, int>)RemiItem.Tag);
            }
            Reporter.ReminderList.Create(this, this._projectForm.Project, RemiIdSet, this.mtbFilterDateFrom.Date, this.mtbFilterDateTo.Date, this.chkReminderAcknowledge.CheckState);
        }

        private void tolLR_btnGoToApplFolder_Click(object sender, EventArgs e)
        {
            if (this._selectedApplId == 0 || this._selectedCompId == 0) return;
            this._projectForm.Project.Companies[this._selectedCompId].Applications[this._selectedApplId].OpenDirectory(this, this._projectForm.Project, this._projectForm.Project.Companies[this._selectedCompId]);
        }

        private void tolLR_btnGoToCompFolder_Click(object sender, EventArgs e)
        {
            if (this._selectedCompId == 0) return;
            this._projectForm.Project.Companies[this._selectedCompId].Applications[this._selectedApplId].OpenDirectory(this, this._projectForm.Project, this._projectForm.Project.Companies[this._selectedCompId]);
        }

        #region Reminder changed
        private void btnReminderDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvReminders.Items.Count != 1) return;
            DialogResult DialogResult = MessageBox.Show(Properties.Stringtable._0x0025m, Properties.Stringtable._0x0025c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    this._selectedReminder.Delete = ItemBase.DeleteFlag.DeleteDirectory;
                    this.lsvReminders.SelectedItems[0].Remove();
                    break;
                default:
                    return;
            }
        }

        private void chkReminderAcknowledge_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lsvReminders.SelectedItems.Count != 1 || this._systemChanged) return;
            this._selectedReminder.Acknowledged = this.chkReminderAcknowledge.Checked;
            this.UpdateListViewItem(this._selectedReminder, this.lsvReminders.SelectedItems[0], (Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag);
        }

        private void mtbReminderDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (this.lsvReminders.SelectedItems.Count != 1 || this._systemChanged) return;
            this._selectedReminder.Date = this.mtbReminderDate.Date;
            this.UpdateListViewItem(this._selectedReminder, this.lsvReminders.SelectedItems[0], (Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag);
        }

        private void txtReminderComment_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvReminders.SelectedItems.Count != 1 || this._systemChanged) return;
            this._selectedReminder.Comment = this.txtReminderComment.Text;
            this.UpdateListViewItem(this._selectedReminder, this.lsvReminders.SelectedItems[0], (Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag);
        }

        private void txtReminderTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.lsvReminders.SelectedItems.Count != 1 || this._systemChanged) return;
            this._selectedReminder.Title = this.txtReminderTitle.Text;
            this.UpdateListViewItem(this._selectedReminder, this.lsvReminders.SelectedItems[0], (Dictionary<IdBelongingIndikator, int>)this.lsvReminders.SelectedItems[0].Tag);
        }
        #endregion
        #endregion
        #endregion
    }
}