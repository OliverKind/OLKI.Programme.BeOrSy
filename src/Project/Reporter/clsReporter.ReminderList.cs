/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data an Methods to create a Company Report
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
        /// Class that contains Data an Methods to create a Reminder List Report
        /// </summary>
        internal static class ReminderList
        {
            #region Constants
            /// <summary>
            /// Main Template file
            /// </summary>
            private const string TPL_REMI = @"Report.Main_ReminderList.html";

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
            private static bool CheckNewState(Project project, List<Dictionary<Filter.Reminder.IdBelongingIndikator, int>> idSets)
            {
                foreach (Dictionary<Filter.Reminder.IdBelongingIndikator, int> IdSetsItem in idSets)
                {
                    if (IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company] > 0)
                    {
                        if (project.Companies[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company]].Id == 0) return false;
                        if (project.Companies[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company]].NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                    }
                    if (IdSetsItem[Filter.Reminder.IdBelongingIndikator.Application] > 0)
                    {
                        if (project.Companies[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company]].Applications[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Application]].Id == 0) return false;
                        if (project.Companies[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company]].Applications[IdSetsItem[Filter.Reminder.IdBelongingIndikator.Application]].NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                    }
                }
                return true;
            }

            /// <summary>
            /// Create Reminder List Report
            /// </summary>
            /// <param name="owner">Owner form for Message Boxes</param>
            /// <param name="project">Owner Project</param>
            /// <param name="idSets">Id set for Reminders, Companies and Applications</param>
            /// <param name="dateFrom">Date from filter</param>
            /// <param name="dateFrom">Date to filter</param>
            /// <param name="acknowledged">Show acknowledged filter</param>
            internal static void Create(IWin32Window owner, Project project, List<Dictionary<Filter.Reminder.IdBelongingIndikator, int>> idSets, DateTime? dateFrom, DateTime? dateTo, CheckState acknowledged)
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
                    Output = FillRemindersBasicData(Output, dateFrom, dateTo, acknowledged);
                    Output = FillReminders(Output, project, idSets);

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
            private static StringBuilder FillRemindersBasicData(StringBuilder inputTemplate, DateTime? dateFrom, DateTime? dateTo, CheckState acknowledged)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                Output = Output.Replace("{{$ReminderList_PeriodFrom}}", dateFrom == null ? Stringtable._0x003F : HttpUtility.HtmlEncode(((DateTime)dateFrom).ToString(Properties.Settings.Default.DateFormat))); ;
                Output = Output.Replace("{{$ReminderList_PeriodTo}}", dateTo == null ? Stringtable._0x003F : HttpUtility.HtmlEncode(((DateTime)dateTo).ToString(Properties.Settings.Default.DateFormat))); ;
                Output = Output.Replace("{{$ReminderList_AcknowledgeState}}", HttpUtility.HtmlEncode(Reporter.StateString[(int)acknowledged]));

                return Output;
            }

            #region Sub Reports
            /// <summary>
            /// Create sub Report with Reminders
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Reminders</returns>
            private static StringBuilder FillReminders(StringBuilder inputTemplate, Project project, List<Dictionary<Filter.Reminder.IdBelongingIndikator, int>> idSets)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                int ApplId = 0;
                int CompId = 0;
                int RemiId = 0;
                string RemiDate = "";
                string RemiTplBody = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_REMI);
                StringBuilder RemiDateList = new StringBuilder();
                foreach (Dictionary<Filter.Reminder.IdBelongingIndikator, int> IdSetsItem in idSets)
                {
                    ApplId = IdSetsItem[Filter.Reminder.IdBelongingIndikator.Application];
                    CompId = IdSetsItem[Filter.Reminder.IdBelongingIndikator.Company];
                    RemiId = IdSetsItem[Filter.Reminder.IdBelongingIndikator.Reminder];
                    RemiDate = RemiTplBody;

                    if (ApplId > 0)
                    {
                        RemiDate = RemiDate.Replace("{{$Reminder_Date}}", project.Companies[CompId].Applications[ApplId].Reminders[RemiId].Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)project.Companies[CompId].Applications[ApplId].Reminders[RemiId].Date).ToString(Properties.Settings.Default.DateFormat)));
                        RemiDate = RemiDate.Replace("{{$Reminder_Acknowledge}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].Reminders[RemiId].Acknowledged.ToString()));
                        RemiDate = RemiDate.Replace("{{$Reminder_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].Reminders[RemiId].TitleNoText));
                        RemiDate = RemiDate.Replace("{{$Reminder_Comment}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].Reminders[RemiId].Comment));

                        RemiDate = RemiDate.Replace("{{$Application_Created}}", project.Companies[CompId].Applications[ApplId].DateCreated == null ? "" : HttpUtility.HtmlEncode(((DateTime)project.Companies[CompId].Applications[ApplId].DateCreated).ToString(Properties.Settings.Default.DateFormat)));
                        RemiDate = RemiDate.Replace("{{$Application_Id}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].Id.ToString()));
                        RemiDate = RemiDate.Replace("{{$Application_ReferenceCode}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].ReferenceCode));
                        RemiDate = RemiDate.Replace("{{$Application_Speculative}}", HttpUtility.HtmlEncode(Reporter.StateString[Convert.ToInt32(project.Companies[CompId].Applications[ApplId].SpeculativeApplication)]));
                        RemiDate = RemiDate.Replace("{{$Application_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].Applications[ApplId].TitleNoText));
                    }
                    else
                    {
                        RemiDate = RemiDate.Replace("{{$Reminder_Date}}", project.Companies[CompId].Reminders[RemiId].Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)project.Companies[CompId].Reminders[RemiId].Date).ToString(Properties.Settings.Default.DateFormat)));
                        RemiDate = RemiDate.Replace("{{$Reminder_Acknowledge}}", HttpUtility.HtmlEncode(project.Companies[CompId].Reminders[RemiId].Acknowledged.ToString()));
                        RemiDate = RemiDate.Replace("{{$Reminder_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].Reminders[RemiId].TitleNoText));
                        RemiDate = RemiDate.Replace("{{$Reminder_Comment}}", HttpUtility.HtmlEncode(project.Companies[CompId].Reminders[RemiId].Comment));

                        RemiDate = RemiDate.Replace("{{$Application_Created}}", "");
                        RemiDate = RemiDate.Replace("{{$Application_Id}}", "");
                        RemiDate = RemiDate.Replace("{{$Application_ReferenceCode}}", "");
                        RemiDate = RemiDate.Replace("{{$Application_Speculative}}", "");
                        RemiDate = RemiDate.Replace("{{$Application_Title}}", "");
                    }

                    RemiDate = RemiDate.Replace("{{$Company_Address}}", HttpUtility.HtmlEncode(project.Companies[CompId].AdressFieldSum));
                    RemiDate = RemiDate.Replace("{{$Company_Id}}", HttpUtility.HtmlEncode(project.Companies[CompId].Id.ToString()));
                    RemiDate = RemiDate.Replace("{{$Company_Title}}", HttpUtility.HtmlEncode(project.Companies[CompId].TitleNoText));
                    RemiDate = RemiDate.Replace("{{$Company_Trade}}", HttpUtility.HtmlEncode(project.Companies[CompId].Trade));

                    RemiDateList.Append(RemiDate);
                }
                Output = Output.Replace("{{$ReminderList_Reminder}}", RemiDateList.ToString());

                return Output;
            }
            #endregion
            #endregion
        }
    }
}