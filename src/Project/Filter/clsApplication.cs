/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class to provide tools to filter and search Applications
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
    internal class Application
    {
        #region Enums
        /// <summary>
        /// Date Search Mode
        /// </summary>
        internal enum DateModeIndikator
        {
            ApplicationCreated,
            FirstProgressItem,
            LastProgressItem
        }

        /// <summary>
        /// Where is the Id belonging to
        /// </summary>
        internal enum IdBelongingIndikator
        {
            Company,
            Application
        }

        /// <summary>
        /// Priority Search Mode
        /// </summary>
        internal enum PriorityModeIndikator
        {
            Ignore,
            IsSmallerOrEven,
            IsEven,
            IsGreaterOrEven,
            IsUneven
        }
        #endregion

        #region Properties
        /// <summary>
        /// Application Date From
        /// </summary>
        public DateTime? DateFrom { get; set; }

        /// <summary>
        /// Application Date search Mode
        /// </summary>
        public DateModeIndikator DateMode { get; set; }

        /// <summary>
        /// Application Date To
        /// </summary>
        public DateTime? DateTo { get; set; }

        /// <summary>
        /// Application Priority Search Mode
        /// </summary>
        public PriorityModeIndikator PriorityMode { get; set; }

        /// <summary>
        /// Application Priority Threshold
        /// </summary>
        public int PriorityThreshold { get; set; }

        /// <summary>
        /// Application List with ProgressWeights to base 100 to search for
        /// </summary>
        public List<int> ProgressWeight { get; set; }

        /// <summary>
        /// Text to search for
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Application Type is Speculativ
        /// </summary>
        public CheckState TypeSpeculativ { get; set; }
        #endregion

        #region Methodes
        /// <summary>
        /// Made a details Search for Appliccations with all filters
        /// </summary>
        /// <param name="companies">List with all Companies, to filter Applications from</param>
        /// <returns>List with the remaining Companies and Applications, but only the Id's. First Index ist Company Id, Second Index is Application Id</returns>
        internal List<Dictionary<IdBelongingIndikator, int>> Detail(Dictionary<int, CompanyItem> companies)
        {
            List<Dictionary<IdBelongingIndikator, int>> ApplicationFilterList = new List<Dictionary<IdBelongingIndikator, int>>();
            foreach (CompanyItem CompItem in companies.Values)
            {
                if (CompItem.Delete != ItemBase.DeleteFlag.None) continue;
                foreach (ApplicationItem ApplItem in CompItem.Applications.Values)
                {
                    if (ApplItem.Delete == ItemBase.DeleteFlag.None) continue;
                    if (this.InFilter(ApplItem)) ApplicationFilterList.Add(new Dictionary<IdBelongingIndikator, int> { { IdBelongingIndikator.Company, CompItem.Id }, { IdBelongingIndikator.Application, ApplItem.Id } });
                }
            }
            //if (ApplicationFilterList.Count == AppCount) return null;
            return ApplicationFilterList;
        }

        /// <summary>
        /// Check if the given Application is in Filter
        /// </summary>
        /// <param name="application">Application to check</param>
        /// <returns>True if the Application is in Filter</returns>
        private bool InFilter(ApplicationItem application)
        {
            if (application.Delete != ItemBase.DeleteFlag.None) return false;

            //Filter Date
            if (this.DateFrom != null || this.DateTo != null)
            {
                switch (this.DateMode)
                {
                    case DateModeIndikator.ApplicationCreated:
                        if (application.DateCreated == null) return false;
                        if (this.DateFrom != null && this.DateTo == null && DateTime.Compare(this.DateFrom.Value, application.DateCreated.Value) > 0) return false;
                        if (this.DateFrom == null && this.DateTo != null && DateTime.Compare(this.DateTo.Value, application.DateCreated.Value) < 0) return false;
                        if (this.DateFrom != null && this.DateTo != null && (DateTime.Compare(this.DateFrom.Value, application.DateCreated.Value) > 0 || DateTime.Compare(this.DateTo.Value, application.DateCreated.Value) < 0)) return false;
                        break;
                    case DateModeIndikator.FirstProgressItem:
                        if (application.ProgressMin == null || application.ProgressMin.Date == null) return false;
                        if (this.DateFrom != null && this.DateTo == null && DateTime.Compare(this.DateFrom.Value, application.ProgressMin.Date.Value) > 0) return false;
                        if (this.DateFrom == null && this.DateTo != null && DateTime.Compare(this.DateTo.Value, application.ProgressMin.Date.Value) < 0) return false;
                        if (this.DateFrom != null && this.DateTo != null && (DateTime.Compare(this.DateFrom.Value, application.ProgressMin.Date.Value) > 0 || DateTime.Compare(this.DateTo.Value, application.ProgressMin.Date.Value) < 0)) return false;
                        break;
                    case DateModeIndikator.LastProgressItem:
                        if (application.ProgressMax == null || application.ProgressMax.Date == null) return false;
                        if (this.DateFrom != null && this.DateTo == null && DateTime.Compare(this.DateFrom.Value, application.ProgressMax.Date.Value) > 0) return false;
                        if (this.DateFrom == null && this.DateTo != null && DateTime.Compare(this.DateTo.Value, application.ProgressMax.Date.Value) < 0) return false;
                        if (this.DateFrom != null && this.DateTo != null && (DateTime.Compare(this.DateFrom.Value, application.ProgressMax.Date.Value) > 0 || DateTime.Compare(this.DateTo.Value, application.ProgressMax.Date.Value) < 0)) return false;
                        break;
                    default:
                        return false;
                }
            }

            //Filter Priority
            int PriorityThresholdMeaning = this.PriorityThreshold == 0 ? int.MaxValue : this.PriorityThreshold;
            switch (this.PriorityMode)
            {
                case PriorityModeIndikator.Ignore:
                    //Nothing to do
                    break;
                case PriorityModeIndikator.IsSmallerOrEven:
                    if (application.PriorityMeaning > PriorityThresholdMeaning) return false;
                    break;
                case PriorityModeIndikator.IsEven:
                    if (application.PriorityMeaning != PriorityThresholdMeaning) return false;
                    break;
                case PriorityModeIndikator.IsGreaterOrEven:
                    if (application.PriorityMeaning < PriorityThresholdMeaning) return false;
                    break;
                case PriorityModeIndikator.IsUneven:
                    if (application.PriorityMeaning == PriorityThresholdMeaning) return false;
                    break;
                default:
                    return false;
            }

            //Filter Text
            List<string> DiverseTextList = new List<string>();
            if (!DiverseTextList.Contains(application.Comment)) DiverseTextList.Add(application.Comment);
            if (!DiverseTextList.Contains(application.ReferenceCode)) DiverseTextList.Add(application.ReferenceCode);
            if (!DiverseTextList.Contains(application.Title)) DiverseTextList.Add(application.Title);
            if (!Toolbox.Common.Search.List(DiverseTextList, this.Text)) return false;

            //Filter Progress
            if (this.ProgressWeight != null && this.ProgressWeight.Count > 0)
            {
                if (application.Progresses.Count == 0) return false;
                List<int> ProgressList = new List<int>();
                foreach (ProgressItem ProgressItem in application.Progresses.Values)
                {
                    ProgressList.Add(ProgressItem.WeightBase100);
                }
                if (!Toolbox.Common.Search.List(this.ProgressWeight, ProgressList)) return false;
            }

            //Filter Application Type
            if (this.TypeSpeculativ == CheckState.Checked && !application.SpeculativeApplication) return false;
            if (this.TypeSpeculativ == CheckState.Unchecked && application.SpeculativeApplication) return false;
            return true;
        }
        #endregion
    }
}