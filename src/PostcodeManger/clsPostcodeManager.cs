/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Postcode Data and provide Methodes to handle them
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
using OLKI.Programme.BeOrSy.src.Forms.PostcodeManger;
using OLKI.Toolbox.Common;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OLKI.Programme.BeOrSy.src.PostcodeManger
{
    /// <summary>
    /// Class that contains Postcode Data and provide Methodes to handle them
    /// </summary>
    public class PostcodeManager
    {
        #region Properties
        /// <summary>
        /// List with Postcode Itms
        /// </summary>
        private List<PostcodeItem> _postcodeList = new List<PostcodeItem>();
        /// <summary>
        /// Get or set a List with Postcode Items. Get will remove double Entrys.
        /// </summary>
        public List<PostcodeItem> PostcodeList
        {
            get
            {
                //Remove double Entries
                return this._postcodeList.Distinct(new PostcodeItemComparer()).ToList();
            }
            set
            {
                this._postcodeList = value;
            }
        }

        /// <summary>
        /// Get Postcode List das Base64 encodes string
        /// </summary>
        public string PostcodeListAsBase64EncodetXML
        {
            get
            {
                string PostcodeData = "";
                PostcodeData += Settings_AppConst.Default.XMLheader;
                PostcodeData += "\r\n";
                PostcodeData += this.PostcodeListAsXML.ToString();
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(PostcodeData));
            }
        }

        /// <summary>
        /// Get Postcode List das XML-Object
        /// </summary>
        public XElement PostcodeListAsXML
        {
            get
            {
                XElement PostcodeData = new XElement("PostcodeList");
                PostcodeData.Add(new XAttribute("Version", "1"));
                foreach (PostcodeItem Item in this.PostcodeList)
                {
                    PostcodeData.Add(Item.ToXElement());
                }
                return PostcodeData;
            }

        }
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Postcode Manger
        /// </summary>
        public PostcodeManager()
        {
        }

        /// <summary>
        /// Add a Item to Postcode List
        /// </summary>
        /// <param name="item">Item to Add</param>
        public void AddItem(PostcodeItem item)
        {
            this._postcodeList.Add(item);
        }

        /// <summary>
        /// Clone the PostcodeManager object and all sub items
        /// </summary>
        /// <returns>The cloned PostcodeManager object and all cloned sub items</returns>
        public PostcodeManager Clone()
        {
            PostcodeManager ThisClone = (PostcodeManager)this.MemberwiseClone();

            ThisClone._postcodeList = new List<PostcodeItem>();
            foreach (PostcodeItem Item in this._postcodeList)
            {
                ThisClone._postcodeList.Add(Item.Clone());
            }
            return ThisClone;
        }

        /// <summary>
        /// Load Postcodes from a File
        /// </summary>
        /// <param name="path">Path to file to import postcodes from</param>
        public void LoadPostcodesFromFile(string path)
        {
            if (this.PostcodeList.Count > 0)
            {
                DialogResult Action = MessageBox.Show(Stringtable._0x0029m, Stringtable._0x0029c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (Action)
                {
                    case DialogResult.Yes:
                        this._postcodeList.Clear();
                        break;
                    case DialogResult.No:
                        // Do Nothing
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        return;
                }
            }

            FileInfo SourceFile = new FileInfo(path);
            switch (SourceFile.Extension.ToLower())
            {
                case ".csv":
                    this.LoadPostcodesFromFile_CSV(SourceFile);
                    break;
                case ".txt":
                    this.LoadPostcodesFromFile_Base64(SourceFile);
                    break;
                case ".xml":
                    this.LoadPostcodesFromFile_XML(SourceFile);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Read Postcode Date from an TXT-File (Base64 encoded XML)
        /// </summary>
        /// <param name="sourceFile">File to read from</param>
        private void LoadPostcodesFromFile_Base64(FileInfo sourceFile)
        {
            byte[] RawDataByteArray = Convert.FromBase64String(File.ReadAllText(sourceFile.FullName));
            string RawDataString = System.Text.Encoding.UTF8.GetString(RawDataByteArray);
            XElement RawDataXMLData = XElement.Parse(RawDataString);
            foreach (XElement PostcodeItem in RawDataXMLData.Elements("PostcodeItem"))
            {
                this._postcodeList.Add(new PostcodeItem(PostcodeItem));
            }
        }

        /// <summary>
        /// Read Postcode Date from an CSV-File
        /// </summary>
        /// <param name="sourceFile">File to read from</param>
        /// <exception cref="Exception">Exception while reading CSV-Data</exception>
        private void LoadPostcodesFromFile_CSV(FileInfo sourceFile)
        {
            CSVreader CSVread = new CSVreader
            {
                CommentIndicator = new List<char> { '#' },
                Seperators = new List<char> { '\t', ';' }
            };
            if (CSVread.ReadCSVfromFile(sourceFile.FullName, out Exception ImportException))
            {
                if (ImportException != null) throw ImportException;
                foreach (CSVreader.CSVrow CSVrow in CSVread.CSVrows)
                {
                    PostcodeItem NewPostcode = new PostcodeItem();
                    if (CSVrow.Columns.Count >= 1) NewPostcode.CodePostcode = CSVrow.Columns[0];
                    if (CSVrow.Columns.Count >= 2) NewPostcode.CodeCity = CSVrow.Columns[1];
                    if (CSVrow.Columns.Count >= 3) NewPostcode.CodeState = CSVrow.Columns[2];
                    if (CSVrow.Columns.Count >= 4) NewPostcode.CodeNation = CSVrow.Columns[3];
                    if (CSVrow.Columns.Count >= 5) NewPostcode.CodeActive = Convert.ToBoolean(CSVrow.Columns[4]);

                    this._postcodeList.Add(NewPostcode);
                }
            }
        }

        /// <summary>
        /// Read Postcode Date from an XML-File
        /// </summary>
        /// <param name="sourceFile">File to read from</param>
        private void LoadPostcodesFromFile_XML(FileInfo sourceFile)
        {
            string RawDataString = File.ReadAllText(sourceFile.FullName);
            XElement RawDataXMLData = XElement.Parse(RawDataString);
            foreach (XElement PostcodeItem in RawDataXMLData.Elements("PostcodeItem"))
            {
                this._postcodeList.Add(new PostcodeItem(PostcodeItem));
            }
        }

        /// <summary>
        /// Load Postcodes from settings
        /// </summary>
        public void LoadPostcodesFromSettings()
        {
            try
            {
                this.PostcodeList.Clear();
                if (string.IsNullOrEmpty(Settings.Default.PostcodeList)) return;

                byte[] RawDataByteArray = Convert.FromBase64String(Settings.Default.PostcodeList);
                string RawDataString = Encoding.UTF8.GetString(RawDataByteArray);
                XElement RawDataXMLData = XElement.Parse(RawDataString);
                foreach (XElement PostcodeItem in RawDataXMLData.Elements("PostcodeItem"))
                {
                    this._postcodeList.Add(new PostcodeItem(PostcodeItem));
                }
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        /// <summary>
        /// Remove Items, marked as Delete, from Psotcodelist
        /// </summary>
        public void RemoveDeletedItems()
        {
            List<PostcodeItem> TempList = new List<PostcodeItem>();
            foreach (PostcodeItem Item in this._postcodeList)
            {
                if (Item.Delete == Project.ItemBase.DeleteFlag.None) TempList.Add(Item);
            }
            this._postcodeList.Clear();
            this._postcodeList = TempList;
        }

        /// <summary>
        /// Search for the given Postcode in Postcode Database
        /// </summary>
        /// <param name="owner">Obnerform to show Form, if more than one result is found</param>
        /// <param name="searchCode">Postcode to search</param>
        /// <returns></returns>
        public PostcodeItem SearchPostcode(Form owner, string searchCode)
        {
            try
            {
                searchCode = searchCode.Trim();
                if (string.IsNullOrEmpty(searchCode) || this.PostcodeList == null || this.PostcodeList.Count == 0) return null;
                List<PostcodeItem> ResultList = new List<PostcodeItem>();
                foreach (PostcodeItem Item in this.PostcodeList)
                {
                    if (Item.CodeActive && Item.Delete == Project.ItemBase.DeleteFlag.None && Item.CodePostcode.IndexOf(searchCode, StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        ResultList.Add(Item);
                    }
                }
                //Return Result, if result is distrinct
                if (ResultList == null || ResultList.Count == 0) return null;
                if (ResultList.Count == 1) return ResultList[0];

                //If results withoud comments has more than one result, show form to Select by user
                PostcodeSelectorForm PostcodeSelector = new PostcodeSelectorForm(ResultList, searchCode);
                if (PostcodeSelector.ShowDialog(owner) == DialogResult.OK && PostcodeSelector.SelectedPostcode != null)
                {
                    return PostcodeSelector.SelectedPostcode;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(owner, string.Format(Stringtable._0x0020m, new object[] { ex.Message }), Stringtable._0x0020c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Set the active State for all Postcode Items
        /// </summary>
        /// <param name="State">Active state to set</param>
        public void SetAllActiveState(bool State)
        {
            for (int i = 0; i < this._postcodeList.Count; i++)
            {
                this._postcodeList[i].CodeActive = State;
            }
        }

        /// <summary>
        /// Writes all Postcode Data to a File
        /// </summary>
        /// <param name="path">File path to write Postcode Data to</param>
        public void WritePostcodesToFile(string path)
        {
            FileInfo SourceFile = new FileInfo(path);
            switch (SourceFile.Extension.ToLower())
            {
                case ".csv":
                    this.WritePostcodesToFile_CSV(SourceFile);
                    break;
                case ".txt":
                    this.WritePostcodesToFile_Base64(SourceFile);
                    break;
                case ".xml":
                    this.WritePostcodesToFile_XML(SourceFile);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Write Postcode Date to an TXT-File (Base64 encoded XML)
        /// </summary>
        /// <param name="targetFile">File to read from</param>
        private void WritePostcodesToFile_Base64(FileInfo targetFile)
        {
            using (StreamWriter outputFile = new StreamWriter(targetFile.FullName, false))
            {
                outputFile.WriteLine(this.PostcodeListAsBase64EncodetXML);
            }
        }

        /// <summary>
        /// Write Postcode Date to an CSV-File
        /// </summary>
        /// <param name="owner">Owner Form to show exceptions</param>
        /// <param name="targetFile">File to read from</param>
        private void WritePostcodesToFile_CSV(FileInfo targetFile)
        {
            string Template = Resources.PostcodeTemplate;

            List<List<string>> DataLines = new List<List<string>>();
            foreach (PostcodeItem Item in this.PostcodeList.OrderBy(o => o.CodePostcode))
            {
                List<string> ItemData = new List<string>
                {
                    Item.CodePostcode,
                    Item.CodeCity,
                    Item.CodeState,
                    Item.CodeNation,
                    Item.CodeActive.ToString()
                };

                DataLines.Add(ItemData);
            }
            CSVwriter CSVwriter = new CSVwriter();
            if (!CSVwriter.WriteCSVtoFile(targetFile.FullName, Template, DataLines, null, ";", out Exception Exception))
            {
                throw Exception;
            }
        }

        /// <summary>
        /// Write Postcode Date to an XML-File
        /// </summary>
        /// <param name="targetFile">File to read from</param>
        private void WritePostcodesToFile_XML(FileInfo targetFile)
        {
            string PostcodeData = "";
            PostcodeData += Settings_AppConst.Default.XMLheader;
            PostcodeData += "\r\n";
            PostcodeData += this.PostcodeListAsXML.ToString();
            using (StreamWriter outputFile = new StreamWriter(targetFile.FullName, false))
            {
                outputFile.WriteLine(PostcodeData);
            }
        }
        #endregion

        #region Sub Classes
        /// <summary>
        /// Class to compare PostcodeItems
        /// </summary>
        private class PostcodeItemComparer : IEqualityComparer<PostcodeItem>
        {
            /// <summary>
            /// Check of two PostcodeItem are equal
            /// </summary>
            /// <param name="x">First PostcodeItem to compare</param>
            /// <param name="y">Second PostcodeItem to compare</param>
            /// <returns>True if both PostcodeItems are equal</returns>
            public bool Equals(PostcodeItem x, PostcodeItem y)
            {

                //Check whether the compared objects reference the same data.
                if (Object.ReferenceEquals(x, y)) return true;

                //Check whether any of the compared objects is null.
                if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                    return false;

                //Check whether the PostcodeItems properties are equal.
                return x.CodeActive == y.CodeActive
                    && x.CodeCity == y.CodeCity
                    && x.CodeNation == y.CodeNation
                    && x.CodePostcode == y.CodePostcode
                    && x.CodeState == y.CodeState
                    && x.Delete == y.Delete;
            }

            // If Equals() returns true for a pair of objects
            // then GetHashCode() must return the same value for these objects.
            /// <summary>
            /// Get the HashCode of a PostcodeItem
            /// </summary>
            /// <param name="postcodeItem">PostcodeItem to get the HashCode from</param>
            /// <returns>HashCode of the PostcodeItem</returns>
            public int GetHashCode(PostcodeItem postcodeItem)
            {
                //Check whether the object is null
                if (Object.ReferenceEquals(postcodeItem, null)) return 0;

                int CodeActive = postcodeItem.CodeActive.GetHashCode();
                int CodeCity = string.IsNullOrEmpty(postcodeItem.CodeCity) ? 0 : postcodeItem.CodeCity.GetHashCode();
                int CodeNation = string.IsNullOrEmpty(postcodeItem.CodeNation) ? 0 : postcodeItem.CodeNation.GetHashCode();
                int CodePostcode = string.IsNullOrEmpty(postcodeItem.CodePostcode) ? 0 : postcodeItem.CodePostcode.GetHashCode();
                int CodeState = string.IsNullOrEmpty(postcodeItem.CodeState) ? 0 : postcodeItem.CodeState.GetHashCode();
                int Delete = postcodeItem.Delete.GetHashCode();

                //Calculate the hash code for the PostcodeItem
                return CodeActive ^ CodeCity ^ CodeNation ^ CodePostcode ^ CodeState ^ Delete;
            }
        }
        #endregion
    }
}