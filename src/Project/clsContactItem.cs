/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a Contact and provide Methodes to handle them
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
using OLKI.Toolbox.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a Contact and provide Methodes to handle them
    /// </summary>
    public class ContactItem : ItemBase
    {
        #region Properties
        /// <summary>
        /// The Contact Cellphone Numer
        /// </summary>
        private string _contactCellPhone;
        /// <summary>
        /// Get or set the Contact Cellphone Numer
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Mobilfunknummer des Kontakts.")]
        [DisplayName("Mobil")]
        public string ContactCellphone
        {
            get => this._contactCellPhone;
            set
            {
                this._contactCellPhone = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Contact E-Mail Adress
        /// </summary>
        private string _contactEMail;
        /// <summary>
        /// Get or set the Contact E-Mail Adress
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("E-Mail Adresse des Kontakts.")]
        [DisplayName("E-Mail")]
        public string ContactEMail
        {
            get => this._contactEMail;
            set
            {
                this._contactEMail = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Contact Telephone Number
        /// </summary>
        private string _contactTelephone;
        /// <summary>
        /// Get or set the Contact Telephone Number
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Telefonnummer des Kontakts.")]
        [DisplayName("Telefonnummer")]
        public string ContactTelephone
        {
            get => this._contactTelephone;
            set
            {
                this._contactTelephone = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Contact Fax Number
        /// </summary>
        private string _contactFax;
        /// <summary>
        /// Get or set the Contact Fax Number
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Faxnummer des Kontakts.")]
        [DisplayName("Faxnummer")]
        public string ContactFax
        {
            get => this._contactFax;
            set
            {
                this._contactFax = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Division of the Contact
        /// </summary>
        private string _division;
        /// <summary>
        /// Get or set the Division of the Contact
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue("")]
        [Description("Abteilung des Kontakts.")]
        [DisplayName("Abteilung")]
        public string Division
        {
            get => this._division;
            set
            {
                this._division = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get or set a list with Files to this Contact
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, FileItem> Files { get; set; } = new Dictionary<int, FileItem> { };

        /// <summary>
        /// Get the complete Name of the contact, or an default text if no name is given
        /// </summary>
        [Browsable(false)]
        public string NameComplete
        {
            get
            {
                string CplName = "";
                CplName += string.IsNullOrEmpty(this._nameTitle) ? "" : this._nameTitle + " ";
                CplName += string.IsNullOrEmpty(this._nameFirst) ? "" : this._nameFirst + " ";
                CplName += string.IsNullOrEmpty(this._nameLastt) ? "" : this._nameLastt + " ";

                return string.IsNullOrEmpty(CplName) ? Stringtable._0x0002 : CplName;
            }
        }

        /// <summary>
        /// The Contact First Name
        /// </summary>
        private string _nameFirst;
        /// <summary>
        /// Get or set the Contact First Name
        /// </summary>
        [Category("Name")]
        [DefaultValue("")]
        [Description("Vorname des Kontakts.")]
        [DisplayName("Vorname")]
        public string NameFirst
        {
            get
            {
                return this._nameFirst;
            }
            set
            {
                this._nameFirst = value.Trim();
                base.Changed = true;
            }
        }
        /// <summary>
        /// Get the first name of the contadct, or an default text if no name is given
        /// </summary>
        [Browsable(false)]
        public string NameFirstNoText
        {
            get
            {
                return string.IsNullOrEmpty(this.NameFirst) ? Stringtable._0x0002 : this.NameFirst;
            }
        }

        /// <summary>
        /// The Contact Lastname
        /// </summary>
        private string _nameLastt;
        /// <summary>
        /// Get or set the Contact Lastname
        /// </summary>
        [Category("Name")]
        [DefaultValue("")]
        [Description("Nachname des Kontakts.")]
        [DisplayName("Nachname")]
        public string NameLast
        {
            get
            {
                return this._nameLastt;
            }
            set
            {
                this._nameLastt = value.Trim();
                base.Changed = true;
            }
        }
        /// <summary>
        /// Get the Lastname of the contadct, or an default text if no name is given
        /// </summary>
        [Browsable(false)]
        public string NameLastNoText
        {
            get
            {
                return string.IsNullOrEmpty(this.NameLast) ? Stringtable._0x0002 : this.NameLast;
            }
        }

        /// <summary>
        /// The Contact Title
        /// </summary>
        private string _nameTitle;
        /// <summary>
        /// Get or set the Contact Title
        /// </summary>
        [Category("Name")]
        [DefaultValue("")]
        [Description("Titel des Kontakts.")]
        [DisplayName("Titel")]
        public string NameTitle
        {
            get
            {
                return this._nameTitle;
            }
            set
            {
                this._nameTitle = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Contact Position
        /// </summary>
        private string _position;
        /// <summary>
        /// Get or set the Contact Position
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue("")]
        [Description("Position des Kontakts.")]
        [DisplayName("Position")]
        public string Position
        {
            get
            {
                return this._position;
            }
            set
            {
                this._position = value.Trim();
                base.Changed = true;
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Create a new empty Contact object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty Contact</param>
        public ContactItem(int id)
        {
            base.Id = id;
        }
        /// <summary>
        /// Create a new Contact, get data from an XElement Object
        /// </summary>
        /// <param name="inputContact">XElement to read Contact data from</param>
        public ContactItem(XElement inputContact)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputContact, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputContact, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputContact, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = Serialize.GetFromXElement(inputContact, "Id", base.Id);
            base.NewItemState = NewItemStateFlag.NotNew;

            this._contactCellPhone = Serialize.GetFromXElement(inputContact, "ContactCellphone", this._contactCellPhone);
            this._contactEMail = Serialize.GetFromXElement(inputContact, "ContactEMail", this._contactEMail);
            this._contactFax = Serialize.GetFromXElement(inputContact, "ContactFax", this._contactFax);
            this._contactTelephone = Serialize.GetFromXElement(inputContact, "ContactTelephone", this._contactTelephone);

            this._division = Serialize.GetFromXElement(inputContact, "Division", this._division);
            this._nameFirst = Serialize.GetFromXElement(inputContact, "NameFirst", this._nameFirst);
            this._nameLastt = Serialize.GetFromXElement(inputContact, "NameLast", this._nameLastt);
            this._nameTitle = Serialize.GetFromXElement(inputContact, "NameTitle", this._nameTitle);
            this._position = Serialize.GetFromXElement(inputContact, "Position", this._position);

            this.Files.Clear();
            XElement FileList = Serialize.GetFromXElement(inputContact, "FileList", new XElement("FileList"));
            if (FileList != null)
            {
                foreach (XElement FileItem in FileList.Elements("FileItem"))
                {
                    FileItem NewFile = new FileItem(FileItem);
                    this.Files.Add(NewFile.Id, NewFile);
                    this.Files[NewFile.Id].ItemChanged += new EventHandler(this.Item_Changed);
                }
            }
        }

        /// <summary>
        /// Clone the Contact object and all sub items
        /// </summary>
        /// <returns>The cloned Contact object and all cloned sub items</returns>
        public ContactItem Clone()
        {
            ContactItem ThisClone = (ContactItem)this.MemberwiseClone();

            ThisClone.Files = new Dictionary<int, FileItem>();
            foreach (KeyValuePair<int, FileItem> FileItem in this.Files)
            {
                ThisClone.Files.Add(FileItem.Key, FileItem.Value.Clone());
                ThisClone.Files[FileItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Files[FileItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
            }
            return ThisClone;
        }

        /// <summary>
        /// Converts the Contact Item to an XElement object
        /// </summary>
        /// <returns>Contact Item data as XElement</returns>
        public XElement ToXElement()
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("ContactItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base.Comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));
            Root.Add(new XElement("Title", base.Title));

            Root.Add(new XElement("ContactCellphone", this._contactCellPhone));
            Root.Add(new XElement("ContactEMail", this._contactEMail));
            Root.Add(new XElement("ContactFax", this._contactFax));
            Root.Add(new XElement("ContactTelephone", this._contactTelephone));

            Root.Add(new XElement("Division", this._division));
            Root.Add(new XElement("NameFirst", this._nameFirst));
            Root.Add(new XElement("NameLast", this._nameLastt));
            Root.Add(new XElement("NameTitle", this._title));
            Root.Add(new XElement("Position", this._nameTitle));

            XElement FileList = new XElement("FileList");
            foreach (FileItem File in this.Files.Values.OrderBy(oFile => oFile.Id))
            {
                if (File.Delete == DeleteFlag.None) FileList.Add(File.ToXElement());
            }
            Root.Add(FileList);

            return Root;
        }
        #endregion
    }
}