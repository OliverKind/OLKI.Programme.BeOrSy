/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a Application and provide Methodes to handle it
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
    /// Class that contains Data of a Application and provide Methodes to handle it
    /// </summary>
    public class ApplicationItem : ItemBase
    {
        #region Properties
        /// <summary>
        /// True if the Application is archived
        /// </summary>
        private bool _archive = false;
        /// <summary>
        /// Get or set if the Application is archived
        /// </summary>
        [Category("Bewerbungszeitraum")]
        [DefaultValue("")]
        [Description("Befindet sich eine Bewerbung im Archiv wird sie bei der Ermittlung des Bewerbungsstatus einer Firma nicht weiter berücksichtigt. Auch wird die Hintergrundfarbe des Listeneintrags der Bewerbung nicht mehr angepasst und die Bewerbung in der Auflistung durchgestrichen.")]
        [DisplayName("Archiviert")]
        [TypeConverter(typeof(Program.BoolClassConverter))]
        public bool Archive
        {
            get => this._archive;
            set
            {
                this._archive = value;
                base._changed = true;
            }
        }

        /// <summary>
        /// A list with Company Conntacts they are associated with this application
        /// </summary>
        private string _associatedContacts;
        /// <summary>
        /// Get or set a list with Company Conntacts they are associated with this application
        /// </summary>
        [Browsable(false)]
        public List<int> AssociatedContacts
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this._associatedContacts)) return new List<int>();
                    return this._associatedContacts.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return new List<int>();
                }
            }
            set
            {
                this._associatedContacts = string.Join(";", value);
                base.Changed = true;
            }
        }

        /// <summary>
        /// Date when the application was published
        /// </summary>
        private DateTime? _dateCreated = null;
        [Category("Sonstiges")]
        [Description("Datum als die Bewerbung angelegt wurde.")]
        [DisplayName("Angelegt")]
        [Editor(typeof(DateTimeEditor), typeof(UITypeEditor))]
        /// <summary>
        /// Get or set the Date when the application was published
        /// </summary>
        public DateTime? DateCreated
        {
            get => this._dateCreated;
            set
            {
                this._dateCreated = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Date when the application period starts
        /// </summary>
        private DateTime? _datePeriodStart = null;
        [Category("Bewerbungszeitraum")]
        [Description("Seitpunkt an dem Bewerbungen frühestens eingesendet werden sollen.")]
        [DisplayName("Beginn Bewerbungszeitraum")]
        [Editor(typeof(DateTimeEditor), typeof(UITypeEditor))]
        /// <summary>
        /// Get or set the Date when the application period starts
        /// </summary>
        public DateTime? DatePeriodStart
        {
            get => this._datePeriodStart;
            set
            {
                this._datePeriodStart = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Date when the application period ends
        /// </summary>
        private DateTime? _datePeriodEnd = null;
        [Category("Bewerbungszeitraum")]
        [Description("Seitpunkt bis zu dem die Bewerbung spätestens eingegangen sein muss.")]
        [DisplayName("Ende Bewerbungszeitraum")]
        [Editor(typeof(DateTimeEditor), typeof(UITypeEditor))]
        /// <summary>
        /// Get or set the Date when the application period ends
        /// </summary>
        public DateTime? DatePeriodEnd
        {
            get => this._datePeriodEnd;
            set
            {
                this._datePeriodEnd = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// The directory, associated to the Application
        /// </summary>
        public string _directory;
        /// <summary>
        /// Get or set the directory, associated to the Application
        /// </summary>
        [Category("Allgemein")]
        [Description("Ordner der mit der Bewerbung verknüpft ist.")]
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
        /// Get or set a list with Files to this Application
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, FileItem> Files { get; set; } = new Dictionary<int, FileItem> { };

        /// <summary>
        /// Get the Application image Index
        /// </summary>
        [Browsable(false)]
        public int ImageIndex
        {
            get
            {
                if (!this._speculativeApplication && !this._archive) return 1;
                if (!this._speculativeApplication && this._archive) return 2;
                if (this._speculativeApplication && !this._archive) return 3;
                if (this._speculativeApplication && this._archive) return 4;
                return 0;
            }
        }

        /// <summary>
        /// The Priority of the Application
        /// </summary>
        private int _priority = 0;
        /// <summary>
        /// Get or set the Priority of the Application
        /// </summary>
        [Category("Identifikation")]
        [DefaultValue(0)]
        [Description("Priorität der Bewerbung.")]
        [DisplayName("Priorität")]
        public int Priority
        {
            get => this._priority;
            set
            {
                this._priority = value > 100 ? 100 : value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get the priority as it is meant in everyday use. If Priority is 0, it will be converted to lowest Priority (int.MaxValue)
        /// </summary>
        [Browsable(false)]
        public int PriorityMeaning
        {
            get => this._priority == 0 ? int.MaxValue : this._priority;
        }

        /// <summary>
        /// Get the max Progress of the Application, not Weightet
        /// </summary>
        [Browsable(false)]
        public ProgressItem ProgressMax
        {
            get
            {
                if (this.Progresses.Count == 0) return null;
                Dictionary<int, ProgressItem> TempProgresses = new Dictionary<int, ProgressItem>();
                foreach (KeyValuePair<int, ProgressItem> ProgressItem in this.Progresses.OrderBy(o => o.Value.Order))
                {
                    if (ProgressItem.Value.Delete == DeleteFlag.None) TempProgresses.Add(ProgressItem.Key, ProgressItem.Value);
                }
                if (TempProgresses.Count == 0) return null;
                return TempProgresses.OrderBy(o => o.Value.Order).LastOrDefault().Value;
            }
        }

        /// <summary>
        /// Get the min Progress of the Application, not Weightet
        /// </summary>
        [Browsable(false)]
        public ProgressItem ProgressMin
        {
            get
            {
                if (this.Progresses.Count == 0) return null;
                Dictionary<int, ProgressItem> TempProgresses = new Dictionary<int, ProgressItem>();
                foreach (KeyValuePair<int, ProgressItem> ProgressItem in this.Progresses.OrderBy(o => o.Value.Order))
                {
                    if (ProgressItem.Value.Delete == DeleteFlag.None) TempProgresses.Add(ProgressItem.Key, ProgressItem.Value);
                }
                if (TempProgresses.Count == 0) return null;
                return TempProgresses.OrderBy(o => o.Value.Order).FirstOrDefault().Value;
            }
        }

        /// <summary>
        /// Get or set a list with Progresses to this Applications
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ProgressItem> Progresses { get; set; } = new Dictionary<int, ProgressItem> { };

        /// <summary>
        /// Application reference Code
        /// </summary>
        private string _referenceCode;
        /// <summary>
        /// Get or set the Application reference Code
        /// </summary>
        [Category("Identifikation")]
        [DefaultValue("")]
        [Description("Referenznummer der Stelle.")]
        [DisplayName("Referenznummer")]
        public string ReferenceCode
        {
            get => this._referenceCode;
            set
            {
                this._referenceCode = value.Trim();
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get or set a list with Reminders to this Application
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ReminderItem> Reminders { get; set; } = new Dictionary<int, ReminderItem> { };

        /// <summary>
        /// Get the next Reminder of the Application
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
        /// True if the Application is speculative
        /// </summary>
        private bool _speculativeApplication = false;
        /// <summary>
        /// Get or set if the Application is speculative
        /// </summary>
        [Category("Identifikation")]
        [DefaultValue(false)]
        [Description("Handelt es sich bei der Stelle um eine Initiativbewerbung.")]
        [DisplayName("Initiativbewerbung")]
        [TypeConverter(typeof(Program.BoolClassConverter))]
        public bool SpeculativeApplication
        {
            get => this._speculativeApplication;
            set
            {
                this._speculativeApplication = value;
                base._changed = true;
            }
        }

        #region Counts
        /// <summary>
        /// Get tehe count of added Contacts
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Kontakte")]
        [DisplayName("Anzahl Kontakte")]
        [ReadOnly(true)]
        public int CountContacts => this.AssociatedContacts.Count;

        /// <summary>
        /// Get tehe count of added Files
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Dateien")]
        [DisplayName("Anzahl Dateien")]
        [ReadOnly(true)]
        public int FilesContacts => this.Files.Count;

        /// <summary>
        /// Get tehe count of added Reminders
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Anzahl der angehangenen Erinnerungen")]
        [DisplayName("Anzahl Erinnerungen")]
        [ReadOnly(true)]
        public int ReminContacts => this.Reminders.Count;
        #endregion
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new empty Application object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty Application</param>
        public ApplicationItem(int id)
        {
            base.Id = id;
        }
        /// <summary>
        /// Create a new Application, get data from an XElement Object
        /// </summary>
        /// <param name="inputApplication">XElement to read Application data from</param>
        public ApplicationItem(XElement inputApplication)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputApplication, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputApplication, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputApplication, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = Serialize.GetFromXElement(inputApplication, "Id", base.Id);
            base.NewItemState = NewItemStateFlag.NotNew;
            base._title = Serialize.GetFromXElement(inputApplication, "Title", base._title);

            this._dateCreated = DateTime.TryParse(Serialize.GetFromXElement(inputApplication, "DateCreated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            this._datePeriodEnd = DateTime.TryParse(Serialize.GetFromXElement(inputApplication, "DatePeriodEnd", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            this._datePeriodStart = DateTime.TryParse(Serialize.GetFromXElement(inputApplication, "DatePeriodStart", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;

            this._archive = Serialize.GetFromXElement(inputApplication, "Archive", this._archive);
            this._associatedContacts = Serialize.GetFromXElement(inputApplication, "AssociatedContacts", this._associatedContacts);
            this._directory = Serialize.GetFromXElement(inputApplication, "Directory", this._directory);
            this._priority = Serialize.GetFromXElement(inputApplication, "Priority", this._priority);
            this._referenceCode = Serialize.GetFromXElement(inputApplication, "ReferenceCode", this._referenceCode);
            this._speculativeApplication = Serialize.GetFromXElement(inputApplication, "Speculative", this._speculativeApplication);

            this.Progresses.Clear();
            XElement ProgressList = Serialize.GetFromXElement(inputApplication, "ProgressList", new XElement("ProgressList"));
            if (ProgressList != null)
            {
                foreach (XElement ProgressItem in ProgressList.Elements("ProgressItem"))
                {
                    ProgressItem NewProgress = new ProgressItem(ProgressItem);
                    this.Progresses.Add(NewProgress.Id, NewProgress);
                    this.Progresses[NewProgress.Id].ItemChanged += new EventHandler(base.Item_Changed);
                }
            }

            this.Files.Clear();
            XElement FileList = Serialize.GetFromXElement(inputApplication, "FileList", new XElement("FileList"));
            if (FileList != null)
            {
                foreach (XElement FileItem in FileList.Elements("FileItem"))
                {
                    FileItem NewFile = new FileItem(FileItem);
                    this.Files.Add(NewFile.Id, NewFile);
                    this.Files[NewFile.Id].ItemChanged += new EventHandler(base.Item_Changed);
                }
            }

            this.Reminders.Clear();
            XElement ReminderList = Serialize.GetFromXElement(inputApplication, "ReminderList", new XElement("ReminderList"));
            if (ReminderList != null)
            {
                foreach (XElement ReminderItem in ReminderList.Elements("ReminderItem"))
                {
                    ReminderItem NewReminder = new ReminderItem(ReminderItem);
                    this.Reminders.Add(NewReminder.Id, NewReminder);
                    this.Reminders[NewReminder.Id].ItemChanged += new EventHandler(base.Item_Changed);
                }
            }
        }

        /// <summary>
        /// Clone the Application object and all sub items
        /// </summary>
        /// <returns>The cloned Application object and all cloned sub items</returns>
        public ApplicationItem Clone()
        {
            ApplicationItem ThisClone = (ApplicationItem)this.MemberwiseClone();

            ThisClone.Files = new Dictionary<int, FileItem>();
            foreach (KeyValuePair<int, FileItem> FileItem in this.Files)
            {
                ThisClone.Files.Add(FileItem.Key, FileItem.Value.Clone());
                ThisClone.Files[FileItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Files[FileItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
            }

            ThisClone.Progresses = new Dictionary<int, ProgressItem>();
            foreach (KeyValuePair<int, ProgressItem> ProgressItem in this.Progresses)
            {
                ThisClone.Progresses.Add(ProgressItem.Key, ProgressItem.Value.Clone());
                ThisClone.Progresses[ProgressItem.Key].ItemChanged -= base.Item_Changed;
                ThisClone.Progresses[ProgressItem.Key].ItemChanged += new EventHandler(ThisClone.Item_Changed);
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
        /// Calculates the Application Directory
        /// </summary>
        /// <param name="rootPath">Root Path for the Applicaiton, Comapny Path</param>
        /// <param name="addTitle">Should the Application Title added to the path</param>
        /// <param name="addTitleLength">Char to use from Name</param>
        /// <param name="titleBeforeId">Add Name before Id</param>
        /// <returns>Application Directory</returns>
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
        /// <param name="project">Project for the Application</param>
        /// <param name="company">Company for the Application</param>
        public void OpenDirectory(IWin32Window owner, Project project, CompanyItem company)
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
                if (string.IsNullOrEmpty(company.Directory))
                {
                    company.Directory = company.GetCalcDirectory(project.Settings.ProjectDirPath, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                    if (!Toolbox.DirectoryAndFile.Directory.Create(company.Directory, project.Settings.CompTemplPath)) return;
                }
                string OpenDir = this.GetCalcDirectory(company.Directory, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                if (Toolbox.DirectoryAndFile.Directory.Open(OpenDir, true, project.Settings.ApplTemplPath)) this.Directory = OpenDir;
            }
            else
            {
                Toolbox.DirectoryAndFile.Directory.Open(this._directory, true, project.Settings.ApplTemplPath);
            }
        }

        /// <summary>
        /// Converts the Application Item to an XElement object
        /// </summary>
        /// <returns>Application Item data as XElement</returns>
        public XElement ToXElement()
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("ApplicationItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base.Comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));
            Root.Add(new XElement("Title", base.Title));

            Root.Add(new XElement("Archive", this._archive));
            Root.Add(new XElement("Contacts", this._associatedContacts));
            Root.Add(new XElement("DateCreated", this._dateCreated));
            Root.Add(new XElement("DatePeriodEnd", this._datePeriodEnd));
            Root.Add(new XElement("DatePeriodStart", this._datePeriodStart));
            Root.Add(new XElement("Directory", this._directory));
            Root.Add(new XElement("Priority", this._priority));
            Root.Add(new XElement("ReferenceCode", this._referenceCode));
            Root.Add(new XElement("Speculative", this._speculativeApplication));
            Root.Add(new XElement("Title", this._title));

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

            XElement ProgList = new XElement("ProgressList");
            foreach (ProgressItem Prog in this.Progresses.Values.OrderBy(oAppl => oAppl.Id))
            {
                if (Prog.Delete == DeleteFlag.None) ProgList.Add(Prog.ToXElement());
            }
            Root.Add(ProgList);

            return Root;
        }
        #endregion
    }
}