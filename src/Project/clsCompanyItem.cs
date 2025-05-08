/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a Company and provide Methodes to handle them
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
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a Company and provide Methodes to handle them
    /// </summary>
    public class CompanyItem : ItemBase
    {
        #region Properties
        #region Adress
        /// <summary>
        /// The Adress City
        /// </summary>
        private string _adressCity = string.Empty;
        /// <summary>
        /// Get or set the Adress City
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Stadt der Firmenanschrift.")]
        [DisplayName("Stadt")]
        public string AdressCity
        {
            get
            {
                return this._adressCity;
            }
            set
            {
                this._adressCity = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Adress Country
        /// </summary>
        private string _adressCountry = string.Empty;
        /// <summary>
        /// Get or set the Adress Country
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Land der Firmenanschrift.")]
        [DisplayName("Land")]
        public string AdressCountry
        {
            get
            {
                return this._adressCountry;
            }
            set
            {
                this._adressCountry = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The complete Adress connected
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Komplette Anschrift der Firma.")]
        [DisplayName("Anschriftsfeld")]
        [ReadOnly(true)]
        public string AdressFieldSum
        {
            get
            {
                string Output = string.Empty;
                Output += this.Title + "\r\n";
                Output += this.AdressStreet + "\r\n";
                Output += "\r\n";
                Output += this.AdressPostcode + " " + this.AdressCity;
                return Output;
            }
        }

        /// <summary>
        /// The Adress State
        /// </summary>
        private string _adressState = string.Empty;
        /// <summary>
        /// Get or set the Adress State
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Bundesland der Firmenanschrift.")]
        [DisplayName("Bundesland")]
        public string AdressState
        {
            get
            {
                return this._adressState;
            }
            set
            {
                this._adressState = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Adress Street, Housenumber and additional Informations
        /// </summary>
        private string _adressStreet = string.Empty;
        /// <summary>
        /// Get or set the Adress Street, Housenumber and additional Informations
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Straße, Hausnummer, Adresszusatz der Firmenanschrift.")]
        [DisplayName("Straße, Hausnummer, Adresszusatz")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string AdressStreet
        {
            get
            {
                return this._adressStreet;
            }
            set
            {
                this._adressStreet = value.Trim().Replace("\r\n", "\n");
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Adress Postcode
        /// </summary>
        private string _adressPostcode = string.Empty;
        /// <summary>
        /// Get or set the Adress Postcode
        /// </summary>
        [Category("Adresse")]
        [DefaultValue("")]
        [Description("Postleitzahl der Firmenanschrift.")]
        [DisplayName("Postleitzahl")]
        public string AdressPostcode
        {
            get
            {
                return this._adressPostcode;
            }
            set
            {
                this._adressPostcode = value.Trim();
                base.Changed = true;
            }
        }
        #endregion

        #region Contact
        /// <summary>
        /// The URL to Link to the Careerpage
        /// </summary>
        private string _contactCareerPage = string.Empty;
        /// <summary>
        /// Get or set the URL to Link to the Careerpage
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("URL zum Jobportal oder Auflistung der Stellenausschreibungen der Firma.")]
        [DisplayName("Jobportal")]
        public string ContactCareerPage
        {
            get
            {
                return this._contactCareerPage;
            }
            set
            {
                this._contactCareerPage = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The company E-Mail Adress
        /// </summary>
        private string _contactEMail = string.Empty;
        /// <summary>
        /// Get or set the company E-Mail Adress
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Hauptemailadresse der Firma.")]
        [DisplayName("E-Mail")]
        public string ContactEMail
        {
            get
            {
                return this._contactEMail;
            }
            set
            {
                this._contactEMail = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The company FAX number
        /// </summary>
        private string _contactFax = string.Empty;
        /// <summary>
        /// Get or set the company FAX number
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Haupttelefaxnummer der Firma.")]
        [DisplayName("Faxnummer")]
        public string ContactFax
        {
            get
            {
                return this._contactFax;
            }
            set
            {
                this._contactFax = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The company Homepage
        /// </summary>
        private string _contactHomepage = string.Empty;
        /// <summary>
        /// Get or set the company Homepage
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("URL zur Homepage der Firma.")]
        [DisplayName("Homepage")]
        public string ContactHomepage
        {
            get
            {
                return this._contactHomepage;
            }
            set
            {
                this._contactHomepage = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// The company Telephone number
        /// </summary>
        private string _contactTelephone = string.Empty;
        /// <summary>
        /// Get or set the company Telephone number
        /// </summary>
        [Category("Kontakt")]
        [DefaultValue("")]
        [Description("Haupttelefonnummer der Firma.")]
        [DisplayName("Telefonnummer")]
        public string ContactTelephone
        {
            get
            {
                return this._contactTelephone;
            }
            set
            {
                this._contactTelephone = value.Trim();
                base.Changed = true;
            }
        }
        #endregion

        #region Generel
        /// <summary>
        /// Get or set a list with Applications to this Company
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ApplicationItem> Applications { get; set; } = new Dictionary<int, ApplicationItem> { };

        /// <summary>
        /// Colormarker Index for the Company
        /// </summary>
        private int _colorMarker = 0;
        /// <summary>
        /// Get or set the Colormarker Index for the Company
        /// </summary>
        [Browsable(false)]
        public int ColorMarker
        {
            get => this._colorMarker;
            set
            {
                this._colorMarker = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get or set a list with Contacts to this Company
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ContactItem> Contacts { get; set; } = new Dictionary<int, ContactItem> { };

        /// <summary>
        /// The directory, associated to the Company
        /// </summary>
        public string _directory;
        /// <summary>
        /// Get or set the directory, associated to the Company
        /// </summary>
        [Category("Allgemein")]
        [Description("Ordner der mit der Firma verknüpft ist.")]
        [DisplayName("Ordner")]
        public string Directory
        {
            get => this._directory;
            set
            {
                this._directory = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// Get or set a list with Files to this Company
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, FileItem> Files { get; set; } = new Dictionary<int, FileItem> { };

        /// <summary>
        /// The Maximum Priority of all active Applications
        /// </summary>
        [Category("Allgemein")]
        [DefaultValue(0)]
        [Description("Die maximale Priorität aller aktiven Bewerbungen.")]
        [DisplayName("Maximale Priorität")]
        [ReadOnly(true)]
        public int PriorityMax
        {
            get
            {
                if (this.Applications.Count == 0) return 0;
                return this.Applications.OrderByDescending(o => o.Value.Priority).FirstOrDefault().Value.Priority;
            }
        }

        /// <summary>
        /// Get the max Progress of the Applications, weightet
        /// </summary>
        [Browsable(false)]
        public ProgressItem ProgressWeightetMax
        {
            get
            {
                int MaxWAppId = -1;
                int MaxWStaId = -1;
                int MaxWeight = -1;
                foreach (ApplicationItem ApplItem in this.Applications.Values)
                {
                    if (!ApplItem.Archive && ApplItem.ProgressMax != null && ApplItem.ProgressMax.Weight > MaxWeight)
                    {
                        MaxWAppId = ApplItem.Id;
                        MaxWeight = ApplItem.ProgressMax.Weight;
                        MaxWStaId = ApplItem.ProgressMax.Id;
                    }
                }
                if (MaxWeight > -1 && MaxWAppId > -1 && MaxWStaId > -1)
                {
                    return this.Applications[MaxWAppId].Progresses[MaxWStaId];
                }
                return null;
            }
        }

        /// <summary>
        /// Get or set a list with Reminders to this Company
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ReminderItem> Reminders { get; set; } = new Dictionary<int, ReminderItem> { };

        /// <summary>
        /// Get the next Reminder of the Company
        /// </summary>
        [Browsable(false)]
        public ReminderItem ReminderNext
        {
            get
            {
                try
                {
                    if (this.Reminders == null || this.Reminders.Count < 1) return null;
                    foreach (ReminderItem ReminderItem in this.Reminders.Values.OrderBy(o => o.Date))
                    {
                        if (ReminderItem.Date != null && DateTime.Compare((DateTime)ReminderItem.Date, DateTime.Today) >= 0) return ReminderItem;
                        if (ReminderItem.Date != null && DateTime.Compare((DateTime)ReminderItem.Date, DateTime.Today) <= 0 && !ReminderItem.Acknowledged) return ReminderItem;
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return null;
                }
            }
        }

        /// <summary>
        /// Is the Company terminated
        /// </summary>
        private bool _terminated = false;
        /// <summary>
        /// Get or set if the Company terminated
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(false)]
        [Description("Gibt an ob die Firma noch aktiv ist oder aufgelöst wurde.")]
        [DisplayName("Firma aufgelöst")]
        [TypeConverter(typeof(Program.BoolClassConverter))]
        public bool Terminated
        {
            get => this._terminated;
            set
            {
                this._terminated = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Trade of the Company
        /// </summary>
        private string _trade = string.Empty;
        /// <summary>
        /// Get or set the Trade of the Company
        /// </summary>
        [Category("Allgemein")]
        [DefaultValue("")]
        [Description("Die Branche der Firma.")]
        [DisplayName("Branche")]
        public string Trade
        {
            get => this._trade;
            set
            {
                this._trade = value.Trim();
                base.Changed = true;
            }
        }
        #endregion

        #region Counts
        /// <summary>
        /// Get the count of added Applications
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Bewerbungen")]
        [DisplayName("Anzahl Bewerbungen")]
        [ReadOnly(true)]
        public int CountAppl => this.Applications.Count(C => C.Value.Delete == ItemBase.DeleteFlag.None);

        /// <summary>
        /// Get the count of added Contacts
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Kontakte")]
        [DisplayName("Anzahl Kontakte")]
        [ReadOnly(true)]
        public int CountCont => this.Contacts.Count;

        /// <summary>
        /// Get the count of added Files
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Dateien")]
        [DisplayName("Anzahl Dateien")]
        [ReadOnly(true)]
        public int CountFile => this.Files.Count;

        /// <summary>
        /// Get the count of added Reminders
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Erinnerungen")]
        [DisplayName("Anzahl Erinnerungen")]
        [ReadOnly(true)]
        public int CountRemi => this.Reminders.Count;
        #endregion
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new empty Company object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty Company</param>
        public CompanyItem(int id)
        {
            base.Id = id;
        }
        /// <summary>
        /// Create a new Company, get data from an XElement Object
        /// </summary>
        /// <param name="inputCompany">XElement to read Company data from</param>
        public CompanyItem(XElement inputCompany) : this(inputCompany, 0)
        {
            base.Id = Serialize.GetFromXElement(inputCompany, "Id", base.Id);
        }
        /// <summary>
        /// Create a new Company, get data from an XElement Object
        /// </summary>
        /// <param name="inputCompany">XElement to read Company data from</param>
        /// <param name="id">Id for the new, empty Company</param>
        public CompanyItem(XElement inputCompany, int id)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputCompany, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputCompany, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputCompany, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = id;
            base.NewItemState = NewItemStateFlag.NotNew;
            base._title = Serialize.GetFromXElement(inputCompany, "Title", base._title);

            this._adressCity = Serialize.GetFromXElement(inputCompany, "AdressCity", this._adressCity);
            this._adressCountry = Serialize.GetFromXElement(inputCompany, "AdressCountry", this._adressCountry);
            this._adressPostcode = Serialize.GetFromXElement(inputCompany, "AdressPostcode", this._adressPostcode);
            this._adressState = Serialize.GetFromXElement(inputCompany, "AdressState", this._adressState);
            this._adressStreet = Serialize.GetFromXElement(inputCompany, "AdressStreet", this._adressStreet);

            this._contactCareerPage = Serialize.GetFromXElement(inputCompany, "ContactCareerPage", this._contactCareerPage);
            this._contactEMail = Serialize.GetFromXElement(inputCompany, "ContactEMail", this._contactEMail);
            this._contactFax = Serialize.GetFromXElement(inputCompany, "ContactFax", this._contactFax);
            this._contactHomepage = Serialize.GetFromXElement(inputCompany, "ContactHomepage", this._contactHomepage);
            this._contactTelephone = Serialize.GetFromXElement(inputCompany, "ContactTelephone", this._contactTelephone);

            this._colorMarker = Serialize.GetFromXElement(inputCompany, "ColorMarker", this._colorMarker);
            this._directory = Serialize.GetFromXElement(inputCompany, "Directory", this._directory);
            this._terminated = Serialize.GetFromXElement(inputCompany, "Terminated", this._terminated);
            this._trade = Serialize.GetFromXElement(inputCompany, "Trade", this._trade);

            this.Applications.Clear();
            XElement ApplicationList = Serialize.GetFromXElement(inputCompany, "ApplicationList", new XElement("ApplicationList"));
            if (ApplicationList != null)
            {
                foreach (XElement ApplicationItem in ApplicationList.Elements("ApplicationItem"))
                {
                    ApplicationItem NewApplication = new ApplicationItem(ApplicationItem);
                    this.Applications.Add(NewApplication.Id, NewApplication);
                    this.Applications[NewApplication.Id].ItemChanged += new EventHandler(this.Item_Changed);
                }
            }

            this.Contacts.Clear();
            XElement ContactList = Serialize.GetFromXElement(inputCompany, "ContactList", new XElement("ContactList"));
            if (ContactList != null)
            {
                foreach (XElement ContactItem in ContactList.Elements("ContactItem"))
                {
                    ContactItem NewContact = new ContactItem(ContactItem);
                    this.Contacts.Add(NewContact.Id, NewContact);
                    this.Contacts[NewContact.Id].ItemChanged += new EventHandler(this.Item_Changed);
                }
            }

            this.Files.Clear();
            XElement FileList = Serialize.GetFromXElement(inputCompany, "FileList", new XElement("FileList"));
            if (FileList != null)
            {
                foreach (XElement FileItem in FileList.Elements("FileItem"))
                {
                    FileItem NewFile = new FileItem(FileItem);
                    this.Files.Add(NewFile.Id, NewFile);
                    this.Files[NewFile.Id].ItemChanged += new EventHandler(this.Item_Changed);
                }
            }

            this.Reminders.Clear();
            XElement ReminderList = Serialize.GetFromXElement(inputCompany, "ReminderList", new XElement("ReminderList"));
            if (ReminderList != null)
            {
                foreach (XElement ReminderItem in ReminderList.Elements("ReminderItem"))
                {
                    ReminderItem NewReminder = new ReminderItem(ReminderItem);
                    this.Reminders.Add(NewReminder.Id, NewReminder);
                    this.Reminders[NewReminder.Id].ItemChanged += new EventHandler(this.Item_Changed);
                }
            }
        }

        /// <summary>
        /// Clone the Company object and all sub items
        /// </summary>
        /// <returns>The cloned Company object and all cloned sub items</returns>
        public CompanyItem Clone()
        {
            CompanyItem ThisClone = (CompanyItem)this.MemberwiseClone();

            ThisClone.Applications = new Dictionary<int, ApplicationItem>();
            foreach (KeyValuePair<int, ApplicationItem> ApplItem in this.Applications)
            {
                ThisClone.Applications.Add(ApplItem.Key, ApplItem.Value.Clone());
                ThisClone.Applications[ApplItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Applications[ApplItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
            }

            ThisClone.Contacts = new Dictionary<int, ContactItem>();
            foreach (KeyValuePair<int, ContactItem> ContactItem in this.Contacts)
            {
                ThisClone.Contacts.Add(ContactItem.Key, ContactItem.Value.Clone());
                ThisClone.Contacts[ContactItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Contacts[ContactItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
            }

            ThisClone.Reminders = new Dictionary<int, ReminderItem>();
            foreach (KeyValuePair<int, ReminderItem> ReminderItem in this.Reminders)
            {
                ThisClone.Reminders.Add(ReminderItem.Key, ReminderItem.Value.Clone());
                ThisClone.Reminders[ReminderItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Reminders[ReminderItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
            }
            return ThisClone;
        }

        /// <summary>
        /// Calculates the Company Directory
        /// </summary>
        /// <param name="rootPath">Root Path for the Company</param>
        /// <param name="addTitle">Should the Company Title added to the path</param>
        /// <param name="addTitleLength">Char to use from Name</param>
        /// <param name="titleBeforeId">Add Name before Id</param>
        /// <returns>Company Directory</returns>
        public DirectoryInfo GetCalcDirectory(string rootPath, bool addTitle, int addTitleLength, bool titleBeforeId)
        {
            try
            {
                if (string.IsNullOrEmpty(rootPath)) return null;

                string Path = rootPath;
                Path += @"\";
                string SafeTile = base.TitlePathSafe;
                if (addTitle && titleBeforeId)
                {
                    Path += addTitleLength == 0 || SafeTile.Length < addTitleLength ? SafeTile : SafeTile.Substring(0, addTitleLength);
                    Path += " - ";
                    Path += this.Id.ToString();
                }
                else if (addTitle && !titleBeforeId)
                {
                    Path += this.Id.ToString();
                    Path += " - ";
                    Path += addTitleLength == 0 || SafeTile.Length < addTitleLength ? SafeTile : SafeTile.Substring(0, addTitleLength);
                }
                else
                {
                    Path += this.Id.ToString();
                }
                Path = Toolbox.DirectoryAndFile.Path.Repair(Path);
                return new DirectoryInfo(Path);
            }
            catch (Exception ex)
            {
                _ = ex;
                return null;
            }
        }

        /// <summary>
        /// Open the Company Directory
        /// </summary>
        /// <param name="owner">Owner Form for MesssageBox</param>
        /// <param name="project">Project for the Company</param>
        public void OpenDirectory(IWin32Window owner, Project project)
        {
            // Check for project directroy
            if (string.IsNullOrEmpty(project.Settings.ProjectDirPath))
            {
                MessageBox.Show(owner, Stringtable._0x0039m, Stringtable._0x0039c, MessageBoxButtons.OK, MessageBoxIcon.Information);
                project.ChangeSettings(owner);
                if (string.IsNullOrEmpty(project.Settings.ProjectDirPath)) return;
            }

            // Check for saved
            if (base.Id <= 0 || base.NewItemState != NewItemStateFlag.NotNew)
            {
                if (MessageBox.Show(owner, Stringtable._0x003Am, Stringtable._0x003Ac, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes) return;
                if (!project.Save()) return;
            }

            //Oepn directroy
            if (string.IsNullOrEmpty(this._directory))
            {
                string OpenDir = this.GetCalcDirectory(project.Settings.ProjectDirPath, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                if (Toolbox.DirectoryAndFile.Directory.Open(OpenDir, true, project.Settings.CompTemplPath)) this.Directory = OpenDir;
            }
            else
            {
                Toolbox.DirectoryAndFile.Directory.Open(this._directory, true, project.Settings.CompTemplPath);
            }
        }

        /// <summary>
        /// Set the defined NewItemStateFlag to the Element and alle Sub Elements
        /// </summary>
        /// <param name="newItemStatFlag">NewItemStateFlag to set</param>
        public void SetAllNewItemStateFlag(NewItemStateFlag newItemStatFlag)
        {
            base.NewItemState = newItemStatFlag;
        }

        /// <summary>
        /// Converts the Company Item to an XElement object
        /// </summary>
        /// <param name="onlyCompany">Set to true if only company Data should been exportet, but no contacts, files, applications etc.</param>
        /// <returns>Company Item data as XElement</returns>
        public XElement ToXElement(bool onlyCompany)
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("CompanyItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base.Comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));
            Root.Add(new XElement("Title", base.Title));

            Root.Add(new XElement("AdressCity", this._adressCity));
            Root.Add(new XElement("AdressCountry", this._adressCountry));
            Root.Add(new XElement("AdressState", this._adressState));
            Root.Add(new XElement("AdressStreet", this._adressStreet));
            Root.Add(new XElement("AdressPostcode", this._adressPostcode));

            Root.Add(new XElement("ContactCareerPage", this._contactCareerPage));
            Root.Add(new XElement("ContactEMail", this._contactEMail));
            Root.Add(new XElement("ContactFax", this._contactFax));
            Root.Add(new XElement("ContactHomepage", this._contactHomepage));
            Root.Add(new XElement("ContactTelephone", this._contactTelephone));

            Root.Add(new XElement("ColorMarker", this._colorMarker));
            Root.Add(new XElement("Directory", this._directory));
            Root.Add(new XElement("Terminated", this._terminated));
            Root.Add(new XElement("Trade", this._trade));

            XElement ApplList = new XElement("ApplicationList");
            foreach (ApplicationItem Appl in this.Applications.Values.OrderBy(oAppl => oAppl.Id))
            {
                if (Appl.Delete == ItemBase.DeleteFlag.None) ApplList.Add(Appl.ToXElement());
                if (Appl.Delete == ItemBase.DeleteFlag.DeleteDirectory && !string.IsNullOrEmpty(Appl.Directory))
                {
                    Toolbox.DirectoryAndFile.Directory.Delete(Appl.Directory, false, false, out _);
                }
            }
            Root.Add(ApplList);

            XElement ContList = new XElement("ContactList");
            foreach (ContactItem Cont in this.Contacts.Values.OrderBy(oCont => oCont.Id))
            {
                if (Cont.Delete == DeleteFlag.None) ContList.Add(Cont.ToXElement());
            }
            Root.Add(ContList);

            XElement FileList = new XElement("FileList");
            foreach (FileItem File in this.Files.Values.OrderBy(oFile => oFile.Id))
            {
                if (File.Delete == DeleteFlag.None) FileList.Add(File.ToXElement());
            }
            Root.Add(FileList);

            XElement RemiList = new XElement("ReminderList");
            foreach (ReminderItem Remi in this.Reminders.Values.OrderBy(oRemi => oRemi.Id))
            {
                if (Remi.Delete == DeleteFlag.None) RemiList.Add(Remi.ToXElement());
            }
            Root.Add(RemiList);

            return Root;
        }
        #endregion
    }
}