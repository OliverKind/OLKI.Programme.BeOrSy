/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains maximum Id-Data of the project and provide Methodes to handle them
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
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Project
{
    /// <summary>
    /// Class that contains maximum Id-Data of the project and provide Methodes to handle them
    /// </summary>
    public class IdSet
    {
        #region Properties
        /// <summary>
        /// Get or set maximum Id for Application
        /// </summary>
        public int Appl { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Companies
        /// </summary>
        public int Comp { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Contacts
        /// </summary>
        public int Cont { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Files
        /// </summary>
        public int File { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Application Progress
        /// </summary>
        public int Prog { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Application Progress Templates
        /// </summary>
        public int ProT { get; set; } = 0;

        /// <summary>
        /// Get or set maximum Id for Reminders
        /// </summary>
        public int Remi { get; set; } = 0;
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new, empty Instance. Using Stndard Id's, 0 for all
        /// </summary>
        public IdSet()
        {
        }
        /// <summary>
        /// Create a new Instance, get data from an XElement Object
        /// </summary>
        /// <param name="inputIds"></param>
        public IdSet(XElement inputIds)
        {
            this.Appl = Serialize.GetFromXElement(inputIds, "Appl", this.Appl);
            this.Comp = Serialize.GetFromXElement(inputIds, "Comp", this.Comp);
            this.Cont = Serialize.GetFromXElement(inputIds, "Cont", this.Cont);
            this.File = Serialize.GetFromXElement(inputIds, "File", this.File);
            this.Prog = Serialize.GetFromXElement(inputIds, "Prog", this.Prog);
            this.ProT = Serialize.GetFromXElement(inputIds, "ProT", this.ProT);
            this.Remi = Serialize.GetFromXElement(inputIds, "Remi", this.Remi);
        }

        /// <summary>
        /// Clone the LastInsertedId object
        /// </summary>
        /// <returns>The cloned LastInsertedId object</returns>
        public IdSet Clone()
        {
            return (IdSet)this.MemberwiseClone();
        }

        /// <summary>
        /// Get the Next Id from the given Id
        /// </summary>
        /// <param name="id">Id to get the next from</param>
        /// <returns>The next free Id, given Id plus one</returns>
        public int GetNextId(int id)
        {
            return id + 1;
        }

        /// <summary>
        /// Converts the IdSet object to an XElement object
        /// </summary>
        /// <returns>IdSet data as XElement</returns>
        public XElement ToXElement()
        {
            XElement LastInsertedId = new XElement("LastInsertedId");

            LastInsertedId.Add(new XElement("Appl", this.Appl));
            LastInsertedId.Add(new XElement("Comp", this.Comp));
            LastInsertedId.Add(new XElement("Cont", this.Cont));
            LastInsertedId.Add(new XElement("File", this.File));
            LastInsertedId.Add(new XElement("Prog", this.Prog));
            LastInsertedId.Add(new XElement("ProT", this.ProT));
            LastInsertedId.Add(new XElement("Remi", this.Remi));

            return LastInsertedId;
        }
        #endregion
    }
}