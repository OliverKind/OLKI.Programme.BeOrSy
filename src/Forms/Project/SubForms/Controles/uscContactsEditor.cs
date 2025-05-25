/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Editor Control to edit Contacts
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    /// <summary>
    /// Editor Control to edit Contacts
    /// </summary>
    public partial class ContactsEditor : UserControl
    {
        #region Events
        /// <summary>
        /// Raised if a Item was added
        /// </summary>
        public event EventHandler ItemAddedOrAssociationChanged;
        #endregion

        #region Fields
        /// <summary>
        /// Contact Editor Form
        /// </summary>
        private ContactEditForm _contactEditForm;
        #endregion

        #region Properties
        /// <summary>
        /// Is the Editor in application Mode
        /// </summary>
        private bool _applicationMode = false;
        /// <summary>
        /// Get or set if the Editor in application Mode
        /// </summary>
        public bool ApplicationMode
        {
            get => this._applicationMode;
            set
            {
                this._applicationMode = value;
                this.chkOnlyChecked.Visible = this._applicationMode;
                this.lsvItems.CheckBoxes = this._applicationMode;
                this.ListItems();
            }
        }

        /// <summary>
        /// A List with Contacts, associated to the application, if in Application Mode
        /// </summary>
        private List<int> _associatedContacts = new List<int>();
        /// <summary>
        /// Get or set a List with Contacts, associated to the application, if in Application Mode
        /// </summary>
        [Browsable(false)]
        public List<int> AssociatedContacts
        {
            get
            {
                this._associatedContacts.Clear();
                foreach (ListViewItem Item in this.lsvItems.Items)
                {
                    if (Item.Checked) this._associatedContacts.Add((int)Item.Tag);
                }
                return this._associatedContacts;
            }
            set
            {
                this._associatedContacts = value;
            }
        }

        /// <summary>
        /// Get or set the CompanyId refer the Contact
        /// </summary>
        [Browsable(false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// Contact Items for the Editor
        /// </summary>
        private Dictionary<int, ContactItem> _items;
        /// <summary>
        /// Get or set the Contact Items for the Editor
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ContactItem> Items
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
        /// Project for the Contact Item
        /// </summary>
        [Browsable(false)]
        public src.Project.Project Project { get; set; } = null;

        /// <summary>
        /// Selected Contact Item
        /// </summary>
        [Browsable(false)]
        public ContactItem SelectedItem { get; private set; } = null;
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Editor Control to edit Contacts
        /// </summary>
        public ContactsEditor()
        {
            InitializeComponent();
#if !DEBUG
            this.Width -= this.prgEditor.Width - this.prgEditor.Margin.Left - this.prgEditor.Right - this.lsvItems.Margin.Right;
            this.prgEditor.Enabled = false;
            this.prgEditor.Visible = false;
#endif
            this.lsvItems_SelectedIndexChanged(this, EventArgs.Empty);
            this.ApplicationMode = false;
        }

        /// <summary>
        /// List Contact Items to ListView
        /// </summary>
        public void ListItems()
        {
            this.lsvItems.Items.Clear();
            if (this._items == null || this._items.Count == 0) return;

            foreach (ContactItem ContactItem in this._items.Values.OrderBy(o => o.NameLast).ThenBy(o => o.NameFirst))
            {
                if (ContactItem.Delete == ItemBase.DeleteFlag.None)
                {
                    //Create empty item and fill up by update procedure
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvItems.FillUpSubItems(NewItem);
                    this.UpdateListViewItem(ContactItem, NewItem);
                    this.lsvItems.Items.Add(NewItem);
                }
            }
        }

        /// <summary>
        /// Update the defined Contact Item in ListView
        /// </summary>
        /// <param name="contact">Contact to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        private void UpdateListViewItem(ContactItem contact, ListViewItem listViewItem)
        {
            listViewItem.Checked = this._associatedContacts != null && this._associatedContacts.Contains(contact.Id);
            listViewItem.ImageIndex = 0;
            listViewItem.Tag = contact.Id;
            listViewItem.Text = contact.NameFirstNoText;
            listViewItem.SubItems[1].Text = contact.NameLastNoText;
            listViewItem.SubItems[2].Text = contact.Position;
            listViewItem.SubItems[4].Text = contact.Division;
            listViewItem.SubItems[4].Text = contact.ContactTelephone;
            listViewItem.SubItems[5].Text = contact.ContactEMail;
            listViewItem.SubItems[6].Text = contact.Comment;
        }

        #region Controle Events
        private void contactEdit_ContactChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1 || this._contactEditForm.Contact.NewItemState == ItemBase.NewItemStateFlag.NewInitial) return;
            this._items[this._contactEditForm.Contact.Id] = this._contactEditForm.Contact;
            this.UpdateListViewItem(this._items[this._contactEditForm.Contact.Id], this.lsvItems.SelectedItems[0]);
            this.prgEditor.SelectedObject = this._items[this._contactEditForm.Contact.Id];
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            int NewId = this.IdSet.GetNextId(this.IdSet.Cont);
            ContactItem NewContact = new ContactItem(NewId);
            this._contactEditForm = new ContactEditForm(NewContact, this.IdSet.Clone(), this.Project, this.CompanyId);
            this._contactEditForm.ContactChanged += new EventHandler(this.contactEdit_ContactChanged);

            if (this._contactEditForm.ShowDialog(this) == DialogResult.OK)
            {
                this._contactEditForm.Contact.NewItemState = ItemBase.NewItemStateFlag.NewNotSaved;
                this.Items.Add(NewId, this._contactEditForm.Contact);
                this.IdSet.Cont = NewId;

                ListViewItem NewItem = new ListViewItem();
                this.lsvItems.FillUpSubItems(NewItem);
                this.UpdateListViewItem(this._contactEditForm.Contact, NewItem);
                this.lsvItems.Items.Add(NewItem);
                //TODO: this.lsvContact.SelectItemByIdTag(NewId); <-- Leading to exception
                this.lsvItems.LastItemVisible();
                this.ItemAddedOrAssociationChanged?.Invoke(sender, e);
            }
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.Items.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0010m, Stringtable._0x0010c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            ItemBase.DeleteFlag DeleteFlag;
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteDirectory;
                    break;
                default:
                    return;
            }
            foreach (ListViewItem ContactItem in this.lsvItems.SelectedItems)
            {
                this.Items[(int)ContactItem.Tag].Delete = DeleteFlag;
                ContactItem.Remove();
            }
        }

        private void btnItemEdit_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1) return;
            this._contactEditForm = new ContactEditForm(this.Items[(int)this.lsvItems.SelectedItems[0].Tag].Clone(), this.IdSet.Clone(), this.Project, this.CompanyId);
            this._contactEditForm.ContactChanged += new EventHandler(this.contactEdit_ContactChanged);
            this._contactEditForm.ShowDialog(this);
        }

        private void btnContactReport_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1) return;
            Reporter.Contact.Create(this, this.Project, this.CompanyId, (int)this.lsvItems.SelectedItems[0].Tag);
        }

        private void chkOnlyChecked_CheckedChanged(object sender, EventArgs e)
        {
            this.ListItems();
        }

        private void lsvItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btnItemEdit_Click(sender, e);
        }

        private void lsvIttemss_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (this._applicationMode)
            {
                this._associatedContacts.Clear();
                foreach (ListViewItem ContactItem in this.lsvItems.Items)
                {
                    if (ContactItem.Checked && !this._associatedContacts.Contains((int)ContactItem.Tag))
                    {
                        this._associatedContacts.Add((int)ContactItem.Tag);
                    }
                }
            }
            this.ItemAddedOrAssociationChanged?.Invoke(this, EventArgs.Empty);
        }

        private void lsvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count == 1)
            {
                this.SelectedItem = this.Items[(int)this.lsvItems.SelectedItems[0].Tag];
                this.btnItemDelete.Enabled = true;
                this.btnItemEdit.Enabled = true;
                this.btnContactReport.Enabled = true;
                this.prgEditor.SelectedObject = this.SelectedItem;
            }
            else
            {
                this.SelectedItem = null;
                this.btnItemDelete.Enabled = this.lsvItems.SelectedItems.Count > 0;
                this.btnItemEdit.Enabled = false;
                this.btnContactReport.Enabled = false;
                this.prgEditor.SelectedObject = this.SelectedItem;
            }
        }

        private void prgEditor_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.lsvItems.SelectedItems.Count != 1) return;
            this.UpdateListViewItem((ContactItem)this.prgEditor.SelectedObject, this.lsvItems.SelectedItems[0]);
        }
        #endregion
        #endregion
    }
}