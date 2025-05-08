/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a Project and provide Methodes to handle it
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
using OLKI.Programme.BeOrSy.src.Forms.MainForm;
using OLKI.Programme.BeOrSy.src.Forms.Project;
using OLKI.Programme.BeOrSy.src.Forms.Project.SubForms;
using OLKI.Toolbox.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a Project and provide Methodes to handle it
    /// </summary>
    public class Project
    {
        #region Events
        /// <summary>
        /// Thrown if the project was changed, settings or data
        /// </summary>
        internal event EventHandler ProjectChanged;
        #endregion

        #region Properties
        /// <summary>
        /// True if the project was changed, settings or data, and the was not saved since this time
        /// </summary>
        private bool _changed = false;
        /// <summary>
        /// Get or set the change state of the project. True if the project was changed, settings or data, and the was not saved since this time. If setting it to true will raise the ProjectChanged__Event event
        /// </summary>
        public bool Changed
        {
            get => this._changed;
            set
            {
                this._changed = value;
                if (this._changed && Settings != null && Settings.InstantSave) this.Save();
                this.ProjectChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Get or set a list with all Companies
        /// </summary>
        public Dictionary<int, CompanyItem> Companies { get; set; } = new Dictionary<int, CompanyItem> { };

        /// <summary>
        /// Get the file of the active project or null if the project did not have a file
        /// </summary>
        internal FileInfo File { get; set; } = null;

        /// <summary>
        /// Get if the Project has Reminders to Aknowledge
        /// </summary>
        internal bool HasRemindersToAknowledge
        {
            get
            {
                Filter.Reminder ReminderFilter = new Filter.Reminder
                {
                    Acknowledged = CheckState.Unchecked,
                    DateFrom = null,
                    DateTo = DateTime.Now,
                    SourceApplication = CheckState.Indeterminate,
                    SourceCompany = CheckState.Indeterminate,
                    Text = null
                };
                foreach (CompanyItem CompItem in this.Companies.Values)
                {
                    foreach (ReminderItem RemiItem in CompItem.Reminders.Values)
                    {
                        if (ReminderFilter.InFilter(RemiItem, false, true)) return true;
                    }
                    foreach (ApplicationItem ApplItem in CompItem.Applications.Values)
                    {
                        foreach (ReminderItem RemiItem in ApplItem.Reminders.Values)
                        {
                            if (ReminderFilter.InFilter(RemiItem, true, false)) return true;
                        }
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// A set with Last inserted ID's of database Elements
        /// </summary>
        internal IdSet IdSet { get; set; } = new IdSet();

        /// <summary>
        /// The form for the Project
        /// </summary>
        internal ProjectForm ProjectForm { get; set; }

        /// <summary>
        /// Get the title of the project. That's the file name or an default text, if the project hasn't a file
        /// </summary>
        internal string ProjectTitle
        {
            get => this.File != null ? this.File.Name : Stringtable._0x0009;
        }

        /// <summary>
        /// Get or set the Project Settings
        /// </summary>
        internal Settings Settings { get; private set; } = null;

        #region Counts
        /// <summary>
        /// Count of Applications
        /// </summary>
        internal int CountAppl
        {
            get
            {
                int CountAppl = 0;
                foreach (CompanyItem CompItem in this.Companies.Values)
                {
                    if (CompItem.Delete == ItemBase.DeleteFlag.None) CountAppl += CompItem.CountAppl;
                }
                return CountAppl;
            }
        }

        /// <summary>
        /// Count of Companies
        /// </summary>
        internal int CountComp => this.Companies.Count(C => C.Value.Delete == ItemBase.DeleteFlag.None);
        #endregion
        #endregion

        #region Methodes
        /// <summary>
        /// Initialise a new project
        /// </summary>
        /// <param name="path">A string that specifies the path of the project file. If it is an empty project withoud file give an empth string</param>
        internal Project(string path)
        {
            if (!string.IsNullOrEmpty(path)) this.File = new FileInfo(path);
            this.Settings = new Settings();
        }

        /// <summary>
        /// Close the Project
        /// </summary>
        /// <returns>True, if closing the Project was sucessfull</returns>
        public bool Close()
        {
            this.ProjectForm.Close();
            // Form is closed
            return this.ProjectForm.IsDisposed;
        }

        /// <summary>
        /// Fill the defined ComboBox with DropDown Items from List
        /// </summary>
        /// <param name="dropDownItems">Items to list in ComboBox</param>
        /// <param name="comboBox">Combobox mto add items</param>
        private void FillComboBoxDropDown(List<string> dropDownItems, ComboBox comboBox)
        {
            try
            {
                if (comboBox == null) return;
                comboBox.Items.Clear();

                if (dropDownItems.Count == 0) return;
                comboBox.Items.AddRange(dropDownItems.OrderBy(o => o).ToArray());
                Toolbox.Widgets.Tools.ComboBox.AutoDropDownWidth(comboBox);
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        /// <summary>
        /// Fill the defined ComboBoxes with predefinded DropDown Items
        /// </summary>
        /// <param name="adressCity"></param>
        /// <param name="adressCountry"></param>
        /// <param name="adressState"></param>
        /// <param name="trade"></param>
        public void FillComboBoxDropDown(ComboBox adressCity, ComboBox adressCountry, ComboBox adressState, ComboBox trade)
        {

            List<string> AdrCiList = new List<string>();
            List<string> AdrCoList = new List<string>();
            List<string> AdrStList = new List<string>();
            List<string> TradeList = new List<string>();

            foreach (CompanyItem CompanyItem in this.Companies.Values)
            {
                AdrCiList.Add(CompanyItem.AdressCity);
                AdrCoList.Add(CompanyItem.AdressCountry);
                AdrStList.Add(CompanyItem.AdressState);
                TradeList.Add(CompanyItem.Trade);
            }

            this.FillComboBoxDropDown(AdrCiList.Distinct().ToList(), adressCity);
            this.FillComboBoxDropDown(AdrCoList.Distinct().ToList(), adressCountry);
            this.FillComboBoxDropDown(AdrStList.Distinct().ToList(), adressState);
            this.FillComboBoxDropDown(TradeList.Distinct().ToList(), trade);
        }

        /// <summary>
        /// Change Project settings, showing a Form
        /// </summary>
        /// <param name="owner">Ownner Form</param>
        internal void ChangeSettings(IWin32Window owner)
        {
            ProjectSettingsForm ProjectSettingsForm = new ProjectSettingsForm(this);
            ProjectSettingsForm.ShowDialog(owner);
        }

        /// <summary>
        /// Set Changed to true and call ToggleProjectChanged
        /// </summary>
        /// <param name="sender">Sender of changed event</param>
        /// <param name="e">EventArgs of changed event</param>
        internal void Item_Changed(object sender, EventArgs e)
        {
            this.Changed = true;
        }

        #region Read and create XML-Object
        /// <summary>
        /// Converts the project with all data and settings to an XML formated string
        /// </summary>
        /// <returns>An XML-format string that represents the project content</returns>
        internal XElement ToXElement()
        {
            XElement ProjectRoot = new XElement("BeOrSy_ProjectData");
            ProjectRoot.Add(new XAttribute("Version", Settings_AppConst.Default.ProjectFile_Version_Actual));
            ProjectRoot.Add(this.Settings.ToXElement());
            ProjectRoot.Add(this.IdSet.ToXElement());

            XElement CompList = new XElement("CompanyList");
            foreach (CompanyItem Comp in this.Companies.Values.OrderBy(oComp => oComp.Id))
            {
                if (Comp.Delete == ItemBase.DeleteFlag.None) CompList.Add(Comp.ToXElement(false));
                if (Comp.Delete == ItemBase.DeleteFlag.DeleteDirectory && !string.IsNullOrEmpty(Comp.Directory))
                {
                    Toolbox.DirectoryAndFile.Directory.Delete(Comp.Directory, false, false, out _);
                }
            }
            ProjectRoot.Add(CompList);
            return ProjectRoot;
        }

        #region FromXElement
        /// <summary>
        /// Check if the file to open is compatible or compatible after conwerted, with this application
        /// </summary>
        /// <param name="FileVersion">Version of the file to check</param>
        /// <returns>True if file is compatible or converted, otherwise false</returns>
        private bool CheckFileVersion(string FileVersion, MainForm mainForm)
        {
            // Create list with file Versions
            // Highest Version ist file version, lower versions are for compability with older versions
            List<string> FileVersionList = FileVersion.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            // Full Compatible fileversions
            List<string> FullCompatibleVersionList = Settings_AppConst.Default.ProjectFile_VersionCompatibleNative.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (FileVersionList.Intersect(FullCompatibleVersionList).Count() > 0)
            {
                return true;    // Full Compatible Return true
            }

            // Fileversions they are compatible if the file would been converted
            List<string> ConvCompatibleVersionList = Settings_AppConst.Default.ProjectFile_VersionCompatibleConvert.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (FileVersionList.Intersect(ConvCompatibleVersionList).Count() > 0)
            {
                //TODO: ADD CODE --> in future version to convert if necessary 
                return true;    // Compatible if converted
            }

            // Not Compatible file, return false
            mainForm.Invoke((Func<DialogResult>)(() => MessageBox.Show(Stringtable._0x0001m, Stringtable._0x0001c, MessageBoxButtons.OK, MessageBoxIcon.Error)));
            return false;
        }

        /// <summary>
        /// Set all project data from an specified XML formated string
        /// </summary>
        /// <param name="inputProject">Specifies an XML format string which represents the project</param>
        internal bool FromXElement(string inputProject, MainForm mainForm)
        {
            return this.FromXElement(XElement.Parse(inputProject), mainForm);
        }
        /// <summary>
        /// Set all project data from an specified XElement which parsed an XML formated string
        /// </summary>
        /// <param name="inputProject">Specifies XElement XElement which parsed an XML formated string which represents the project</param>
        internal bool FromXElement(XElement inputProject, MainForm mainForm)
        {
            try
            {
                //Check Fileversion
                if (!this.CheckFileVersion(Serialize.GetFromXElementAttribute(inputProject, "Version", ""), mainForm)) return false;

                //Read Settings
                this.Settings = new Settings(Serialize.GetFromXElement(inputProject, "Settings", new XElement("Settings")));
                this.IdSet = new IdSet(Serialize.GetFromXElement(inputProject, "LastInsertedId", new XElement("LastInsertedId")));

                //Read Companies und sub Elements
                this.Companies.Clear();
                XElement CompanyList = Serialize.GetFromXElement(inputProject, "CompanyList", new XElement("CompanyList"));
                if (CompanyList != null)
                {
                    foreach (XElement CompanyItem in CompanyList.Elements("CompanyItem"))
                    {
                        CompanyItem NewCompany = new CompanyItem(CompanyItem);
                        this.Companies.Add(NewCompany.Id, NewCompany);
                        this.Companies[NewCompany.Id].ItemChanged += new EventHandler(this.Item_Changed);
                    }
                }
                this._changed = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(mainForm, string.Format(Stringtable._0x0005m, new object[] { ex.Message }), Stringtable._0x0005c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #endregion

        #region Save Project to File
        /// <summary>
        /// Get the max length for the file read buffer, to avoid buffer overflows
        /// </summary>
        /// <param name="dataBufferLength">The length of the full data buffer</param>
        /// <param name="readStart">The actual rad position</param>
        /// <param name="maxBufferLength">Maximum allowed buffer length</param>
        /// <returns>The maximum allowed read buffer length</returns>
        public int GetValidBufferReadLength(int dataBufferLength, int readStart, int maxBufferLength)
        {
            if ((readStart * maxBufferLength + maxBufferLength) > dataBufferLength)
            {
                return maxBufferLength - ((readStart * maxBufferLength + maxBufferLength) - dataBufferLength);
            }
            return maxBufferLength;
        }

        /// <summary>
        /// Save the Project
        /// </summary>
        /// <returns>True, if saving the project was sucessfull</returns>
        public bool Save()
        {
            if (this.File == null) return this.SaveAs();
            return this.Save(this.File);
        }
        /// <summary>
        /// Save the project, to the defined file
        /// </summary>
        /// <param name="file">File to sava the Project to</param>
        /// <returns>True, if saving the project was sucessfull</returns>
        public bool Save(FileInfo file)
        {
            // Save the actual project file info
            // If an exception occurs the old fileinfo will be restored
            FileInfo ProjectPathBackup = file;
            try
            {
                // If there is no project file, call Project_SaveAs() and continue saving by recalling tis function in Project_SaveAs()
                if (file == null || string.IsNullOrEmpty(file.FullName))
                {
                    // Nothing to do, beccause no file was specified to save to
                    // Otherwise the Project_SaveAs function will call this function again 
                    if (!this.SaveAs()) return false;
                }
                else
                {
                    // Write data
                    char[] Content = this.ToXElement().ToString().ToCharArray();
                    string TempFileName = file.FullName + Settings_AppConst.Default.TempFileExtension;

                    using (StreamWriter StreamWriter = new StreamWriter(System.IO.File.Open(TempFileName, FileMode.Create), System.Text.Encoding.UTF8))
                    {
                        StreamWriter.WriteLine(Settings_AppConst.Default.XMLheader);
                        int ReadLength;
                        int Limit = (int)Math.Ceiling((decimal)Content.Length / (decimal)Settings_AppConst.Default.WriteDataBufferLength);
                        for (int i = 0; i < Limit; i++)
                        {
                            ReadLength = GetValidBufferReadLength(Content.Length, i, Settings_AppConst.Default.WriteDataBufferLength);
                            StreamWriter.Write(Content, i * Settings_AppConst.Default.WriteDataBufferLength, ReadLength);
                        }
                    }

                    //Move temp file to destination file
                    if (file.Exists) file.Delete();
                    System.IO.File.Move(TempFileName, file.FullName);

                    //Set NotNew Flag
                    this.Settings.SetAllNewItemStateFlag(ItemBase.NewItemStateFlag.NotNew);
                    foreach (KeyValuePair<int, CompanyItem> Comp in this.Companies.OrderBy(oComp => oComp.Value.Id))
                    {
                        this.Companies[Comp.Value.Id].SetAllNewItemStateFlag(ItemBase.NewItemStateFlag.NotNew);
                    }

                    this.File = file;
                    this.Changed = false;
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ProjectForm, string.Format(Stringtable._0x0019m, new object[] { this.File.FullName, ex.Message }), Stringtable._0x0019c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.File = ProjectPathBackup;
                return false;
            }
        }

        /// <summary>
        /// Save the Project
        /// </summary>
        /// <returns>True, if saving the project was sucessfull</returns>
        public bool SaveAs()
        {
            string TargetPath = string.Empty;
            try
            {
                SaveFileDialog SaveFileDialog = new SaveFileDialog
                {
                    DefaultExt = Settings_AppConst.Default.ProjectFile_DefaultExtension,
                    Filter = Settings_AppConst.Default.ProjectFile_FilterList,
                    FilterIndex = Settings_AppConst.Default.ProjectFile_FilterIndex,
                    InitialDirectory = this.Settings.ProjectDirPath,
                    SupportMultiDottedExtensions = true
                };

                if (SaveFileDialog.ShowDialog(this.ProjectForm) != DialogResult.OK) return false;
                TargetPath = SaveFileDialog.FileName;
                return Save(new FileInfo(TargetPath));
            }
            catch (Exception ex)
            {
                MessageBox.Show(this.ProjectForm, string.Format(Stringtable._0x0019m, new object[] { TargetPath, ex.Message }), Stringtable._0x0019c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion
        #endregion
    }
}