/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class to provide tools to filter and search Reminders
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Project.Filter
{
    /// <summary>
    /// Class to provide tools to filter and search Applications
    /// </summary>
    internal class Reminder
    {
        #region Enums
        /// <summary>
        /// Where is the Id belonging to
        /// </summary>
        internal enum IdBelongingIndikator
        {
            Company,
            Application,
            Reminder
        }
        #endregion

        #region Properties
        /// <summary>
        /// Reminder is Acknowledged 
        /// </summary>
        public CheckState Acknowledged { get; set; }

        /// <summary>
        /// Reminder Date From
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Reminder Date To
        /// </summary>
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Text to search for
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Reminder  Source is Application
        /// </summary>
        public CheckState SourceApplication { get; set; }

        /// <summary>
        /// Reminder  Source is Company
        /// </summary>
        public CheckState SourceCompany { get; set; }
        #endregion

        #region Methodes
        /// <summary>
        /// Made a details Search for Appliccations with all filters
        /// </summary>
        /// <param name="companies">List with all Companies, to filter Applications from</param>
        /// <returns>List with the remaining Companies and Applications, but only the Id's. First Index ist Company Id, Second Index is Application Id</returns>
        internal List<Dictionary<IdBelongingIndikator, int>> Detail(Dictionary<int, CompanyItem> companies)
        {
            List<Dictionary<IdBelongingIndikator, int>> ReminderFilterList = new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (CompanyItem CompItem in companies.Values)
            {
                if (CompItem.Delete != ItemBase.DeleteFlag.None) continue;
                foreach (ReminderItem RemiItem in CompItem.Reminders.Values)
                {
                    if (RemiItem.Delete != ItemBase.DeleteFlag.None) continue;
                    if (this.InFilter(RemiItem, false, true)) ReminderFilterList.Add(new Dictionary<IdBelongingIndikator, int> { { IdBelongingIndikator.Company, CompItem.Id }, { IdBelongingIndikator.Application, 0 }, { IdBelongingIndikator.Reminder, RemiItem.Id } });
                }
                foreach (ApplicationItem ApplItem in CompItem.Applications.Values)
                {
                    if (ApplItem.Delete != ItemBase.DeleteFlag.None) continue;
                    foreach (ReminderItem RemiItem in ApplItem.Reminders.Values)
                    {
                        if (RemiItem.Delete != ItemBase.DeleteFlag.None) continue;
                        if (this.InFilter(RemiItem, true, false)) ReminderFilterList.Add(new Dictionary<IdBelongingIndikator, int> { { IdBelongingIndikator.Company, CompItem.Id }, { IdBelongingIndikator.Application, ApplItem.Id }, { IdBelongingIndikator.Reminder, RemiItem.Id } });
                    }
                }
            }
            return ReminderFilterList;
        }

        /// <summary>
        /// Check if the given Reminder is in Filter
        /// </summary>
        /// <param name="reminder">Reminder to check</param>
        /// <param name="sourceApp">Source is Application</param>
        /// <param name="sourceCom">Source is Company</param>
        /// <returns>True if the Reminder is in Filter</returns>
        public bool InFilter(ReminderItem reminder, bool sourceApp, bool sourceCom)
        {
            if (reminder.Delete != ItemBase.DeleteFlag.None) return false;

            //Filter Acknowledged
            if (this.Acknowledged == CheckState.Checked && !reminder.Acknowledged) return false;
            if (this.Acknowledged == CheckState.Unchecked && reminder.Acknowledged) return false;

            //Filter Date
            if ((this.DateFrom != null || this.DateTo != null) && reminder.Date == null) return false;
            if (this.DateFrom != null && this.DateTo == null && DateTime.Compare(this.DateFrom.Value, reminder.Date.Value) > 0) return false;
            if (this.DateFrom == null && this.DateTo != null && DateTime.Compare(this.DateTo.Value, reminder.Date.Value) < 0) return false;
            if (this.DateFrom != null && this.DateTo != null && (DateTime.Compare(this.DateFrom.Value, reminder.Date.Value) > 0 || DateTime.Compare(this.DateTo.Value, reminder.Date.Value) < 0)) return false;

            //Filter Text
            List<string> DiverseTextList = new List<string>();
            if (!DiverseTextList.Contains(reminder.Comment)) DiverseTextList.Add(reminder.Comment);
            if (!DiverseTextList.Contains(reminder.Title)) DiverseTextList.Add(reminder.Title);
            if (!Toolbox.Common.Search.List(DiverseTextList, this.Text)) return false;

            //Filter Reminder Source
            if (this.SourceApplication == CheckState.Checked && !sourceApp) return false;
            if (this.SourceApplication == CheckState.Unchecked && sourceApp) return false;
            if (this.SourceCompany == CheckState.Checked && !sourceCom) return false;
            if (this.SourceCompany == CheckState.Unchecked && sourceCom) return false;

            return true;
        }
        #endregion
    }
}