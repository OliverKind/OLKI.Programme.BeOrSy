/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data of a Reminder and provide Methodes to handle them
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

using OLKI.Toolbox.Common;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing.Design;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a Reminder and provide Methodes to handle them
    /// </summary>
    public class ReminderItem : ItemBase
    {
        #region Properties
        /// <summary>
        /// True if the Reminder was Acknowledged
        /// </summary>
        private bool _acknowledged = false;
        /// <summary>
        /// Get or set if the Reminder was Acknowledged
        /// </summary>
        [Category("Erinnerungsinformationen")]
        [DefaultValue(false)]
        [Description("Gibt an ob die Erinnerung gelesen und bestätigt wurde.")]
        [DisplayName("Bestätigt")]
        [TypeConverter(typeof(Program.BoolClassConverter))]
        public bool Acknowledged
        {
            get => this._acknowledged;
            set
            {
                this._acknowledged = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// The Date of the Reminder
        /// </summary>
        private DateTime? _date;
        /// <summary>
        /// Get or set the Date of the Reminder
        /// </summary>
        [Category("Erinnerungsinformationen")]
        [DefaultValue("")]
        [Description("Zeitpunkt zu dem die Erinnerung ausgelöst werden soll.")]
        [DisplayName("Zeitpunkt")]
        [Editor(typeof(DateTimeEditor), typeof(UITypeEditor))]
        public DateTime? Date
        {
            get => this._date;
            set
            {
                this._date = value;
                base.Changed = true;
            }
        }

        /// <summary>
        /// Get the formated Date
        /// </summary>
        public string DateFormated
        {
            get
            {
                try
                {
                    if (this._date == null) return "";
                    return ((DateTime)this._date).ToString(Properties.Settings.Default.DateFormat);
                }
                catch (Exception ex)
                {
                    _ = ex;
                    return "";
                }
            }
        }
        #endregion

        #region Functions
        /// <summary>
        /// Create a new empty Reminder object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty Reminder</param>
        public ReminderItem(int id)
        {
            base.Id = id;
        }
        /// <summary>
        /// Create a new Reminder, get data from an XElement Object
        /// </summary>
        /// <param name="inputReminder">XElement to read Reminder data from</param>
        public ReminderItem(XElement inputReminder)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputReminder, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputReminder, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputReminder, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = Serialize.GetFromXElement(inputReminder, "Id", base.Id);
            base.NewItemState = NewItemStateFlag.NotNew;
            base._title = Serialize.GetFromXElement(inputReminder, "Title", base._title);

            this._acknowledged = Serialize.GetFromXElement(inputReminder, "Acknowledged", this._acknowledged);
            this._date = DateTime.TryParse(Serialize.GetFromXElement(inputReminder, "Date", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
        }

        /// <summary>
        /// Clone the Reminder object and all sub items
        /// </summary>
        /// <returns>The cloned Contact object and all cloned sub items</returns>
        public ReminderItem Clone()
        {
            return (ReminderItem)this.MemberwiseClone();
        }

        /// <summary>
        /// Reminder the File Item to an XElement object
        /// </summary>
        /// <returns>Reminder Item data as XElement</returns>
        public XElement ToXElement()
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("ReminderItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base.Comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));
            Root.Add(new XElement("Title", base.Title));

            Root.Add(new XElement("Acknowledged", this._acknowledged));
            Root.Add(new XElement("Date", this._date));

            return Root;
        }
        #endregion
    }
}