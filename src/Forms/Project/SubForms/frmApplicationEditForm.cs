/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to edit Applications
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
using OLKI.Programme.BeOrSy.src.Project.ReportCeator;
using System;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to edit Applications
    /// </summary>
    public partial class ApplicationEditForm : Form
    {
        #region Events
        /// <summary>
        /// Raised if the Application was changed
        /// </summary>
        internal event EventHandler ItemChanged;
        #endregion

        #region Fields
        /// <summary>
        /// Changes are system intern
        /// </summary>
        private readonly bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the Application for this Form
        /// </summary>
        internal ApplicationItem Application { get; private set; }

        /// <summary>
        /// Get or set the Company for this Application
        /// </summary>
        internal CompanyItem Company { get; private set; }

        /// <summary>
        /// Get or set the IdSet for this Form
        /// </summary>
        public IdSet IdSet { get; }

        /// <summary>
        /// Get or set the main Project
        /// </summary>
        private src.Project.Project Project { get; set; }
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Form to edit Companies
        /// </summary>
        /// <param name="companyId">Id of the root  Company</param>
        /// <param name="idSet">ID-Set of the project</param>
        /// <param name="project">Main Project</param>
        internal ApplicationEditForm(ApplicationItem application, CompanyItem company, IdSet idSet, src.Project.Project project)
        {
            InitializeComponent();
#if !DEBUG
            this.Width = this.Width - Settings_AppConst.Default.Debug_FormWidthOffset;
            this.tabApplication.Width = this.tabApplication.Width - Settings_AppConst.Default.Debug_FormWidthOffset;
#endif
            this.btnAccept.Enabled = application.Id > 0 && application.NewItemState != ItemBase.NewItemStateFlag.NewInitial;

            this._systemChanged = true;
            this.Application = application;
            this.Company = company;
            this.IdSet = idSet;
            this.Project = project;

            this.Text = this.Application.TitleNoText;
            this.tolA_lblId.Text = string.Format(this.tolA_lblId.Text, this.Application.IdText);

            this.chkArchive.Checked = this.Application.Archive;
            this.chkSpeculativeApplication.Checked = this.Application.SpeculativeApplication;
            this.mtbDateCreated.Date = this.Application.DateCreated;
            this.mtbDatePeriodEnd.Date = this.Application.DatePeriodEnd;
            this.mtbDatePeriodStart.Date = this.Application.DatePeriodStart;
            this.txtComment.Text = this.Application.Comment;
            this.txtDirectory.Text = this.Application.Directory;
            this.txtReferenceCode.Text = this.Application.ReferenceCode;
            this.txtTitle.Text = this.Application.Title;

            this.uscEditorContacts.AssociatedContacts = this.Application.AssociatedContacts;
            this.uscEditorContacts.CompanyId = this.Company.Id;
            this.uscEditorContacts.IdSet = this.IdSet;
            this.uscEditorContacts.Items = this.Project.Companies[this.Company.Id].Contacts;
            this.uscEditorContacts.Project = this.Project;

            this.uscEditorFiles.IdSet = this.IdSet;
            this.uscEditorFiles.Items = this.Application.Files;
            this.uscProgressEditor.IdSet = this.IdSet;
            this.uscProgressEditor.Items = this.Application.Progresses;
            this.uscProgressEditor.Project = this.Project;
            this.uscEditorReminders.IdSet = this.IdSet;
            this.uscEditorReminders.Items = this.Application.Reminders;

            this._systemChanged = false;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Application.Archive = this.chkArchive.Checked;
            this.Application.SpeculativeApplication = this.chkSpeculativeApplication.Checked;
            this.Application.DateCreated = this.mtbDateCreated.Date;
            this.Application.DatePeriodEnd = this.mtbDatePeriodEnd.Date;
            this.Application.DatePeriodStart = this.mtbDatePeriodStart.Date;
            this.Application.Comment = this.txtComment.Text;
            this.Application.Directory = this.txtDirectory.Text;
            this.Application.ReferenceCode = this.txtReferenceCode.Text;
            this.Application.Title = this.txtTitle.Text;

            this.uscEditorContacts.IdSet = this.IdSet;
            this.uscEditorContacts.Items = this.Project.Companies[this.Company.Id].Contacts;
            this.Application.AssociatedContacts = this.uscEditorContacts.AssociatedContacts;
            this.Application.Files = this.uscEditorFiles.Items;
            this.Application.Progresses = this.uscProgressEditor.Items;
            this.Application.Reminders = this.uscEditorReminders.Items;

            this.Application.Changed = true;
            this.ItemChanged?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.btnAccept_Click(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tolA_btnCreateReport_Click(object sender, EventArgs e)
        {
            Reporter.Application.Create(this, this.Project, this.Company.Id, this.Application.Id);
        }

        private void tolA_btnGoToFolder_Click(object sender, EventArgs e)
        {
            this.Application.OpenDirectory(this, this.Project, this.Company);
        }

        private void uscEditorContacts_ItemAddedOrAssociationChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            if (this.uscEditorContacts.SelectedItem != null) this.uscEditorContacts.SelectedItem.ItemChanged += new EventHandler(this.Application.Item_Changed);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.Application.Title = this.txtTitle.Text;
            this.Text = this.Application.TitleNoText;
        }
        #endregion
    }
}