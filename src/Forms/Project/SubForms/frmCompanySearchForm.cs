/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form that contains Data and provide Methodes to search for Companies
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

using OLKI.Toolbox.Widgets;
using OLKI.Programme.BeOrSy.src.Project.Filter;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form that contains Data and provide Methodes to search for Companies
    /// </summary>
    public partial class CompanySearchForm : Form
    {
        #region Events
        /// <summary>
        /// Raised if the results List should been requested
        /// </summary>
        public event EventHandler RequestListResults;
        #endregion

        #region Fields
        /// <summary>
        /// Get the root Project
        /// </summary>
        private readonly src.Project.Project _project;

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properteis
        /// <summary>
        /// List with filtered Companys
        /// </summary>
        public List<int> CompanyFilteredList { get; private set; }
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Form that contains Data and provide Methodes to search for Companies
        /// </summary>
        /// <param name="project">Root Project</param>
        public CompanySearchForm(src.Project.Project project)
        {
            InitializeComponent();
            this._systemChanged = true;
            this._project = project;
            this.Text = string.Format(this.Text, new object[] { this._project.ProjectTitle });
            this.btnClose.Visible = false;

            this.uscAppProgressFrom.ProgressList = this._project.Settings.ProgressTemplateList;
            Tools.ComboBox.SetToIndex(this.uscAppProgressFrom, this._project.Settings.QuickFilterCompanyAppProgress);
            this.uscProgressStateTo.ProgressList = this._project.Settings.ProgressTemplateList;
            Tools.ComboBox.SetToIndex(this.uscProgressStateTo, this._project.Settings.QuickFilterCompanyAppProgress);
            project.FillComboBoxDropDown(this.cboAdressCity, this.cboAdressCountry, this.cboAdressState, this.cboTrade);

            Tools.ComboBox.SetToFirstIndex(this.uscAppProgressFrom);
            Tools.ComboBox.SetToLastIndex(this.uscProgressStateTo);

            this.lsvColorMarker.Items.Clear();
            ListViewItem NewListViewItem;
            for (int i = 0; i < this.imlColorMarkers.Images.Count; i++)
            {
                NewListViewItem = new ListViewItem
                {
                    ImageIndex = i,
                    Text = this.imlColorMarkers.Images.Keys[i].ToString().Substring(5, this.imlColorMarkers.Images.Keys[i].ToString().Length - 9)
                };
                this.lsvColorMarker.Items.Add(NewListViewItem);
            }
            this.chkAppProgressMode_CheckStateChanged(this, EventArgs.Empty);
            this._systemChanged = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.CompanyFilteredList = new List<int>();

            Company FilterCompany = new Company
            {
                AdressCity = this.cboAdressCity.Text,
                AdressNation = this.cboAdressCountry.Text,
                AdressState = this.cboAdressState.Text,
                AdressStreet = this.txtAdressStreet.Text,
                AdressPostcode = this.txtAdressPostcode.Text,
                Comment = this.txtComment.Text,
                ColorMarker = this.lsvColorMarker.SelectedItems.Count > 0 ? this.lsvColorMarker.SelectedItems[0].Index : 0,
                Id = (int)this.nudId.Value,
                ProgressFrom = this.uscAppProgressFrom.SelectedProgress.Weight,
                ProgressTo = this.uscProgressStateTo.SelectedProgress.Weight,
                ProgressMode = this.chkAppProgressMode.CheckState,
                Terminated = this.chkTerminated.CheckState,
                Title = this.txtTitle.Text,
                Trade = this.cboTrade.Text,
                ApplicationId = (int)this.nudApplicationtId.Value,
                ApplicationText = this.txtApplicationText.Text,
                ContactContact = this.txtContactDiverse.Text,
                ContactId = (int)this.nudContactId.Value,
                ContactText = this.txtContactText.Text
            };

            this.CompanyFilteredList = FilterCompany.Detail(this._project.Companies);
            RequestListResults?.Invoke(sender, e);
            if ((this.CompanyFilteredList == null || this.CompanyFilteredList.Count > 0) && this.chkCloseAfterSucessSearch.Checked) this.Close();
        }

        private void chkAppProgressMode_CheckStateChanged(object sender, EventArgs e)
        {
            this.uscAppProgressFrom.Enabled = this.chkAppProgressMode.CheckState != CheckState.Indeterminate;
            this.uscProgressStateTo.Enabled = this.chkAppProgressMode.CheckState != CheckState.Indeterminate;
        }
        #endregion
    }
}