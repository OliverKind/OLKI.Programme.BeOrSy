/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to edit Contacts
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
using OLKI.Toolbox.Common;
using System;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to edit Contacts
    /// </summary>
    public partial class ContactEditForm : Form
    {
        #region Events
        /// <summary>
        /// Raised if the Contact was changed
        /// </summary>
        public event EventHandler ContactChanged;
        #endregion

        #region Fields
        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the CompanyId refer the Contact
        /// </summary>
        public int CompanyId { get; set; }

        /// <summary>
        /// Get or set the Contact Item for this Form
        /// </summary>
        internal ContactItem Contact { get; private set; }

        /// <summary>
        /// Get or set the IdSet for this Form
        /// </summary>
        public IdSet IdSet { get; private set; }

        /// <summary>
        /// Project for the Contact Item
        /// </summary>
        public src.Project.Project Project { get; set; } = null;
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Form to edit Contacts
        /// </summary>
        /// <param name="contact">Contat to edit</param>
        /// <param name="idSet">IdSet of the Project</param>
        /// <param name="project">Main Porject</param>
        /// <param name="companyId">Company refer to the contact</param>
        public ContactEditForm(ContactItem contact, IdSet idSet, src.Project.Project project, int companyId)
        {
            InitializeComponent();
#if DEBUG
            this.Width = this.Width + Settings_AppConst.Default.Debug_FormWidthOffset;
            this.tapContact.Width = this.tapContact.Width + Settings_AppConst.Default.Debug_FormWidthOffset;
#endif
            this.btnAccept.Enabled = contact.Id > 0 && contact.NewItemState != ItemBase.NewItemStateFlag.NewInitial;

            this._systemChanged = true;
            this.CompanyId = companyId;
            this.Contact = contact;
            this.IdSet = idSet;
            this.Project = project;

            this.Text = this.Contact.NameComplete;
            this.tolCt_lblId.Text = string.Format(this.tolCt_lblId.Text, this.Contact.IdText);

            this.txtNameFirst.Text = this.Contact.NameFirst;
            this.txtNameLast.Text = this.Contact.NameLast;
            this.txtNameTitle.Text = this.Contact.NameTitle;

            this.txtComment.Text = this.Contact.Comment;
            this.txtContactCellphone.Text = this.Contact.ContactCellphone;
            this.txtContactEMail.Text = this.Contact.ContactEMail;
            this.txtContactFax.Text = this.Contact.ContactFax;
            this.txtContactTelephone.Text = this.Contact.ContactTelephone;
            this.txtDivision.Text = this.Contact.Division;
            this.txtPosition.Text = this.Contact.Position;

            this.uscEditorFiles.IdSet = this.IdSet;
            this.uscEditorFiles.Items = this.Contact.Files;

            this._systemChanged = false;
        }

        #region Form Events
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.Contact.Comment = this.txtComment.Text;
            this.Contact.ContactCellphone = this.txtContactCellphone.Text;
            this.Contact.ContactEMail = this.txtContactEMail.Text;
            this.Contact.ContactFax = this.txtContactFax.Text;
            this.Contact.ContactTelephone = this.txtContactTelephone.Text;
            this.Contact.Division = this.txtDivision.Text;
            this.Contact.Files = this.uscEditorFiles.Items;
            this.Contact.NameFirst = this.txtNameFirst.Text;
            this.Contact.NameLast = this.txtNameLast.Text;
            this.Contact.NameTitle = this.txtNameTitle.Text;
            this.Contact.Position = this.txtPosition.Text;

            this.ContactChanged?.Invoke(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnContatEMail_Click(object sender, EventArgs e)
        {
            if (this.txtContactEMail.Text.Length > 0) System.Diagnostics.Process.Start("mailto:" + this.txtContactEMail.Text);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.btnAccept_Click(sender, e);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tolC_btnCreateReport_Click(object sender, EventArgs e)
        {
            Reporter.Contact.Create(this, this.Project, this.CompanyId, this.Contact.Id);
        }

        private void txtContactEMail_TextChanged(object sender, EventArgs e)
        {
            bool EMailValid = Validation.IsValidEMail(this.txtContactEMail.Text);
            this.btnContatEMail.Enabled = EMailValid;
            this.erpEditor.SetError((Control)sender, EMailValid ? "" : Stringtable._0x0022);
        }

        private void txtNameXXX_TextChanged(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            ContactItem TempContact = new ContactItem(0)
            {
                NameFirst = this.txtNameFirst.Text,
                NameLast = this.txtNameLast.Text,
                NameTitle = this.txtNameTitle.Text
            };

            this.Text = TempContact.NameComplete;
        }

        private void uscEditorFiles_ItemAdded(object sender, EventArgs e)
        {
            if (this.uscEditorFiles.SelectedItem != null) this.uscEditorFiles.SelectedItem.ItemChanged += new EventHandler(this.Contact.Item_Changed);
        }
        #endregion
        #endregion
    }
}