/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that contains Data an Methods to create a Contact Report
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
        /// Class that contains Data an Methods to create a Contact Report
        /// </summary>
        internal static class Contact
        {
            #region Constants
            /// <summary>
            /// Main Template file
            /// </summary>
            private const string TPL_CONT = @"Report.Main_Contact.html";

            /// <summary>
            /// Sub Template for Files
            /// </summary>
            private const string TPL_SUB_FILE = @"Report.Sub_File.html";
            #endregion

            #region Methods
            /// <summary>
            /// Check if the Items have a Id and are not new
            /// </summary>
            /// <param name="comp">Company to check</param>
            /// <param name="cont">Contact to check</param>
            /// <returns>True if all elemts have a Id and are not in New state</returns>
            private static bool CheckNewState(CompanyItem comp, ContactItem cont)
            {
                if (comp.Id <= 0) return false;
                if (comp.NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                if (cont.Id <= 0) return false;
                if (cont.NewItemState != ItemBase.NewItemStateFlag.NotNew) return false;
                return true;
            }

            /// <summary>
            /// Create Company Report
            /// </summary>
            /// <param name="owner">Owner form for Message Boxes</param>
            /// <param name="project">Owner Project</param>
            /// <param name="companyId">Id of the Company, contains the Contact</param>
            /// <param name="contactId">Id of the Contact, to create the Report from</param>
            internal static void Create(IWin32Window owner, Project project, int companyId, int contactId)
            {
                try
                {
                    CompanyItem Comp = project.Companies[companyId];
                    ContactItem Cont = project.Companies[companyId].Contacts[contactId];
                    if (!CheckNewState(Comp, Cont))
                    {
                        MessageBox.Show(owner, Stringtable._0x003Em, Stringtable._0x003Ec, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // Create directory if necessary
                    if (string.IsNullOrEmpty(Comp.Directory) || !new DirectoryInfo(Comp.Directory).Exists)
                    {
                        Comp.Directory = Comp.GetCalcDirectory(project.Settings.ProjectDirPath, project.Settings.DirectoryAddTitle, project.Settings.DirectoryTitleLength, project.Settings.DirectoryTitleBeforeId).FullName;
                        if (!Toolbox.DirectoryAndFile.Directory.Create(Comp.Directory, project.Settings.CompTemplPath)) return;
                    }

                    // Load Template
                    string TemplateContent = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_CONT);
                    StringBuilder Output = new StringBuilder(TemplateContent);

                    // Fill up Template
                    Output = FillReportBasicData(Output);
                    Output = FillContactBasicDate(Output, Comp, Cont);
                    Output = FillContactFile(Output, Cont);

                    // Write File
                    string ReportFilePath = Toolbox.DirectoryAndFile.Path.Repair(Comp.Directory + @"\" + string.Format(Settings_AppConst.Default.Filename_Report_Contact, new object[] { Comp.Id, DateTime.Now.ToString(Settings_AppConst.Default.DateTimeFormatForFile) }));
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
            /// <param name="company">Company for the Contact</param>
            /// <param name="contact">Contact for the Report</param>
            /// <returns>Report with Company Data</returns>
            private static StringBuilder FillContactBasicDate(StringBuilder inputTemplate, CompanyItem company, ContactItem contact)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                Output = Output.Replace("{{$Contact_Comment}}", HttpUtility.HtmlEncode(contact.Comment).Replace("\n", "<br />"));
                Output = Output.Replace("{{$Contact_ContactCellphone}}", HttpUtility.HtmlEncode(contact.ContactCellphone));
                Output = Output.Replace("{{$Contact_ContactEMail}}", HttpUtility.HtmlEncode(contact.ContactEMail));
                Output = Output.Replace("{{$Contact_ContactFax}}", HttpUtility.HtmlEncode(contact.ContactFax));
                Output = Output.Replace("{{$Contact_ContactTelephone}}", HttpUtility.HtmlEncode(contact.ContactTelephone));
                Output = Output.Replace("{{$Contact_Division}}", HttpUtility.HtmlEncode(contact.Division));
                Output = Output.Replace("{{$Contact_Position}}", HttpUtility.HtmlEncode(contact.Position));
                Output = Output.Replace("{{$Contact_NameComplete}}", HttpUtility.HtmlEncode(contact.NameComplete));
                Output = Output.Replace("{{$Contact_NameFirst}}", HttpUtility.HtmlEncode(contact.NameFirstNoText));
                Output = Output.Replace("{{$Contact_NameLast}}", HttpUtility.HtmlEncode(contact.NameLastNoText));
                Output = Output.Replace("{{$Contact_NameTitle}}", HttpUtility.HtmlEncode(contact.NameTitle));

                Output = Output.Replace("{{$Company_Id}}", HttpUtility.HtmlEncode(company.Id));
                Output = Output.Replace("{{$Company_Title}}", HttpUtility.HtmlEncode(company.TitleNoText));

                return Output;
            }

            #region Sub Reports
            /// <summary>
            /// Create sub Report with Files
            /// </summary>
            /// <param name="inputTemplate">Main Template</param>
            /// <param name="contact">Contact for the Report</param>
            /// <returns>Report with sub Report Files</returns>
            private static StringBuilder FillContactFile(StringBuilder inputTemplate, ContactItem contact)
            {
                StringBuilder Output = new StringBuilder(inputTemplate.ToString());

                if (contact.Files == null || contact.Files.Count == 0)
                {
                    Output = Output.Replace("{{$Contact_File}}", HttpUtility.HtmlEncode(Stringtable._0x003D));
                    return Output;
                }

                string FileDate = "";
                string FileTpl = Toolbox.DirectoryAndFile.File.OpenToString(System.Windows.Forms.Application.StartupPath + TPL_PATH + TPL_SUB_FILE);
                string FileTplHead = FileTpl.Substring(0, FileTpl.IndexOf("<tbody>") + "<tbody>".Length);
                string FileTplBody = FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length, FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - (FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).Length - FileTpl.Substring(FileTpl.IndexOf("<tbody>") + "<tbody>".Length).IndexOf("\t</tbody>")));
                string FileTplFoot = FileTpl.Substring(FileTpl.IndexOf("\t</tbody>"));
                StringBuilder FileDateList = new StringBuilder();
                FileDateList.Append(FileTplHead);
                foreach (FileItem FileItem in contact.Files.Values.OrderBy(o => o.TitleNoText))
                {
                    FileDate = FileTplBody;
                    FileDate = FileDate.Replace("{{$File_Comment}}", HttpUtility.HtmlEncode(FileItem.Comment).Replace("\n", "<br />"));
                    FileDate = FileDate.Replace("{{$File_Title}}", HttpUtility.HtmlEncode(FileItem.TitleNoText));
                    FileDateList.Append(FileDate);
                }
                FileDateList.Append(FileTplFoot);
                Output = Output.Replace("{{$Contact_File}}", FileDateList.ToString());

                return Output;
            }
            #endregion
            #endregion
        }
    }
}