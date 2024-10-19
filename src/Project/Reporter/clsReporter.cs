/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data an Methods to create a Report
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
using System.Collections.Generic;
using System.Text;

namespace OLKI.Programme.BeOrSy.src.Project.ReportCeator
{

    /// <summary>
    /// Class that contains Data an Methods to create a Report
    /// </summary>
    internal static partial class Reporter
    {
        #region Constants
        /// <summary>
        /// Template Directory Subpath
        /// </summary>
        private const string TPL_PATH = @"\Resources\ReportTemplates\";

        /// <summary>
        /// Sub Template for Styleing
        /// </summary>
        private const string TPL_STYLE = @"Report.Style.html";
        #endregion

        #region Fields
        public static readonly Dictionary<int, string> StateString = new Dictionary<int, string>() {
            { 0, Stringtable._0x0007 },
            { 1, Stringtable._0x0006 },
            { 2, Stringtable._0x003F }
        };
        #endregion

        #region Methods
        /// <summary>
        /// Fill up basic Template Data
        /// </summary>
        /// <param name="inputTemplate">Main Template</param>
        /// <returns></returns>
        public static StringBuilder FillReportBasicData(StringBuilder inputTemplate)
        {
            StringBuilder Output = new StringBuilder(inputTemplate.ToString());

            Output = Output.Replace("{{$ReportBasic_DateTime}}", DateTime.Now.ToString(Properties.Settings.Default.DateTimeFormat));
            Output = Output.Replace("{{$ReportBasic_Style}}", Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_STYLE, false, out Exception Exception));
            if (Exception != null) throw Exception;

            return Output;
        }
        #endregion
    }
}