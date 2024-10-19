/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data an Methods to create a Application Report
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
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Project.ReportCeator
{
    internal static partial class Reporter
    {
        /// <summary>
        /// Class that contains Data an Methods to create a Application Report
        /// </summary>
        internal static class Application
        {
            #region Constants
            /// <summary>
            /// Main Template file
            /// </summary>
            private const string TPL_COMP = @"Report.Main_Application.html";

            /// <summary>
            /// Sub Template for Contacts
            /// </summary>
            private const string TPL_SUB_CONT = @"Report.Sub_Contact.html";

            /// <summary>
            /// Sub Template for Files
            /// </summary>
            private const string TPL_SUB_FILE = @"Report.Sub_File.html";

            /// <summary>
            /// Sub Template for Progress
            /// </summary>
            private const string TPL_SUB_PROG = @"Report.Sub_Progress.html";

            /// <summary>
            /// Sub Template for Reminders
            /// </summary>
            private const string TPL_SUB_REMI = @"Report.Sub_Reminder.html";
            #endregion

            #region Methods
            /// <summary>
            /// Check if the Items have a Id and are not new
            /// </summary>
            /// <param name="appl">Application to check</param>
            /// <param name="comp">Company to check</param>
            /// <returns>False if all elemts have a Id and are not in New state</returns>
            private static bool IsNewItemOrSubItem(ApplicationItem appl, CompanyItem comp)
            {
                if (appl.Id <= 0) return true;
                if (appl.NewItemState != ItemBase.NewItemStateFlag.NotNew) return true;
                if (comp.Id <= 0) return true;
                if (comp.NewItemState != ItemBase.NewItemStateFlag.NotNew) return true;
                return false;
            }

            /// <summary>
            /// Create Company Report
            /// </summary>
            /// <param name="owner">Owner form for Message Boxes</param>
            /// <param name="project">Owner Project</param>
            /// <param name="companyId">Id of the Company, contains the Application</param>
            /// <param name="companyId">Id of the Application, to create the Report from</param>
            internal static void Create(IWin32Window owner, Project project, int companyId, int applicationId)
            {
                try
                {
                    CompanyItem Comp = project.Companies.ContainsKey(companyId) ? project.Companies[companyId] : null;
                    ApplicationItem Appl = Comp != null && Comp.Applications.ContainsKey(applicationId) ? Comp.Applications[applicationId] : null;
                    if (Comp == null || Appl == null || IsNewItemOrSubItem(Appl, Comp))
                    {
                        MessageBox.Show(owner, Stringtable._0x003Em, Stringtable._0x003Ec, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Create directory if necessary
                    if (string.IsNullOrEmpty(Appl.Directory) || !new DirectoryInfo(Appl.Directory).Exists)
                    {
                        if (string.IsNullOrEmpty(Comp.Directory) || !new DirectoryInfo(Comp.Directory).Exists)
                        {
                            Comp.Directory = Comp.GetCalcDirectory(project.Settings.ProjectDirPath, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                            if (!Toolbox.DirectoryAndFile.Directory.Create(Comp.Directory, project.Settings.CompTemplPath)) return;
                        }
                        Appl.Directory = Appl.GetCalcDirectory(Comp.Directory, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                        if (!Toolbox.DirectoryAndFile.Directory.Create(Appl.Directory, project.Settings.ApplTemplPath)) return;
                    }

                    // Load Template
                    string TemplateContent = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_COMP);
                    StringBuilder Output = new StringBuilder(TemplateContent);

                    // Fill up Template
                    Output = FillReportBasicData(Output);
                    Output = FillAoolicationBasicDate(Output, Appl, Comp);
                    Output = FillAoolicationContact(Output, Appl, Comp);
                    Output = FillAoolicationFile(Output, Appl);
                    Output = FillApplicationProgress(Output, Appl);
                    Output = FillAoolicationReminder(Output, Appl);

                    // Write File
                    string ReportFilePath = Toolbox.DirectoryAndFile.Path.Repair(Appl.Directory + @"\" + string.Format(Settings_AppConst.Default.Filename_Report_Application, new object[] { Comp.Id, DateTime.Now.ToString(Settings_AppConst.Default.DateTimeFormatForFile) }));
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
            /// <param name="application">Application for the Report</param>
            /// <param name="company">Company of the Application</param>
            /// <returns>Report with Company Data</returns>
            private static StringBuilder FillAoolicationBasicDate(StringBuilder inputTemplate, ApplicationItem application, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                Output = Output.Replace("{{$Application_Comment}}", HttpUtility.HtmlEncode(application.Comment).Replace("\n", "<br />"));
                Output = Output.Replace("{{$Application_Created}}", application.DateCreated == null ? "" : HttpUtility.HtmlEncode(((DateTime)application.DateCreated).ToString(Properties.Settings.Default.DateFormat)));
                Output = Output.Replace("{{$Application_Id}}", HttpUtility.HtmlEncode(application.Id));
                Output = Output.Replace("{{$Application_Period}}", application.DatePeriodEnd == null ? "" : HttpUtility.HtmlEncode(((DateTime)application.DatePeriodEnd).ToString(Properties.Settings.Default.DateFormat)));
                Output = Output.Replace("{{$Application_ReferenceCode}}", HttpUtility.HtmlEncode(application.ReferenceCode));
                Output = Output.Replace("{{$Application_SpeculativeApplication}}", HttpUtility.HtmlEncode(Reporter.StateString[Convert.ToInt32(application.SpeculativeApplication)]));
                Output = Output.Replace("{{$Application_Title}}", HttpUtility.HtmlEncode(application.TitleNoText));
                Output = Output.Replace("{{$Company_Id}}", HttpUtility.HtmlEncode(company.Id));
                Output = Output.Replace("{{$Company_Title}}", HttpUtility.HtmlEncode(company.TitleNoText));

                return Output;
            }

            #region Sub Reports
            /// <summary>
            /// Create sub Report with Contacts
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Contacts</returns>
            private static StringBuilder FillAoolicationContact(StringBuilder inputTemplate, ApplicationItem application, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (company.Contacts == null || company.Contacts.Count == 0 || application.AssociatedContacts == null || application.AssociatedContacts.Count == 0)
                {
                    Output = Output.Replace("{{$Application_Contact}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string ContDate = "";
                string ContTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_CONT);
                string ContTplHead = ContTpl.Substring(0, ContTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string ContTplBody = ContTpl.Substring(ContTpl.IndexOf("<tbody>") + "<tbody>".Length, ContTpl.Substring(ContTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (ContTpl.Substring(ContTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - ContTpl.Substring(ContTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string ContTplFoot = ContTpl.Substring(ContTpl.IndexOf("\t</tbody>"));
                StringBuilder ContDateList = new StringBuilder();
                ContDateList.Append(ContTplHead);
                foreach (ContactItem ContItem in company.Contacts.Values.OrderBy(o => o.NameLastNoText))
                {
                    if (application.AssociatedContacts.Contains(ContItem.Id))
                    {
                        ContDate = ContTplBody;
                        ContDate = ContDate.Replace("{{$Contact_Comment}}", HttpUtility.HtmlEncode(ContItem.Comment).Replace("\n", "<br />"));
                        ContDate = ContDate.Replace("{{$Contact_NameFirst}}", HttpUtility.HtmlEncode(ContItem.NameFirstNoText));
                        ContDate = ContDate.Replace("{{$Contact_NameLast}}", HttpUtility.HtmlEncode(ContItem.NameLastNoText));
                        ContDateList.Append(ContDate);
                    }
                }
                ContDateList.Append(ContTplFoot);
                Output = Output.Replace("{{$Application_Contact}}", ContDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Files
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="application">Application for the Report</param>
            /// <returns>Report with sub Report Files</returns>
            private static StringBuilder FillAoolicationFile(StringBuilder inputTemplate, ApplicationItem application)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (application.Files == null || application.Files.Count == 0)
                {
                    Output = Output.Replace("{{$Application_File}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string FileDate = "";
                string FileTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_FILE);
                string FileTplHead = FileTpl.Substring(0, FileTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string FileTplBody = FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length, FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string FileTplFoot = FileTpl.Substring(FileTpl.IndexOf("\t</tbody>"));
                StringBuilder FileDateList = new StringBuilder();
                FileDateList.Append(FileTplHead);
                foreach (FileItem FileItem in application.Files.Values.OrderBy(o => o.TitleNoText))
                {
                    FileDate = FileTplBody;
                    FileDate = FileDate.Replace("{{$File_Comment}}", HttpUtility.HtmlEncode(FileItem.Comment).Replace("\n", "<br />"));
                    FileDate = FileDate.Replace("{{$File_Title}}", HttpUtility.HtmlEncode(FileItem.TitleNoText));
                    FileDateList.Append(FileDate);
                }
                FileDateList.Append(FileTplFoot);
                Output = Output.Replace("{{$Application_File}}", FileDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Progresses
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="application">Application for the Report</param>
            /// <returns>Report with sub Report Progresses</returns>
            internal static StringBuilder FillApplicationProgress(StringBuilder inputTemplate, ApplicationItem application)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (application.Progresses == null || application.Progresses.Count == 0)
                {
                    Output = Output.Replace("{{$Application_Progress}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string ProgDate = "";
                string ProgTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_PROG);
                string ProgTplHead = ProgTpl.Substring(0, ProgTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string ProgTplBody = ProgTpl.Substring(ProgTpl.IndexOf("<tbody>") + "<tbody>".Length, ProgTpl.Substring(ProgTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (ProgTpl.Substring(ProgTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - ProgTpl.Substring(ProgTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string ProgTplFoot = ProgTpl.Substring(ProgTpl.IndexOf("\t</tbody>"));
                StringBuilder ProglDateList = new StringBuilder();
                ProglDateList.Append(ProgTplHead);
                foreach (ProgressItem ProgItem in application.Progresses.Values.OrderBy(o => o.Date))
                {
                    ProgDate = ProgTplBody;
                    ProgDate = ProgDate.Replace("{{$Progress_Comment}}", HttpUtility.HtmlEncode(ProgItem.Comment).Replace("\n", "<br />"));
                    ProgDate = ProgDate.Replace("{{$Progress_Date}}", ProgItem.Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)ProgItem.Date).ToString(Properties.Settings.Default.DateFormat)));
                    ProgDate = ProgDate.Replace("{{$Progress_Title}}", HttpUtility.HtmlEncode(ProgItem.TitleNoText));
                    ProglDateList.Append(ProgDate);
                }
                ProglDateList.Append(ProgTplFoot);
                Output = Output.Replace("{{$Application_Progress}}", ProglDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Reminders
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="application">Application for the Report</param>
            /// <returns>Report with sub Report Reminders</returns>
            private static StringBuilder FillAoolicationReminder(StringBuilder inputTemplate, ApplicationItem application)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (application.Reminders == null || application.Reminders.Count == 0)
                {
                    Output = Output.Replace("{{$Application_Reminder}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string RemiDate = "";
                string RemiTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_REMI);
                string RemiTplHead = RemiTpl.Substring(0, RemiTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string RemiTplBody = RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length, RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string RemiTplFoot = RemiTpl.Substring(RemiTpl.IndexOf("\t</tbody>"));
                StringBuilder RemiDateList = new StringBuilder();
                RemiDateList.Append(RemiTplHead);
                foreach (ReminderItem RemiItem in application.Reminders.Values.OrderBy(o => o.Date))
                {
                    RemiDate = RemiTplBody;
                    RemiDate = RemiDate.Replace("{{$Reminder_Comment}}", HttpUtility.HtmlEncode(RemiItem.Comment).Replace("\n", "<br />"));
                    RemiDate = RemiDate.Replace("{{$Reminder_Date}}", RemiItem.Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)RemiItem.Date).ToString(Properties.Settings.Default.DateFormat)));
                    RemiDate = RemiDate.Replace("{{$Reminder_Title}}", HttpUtility.HtmlEncode(RemiItem.TitleNoText));
                    RemiDateList.Append(RemiDate);
                }
                RemiDateList.Append(RemiTplFoot);
                Output = Output.Replace("{{$Application_Reminder}}", RemiDateList.ToString());

                return Output;
            }
            #endregion
            #endregion
        }
    }
}