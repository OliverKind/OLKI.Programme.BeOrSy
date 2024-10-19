/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data an Methods to create a Application List Report
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
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Project.ReportCeator
{
    internal static partial class Reporter
    {
        /// <summary>
        /// Class that contains Data an Methods to create a Application List Report
        /// </summary>
        internal static class ApplicationList
        {
            #region Constants
            /// <summary>
            /// Sub Template for Applications
            /// </summary>
            private const string TPL_SUB_APPL = @"Report.Sub_ApplicationList.html";

            /// <summary>
            /// Main Template file
            /// </summary>
            private const string TPL_REMI = @"Report.Main_ApplicationList.html";

            /// <summary>
            /// Sub Template for Reminders
            /// </summary>
            private const string TPL_SUB_REMI = @"Report.Sub_ReminderList.html";
            #endregion

            #region Methods
            /// <summary>
            /// Check if the Items have a Id and are not new
            /// </summary>
            /// <param name="project">Owner Project</param>
            /// <param name="idSets">Set of Ids of Items to check</param>
            /// <returns>True if all elemts have a Id and are not in New state</returns>
            private static bool CheckNewState(Project project, List<Dictionary<Filter.Application.IdBelongingIndikator, int>> idSets)
            {
                foreach (Dictionary<Filter.Application.IdBelongingIndikator, int> IdSetsItem in idSets)
                {
                    if (IdSetsItem[Filter.Application.IdBelongingIndikator.Company] > 0)
                    {
                        if (project.Companies[IdSetsItem[Filter.Application.IdBelongingIndikator.Company]].Id == 0) return false;
                        if (project.Companies[IdSetsItem[Filter.Application.IdBelongingIndikator.Company]].NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                    }
                    if (IdSetsItem[Filter.Application.IdBelongingIndikator.Application] > 0)
                    {
                        if (project.Companies[IdSetsItem[Filter.Application.IdBelongingIndikator.Company]].Applications[IdSetsItem[Filter.Application.IdBelongingIndikator.Application]].Id == 0) return false;
                        if (project.Companies[IdSetsItem[Filter.Application.IdBelongingIndikator.Company]].Applications[IdSetsItem[Filter.Application.IdBelongingIndikator.Application]].NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                    }
                }
                return true;
            }

            /// <summary>
            /// Create Application List Report
            /// </summary>
            /// <param name="owner">Owner form for Message Boxes</param>
            /// <param name="project">Owner Project</param>
            /// <param name="idSets">Id set for Reminders, Companies and Applications</param>
            /// <param name="dateFrom">Date from filter</param>
            /// <param name="dateFrom">Date to filter</param>
            /// <param name="spekulativ">Show acknowledged filter</param>
            internal static void Create(IWin32Window owner, Project project, List<Dictionary<Filter.Application.IdBelongingIndikator, int>> idSets, DateTime? dateFrom, DateTime? dateTo, CheckState spekulativ)
            {
                try
                {
                    if (idSets == null || idSets.Count == 0) return;
                    if (!CheckNewState(project, idSets))
                    {
                        MessageBox.Show(owner, Stringtable._0x003Em, Stringtable._0x003Ec, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Create directory if necessary
                    if (string.IsNullOrEmpty(project.Settings.ProjectDirPath)) return;
                    if (!new DirectoryInfo(project.Settings.ProjectDirPath).Exists)
                    {
                        if (!Toolbox.DirectoryAndFile.Directory.Create(project.Settings.ProjectDirPath)) return;
                    }

                    // Load Template
                    string TemplateContent = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_REMI);
                    StringBuilder Output = new StringBuilder(TemplateContent);

                    // Fill up Template
                    Output = FillReportBasicData(Output);
                    Output = FilApplicationBasicData(Output, dateFrom, dateTo, spekulativ);
                    Output = FillApplications(Output, project, idSets);

                    // Write File
                    string ReportFilePath = Toolbox.DirectoryAndFile.Path.Repair(project.Settings.ProjectDirPath + @"\" + string.Format(Settings_AppConst.Default.Filename_Report_ReminderList, new object[] { DateTime.Now.ToString(Settings_AppConst.Default.DateTimeFormatForFile) }));
                    File.WriteAllText(ReportFilePath, Output.ToString());

                    //Open File
                    System.Diagnostics.Process.Start(ReportFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(owner, string.Format(Stringtable._0x003Cm, new object[] { ex.Message }), Stringtable._0x003Cc, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /// <summary>
            /// Fill uo up Company basic Data
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with Company Data</returns>
            private static StringBuilder FilApplicationBasicData(StringBuilder inputTemplate, DateTime? dateFrom, DateTime? dateTo, CheckState spekulativ)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                Output = Output.Replace("{{$ApplicationList_PeriodFrom}}", dateFrom == null ? Stringtable._0x003F : HttpUtility.HtmlEncode(((DateTime)dateFrom).ToString(Properties.Settings.Default.DateFormat))); ;
                Output = Output.Replace("{{$ApplicationList_PeriodTo}}", dateTo == null ? Stringtable._0x003F : HttpUtility.HtmlEncode(((DateTime)dateTo).ToString(Properties.Settings.Default.DateFormat))); ;
                Output = Output.Replace("{{$ApplicationList_Speculative}}", HttpUtility.HtmlEncode(Reporter.StateString[(int)spekulativ]));

                return Output;
            }

            #region Sub Reports
            /// <summary>
            /// Create sub Report with Applications
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="project">Owner Project</param>
            /// <param name="idSets">Id set for Reminders, Companies and Applications</param>
            /// <returns>Report with sub Report Applications</returns>
            private static StringBuilder FillApplications(StringBuilder inputTemplate, Project project, List<Dictionary<Filter.Application.IdBelongingIndikator, int>> idSets)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                int ApplId = 0;
                int CompId = 0;
                string ApplDate = "";
                string ApplTplBody = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_APPL);
                StringBuilder RemiDateList = new StringBuilder();
                foreach (Dictionary<Filter.Application.IdBelongingIndikator, int> IdSetsItem in idSets)
                {
                    ApplId = IdSetsItem[Filter.Application.IdBelongingIndikator.Application];
                    CompId = IdSetsItem[Filter.Application.IdBelongingIndikator.Company];
                    ApplDate = ApplTplBody;

                    ApplDate = ApplDate.Replace("{{$Application_Created}}", project.Companies[CompId].Applications[ApplId].DateCreated == null ? "" : HttpUtility.HtmlEncode(((DateTime)project.Companies[CompId].Applications[ApplId].DateCreated).ToString(Properties.Settings.Default.DateFormat)));
                    ApplDate = ApplDate.Replace("{{$Application_Id}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].Id.ToString()));
                    ApplDate = ApplDate.Replace("{{$Application_ReferenceCode}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].ReferenceCode));
                    ApplDate = ApplDate.Replace("{{$Application_Speculative}}", HttpUtility.HtmlEncode(Reporter.StateString[Convert.ToInt32(project.Companies[CompId].Applications[ApplId].SpeculativeApplication)]));
                    ApplDate = ApplDate.Replace("{{$Application_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].TitleNoText));

                    ApplDate = ApplDate.Replace("{{$Company_Address}}", HttpUtility.HtmlEncode(project.Companies[CompId].AdressFieldSum));
                    ApplDate = ApplDate.Replace("{{$Company_Id}}", HttpUtility.HtmlEncode(project.Companies[CompId].Id.ToString()));
                    ApplDate = ApplDate.Replace("{{$Company_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].TitleNoText));
                    ApplDate = ApplDate.Replace("{{$Company_Trade}}", HttpUtility.HtmlEncode(project.Companies[CompId].Trade));
                    ApplDate = ApplDate.Replace("{{$Application_Progress}}", Application.FillApplicationProgress(new StringBuilder("{{$Application_Progress}}"), project.Companies[CompId].Applications[ApplId]).ToString());

                    RemiDateList.Append(ApplDate);
                }
                Output = Output.Replace("{{$ApplicationList_Application}}", RemiDateList.ToString());

                return Output;
            }
            #endregion
            #endregion
        }
    }
}