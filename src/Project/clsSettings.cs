/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains the Project Settings
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
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains the Project Settings
    /// </summary>
    public class Settings
    {
        #region Properties
        /// <summary>
        /// Get or set the Path with Application templates
        /// </summary>
        public string ApplTemplPath { get; set; }

        /// <summary>
        /// Get or set the Path with Company templates
        /// </summary>
        public string CompTemplPath { get; set; }

        /// <summary>
        /// Get or set if open Reminders sould been searched on open Project
        /// </summary>
        public bool CheckRemindersOnOpen { get; set; } = true;

        /// <summary>
        /// Get or set if the Name of the Company and or Application should been added to the Directory path
        /// </summary>
        public bool DirectoryAddTitle { get; set; } = false;

        /// <summary>
        /// Get or set, if the name is added to the dírectory path, the maximum Name length
        /// </summary>
        public int DirectoryTitleLength { get; set; } = 10;

        /// <summary>
        /// Get or set, if the name is added to the dírectory path, if the name should been created before mthe Id
        /// </summary>
        public bool DirectoryTitleBeforeId { get; set; } = false;

        /// <summary>
        /// Get or set if changes should been saved instantly
        /// </summary>
        public bool InstantSave { get; set; } = false;

        /// <summary>
        /// Get or set the Path with project file
        /// </summary>
        public string ProjectDirPath { get; set; }

        /// <summary>
        /// List with state templates
        /// </summary>
        internal Dictionary<int, ProgressItem> ProgressTemplateList { get; set; } = new Dictionary<int, ProgressItem>();

        /// <summary>
        /// Get or set if the Settings shold been automaticaly saved before renaming Directories
        /// </summary>
        public bool SettingsRenameAutosave { get; set; } = true;

        #region Listview Settings
        /// <summary>
        /// Application ListView Column Order
        /// </summary>
        private string _lsvAppOrder;
        /// <summary>
        /// Get or set Application ListView Column Order
        /// </summary>
        public List<int> LsvAppOrder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this._lsvAppOrder)) return new List<int>() { -1, -1 };
                    List<int> Order = this._lsvAppOrder.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
                    if (Order.Count != 2) throw new ArgumentOutOfRangeException();
                    return Order;
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return new List<int>() { -1, -1 };
                }
            }
            set
            {
                this._lsvAppOrder = string.Join(";", value);
            }
        }

        /// <summary>
        /// Application ListView Column Width
        /// </summary>
        private string _lsvAppWidth;
        /// <summary>
        /// Get or set Application ListView Column Width
        /// </summary>
        public List<int> LsvAppWidth
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this._lsvAppWidth)) return new List<int>();
                    return this._lsvAppWidth.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return new List<int>();
                }
            }
            set
            {
                this._lsvAppWidth = string.Join(";", value);
            }
        }

        /// <summary>
        /// Company ListView Column Order
        /// </summary>
        private string _lsvCmpOrder;
        /// <summary>
        /// Get or set Company ListView Column Order
        /// </summary>
        public List<int> LsvCmpOrder
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this._lsvCmpOrder)) return new List<int>() { -1, -1 };
                    List<int> Order = this._lsvCmpOrder.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
                    if (Order.Count != 2) throw new ArgumentOutOfRangeException();
                    return Order;
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return new List<int>() { -1, -1 };
                }
            }
            set
            {
                this._lsvCmpOrder = string.Join(";", value);
            }
        }

        /// <summary>
        /// Company ListView Column Width
        /// </summary>
        private string _lsvCmpWidth;
        /// <summary>
        /// Get or set Company ListView Column Width
        /// </summary>
        public List<int> LsvCmpWidth
        {
            get
            {
                try
                {
                    if (string.IsNullOrEmpty(this._lsvCmpWidth)) return new List<int>();
                    return this._lsvCmpWidth.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return new List<int>();
                }
            }
            set
            {
                this._lsvCmpWidth = string.Join(";", value);
            }
        }
        #endregion

        #region Quick Flilter
        /// <summary>
        /// Quick Filter Company has Progress Item
        /// </summary>
        public int QuickFilterCompanyAppProgress { get; set; } = 0;

        /// <summary>
        /// Quick Filter Company has Progress Item, search mode
        /// </summary>
        public CheckState QuickFilterCompanyAppProgressMode { get; set; } = CheckState.Indeterminate;

        /// <summary>
        /// Quick Filter Company City
        /// </summary>
        public string QuickFilterCompanyCity { get; set; }

        /// <summary>
        /// Quick Filter Company City
        /// </summary>
        public int QuickFilterCompanyId { get; set; } = 0;

        /// <summary>
        /// Quick Filter Company Termínated
        /// </summary>
        public CheckState QuickFilterCompanyTerminated { get; set; } = CheckState.Indeterminate;

        /// <summary>
        /// Quick Filter Company Title
        /// </summary>
        public string QuickFilterCompanyTitle { get; set; }

        /// <summary>
        /// Quick Filter Company Trade
        /// </summary>
        public string QuickFilterCompanyTrade { get; set; }
        #endregion
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new Settings object
        /// </summary>
        public Settings()
        {
            this.ProgressTemplateList.Clear();
            if (!string.IsNullOrEmpty(Settings_AppConst.Default.ProgressListDefault))
            {
                byte[] ProgressTemplateByteArray = Convert.FromBase64String(Settings_AppConst.Default.ProgressListDefault);
                string ProgressTemplateString = System.Text.Encoding.UTF8.GetString(ProgressTemplateByteArray);
                XElement ProgressTemplateList = XElement.Parse(ProgressTemplateString);
                foreach (XElement ProgressItem in ProgressTemplateList.Elements("ProgressItem"))
                {
                    ProgressItem NewProgress = new ProgressItem(ProgressItem);
                    this.ProgressTemplateList.Add(NewProgress.Id, NewProgress);
                }
            }
        }
        /// <summary>
        /// Create a new Settings object, get data from an XElement object
        /// </summary>
        /// <param name="inputSettings">XElement to read Settings data from</param>
        public Settings(XElement inputSettings)
        {
            this.ApplTemplPath = Serialize.GetFromXElement(inputSettings, "ApplTemplPath", this.ApplTemplPath);
            this.CheckRemindersOnOpen = Serialize.GetFromXElement(inputSettings, "CheckRemindersOnOpen", this.CheckRemindersOnOpen);
            this.CompTemplPath = Serialize.GetFromXElement(inputSettings, "CompTemplPath", this.CompTemplPath);
            this.DirectoryAddTitle = Serialize.GetFromXElement(inputSettings, "DirectoryAddTitle", this.DirectoryAddTitle);
            this.DirectoryTitleLength = Serialize.GetFromXElement(inputSettings, "DirectoryTitleLength", this.DirectoryTitleLength);
            this.DirectoryTitleBeforeId = Serialize.GetFromXElement(inputSettings, "DirectoryTitleBeforeId", this.DirectoryTitleBeforeId);
            this.InstantSave = Serialize.GetFromXElement(inputSettings, "InstantSave", this.InstantSave);
            this.ProjectDirPath = Serialize.GetFromXElement(inputSettings, "ProjectDirPath", this.ProjectDirPath);
            this._lsvAppOrder = Serialize.GetFromXElement(inputSettings, "LsvAppOrder", this._lsvAppOrder);
            this._lsvAppWidth = Serialize.GetFromXElement(inputSettings, "LsvAppWidth", this._lsvAppWidth);
            this._lsvCmpOrder = Serialize.GetFromXElement(inputSettings, "LsvCmpOrder", this._lsvCmpOrder);
            this._lsvCmpWidth = Serialize.GetFromXElement(inputSettings, "LsvCmpWidth", this._lsvCmpWidth);


            this.QuickFilterCompanyAppProgress = Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyAppState", this.QuickFilterCompanyAppProgress);
            this.QuickFilterCompanyAppProgressMode = (CheckState)Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyAppStateMode", (int)this.QuickFilterCompanyAppProgressMode);
            this.QuickFilterCompanyCity = Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyCity", this.QuickFilterCompanyCity);
            this.QuickFilterCompanyId = Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyId", this.QuickFilterCompanyId);
            this.QuickFilterCompanyTerminated = (CheckState)Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyTerminated", (int)this.QuickFilterCompanyTerminated);
            this.QuickFilterCompanyTitle = Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyTitle", this.QuickFilterCompanyTitle);
            this.QuickFilterCompanyTrade = Serialize.GetFromXElement(inputSettings, "QuickFilterCompanyTrade", this.QuickFilterCompanyTrade);

            this.ProgressTemplateList.Clear();
            XElement ProgressTemplateList = Serialize.GetFromXElement(inputSettings, "ProgressTemplateList", new XElement("ProgressTemplateList"));
            if (ProgressTemplateList != null)
            {
                foreach (XElement ProgressItem in ProgressTemplateList.Elements("ProgressItem"))
                {
                    ProgressItem NewProgress = new ProgressItem(ProgressItem);
                    this.ProgressTemplateList.Add(NewProgress.Id, NewProgress);
                }
            }
        }

        /// <summary>
        /// Set the defined NewItemStateFlag to all relevnt Elements
        /// </summary>
        /// <param name="newItemStatFlag">NewItemStateFlag to set</param>
        public void SetAllNewItemStateFlag(ItemBase.NewItemStateFlag newItemStatFlag)
        {
            foreach (KeyValuePair<int, ProgressItem> Progress in this.ProgressTemplateList.OrderBy(oStat => oStat.Value.Order))
            {
                this.ProgressTemplateList[Progress.Value.Id].NewItemState = newItemStatFlag;
            }
        }

        /// <summary>
        /// Converts the Settings object to an XElement object
        /// </summary>
        /// <returns>Settings data as XElement</returns>
        public XElement ToXElement()
        {
            XElement Root = new XElement("Settings");

            Root.Add(new XElement("ApplTemplPath", this.ApplTemplPath));
            Root.Add(new XElement("CompTemplPath", this.CompTemplPath));
            Root.Add(new XElement("CheckRemindersOnOpen", this.CheckRemindersOnOpen));
            Root.Add(new XElement("DirectoryAddTitle", this.DirectoryAddTitle));
            Root.Add(new XElement("DirectoryTitleLength", this.DirectoryTitleLength));
            Root.Add(new XElement("DirectoryTitleBeforeId", this.DirectoryTitleBeforeId));
            Root.Add(new XElement("InstantSave", this.InstantSave));
            Root.Add(new XElement("SettingsRenameAutosave", this.SettingsRenameAutosave));

            Root.Add(new XElement("LsvAppOrder", string.Join(";", this.LsvAppOrder)));
            Root.Add(new XElement("LsvAppWidth", string.Join(";", this.LsvAppWidth)));
            Root.Add(new XElement("LsvCmpOrder", string.Join(";", this.LsvCmpOrder)));
            Root.Add(new XElement("LsvCmpWidth", string.Join(";", this.LsvCmpWidth)));

            Root.Add(new XElement("QuickFilterCompanyAppProgress", this.QuickFilterCompanyAppProgress));
            Root.Add(new XElement("QuickFilterCompanyAppProgressMode", (int)this.QuickFilterCompanyAppProgressMode));
            Root.Add(new XElement("QuickFilterCompanyCity", this.QuickFilterCompanyCity));
            Root.Add(new XElement("QuickFilterCompanyId", this.QuickFilterCompanyId));
            Root.Add(new XElement("QuickFilterCompanyTerminated", (int)this.QuickFilterCompanyTerminated));
            Root.Add(new XElement("QuickFilterCompanyTitle", this.QuickFilterCompanyTitle));
            Root.Add(new XElement("QuickFilterCompanyTrade", this.QuickFilterCompanyTrade));

            Root.Add(new XElement("ProjectDirPath", this.ProjectDirPath));

            XElement ProgressTemplateList = new XElement("ProgressTemplateList");
            foreach (KeyValuePair<int, ProgressItem> Progress in this.ProgressTemplateList.OrderBy(oStat => oStat.Value.Order))
            {
                ProgressTemplateList.Add(Progress.Value.ToXElement());
            }
            Root.Add(ProgressTemplateList);

            return Root;
        }
        #endregion
    }
}