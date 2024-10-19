/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class to provide tools to filter and search Companies
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

using System.Collections.Generic;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Project.Filter
{
    /// <summary>
    /// Class to provide tools to filter and search Companies
    /// </summary>
    internal class Company
    {
        #region Properties
        /// <summary>
        /// Company Adress City
        /// </summary>
        public string AdressCity { get; set; }

        /// <summary>
        /// Company Adress Mation
        /// </summary>
        public string AdressNation { get; set; }

        /// <summary>
        /// Company Adress State
        /// </summary>
        public string AdressState { get; set; }

        /// <summary>
        /// Company Adress Street
        /// </summary>
        public string AdressStreet { get; set; }

        /// <summary>
        /// Company Adress Postcode
        /// </summary>
        public string AdressPostcode { get; set; }

        /// <summary>
        /// Company Comment
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Company Color Marker
        /// </summary>
        public int ColorMarker { get; set; }

        /// <summary>
        /// Company Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Company Application Progress
        /// </summary>
        public int Progress { get; set; }

        /// <summary>
        /// Company Application Start Progress
        /// </summary>
        public int ProgressFrom { get; set; }

        /// <summary>
        /// Company Application Progress search Mode
        /// </summary>
        public CheckState ProgressMode { get; set; }

        /// <summary>
        /// Company Application End Progress
        /// </summary>
        public int ProgressTo { get; set; }

        /// <summary>
        /// Company Cerminated
        /// </summary>
        public CheckState Terminated { get; set; }

        /// <summary>
        /// Company Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Company Trade
        /// </summary>
        public string Trade { get; set; }

        #region Application
        /// <summary>
        /// Company Application Id
        /// </summary>
        public int ApplicationId { get; set; }

        /// <summary>
        /// Company Application Text
        /// </summary>
        public string ApplicationText { get; set; }
        #endregion

        #region Contact
        /// <summary>
        /// Company Contact Search in Diverse Properties
        /// </summary>
        public string ContactContact { get; set; }

        /// <summary>
        /// Company Contact Id
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Company Contact Text
        /// </summary>
        public string ContactText { get; set; }
        #endregion
        #endregion

        #region Methodes
        /// <summary>
        /// Made a details Search for Companies with all filters
        /// </summary>
        /// <param name="companies">List with all Companies, to filter from</param>
        /// <returns>List with the remaining Companies, but only the Id's</returns>
        internal List<int> Detail(Dictionary<int, CompanyItem> companies)
        {
            List<int> CompanyFilterList = new List<int>();
            foreach (CompanyItem CompItem in companies.Values)
            {
                if (CompItem.Delete != ItemBase.DeleteFlag.None) continue;
                if (InDetailFilter(CompItem)) CompanyFilterList.Add(CompItem.Id);
            }
            if (CompanyFilterList.Count == companies.Count) return null;
            return CompanyFilterList;
        }

        /// <summary>
        /// Made a details Search for Companies with only some filters
        /// </summary>
        /// <param name="companies">List with all Companies, to filter from</param>
        /// <returns>List with the remaining Companies, but only the Id's</returns>
        internal List<int> Fast(Dictionary<int, CompanyItem> companies)
        {
            List<int> CompanyFilterList = new List<int>();
            foreach (CompanyItem CompItem in companies.Values)
            {
                if (CompItem.Delete != ItemBase.DeleteFlag.None) continue;
                if (InFastFilter(CompItem)) CompanyFilterList.Add(CompItem.Id);
            }
            if (CompanyFilterList.Count == companies.Count) return null;
            return CompanyFilterList;
        }

        /// <summary>
        /// Get if the Company  is inside the full Filterset
        /// </summary>
        /// <param name="company">Company to check</param>
        /// <returns>True if the company is inside the filter</returns>
        private bool InDetailFilter(CompanyItem company)
        {
            if (company.Delete != ItemBase.DeleteFlag.None) return false;

            List<int> ApplicationIdList = new List<int>();
            List<string> ApplicationTextList = new List<string>();
            List<int> ContactIdList = new List<int>();
            List<string> ContactTextList = new List<string>();
            List<string> DiverseContactTextList = new List<string>();
            if (!DiverseContactTextList.Contains(company.ContactFax)) DiverseContactTextList.Add(company.ContactFax);
            if (!DiverseContactTextList.Contains(company.ContactEMail)) DiverseContactTextList.Add(company.ContactEMail);
            if (!DiverseContactTextList.Contains(company.ContactTelephone)) DiverseContactTextList.Add(company.ContactTelephone);
            foreach (ApplicationItem Application in company.Applications.Values)
            {
                if (!ApplicationTextList.Contains(Application.Comment)) ApplicationTextList.Add(Application.Comment);
                if (!ApplicationTextList.Contains(Application.Title)) ApplicationTextList.Add(Application.Title);
                if (!ApplicationTextList.Contains(Application.ReferenceCode)) ApplicationTextList.Add(Application.ReferenceCode);
                if (!ApplicationIdList.Contains(Application.Id)) ApplicationIdList.Add(Application.Id);
            }
            foreach (ContactItem Contact in company.Contacts.Values)
            {
                if (!DiverseContactTextList.Contains(Contact.ContactCellphone)) DiverseContactTextList.Add(Contact.ContactCellphone);
                if (!DiverseContactTextList.Contains(Contact.ContactEMail)) DiverseContactTextList.Add(Contact.ContactEMail);
                if (!DiverseContactTextList.Contains(Contact.ContactFax)) DiverseContactTextList.Add(Contact.ContactFax);
                if (!DiverseContactTextList.Contains(Contact.ContactTelephone)) DiverseContactTextList.Add(Contact.ContactTelephone);
                if (!ContactTextList.Contains(Contact.Comment)) ContactTextList.Add(Contact.Comment);
                if (!ContactTextList.Contains(Contact.NameFirst)) ContactTextList.Add(Contact.NameFirst);
                if (!ContactTextList.Contains(Contact.NameLast)) ContactTextList.Add(Contact.NameLast);
                if (!ContactTextList.Contains(Contact.NameTitle)) ContactTextList.Add(Contact.NameTitle);
                if (!ContactIdList.Contains(Contact.Id)) ContactIdList.Add(Contact.Id);
            }

            //Filter company
            if (!Toolbox.Common.Search.FullText(company.AdressCity, this.AdressCity)) return false;
            if (!Toolbox.Common.Search.FullText(company.AdressCountry, this.AdressNation)) return false;
            if (!Toolbox.Common.Search.FullText(company.AdressState, this.AdressState)) return false;
            if (!Toolbox.Common.Search.FullText(company.AdressStreet, this.AdressStreet)) return false;
            if (!Toolbox.Common.Search.FullText(company.AdressPostcode, this.AdressPostcode)) return false;
            if (!Toolbox.Common.Search.FullText(company.Comment, this.Comment)) return false;

            if (!Toolbox.Common.Search.List(ApplicationIdList, this.ApplicationId)) return false;
            if (!Toolbox.Common.Search.List(ApplicationTextList, this.ApplicationText)) return false;

            if (!Toolbox.Common.Search.List(ContactIdList, this.ContactId)) return false;
            if (!Toolbox.Common.Search.List(ContactTextList, this.ContactText)) return false;
            if (!Toolbox.Common.Search.List(DiverseContactTextList, System.Text.RegularExpressions.Regex.Replace(this.ContactContact, @"\W+", ""))) return false;
            if (this.ColorMarker > 0 && company.ColorMarker != this.ColorMarker) return false;
            if (this.Id > 0 && company.Id != this.Id) return false;

            if (this.ProgressFrom > -1 && this.ProgressTo > -1)
            {
                if (this.ProgressMode != CheckState.Indeterminate && company.ProgressWeightetMax == null) return false;
                if (this.ProgressMode == CheckState.Checked && (company.ProgressWeightetMax.Weight >= this.ProgressTo || company.ProgressWeightetMax.Weight < this.ProgressFrom)) return false;
                if (this.ProgressMode == CheckState.Unchecked && company.ProgressWeightetMax.Weight < this.ProgressTo && company.ProgressWeightetMax.Weight >= this.ProgressFrom) return false;
            }

            if (this.Terminated == CheckState.Checked && company.Terminated == false) return false;
            if (this.Terminated == CheckState.Unchecked && company.Terminated == true) return false;

            if (!Toolbox.Common.Search.FullText(company.Title, this.Title)) return false;
            if (!Toolbox.Common.Search.FullText(company.Trade, this.Trade)) return false;
            return true;
        }

        /// <summary>
        /// Get if the Company is inside the a small Filterset
        /// </summary>
        /// <param name="company">Company to check</param>
        /// <returns>True if the company is inside the filter</returns>
        private bool InFastFilter(CompanyItem company)
        {
            if (company.Delete != ItemBase.DeleteFlag.None) return false;

            if (!Toolbox.Common.Search.FullText(company.AdressCity, this.AdressCity)) return false;
            if (this.Id > 0 && company.Id != this.Id) return false;

            if (this.Progress > -1)
            {
                if (this.ProgressMode != CheckState.Indeterminate && company.ProgressWeightetMax == null) return false;
                if (this.ProgressMode == CheckState.Checked && company.ProgressWeightetMax.Weight < this.Progress) return false;
                if (this.ProgressMode == CheckState.Unchecked && company.ProgressWeightetMax.Weight >= this.Progress) return false;
            }

            if (this.Terminated == CheckState.Checked && company.Terminated == false) return false;
            if (this.Terminated == CheckState.Unchecked && company.Terminated == true) return false;
            if (!Toolbox.Common.Search.FullText(company.Title, this.Title)) return false;
            if (!Toolbox.Common.Search.FullText(company.Trade, this.Trade)) return false;

            return true;
        }
        #endregion
    }
}