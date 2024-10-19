/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 Class that contains Data of a application Progress and provide Methodes to handle them
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
using System.Drawing;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains Data of a application Progress and provide Methodes to handle them
    /// </summary>
    public class ProgressItem : ItemBase
    {
        #region Enums
        /// <summary>
        /// State of the Progress
        /// </summary>
        public enum ProgressState
        {
            Active,
            Finished,
            FinishedLowPriority
        }
        #endregion

        #region Properties
        /// <summary>
        /// The comment to the Progress
        /// </summary>
        private Color _color = Color.Empty;
        /// <summary>
        /// Get or set the comment to the Progress
        /// </summary>
        [Category("Fortschritt")]
        [Description("Farbe des Fortschritt.")]
        [DisplayName("Farbe")]
        public Color Color
        {
            get => this._color;
            set
            {
                this._color = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// The Date of the Progress
        /// </summary>
        private DateTime? _date = new DateTime();
        /// <summary>
        /// Get or set the Date of the Progress
        /// </summary>
        [Category("Fortschritt")]
        [Description("Darum des Fortschritt.")]
        [DisplayName("Datum")]
        public DateTime? Date
        {
            get => this._date;
            set
            {
                this._date = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// Get the formated Date
        /// </summary>
        [Browsable(false)]
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

        /// <summary>
        /// The Order number of the Progress
        /// </summary>
        private int _order = 0;
        /// <summary>
        /// Get or set the Order number of the Progress
        /// </summary>
        [Category("Fortschritt")]
        [Description("Reihenfolge des Fortschritt in der Fortschrittliste.")]
        [DisplayName("Reihenfolge")]
        [ReadOnly(true)]
        public int Order
        {
            get => this._order;
            set
            {
                this._order = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// Get or set the Progress State
        /// </summary>
        [Category("Fortschritt")]
        [Description("Status des Fortschritt.")]
        [DisplayName("Status")]
        public ProgressState State { get; set; } = ProgressState.Active;

        /// <summary>
        /// The priority weight of the Progress, to weight Applications in Company list
        /// </summary>
        private int _weight = -1;
        /// <summary>
        /// Get or set the priority weight of the Progress, to weight Applications in Company list
        /// </summary>
        [Category("Fortschritt")]
        [Description("Gewichtung des Fortschritt.")]
        [DisplayName("Gewichtung")]
        [ReadOnly(true)]
        public int Weight
        {
            get => this._weight;
            set
            {
                this._weight = value;
                this.Changed = true;
            }
        }

        /// <summary>
        /// Get the priority base weight of the Progress, but only multiple of 100
        /// </summary>
        [Browsable(false)]
        public int WeightBase100
        {
            get => this._weight - (this._weight % 100);
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new empty Progress object with an predefined id
        /// </summary>
        /// <param name="id">Id for the new, empty Company</param>
        public ProgressItem(int id)
        {
            this.Id = id;
        }
        /// <summary>
        /// Create a new Progress, get data from an XElement Object
        /// </summary>
        /// <param name="inputProgress">XElement to read Progress data from</param>
        public ProgressItem(XElement inputProgress)
        {
            this.FromXElement(inputProgress);
        }

        /// <summary>
        /// Clone the Progress Object
        /// </summary>
        /// <returns>The cloned Progress Object</returns>
        public ProgressItem Clone()
        {
            return (ProgressItem)this.MemberwiseClone();
        }

        /// <summary>
        /// Clone the Progress Object and set a new Id
        /// </summary>
        /// <param name="cloneId">Id for the clones object</param>
        /// <returns>The cloned Progress Object</returns>
        public ProgressItem Clone(int cloneId)
        {
            ProgressItem Clone = (ProgressItem)this.MemberwiseClone();
            Clone.Id = cloneId;
            return Clone;
        }

        /// <summary>
        /// Get the Progress from an XElement Object
        /// </summary>
        /// <param name="inputProgress">XElement to read Progress data from</param>
        public void FromXElement(XElement inputProgress)
        {
            DateTime DateTimeTemp = DateTime.Now;

            base._comment = Serialize.GetFromXElement(inputProgress, "Comment", base._comment);
            base.DateItemCrated = DateTime.TryParse(Serialize.GetFromXElement(inputProgress, "DateItemCrated", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.DateItemEdited = DateTime.TryParse(Serialize.GetFromXElement(inputProgress, "DateItemEdited", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            base.Id = Serialize.GetFromXElement(inputProgress, "Id", base.Id);
            base.NewItemState = NewItemStateFlag.NotNew;
            base._title = Serialize.GetFromXElement(inputProgress, "Tilte", base._title);

            this._color = Serialize.GetFromXElement(inputProgress, "Color", this._color);
            this._date = DateTime.TryParse(Serialize.GetFromXElement(inputProgress, "Date", ""), out DateTimeTemp) ? (DateTime?)DateTimeTemp : null;
            this._order = Serialize.GetFromXElement(inputProgress, "Order", this._order);
            this.State = (ProgressState)Serialize.GetFromXElement(inputProgress, "State", (int)this.State);
            this._weight = Serialize.GetFromXElement(inputProgress, "Weight", this._weight);
        }

        /// <summary>
        /// Converts the Progress Item to an XElement object
        /// </summary>
        /// <returns>Progress Item data as XElement</returns>
        public XElement ToXElement()
        {
            base.NewItemState = NewItemStateFlag.NotNew;
            XElement Root = new XElement("ProgressItem");

            Root.Add(new XElement("Id", base.Id));
            Root.Add(new XElement("Comment", base._comment));
            Root.Add(new XElement("DateItemCrated", base.DateItemCrated));
            Root.Add(new XElement("DateItemEdited", base.DateItemEdited));

            Root.Add(new XElement("Color", ColorTranslator.ToHtml(this._color)));
            Root.Add(new XElement("Date", this._date));
            Root.Add(new XElement("Order", this._order));
            Root.Add(new XElement("State", (int)this.State));
            Root.Add(new XElement("Tilte", base._title));
            Root.Add(new XElement("Weight", this._weight));

            return Root;
        }
        #endregion
    }
}