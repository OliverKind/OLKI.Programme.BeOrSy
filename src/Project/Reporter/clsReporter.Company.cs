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
        /// Class that contains Data an Methods to create a Company Report
        /// </summary>
        internal static class Company
        {
            #region Constants
            /// <summary>
            /// Main Template file
            /// </summary>
            private const string TPL_COMP = @"Report.Main_Company.html";

            /// <summary>
            /// Sub Template for Applications
            /// </summary>
            private const string TPL_SUB_APPL = @"Report.Sub_Application.html";

            /// <summary>
            /// Sub Template for Contacts
            /// </summary>
            private const string TPL_SUB_CONT = @"Report.Sub_Contact.html";

            /// <summary>
            /// Sub Template for Files
            /// </summary>
            private const string TPL_SUB_FILE = @"Report.Sub_File.html";

            /// <summary>
            /// Sub Template for Reminders
            /// </summary>
            private const string TPL_SUB_REMI = @"Report.Sub_Reminder.html";
            #endregion

            #region Methods
            /// <summary>
            /// Check if the Items have a Id and are not new
            /// </summary>
            /// <param name="comp">Company to check</param>
            /// <returns>False if all elemts have a Id and are not in New state</returns>
            private static bool IsNewItem(CompanyItem comp)
            {
                if (comp.Id <= 0) return true;
                if (comp.NewItemState != ItemBase.NewItemStateFlag.NotNew) return true;
                return false;
            }

            /// <summary>
            /// Create Company Report
            /// </summary>
            /// <param name="owner">Owner form for Message Boxes</param>
            /// <param name="project">Owner Project</param>
            /// <param name="companyId">Id of the Company, to create the Report from</param>
            internal static void Create(IWin32Window owner, Project project, int companyId)
            {
                try
                {
                    CompanyItem Comp = project.Companies.ContainsKey(companyId) ? project.Companies[companyId] : null;
                    if (Comp == null || IsNewItem(Comp))
                    {
                        MessageBox.Show(owner, Stringtable._0x003Em, Stringtable._0x003Ec, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Create directory if necessary
                    if (string.IsNullOrEmpty(Comp.Directory) || !new DirectoryInfo(Comp.Directory).Exists)
                    {
                        Comp.Directory = Comp.GetCalcDirectory(project.Settings.ProjectDirPath, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                        if (!Toolbox.DirectoryAndFile.Directory.Create(Comp.Directory, project.Settings.CompTemplPath)) return;
                    }

                    // Load Template
                    string TemplateContent = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_COMP);
                    StringBuilder Output = new StringBuilder(TemplateContent);

                    // Fill up Template
                    Output = FillReportBasicData(Output);
                    Output = FillCompanyBasicDate(Output, Comp);
                    Output = FillCompanyApplications(Output, Comp);
                    Output = FillCompanyContact(Output, Comp);
                    Output = FillCompanyFile(Output, Comp);
                    Output = FillCompanyReminder(Output, Comp);

                    // Write File
                    string ReportFilePath = Toolbox.DirectoryAndFile.Path.Repair(Comp.Directory + @"\" + string.Format(Settings_AppConst.Default.Filename_Report_Company, new object[] { Comp.Id, DateTime.Now.ToString(Settings_AppConst.Default.DateTimeFormatForFile) }));
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
            private static StringBuilder FillCompanyBasicDate(StringBuilder inputTemplate, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                Output = Output.Replace("{{$Company_Adress}}", HttpUtility.HtmlEncode(company.AdressFieldSum).Replace("\n", "<br />"));
                Output = Output.Replace("{{$Company_ContactCareerPage}}", HttpUtility.HtmlEncode(company.ContactCareerPage));
                Output = Output.Replace("{{$Company_ContactEMail}}", HttpUtility.HtmlEncode(company.ContactEMail));
                Output = Output.Replace("{{$Company_ContactFax}}", HttpUtility.HtmlEncode(company.ContactFax));
                Output = Output.Replace("{{$Company_ContactHomepage}}", HttpUtility.HtmlEncode(company.ContactHomepage));
                Output = Output.Replace("{{$Company_ContactTelephone}}", HttpUtility.HtmlEncode(company.ContactTelephone));
                Output = Output.Replace("{{$Company_Comment}}", HttpUtility.HtmlEncode(company.Comment).Replace("\n", "<br />"));
                Output = Output.Replace("{{$Company_Id}}", HttpUtility.HtmlEncode(company.Id));
                Output = Output.Replace("{{$Company_Title}}", HttpUtility.HtmlEncode(company.TitleNoText));
                Output = Output.Replace("{{$Company_Trade}}", HttpUtility.HtmlEncode(company.Trade));

                return Output;
            }

            #region Sub Reports
            /// <summary>
            /// Create sub Report with Applications
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Applications</returns>
            private static StringBuilder FillCompanyApplications(StringBuilder inputTemplate, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (company.Applications == null || company.Applications.Count == 0)
                {
                    Output = Output.Replace("{{$Comapny_Application}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string ApplDate = "";
                string ApplTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_APPL);
                string ApplTplHead = ApplTpl.Substring(0, ApplTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string ApplTplBody = ApplTpl.Substring(ApplTpl.IndexOf("<tbody>") + "<tbody>".Length, ApplTpl.Substring(ApplTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (ApplTpl.Substring(ApplTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - ApplTpl.Substring(ApplTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string ApplTplFoot = ApplTpl.Substring(ApplTpl.IndexOf("\t</tbody>"));
                StringBuilder ApplDateList = new StringBuilder();
                ApplDateList.Append(ApplTplHead);
                foreach (ApplicationItem ApplItem in company.Applications.Values.OrderBy(o => o.DateCreated))
                {
                    ApplDate = ApplTplBody;
                    ApplDate = ApplDate.Replace("{{$Application_Comment}}", HttpUtility.HtmlEncode(ApplItem.Comment).Replace("\n", "<br />"));
                    ApplDate = ApplDate.Replace("{{$Application_Date}}", ApplItem.DateCreated == null ? "" : HttpUtility.HtmlEncode(((DateTime)ApplItem.DateCreated).ToString(Properties.Settings.Default.DateFormat)));
                    ApplDate = ApplDate.Replace("{{$Application_Id}}", HttpUtility.HtmlEncode(ApplItem.Id));
                    ApplDate = ApplDate.Replace("{{$Application_Progress}}", ApplItem.ProgressMax == null ? "" : ((ApplItem.ProgressMax.Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)ApplItem.ProgressMax.Date).ToString(Properties.Settings.Default.DateFormat)) + "&nbsp;-&nbsp;") + HttpUtility.HtmlEncode(ApplItem.ProgressMax.TitleNoText)));
                    ApplDate = ApplDate.Replace("{{$Application_TitleReference}}", HttpUtility.HtmlEncode(ApplItem.TitleNoText) + (string.IsNullOrEmpty(ApplItem.ReferenceCode) ? "" : "<br /><small>" + HttpUtility.HtmlEncode(ApplItem.ReferenceCode) + "</small>"));
                    ApplDateList.Append(ApplDate);
                }
                ApplDateList.Append(ApplTplFoot);
                Output = Output.Replace("{{$Comapny_Application}}", ApplDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Contacts
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Contacts</returns>
            private static StringBuilder FillCompanyContact(StringBuilder inputTemplate, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (company.Contacts == null || company.Contacts.Count == 0)
                {
                    Output = Output.Replace("{{$Comapny_Contact}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
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
                    ContDate = ContTplBody;
                    ContDate = ContDate.Replace("{{$Contact_Comment}}", HttpUtility.HtmlEncode(ContItem.Comment).Replace("\n", "<br />"));
                    ContDate = ContDate.Replace("{{$Contact_NameFirst}}", HttpUtility.HtmlEncode(ContItem.NameFirstNoText));
                    ContDate = ContDate.Replace("{{$Contact_NameLast}}", HttpUtility.HtmlEncode(ContItem.NameLastNoText));
                    ContDateList.Append(ContDate);
                }
                ContDateList.Append(ContTplFoot);
                Output = Output.Replace("{{$Comapny_Contact}}", ContDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Files
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Files</returns>
            private static StringBuilder FillCompanyFile(StringBuilder inputTemplate, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (company.Files == null || company.Files.Count == 0)
                {
                    Output = Output.Replace("{{$Comapny_File}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string FileDate = "";
                string FileTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_FILE);
                string FileTplHead = FileTpl.Substring(0, FileTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string FileTplBody = FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length, FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string FileTplFoot = FileTpl.Substring(FileTpl.IndexOf("\t</tbody>"));
                StringBuilder FileDateList = new StringBuilder();
                FileDateList.Append(FileTplHead);
                foreach (FileItem FileItem in company.Files.Values.OrderBy(o => o.TitleNoText))
                {
                    FileDate = FileTplBody;
                    FileDate = FileDate.Replace("{{$File_Comment}}", HttpUtility.HtmlEncode(FileItem.Comment).Replace("\n", "<br />"));
                    FileDate = FileDate.Replace("{{$File_Title}}", HttpUtility.HtmlEncode(FileItem.TitleNoText));
                    FileDateList.Append(FileDate);
                }
                FileDateList.Append(FileTplFoot);
                Output = Output.Replace("{{$Comapny_File}}", FileDateList.ToString());

                return Output;
            }

            /// <summary>
            /// Create sub Report with Reminders
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="company">Company for the Report</param>
            /// <returns>Report with sub Report Reminders</returns>
            private static StringBuilder FillCompanyReminder(StringBuilder inputTemplate, CompanyItem company)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (company.Reminders == null || company.Reminders.Count == 0)
                {
                    Output = Output.Replace("{{$Comapny_Reminder}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string RemiDate = "";
                string RemiTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_REMI);
                string RemiTplHead = RemiTpl.Substring(0, RemiTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string RemiTplBody = RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length, RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - RemiTpl.Substring(RemiTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string RemiTplFoot = RemiTpl.Substring(RemiTpl.IndexOf("\t</tbody>"));
                StringBuilder RemiDateList = new StringBuilder();
                RemiDateList.Append(RemiTplHead);
                foreach (ReminderItem RemiItem in company.Reminders.Values.OrderBy(o => o.Date))
                {
                    RemiDate = RemiTplBody;
                    RemiDate = RemiDate.Replace("{{$Reminder_Comment}}", HttpUtility.HtmlEncode(RemiItem.Comment).Replace("\n", "<br />"));
                    RemiDate = RemiDate.Replace("{{$Reminder_Date}}", RemiItem.Date == null ? "" : HttpUtility.HtmlEncode(((DateTime)RemiItem.Date).ToString(Properties.Settings.Default.DateFormat)));
                    RemiDate = RemiDate.Replace("{{$Reminder_Title}}", HttpUtility.HtmlEncode(RemiItem.TitleNoText));
                    RemiDateList.Append(RemiDate);
                }
                RemiDateList.Append(RemiTplFoot);
                Output = Output.Replace("{{$Comapny_Reminder}}", RemiDateList.ToString());

                return Output;
            }
            #endregion
            #endregion
        }
    }
}