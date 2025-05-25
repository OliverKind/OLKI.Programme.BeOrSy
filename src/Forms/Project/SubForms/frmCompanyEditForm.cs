/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to edit Companies
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
using OLKI.Programme.BeOrSy.src.PostcodeManger;
using OLKI.Programme.BeOrSy.src.Project;
using OLKI.Programme.BeOrSy.src.Project.ReportCeator;
using OLKI.Toolbox.Common;
using System;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to edit Companies
    /// </summary>
    internal partial class CompanyEditForm : Form
    {
        #region Events
        /// <summary>
        /// Raised if the Company was changed
        /// </summary>
        internal event EventHandler ItemChanged;
        #endregion

        #region Fields
        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the Company for this Form
        /// </summary>
        internal CompanyItem Company { get; private set; }

        /// <summary>
        /// Get or set the IdSet for this Form
        /// </summary>
        internal IdSet IdSet { get; }

        /// <summary>
        /// Get the main Project
        /// </summary>
        private src.Project.Project Project { get; }
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Form to edit Companies
        /// </summary>
        /// <param name="company">Company to edit</param>
        /// <param name="idSet">ID-Set of the project</param>
        /// <param name="project">Main Project</param>
        internal CompanyEditForm(CompanyItem company, IdSet idSet, src.Project.Project project)
        {
            InitializeComponent();
#if !DEBUG
            this.Width = this.Width - Settings_AppConst.Default.Debug_FormWidthOffset;
            this.tabCompany.Width = this.tabCompany.Width - Settings_AppConst.Default.Debug_FormWidthOffset;
#endif
            this.btnAccept.Enabled = company.Id > 0 && company.NewItemState != ItemBase.NewItemStateFlag.NewInitial;

            this._systemChanged = true;
            this.Company = company;
            this.IdSet = idSet;
            this.Project = project;

            this.Text = this.Company.TitleNoText;
            this.tolC_lblId.Text = string.Format(this.tolC_lblId.Text, this.Company.IdText);

            this.cboTrade.Text = this.Company.Trade;
            this.chkTerminated.Checked = this.Company.Terminated;
            this.txtComment.Text = this.Company.Comment;
            this.txtDirectory.Text = this.Company.Directory;
            this.txtTitle.Text = this.Company.Title;

            this.cboAdressCity.Text = this.Company.AdressCity;
            this.cboAdressCountry.Text = this.Company.AdressCountry;
            this.cboAdressState.Text = this.Company.AdressState;
            this.txtAdressStreet.Text = this.Company.AdressStreet;
            this.txtAdressPostcode.Text = this.Company.AdressPostcode;

            this.txtContactCareerPage.Text = this.Company.ContactCareerPage;
            this.txtContactEMail.Text = this.Company.ContactEMail;
            this.txtContactFax.Text = this.Company.ContactFax;
            this.txtContactHomepage.Text = this.Company.ContactHomepage;
            this.txtContactTelephone.Text = this.Company.ContactTelephone;

            this.uscEditorContacts.CompanyId = this.Company.Id;
            this.uscEditorContacts.IdSet = this.IdSet;
            this.uscEditorContacts.Items = this.Company.Contacts;
            this.uscEditorContacts.Project = this.Project;
            this.uscEditorFiles.IdSet = this.IdSet;
            this.uscEditorFiles.Items = this.Company.Files;
            this.uscEditorReminders.IdSet = this.IdSet;
            this.uscEditorReminders.Items = this.Company.Reminders;

            this.lsvColorMarker.Items.Clear();
            ListViewItem NewListViewItem;
            for (int i = 0; i < this.imlColorMarkers.Images.Count; i++)
            {
                NewListViewItem = new ListViewItem
                {
                    ImageIndex = i,
                    Text = this.imlColorMarkers.Images.Keys[i].ToString().Substring(5, this.imlColorMarkers.Images.Keys[i].ToString().Length - 9),
                    Selected = this.Company.ColorMarker == i
                };
                this.lsvColorMarker.Items.Add(NewListViewItem);
            }

            project.FillComboBoxDropDown(this.cboAdressCity, this.cboAdressCountry, this.cboAdressState, this.cboTrade);
            this.txtContactCareerPage_TextChanged(this, EventArgs.Empty);
            this.txtContactHomepage_TextChanged(this, EventArgs.Empty);
            this.txtContactEMail_TextChanged(this, EventArgs.Empty);
            this._systemChanged = false;
        }

        #region Controle Events
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Company.Title = this.txtTitle.Text;
            this.Company.Trade = this.cboTrade.Text;
            this.Company.ColorMarker = this.lsvColorMarker.SelectedItems.Count > 0 ? this.lsvColorMarker.SelectedItems[0].Index : 0;

            this.Company.AdressCity = this.cboAdressCity.Text;
            this.Company.AdressCountry = this.cboAdressCountry.Text;
            this.Company.AdressState = this.cboAdressState.Text;
            this.Company.Terminated = this.chkTerminated.Checked;
            this.Company.AdressStreet = this.txtAdressStreet.Text;
            this.Company.AdressPostcode = this.txtAdressPostcode.Text;
            this.Company.Comment = this.txtComment.Text;

            this.Company.ContactCareerPage = this.txtContactCareerPage.Text;
            this.Company.ContactEMail = this.txtContactEMail.Text;
            this.Company.ContactFax = this.txtContactFax.Text;
            this.Company.ContactHomepage = this.txtContactHomepage.Text;
            this.Company.ContactTelephone = this.txtContactTelephone.Text;

            this.Company.Contacts = this.uscEditorContacts.Items;
            this.Company.Files = this.uscEditorFiles.Items;
            this.Company.Reminders = this.uscEditorReminders.Items;

            this.Company.Changed = true;
            this.ItemChanged?.Invoke(sender, e);
        }

        private void btnAdressPostcodeAuto_Click(object sender, EventArgs e)
        {
            PostcodeItem PostcodeItem = Program.PostcodeManager.SearchPostcode(this, this.txtAdressPostcode.Text);
            if (PostcodeItem == null) return;

            this.cboAdressCity.Text = PostcodeItem.CodeCity;
            this.cboAdressCountry.Text = PostcodeItem.CodeNation;
            this.cboAdressState.Text = PostcodeItem.CodeState;
        }

        private void btnAdressPostcodeEdit_Click(object sender, EventArgs e)
        {
            MainForm.SubForms.ApplicationSettingsForm ApplicationSettingsForm = new MainForm.SubForms.ApplicationSettingsForm();
            ApplicationSettingsForm.ShowDialog(this);
        }

        private void btnAdressToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.Company.AdressFieldSum);
            MessageBox.Show(this, Stringtable._0x0016m, Stringtable._0x0016c, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnContactCareerPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsValidUri(this.txtContactCareerPage.Text, out Uri Uri)) System.Diagnostics.Process.Start(Uri.ToString());
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void btnContatEMail_Click(object sender, EventArgs e)
        {
            if (this.txtContactEMail.Text.Length > 0) System.Diagnostics.Process.Start("mailto:" + this.txtContactEMail.Text);
        }

        private void btnContactHomepage_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation.IsValidUri(this.txtContactHomepage.Text, out Uri Uri)) System.Diagnostics.Process.Start(Uri.ToString());
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog
            {
                SelectedPath = this.txtDirectory.Text,
                ShowNewFolderButton = true
            };
            if (FolderBrowserDialog.ShowDialog(this) == DialogResult.OK)
            {
                this.txtDirectory.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.btnAccept_Click(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tolC_btnCreateReport_Click(object sender, EventArgs e)
        {
            Reporter.Company.Create(this, this.Project, this.Company.Id);
        }

        private void tolC_btnGoToFolder_Click(object sender, EventArgs e)
        {
            this.Company.OpenDirectory(this, this.Project);

        }

        private void txtContactCareerPage_TextChanged(object sender, EventArgs e)
        {
            bool UriIsValid = Validation.IsValidUri(this.txtContactCareerPage.Text);
            this.btnContactCareerPage.Enabled = UriIsValid;
            this.erpEditor.SetError((Control)sender, UriIsValid ? "" : Stringtable._0x0023);
        }

        private void txtContactEMail_TextChanged(object sender, EventArgs e)
        {
            bool EMailValid = Validation.IsValidEMail(this.txtContactEMail.Text);
            this.btnContatEMail.Enabled = EMailValid;
            this.erpEditor.SetError((Control)sender, EMailValid ? "" : Stringtable._0x0022);
        }

        private void txtContactHomepage_TextChanged(object sender, EventArgs e)
        {
            bool UriIsValid = Validation.IsValidUri(this.txtContactHomepage.Text);
            this.btnContactHomepage.Enabled = UriIsValid;
            this.erpEditor.SetError((Control)sender, UriIsValid ? "" : Stringtable._0x0023);
        }

        private void txtDirectory_TextChanged(object sender, EventArgs e)
        {
            this.erpEditor.SetError((Control)sender, Validation.IsValidDirectory(this.txtDirectory.Text, true) ? "" : Stringtable._0x0017);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            this.Company.Title = this.txtTitle.Text;
            this.Text = this.Company.TitleNoText;
        }

        private void uscEditorContacts_ItemAddedOrAssociationChanged(object sender, EventArgs e)
        {
            if (this.uscEditorContacts.SelectedItem != null) this.uscEditorContacts.SelectedItem.ItemChanged += new EventHandler(this.Company.Item_Changed);
        }
        private void uscEditorFiles_ItemAdded(object sender, EventArgs e)
        {
            if (this.uscEditorFiles.SelectedItem != null) this.uscEditorFiles.SelectedItem.ItemChanged += new EventHandler(this.Company.Item_Changed);
        }

        private void uscEditorReminders_ItemAdded(object sender, EventArgs e)
        {
            if (this.uscEditorReminders.SelectedItem != null) this.uscEditorReminders.SelectedItem.ItemChanged += new EventHandler(this.Company.Item_Changed);
        }
        #endregion
        #endregion
    }
}