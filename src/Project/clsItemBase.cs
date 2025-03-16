/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains basic Data of a project Item and provide Methodes to handle them
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
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains basic Data of a project Item and provide Methodes to handle them
    /// </summary>
    public class ItemBase
    {
        #region Enums
        /// <summary>
        /// State of deleting a Item
        /// </summary>
        public enum DeleteFlag
        {
            None,
            DeleteOnlyEntry,
            DeleteDirectory,
        }

        /// <summary>
        /// State for new items
        /// </summary>
        public enum NewItemStateFlag
        {
            /// <summary>
            /// The Item is not new, and was saved
            /// </summary>
            NotNew,
            /// <summary>
            /// The Item is new and initial, not saved
            /// </summary>
            NewInitial,
            /// <summary>
            /// The item is new but not initial, not saved
            /// </summary>
            NewNotSaved
        }
        #endregion

        #region Events
        /// <summary>
        /// Raised if the Item Data was changed
        /// </summary>
        public event EventHandler ItemChanged;
        #endregion

        #region Properties
        /// <summary>
        /// True if the Item Data was changed
        /// </summary>
        public bool _changed = false;
        /// <summary>
        /// Get or set if the Item Data was changed
        /// </summary>
#if !DEBUG
        [Browsable(false)]
#endif
        [Category("*Debug")]
        public bool Changed
        {
            get => this._changed;
            set
            {
                this._changed = value;
                this.DateItemEdited = DateTime.Now;
                this.ItemChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// The comment to the Item
        /// </summary>
        public string _comment;
        /// <summary>
        /// Get or set the comment to the Item
        /// </summary>
        [Category("Allgemein")]
        [Description("Kommentar zum Eintrag.")]
        [DisplayName("Kommentar")]
        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string Comment
        {
            get => this._comment;
            set
            {
                this._comment = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// Get or set the DateTime when the Item was created
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Gibt an wann der Eintrag mit der Eintrag erstellt wurde.")]
        [DisplayName("Eintrag erstellt")]
        [ReadOnly(true)]
        public DateTime? DateItemCrated { get; set; } = DateTime.Now;

        /// <summary>
        /// Get or set the DateTime when the Item was created
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Gibt an wann der Eintrag zuletzt geändert wurde.")]
        [DisplayName("Eintrag geändert")]
        [ReadOnly(true)]
        public DateTime? DateItemEdited { get; set; } = null;

        /// <summary>
        /// Get or set the delete Flag
        /// </summary>
#if !DEBUG
        [Browsable(false)]
#endif
        [Category("*Debug")]
        public DeleteFlag Delete { get; set; } = DeleteFlag.None;

        /// <summary>
        /// Get or set the Item Id
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Datenbanknummer des Eintrags und Ordnernummer.")]
        [DisplayName("Id")]
        [ReadOnly(true)]
        public int Id { get; set; } = 0;

        /// <summary>
        /// Get the item Id or a text if the item is new and not saved
        /// </summary>
        [Browsable(false)]
        [ReadOnly(true)]
        public string IdText
        {
            get
            {
#if DEBUG
                if (this.NewItemState != NewItemStateFlag.NotNew) return string.Format("{0} (TempId: {1})", new object[] { Stringtable._0x0011, this.Id.ToString() });
#endif
                if (this.NewItemState != NewItemStateFlag.NotNew) return Stringtable._0x0011;
                return this.Id.ToString();
            }
        }

        /// <summary>
        /// Get or set the Item New and not saved until now
        /// </summary>
        [Category("Sonstiges")]
        [DefaultValue(0)]
        [Description("Ist der Eintrag neu und noch nicht gespeichert.")]
        [DisplayName("Neuer Eintrag")]
        [ReadOnly(true)]
        public NewItemStateFlag NewItemState { get; set; } = NewItemStateFlag.NewInitial;

        /// <summary>
        /// The Name of the Item
        /// </summary>
        public string _title;
        /// <summary>
        /// Get or set the Name of the Item
        /// </summary>
        [Category("Allgemein")]
        [DefaultValue("")]
        [Description("Benennung des Eintrags.")]
        [DisplayName("Benennung")]
        public string Title
        {
            get => _title;
            set
            {
                this._title = value.Trim();
                this.Changed = true;
            }
        }
        /// <summary>
        /// Get the Name of the Item, or an default text if no name is given
        /// </summary>
        [Browsable(false)]
        public string TitleNoText
        {
            get => string.IsNullOrEmpty(this._title) ? Stringtable._0x0002 : this.Title;
        }

        /// <summary>
        /// Get the Name of the Item, remove all cahrs they are not valid for a file path
        /// </summary>
        [Browsable(false)]
        public string TitlePathSafe
        {
            get
            {
                if (string.IsNullOrEmpty(this._title)) return "";

                string SafeTitle = this.Title;
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    SafeTitle = SafeTitle.Replace(c.ToString(), "");
                }
                return SafeTitle;
            }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Set Changed to true
        /// </summary>
        /// <param name="sender">Sender of changed event</param>
        /// <param name="e">EventArgs of changed event</param>
        internal void Item_Changed(object sender, EventArgs e)
        {
            this.Changed = true;
        }
        #endregion
    }
}