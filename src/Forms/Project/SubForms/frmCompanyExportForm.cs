/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to export Companies
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
using OLKI.Programme.BeOrSy.src.Project;
using OLKI.Toolbox.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to export Companies
    /// </summary>
    public partial class CompanyExportForm : Form
    {
        #region Enums
        /// <summary>
        /// Mode to show form
        /// </summary>
        public enum FormMode
        {
            ExportCSV,
            ExportXML
        }
        #endregion

        #region Fields
        /// <summary>
        /// Items in Company ListView
        /// </summary>
        private readonly ListView.ListViewItemCollection _companyListViewItems;

        /// <summary>
        /// Selected Items in Company ListView
        /// </summary>
        private readonly ListView.SelectedListViewItemCollection _companyListViewItemsSelected;

        /// <summary>
        /// Mode to show form
        /// </summary>
        private readonly FormMode _formMode;

        /// <summary>
        /// Main Project
        /// </summary>
        private readonly src.Project.Project _project;

        /// <summary>
        /// Target Path to write copmanys to
        /// </summary>
        private readonly string _targetPath;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to export Companies
        /// </summary>
        /// <param name="companyListViewItems">Items in Company ListView</param>
        /// <param name="companyListViewItemsSelected">Selected Items in Company ListView</param>
        /// <param name="formMode">Mo to show form</param>
        /// <param name="project">Main Project</param>
        /// <param name="targetPath">Target Path to write copmanys to</param>
        public CompanyExportForm(ListView.ListViewItemCollection companyListViewItems, ListView.SelectedListViewItemCollection companyListViewItemsSelected, FormMode formMode, src.Project.Project project, string targetPath)
        {
            InitializeComponent();

            this._companyListViewItems = companyListViewItems;
            this._companyListViewItemsSelected = companyListViewItemsSelected;
            this._formMode = formMode;
            this._project = project;
            this._targetPath = targetPath;

            this.rabExportAll.Enabled = this._project.Companies.Count > 0;
            this.rabExportFil.Enabled = this._companyListViewItems.Count > 0;
            this.rabExportSel.Enabled = this._companyListViewItemsSelected.Count > 0;

            if (this._formMode != FormMode.ExportCSV)
            {
                this.grbHandleNewline.Enabled = false;
                this.grbHandleSeperator.Enabled = false;
            }
        }

        /// <summary>
        /// Export Companies to target CSV-File
        /// </summary>
        /// <param name="targetFile">CSV-File to export to</param>
        /// <param name="companies">Companies to export</param>
        /// <param name="newline">Replacement for NewLine</param>
        /// <param name="seperator">Seperator for Columns</param>
        /// <returns>True if writing to file was sucessfull</returns>
        private bool ExportCompaniesCSV(string targetFile, List<CompanyItem> companies, string newline, char seperator)
        {
            string Template = Resources.CompanyTemplate;
            Template = Template.Replace(';', seperator);

            List<List<string>> DataLines = new List<List<string>>();
            foreach (CompanyItem Item in companies.OrderBy(oComp => oComp.Title))
            {
                List<string> ItemData = new List<string>
                {
                    Item.Title,
                    Item.Trade,
                    Item.Terminated.ToString(),
                    Item.AdressStreet.Replace("\r\n", newline),
                    Item.AdressPostcode,
                    Item.AdressCity,
                    Item.AdressState,
                    Item.AdressCountry,
                    Item.ContactTelephone,
                    Item.ContactFax,
                    Item.ContactEMail,
                    Item.ContactHomepage,
                    Item.ContactCareerPage,
                    Item.Comment.Replace("\r\n", newline)
                };

                DataLines.Add(ItemData);
            }
            CSVwriter CSVwriter = new CSVwriter();
            if (!CSVwriter.WriteCSVtoFile(targetFile, Template, DataLines, newline, seperator.ToString(), out Exception Exception))
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0045m, new object[] { Exception.Message }), Stringtable._0x0045c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Export Companies to target XML-File
        /// </summary>
        /// <param name="targetFile">XML-File to export to</param>
        /// <param name="companies">Companies to export</param>
        /// <returns>True if writing to file was sucessfull</returns>
        private bool ExportCompaniesXML(string targetFile, List<CompanyItem> companies)
        {
            XElement ProjectRoot = new XElement("BeOrSy_ProjectData");
            ProjectRoot.Add(new XAttribute("Version", Settings_AppConst.Default.ProjectFile_Version_Actual));

            XElement CompList = new XElement("CompanyList");
            foreach (CompanyItem Comp in companies.OrderBy(oComp => oComp.Id))
            {
                if (Comp.Delete == ItemBase.DeleteFlag.None) CompList.Add(Comp.ToXElement(true));
            }
            ProjectRoot.Add(CompList);

            try
            {
                // Write data
                char[] Content = ProjectRoot.ToString().ToCharArray();
                using (StreamWriter StreamWriter = new StreamWriter(File.Open(targetFile, FileMode.Create), System.Text.Encoding.UTF8))
                {
                    StreamWriter.WriteLine(Settings_AppConst.Default.XMLheader);
                    int ReadLength;
                    int Limit = (int)Math.Ceiling((decimal)Content.Length / (decimal)Settings_AppConst.Default.WriteDataBufferLength);
                    for (int i = 0; i < Limit; i++)
                    {
                        ReadLength = this._project.GetValidBufferReadLength(Content.Length, i, Settings_AppConst.Default.WriteDataBufferLength);
                        StreamWriter.Write(Content, i * Settings_AppConst.Default.WriteDataBufferLength, ReadLength);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0045m, new object[] { ex.Message }), Stringtable._0x0045c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get a list with Companies to export
        /// </summary>
        /// <returns>A list with Companies to export</returns>
        private List<CompanyItem> GetExportCompanies()
        {
            List<CompanyItem> ExportList = new List<CompanyItem>();
            List<int> FilterIdSet = new List<int>();

            if (this.rabExportFil.Checked && this._companyListViewItems != null)
            {
                foreach (ListViewItem Item in this._companyListViewItems)
                {
                    FilterIdSet.Add((int)Item.Tag);
                }
            }

            if (this.rabExportSel.Checked && this._companyListViewItemsSelected != null)
            {
                foreach (ListViewItem Item in this._companyListViewItemsSelected)
                {
                    FilterIdSet.Add((int)Item.Tag);
                }
            }

            foreach (CompanyItem Item in this._project.Companies.Values)
            {
                if (this.rabExportAll.Checked || FilterIdSet.Contains(Item.Id))
                {
                    ExportList.Add(Item);
                }
            }

            return ExportList;
        }

        /// <summary>
        /// Get if there are Companies to export
        /// </summary>
        /// <returns>True if there are any Companoes to export</returns>
        private bool HasExportData()
        {
            if (this.rabExportAll.Checked && this._project.Companies != null && this._project.Companies.Count > 0) return true;
            if (this.rabExportFil.Checked && this._companyListViewItems != null && this._companyListViewItems.Count > 0) return true;
            if (this.rabExportSel.Checked && this._companyListViewItemsSelected != null && this._companyListViewItemsSelected.Count > 0) return true;

            return false;
        }

        #region Form Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!this.HasExportData())
            {
                MessageBox.Show(this, Stringtable._0x0044m, Stringtable._0x0044m, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<CompanyItem> Companies = new List<CompanyItem>();
            Companies = GetExportCompanies();

            string Newline = "";
            if (this.rabNewlineSpace.Checked) Newline = " ";
            if (this.rabNewlineLF.Checked) Newline = @"\n";
            if (this.rabNewlineCRLF.Checked) Newline = @"\r\n";
            if (this.rabNewlineBR.Checked) Newline = @"<br />";
            if (this.rabNewlineCustom.Checked) Newline = this.txtNewlineCustom.Text;

            char Seperator = ' ';
            if (this.rabSeperatorComma.Checked) Seperator = ',';
            if (this.rabSeperatorSemicolon.Checked) Seperator = ';';
            if (this.rabSeperatorTabulator.Checked) Seperator = '\t';
            if (this.rabSeperatorCustom.Checked && this.txtSeperatorCustom.Text.Length > 0) Seperator = char.Parse(this.txtSeperatorCustom.Text);

            switch (this._formMode)
            {
                case FormMode.ExportCSV:
                    if (this.ExportCompaniesCSV(this._targetPath, Companies, Newline, Seperator)) this.Close();
                    break;
                case FormMode.ExportXML:
                    if (this.ExportCompaniesXML(this._targetPath, Companies)) this.Close();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion
        #endregion
    }
}