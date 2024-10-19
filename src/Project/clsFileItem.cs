/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a File and provide Methodes to handle them
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
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a File and provide Methodes to handle them
    /// </summary>
    public class FileItem : ItemBase
    {
        #region Enums
        /// <summary>
        /// How the file Data to the file is attached, Likeded to a local file, uploaded or unknown
        /// </summary>
        public enum FileAttachType
        {
            None = 0,
            Linked = 1,
            Upload = 2
        }
        #endregion

        #region Properties
        /// <summary>
        /// Get how the file data are attached, Likeded to a local file, uploaded or unknown
        /// </summary>
        public FileAttachType AttachType
        {
            get
            {
                if (string.IsNullOrEmpty(this._fileBase64) && !string.IsNullOrEmpty(this.Path)) return FileAttachType.Linked;
                if (!string.IsNullOrEmpty(this._fileBase64) && string.IsNullOrEmpty(this.Path)) return FileAttachType.Upload;
                return FileAttachType.None;
            }
        }

        /// <summary>
        /// The File data as Base64 encoded string
        /// </summary>
        private string _fileBase64;
        /// <summary>
        /// Get or set the File data as Base64 encoded string
        /// </summary>
#if !DEBUG
        [Browsable(false)]
#endif
        [ReadOnly(true)]
        public string FileBase64
        {
            get => _fileBase64;
            set
            {
                this._fileBase64 = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get or set the original Name of the file
        /// </summary>
        [Category("Dateiinformationen")]
        [DefaultValue("")]
        [Description("Ursprünglicher Name der Datei.")]
        [DisplayName("Dateiname")]
        [ReadOnly(true)]
        public string Name { get; set; } = "";

        /// <summary>
        /// The Path where the File is located
        /// </summary>
        private string _path = string.Empty;
        /// <summary>
        /// Get or set the Path where the File is located
        /// </summary>
        [Category("Dateiinformationen")]
        [DefaultValue("")]
        [Description("Ursprünglicher Pfad der Datei.")]
        [DisplayName("Dateipfad")]
        [ReadOnly(true)]
        public string Path
        {
            get => this._path;
            set
            {
                this._path = value;
                base.Changed = true;
            }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new empty File object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty File</param>
        public FileItem(int id)
        {
            base.Id = id;
        }
        /// <summary>
        /// Create a new File, get data from an XElement Object
        /// </summary>
        /// <param name="inputFile">XElement to read File data from</param>
        public FileItem(XElement inputFile)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputFile, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputFile, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputFile, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = Serialize.GetFromXElement(inputFile, "Id", base.Id);
            base.NewItemState = NewItemStateFlag.NotNew;
            base._title = Serialize.GetFromXElement(inputFile, "Title", base._title);

            this._fileBase64 = Serialize.GetFromXElement(inputFile, "Data", this._fileBase64);
            this.Name = Serialize.GetFromXElement(inputFile, "Name", this.Name);
            this._path = Serialize.GetFromXElement(inputFile, "Path", this._path);
        }

        /// <summary>
        /// Clone the File object and all sub items
        /// </summary>
        /// <returns>The cloned File object and all cloned sub items</returns>
        public FileItem Clone()
        {
            return (FileItem)this.MemberwiseClone();
        }

        /// <summary>
        /// Load the defined file from fined path to the file object or default ImageFormat
        /// </summary>
        /// <param name="owner">Owner form to show messages modal</param>
        /// <param name="path">Path to load the file from</param>
        public void LoadFile(IWin32Window owner, string path)
        {
            try
            {
                this._fileBase64 = Convert.ToBase64String(System.IO.File.ReadAllBytes(path));
            }
            catch (Exception ex)
            {
                this.FileBase64 = "";
                MessageBox.Show(owner, string.Format(Stringtable._0x0014m, new object[] { path, ex.Message }), Stringtable._0x0014c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open the file
        /// </summary>
        /// <param name="owner">Owner form to show messages modal</param>
        public void OpenFile(IWin32Window owner)
        {
            try
            {
                switch (this.AttachType)
                {
                    case FileAttachType.Upload:
                        this.OpenFileFromTemp(owner);
                        break;
                    case FileAttachType.Linked:
                        this.OpenFileFromLink(owner);
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(owner, string.Format(Stringtable._0x0015m, new object[] { ex.Message }), Stringtable._0x0015c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open the linked file
        /// </summary>
        /// <param name="owner">Owner form to show messages modal</param>
        public void OpenFileFromLink(IWin32Window owner)
        {
            try
            {
                System.Diagnostics.Process FileOpener = new System.Diagnostics.Process();
                FileOpener.StartInfo.FileName = "explorer";
                FileOpener.StartInfo.Arguments = "\"" + this._path + "\"";
                FileOpener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(owner, string.Format(Stringtable._0x0015m, new object[] { ex.Message }), Stringtable._0x0015c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Write the file to temp directory an open it with system default application
        /// </summary>
        /// <param name="owner">Owner form to show messages modal</param>
        public void OpenFileFromTemp(IWin32Window owner)
        {
            try
            {
                string TempFile = System.IO.Path.GetTempFileName();
                string FileToOpen = TempFile;
                FileToOpen += " - " + this.Name;
                System.IO.File.Move(TempFile, FileToOpen);
                System.IO.File.WriteAllBytes(FileToOpen, Convert.FromBase64String(this._fileBase64));
                Settings_AppVar.Default.TempFileList += '|' + FileToOpen;
                Settings_AppVar.Default.Save();

                System.Diagnostics.Process FileOpener = new System.Diagnostics.Process();
                FileOpener.StartInfo.FileName = "explorer";
                FileOpener.StartInfo.Arguments = "\"" + FileToOpen + "\"";
                FileOpener.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(owner, string.Format(Stringtable._0x0015m, new object[] { ex.Message }), Stringtable._0x0015c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Converts the File Item to an XElement object
        /// </summary>
        /// <returns>File Item data as XElement</returns>
        public XElement ToXElement()
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("ContactItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base.Comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));
            Root.Add(new XElement("Title", base.Title));

            Root.Add(new XElement("Data", this._fileBase64));
            Root.Add(new XElement("Name", this.Name));
            Root.Add(new XElement("Path", this._path));

            return Root;
        }
        #endregion
    }
}