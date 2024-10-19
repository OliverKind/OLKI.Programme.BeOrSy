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

using System.ComponentModel;
using System.Xml.Linq;
using OLKI.Toolbox.Common;
using OLKI.Programme.BeOrSy.src.Project;

namespace OLKI.Programme.BeOrSy.src.PostcodeManger
{
    /// <summary>
    /// Class that contains Postcode Data and provide Methodes to handle them
    /// </summary>
    public class PostcodeItem
    {
        #region Properties
        /// <summary>
        /// Get or set if the Postcode is active for auto search
        /// </summary>
        [Category("Postleitzahl")]
        [DefaultValue(true)]
        [Description("Gibt an ob die Postleitzahl in die automatische Suche mit einbezogen wird.")]
        [DisplayName("Aktiv")]
        [TypeConverter(typeof(Program.BoolClassConverter))]
        public bool CodeActive { get; set; } = true;

        /// <summary>
        /// Get or set the Postcode related City
        /// </summary>
        [Category("Postleitzahl")]
        [DefaultValue("")]
        [Description("Stadt zur Postleitzahl.")]
        [DisplayName("Stadt")]
        public string CodeCity { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the Postcode related Country
        /// </summary>
        [Category("Postleitzahl")]
        [DefaultValue("")]
        [Description("Land zur Postleitzahl.")]
        [DisplayName("Land")]
        public string CodeNation { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the Postcode related State
        /// </summary>
        [Category("Postleitzahl")]
        [DefaultValue("")]
        [Description("Bundesland zur Postleitzahl.")]
        [DisplayName("Bundesland")]
        public string CodeState { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the Postcode
        /// </summary>
        [Category("Postleitzahl")]
        [DefaultValue("")]
        [Description("Postleitzahl.")]
        [DisplayName("Postleitzahl")]
        public string CodePostcode { get; set; } = string.Empty;

        /// <summary>
        /// Get or set the delete Flag
        /// </summary>
#if !DEBUG
        [Browsable(false)]
#endif
        [Category("*Debug")]
        public ItemBase.DeleteFlag Delete { get; set; } = ItemBase.DeleteFlag.None;
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new empty Postcode object
        /// </summary>
        public PostcodeItem()
        {
        }
        /// <summary>
        /// Create a new Postcode, get data from an XElement Object
        /// </summary>
        /// <param name="inputPostcode">XElement to read Application data from</param>
        public PostcodeItem(XElement inputPostcode)
        {
            this.CodeActive = Serialize.GetFromXElement(inputPostcode, "CodeActive", this.CodeActive);
            this.CodeCity = Serialize.GetFromXElement(inputPostcode, "CodeCity", this.CodeCity);
            this.CodeNation = Serialize.GetFromXElement(inputPostcode, "CodeNation", this.CodeNation);
            this.CodePostcode = Serialize.GetFromXElement(inputPostcode, "CodePostcode", this.CodePostcode);
            this.CodeState = Serialize.GetFromXElement(inputPostcode, "CodeState", this.CodeState);
        }

        /// <summary>
        /// Clone the Postcode object and all sub items
        /// </summary>
        /// <returns>The cloned Postcode object and all cloned sub items</returns>
        public PostcodeItem Clone()
        {
            return (PostcodeItem)this.MemberwiseClone();
        }

        public XElement ToXElement()
        {
            XElement Root = new XElement("PostcodeItem");

            Root.Add(new XElement("CodeActive", this.CodeActive));
            Root.Add(new XElement("CodeCity", this.CodeCity));
            Root.Add(new XElement("CodeNation", this.CodeNation));
            Root.Add(new XElement("CodePostcode", this.CodePostcode));
            Root.Add(new XElement("CodeState", this.CodeState));

            return Root;
        }
        #endregion
    }
}