/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form that contains Data and provide Methodes to search for Applications
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
using OLKI.Programme.BeOrSy.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static OLKI.Programme.BeOrSy.src.Project.Filter.Application;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form that contains Data and provide Methodes to search for Applications
    /// </summary>
    public partial class ApplicationSearchForm : Form
    {
        #region Fields
        /// <summary>
        /// Get the root Project Form
        /// </summary>
        private readonly ProjectForm _projectForm;

        /// <summary>
        /// Id of the currently selected Application
        /// </summary>
        private int _selectedApplId = 0;

        /// <summary>
        /// Id of the currently selected Company, refer to the selected Application
        /// </summary>
        private int _selectedCompId = 0;

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
        /// Initial a new Form that contains Data and provide Methodes to search for Applications
        /// </summary>
        /// <param name="projectForm"></param>
        public ApplicationSearchForm(ProjectForm projectForm)
        {
            InitializeComponent();
            this._projectForm = projectForm;
            this._tolLA_lblAppId_OrgText = this.tolLA_lblAppId.Text;
            this._tolLA_lblComId_OrgText = this.tolLA_lblComId.Text;
            this._tslApplicationsList_OrgText = this.tslApplicationsList.Text;
            this._tslApplicationsSelected_OrgText = this.tslApplicationsSelected.Text;
            this._tslApplicationsTotal_OrgText = this.tslApplicationsTotal.Text;

            this.Text = string.Format(this.Text, new object[] { this._projectForm.Project.ProjectTitle });
            Toolbox.Widgets.Tools.ComboBox.SetToFirstIndex(this.cboFilterPriority);
            this.tolListApplication.Enabled = false;

            this.lsvProgressFilter.Items.Clear();
            foreach (ProgressItem ProgressItem in this._projectForm.Project.Settings.ProgressTemplateList.Values.OrderBy(o => o.Order))
            {
                if (ProgressItem.Delete == ItemBase.DeleteFlag.None)
                {
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvProgressFilter.FillUpSubItems(NewItem);
                    NewItem.BackColor = ProgressItem.Color;
                    NewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(NewItem.BackColor);
                    NewItem.ImageIndex = (int)ProgressItem.State;
                    NewItem.Tag = ProgressItem.Id;
                    NewItem.Text = ProgressItem.TitleNoText;
                    NewItem.SubItems[1].Text = string.Format("{0} - {1}", new object[] { ProgressItem.Weight, ProgressItem.Weight + Settings_AppConst.Default.ProgressWeightWidth });
                    this.lsvProgressFilter.Items.Add(NewItem);
                }
            }

            int ApplCount = 0;
            if (this._projectForm.Project.Companies != null && this._projectForm.Project.Companies.Count > 0)
            {
                foreach (CompanyItem CompItem in this._projectForm.Project.Companies.Values)
                {
                    if (CompItem.Applications != null && CompItem.Applications.Count > 0)
                    {
                        foreach (ApplicationItem ApplItem in CompItem.Applications.Values)
                        {
                            ApplCount++;
                        }
                    }
                }
            }
            this.tslApplicationsList.Text = string.Format(this._tslApplicationsList_OrgText, new object[] { 0 });
            this.tslApplicationsSelected.Text = string.Format(this._tslApplicationsSelected_OrgText, new object[] { 0 });
            this.tslApplicationsTotal.Text = string.Format(this._tslApplicationsTotal_OrgText, new object[] { ApplCount });
            this.lsvApplication_SelectedIndexChanged(this, EventArgs.Empty);
        }

        #region Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListApplications_Click(object sender, EventArgs e)
        {
            this._selectedApplId = 0;
            this._selectedCompId = 0;
            this.lsvApplication.BeginUpdate();
            this.lsvApplication.Items.Clear();

            DateModeIndikator DateMode = (DateModeIndikator)(-1);
            if (this.rabDateFilterApplicationCreated.Checked) DateMode = DateModeIndikator.ApplicationCreated;
            if (this.rabDateFilterFirstProgress.Checked) DateMode = DateModeIndikator.FirstProgressItem;
            if (this.rabDateFilterLastProgress.Checked) DateMode = DateModeIndikator.LastProgressItem;

            List<int> ProgressList = new List<int>();
            foreach (ListViewItem Item in this.lsvProgressFilter.SelectedItems)
            {
                ProgressList.Add(this._projectForm.Project.Settings.ProgressTemplateList[(int)Item.Tag].WeightBase100);
            }
            if (ProgressList == null || ProgressList.Count == 0 || ProgressList.Count == this.lsvProgressFilter.Items.Count) ProgressList = null;

            src.Project.Filter.Application ApplicationFilter = new src.Project.Filter.Application
            {
                DateFrom = this.mtbFilterDateFrom.Date,
                DateMode = DateMode,
                DateTo = this.mtbFilterDateTo.Date,
                PriorityMode = (PriorityModeIndikator)this.cboFilterPriority.SelectedIndex,
                PriorityThreshold = (int)this.nudFilterPriority.Value,
                ProgressWeight = ProgressList,
                Text = this.txtFilterText.Text,
                TypeSpeculativ = this.chkFilterApplicationTypeSpeculative.CheckState
            };

            List<Dictionary<IdBelongingIndikator, int>> ApplicationList = ApplicationFilter.Detail(this._projectForm.Project.Companies) ?? new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (Dictionary<IdBelongingIndikator, int> ApplItem in ApplicationList)
            {
                ApplicationItem App = this._projectForm.Project.Companies[ApplItem[IdBelongingIndikator.Company]].Applications[ApplItem[IdBelongingIndikator.Application]];
                ReminderItem NextReminder = App.ReminderNext;
                ProgressItem ProgressMax = App.ProgressMax;

                ListViewItem ListViewItem = new ListViewItem();
                this.lsvApplication.FillUpSubItems(ListViewItem);

                ListViewItem.BackColor = ProgressMax == null ? Color.Empty : ProgressMax.Color;
                ListViewItem.Font = App.ReminderNext == null ? ListViewItem.Font : new Font(ListViewItem.Font, ListViewItem.Font.Style | FontStyle.Bold);
                ListViewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(ProgressMax == null ? BackColor : ProgressMax.Color);
                ListViewItem.ImageIndex = App.ImageIndex;
                ListViewItem.Tag = ApplItem;
                ListViewItem.Text = App.TitleNoText;

                ListViewItem.SubItems[1].Text = App.ReferenceCode;
                ListViewItem.SubItems[2].Tag = App.DateCreated;
                ListViewItem.SubItems[2].Text = App.DateCreated == null ? "" : ((DateTime)App.DateCreated).ToString(Properties.Settings.Default.DateFormat);
                ListViewItem.SubItems[3].Text = ProgressMax == null ? "" : ProgressMax.TitleNoText;
                ListViewItem.SubItems[4].Tag = ProgressMax?.Date;
                ListViewItem.SubItems[4].Text = ProgressMax == null ? "" : ProgressMax.DateFormated;
                ListViewItem.SubItems[5].Text = this._projectForm.Project.Companies[ApplItem[IdBelongingIndikator.Company]].TitleNoText;
                ListViewItem.SubItems[6].Tag = ApplItem[IdBelongingIndikator.Company];
                ListViewItem.SubItems[6].Text = ApplItem[IdBelongingIndikator.Company].ToString();
                ListViewItem.SubItems[7].Tag = ApplItem[IdBelongingIndikator.Application];
                ListViewItem.SubItems[7].Text = ApplItem[IdBelongingIndikator.Application].ToString();

                this.lsvApplication.Items.Add(ListViewItem);
            }
            this.lsvApplication.Sort();
            this.lsvApplication.EndUpdate();
            this.tslApplicationsList.Text = string.Format(this._tslApplicationsList_OrgText, new object[] { this.lsvApplication.Items.Count });
            this.lsvApplication_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void cboFilterPriority_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.nudFilterPriority.Enabled = this.cboFilterPriority.SelectedIndex != 0;
        }

        private void lsvApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tolListApplication.Enabled = this.lsvApplication.SelectedItems.Count != 0;
            this.tolLA_btnGoToAppFolder.Enabled = this.tolListApplication.Enabled && this.lsvApplication.SelectedItems.Count == 1;
            this.tolLA_btnGoToComFolder.Enabled = this.tolListApplication.Enabled && this.lsvApplication.SelectedItems.Count == 1;
            this.tslApplicationsSelected.Text = string.Format(this._tslApplicationsSelected_OrgText, new object[] { this.lsvApplication.SelectedItems.Count });

            if (this.lsvApplication.SelectedItems.Count != 1)
            {
                this._selectedApplId = 0;
                this._selectedCompId = 0;
                this.tolLA_lblAppId.Text = string.Format(this._tolLA_lblAppId_OrgText, new object[] { 0 });
                this.tolLA_lblComId.Text = string.Format(this._tolLA_lblComId_OrgText, new object[] { 0 });
                return;
            }

            this._selectedApplId = ((Dictionary<IdBelongingIndikator, int>)this.lsvApplication.SelectedItems[0].Tag)[IdBelongingIndikator.Application];
            this._selectedCompId = ((Dictionary<IdBelongingIndikator, int>)this.lsvApplication.SelectedItems[0].Tag)[IdBelongingIndikator.Company];
            this.tolLA_lblAppId.Text = string.Format(this._tolLA_lblAppId_OrgText, new object[] { this._selectedApplId });
            this.tolLA_lblComId.Text = string.Format(this._tolLA_lblComId_OrgText, new object[] { this._selectedCompId });

            this.tolLA_btnGoToComFolder.Enabled = this._selectedCompId > 0;
            this._projectForm.lsvCompany.SetAllSelections(false);
            foreach (ListViewItem CompItem in this._projectForm.lsvCompany.Items)
            {
                if ((int)CompItem.Tag == this._selectedCompId)
                {
                    CompItem.Selected = true;
                    break;
                }
            }
            this.tolLA_btnGoToAppFolder.Enabled = this._selectedApplId > 0;
            this._projectForm.lsvApplication.SetAllSelections(false);
            foreach (ListViewItem ApplItem in this._projectForm.lsvApplication.Items)
            {
                if ((int)ApplItem.Tag == this._selectedApplId)
                {
                    ApplItem.Selected = true;
                    break;
                }
            }
        }

        private void tolLA_btnCreateReport_Click(object sender, EventArgs e)
        {
            if (this.lsvApplication.Items.Count == 0 || this.lsvApplication.SelectedItems.Count == 0) return;

            List<Dictionary<IdBelongingIndikator, int>> ApplIdSet = new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (ListViewItem RemiItem in this.lsvApplication.SelectedItems)
            {
                ApplIdSet.Add((Dictionary<IdBelongingIndikator, int>)RemiItem.Tag);
            }
            Reporter.ApplicationList.Create(this, this._projectForm.Project, ApplIdSet, this.mtbFilterDateFrom.Date, this.mtbFilterDateTo.Date, this.chkFilterApplicationTypeSpeculative.CheckState);
        }

        private void tolLA_btnGoToAppFolder_Click(object sender, EventArgs e)
        {
            if (this._selectedApplId == 0 || this._selectedCompId == 0) return;
            this._projectForm.Project.Companies[this._selectedCompId].Applications[this._selectedApplId].OpenDirectory(this, this._projectForm.Project, this._projectForm.Project.Companies[this._selectedCompId]);
        }

        private void tolLA_btnGoToComFolder_Click(object sender, EventArgs e)
        {
            if (this._selectedCompId == 0) return;
            this._projectForm.Project.Companies[this._selectedCompId].OpenDirectory(this, this._projectForm.Project);
        }
        #endregion
        #endregion
    }
}