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
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to export Companies
    /// </summary>
    public partial class CompanyExportForm : Form
    {
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
        /// Main Project
        /// </summary>
        private readonly src.Project.Project _project;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to export Companies
        /// </summary>
        /// <param name="companyListViewItems">Items in Company ListView</param>
        /// <param name="companyListViewItemsSelected">Selected Items in Company ListView</param>
        /// <param name="project">Main Project</param>
        public CompanyExportForm(ListView.ListViewItemCollection companyListViewItems, ListView.SelectedListViewItemCollection companyListViewItemsSelected, src.Project.Project project)
        {
            InitializeComponent();

            this._companyListViewItems = companyListViewItems;
            this._companyListViewItemsSelected = companyListViewItemsSelected;
            this._project = project;

            this.rabExportAll.Enabled = this._project.Companies.Count > 0;
            this.rabExportFil.Enabled = this._companyListViewItems.Count > 0;
            this.rabExportSel.Enabled = this._companyListViewItemsSelected.Count > 0;
        }

        /// <summary>
        /// Export Companies to target File
        /// </summary>
        /// <param name="targetFile">File to export to</param>
        /// <param name="companies">Companies to export</param>
        /// <param name="newline">Replacement for NewLine</param>
        /// <param name="seperator">Seperator for Columns</param>
        private void ExportCompanies(string targetFile, List<CompanyItem> companies, string newline, string seperator)
        {
            string Template = Resources.CompanyTemplate;
            Template = Template.Replace(";", seperator);

            StringBuilder DataSring = new StringBuilder();
            DataSring.AppendLine(Template);

            StringBuilder DataLineBuilder = new StringBuilder();
            List<string> CompanyData = new List<string>();
            foreach (CompanyItem Item in companies.OrderBy(o => o.TitleNoText))
            {
                CompanyData.Clear();

                CompanyData.Add(Item.TitleNoText);
                CompanyData.Add(Item.Trade);
                CompanyData.Add(Item.Terminated.ToString());
                CompanyData.Add(Item.AdressStreet.Replace("\r\n", newline));
                CompanyData.Add(Item.AdressPostcode);
                CompanyData.Add(Item.AdressCity);
                CompanyData.Add(Item.AdressState);
                CompanyData.Add(Item.AdressCountry);
                CompanyData.Add(Item.ContactTelephone);
                CompanyData.Add(Item.ContactFax);
                CompanyData.Add(Item.ContactEMail);
                CompanyData.Add(Item.ContactHomepage);
                CompanyData.Add(Item.ContactCareerPage);
                CompanyData.Add(Item.Comment.Replace("\r\n", newline));

                DataSring.AppendLine(this.GetDataLine(DataLineBuilder, CompanyData, newline, seperator));
            }
            using (StreamWriter outputFile = new StreamWriter(targetFile, false))
            {
                outputFile.WriteLine(DataSring.ToString());
            }
        }

        /// <summary>
        /// Get the data Line
        /// </summary>
        /// <param name="dataLineBuilder">StringBuilder to create a data line</param>
        /// <param name="companyData">Data of the Company, to create a data line from</param>
        /// <param name="newline">Newline replacement</param>
        /// <param name="seperator">Column seperator</param>
        /// <returns>Data line for CSV-File</returns>
        string GetDataLine(StringBuilder dataLineBuilder, List<string> companyData, string newline, string seperator)
        {
            dataLineBuilder.Clear();
            for (int i = 0; i < companyData.Count; i++)
            {
                if (i > 0) dataLineBuilder.Append(seperator);

                string CompanyData = companyData[i];
                CompanyData = CompanyData.Replace("\r\n", newline);
                CompanyData = CompanyData.Replace("\"", "\"\"");
                if (CompanyData.Contains(seperator))
                {
                    dataLineBuilder.Append("\"");
                    dataLineBuilder.Append(CompanyData);
                    dataLineBuilder.Append("\"");
                }
                else
                {
                    dataLineBuilder.Append(CompanyData);
                }
            }

            return dataLineBuilder.ToString();
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

            string TargetPath = string.Empty;
            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                DefaultExt = Settings_AppConst.Default.CompanyExportFile_DefaultExtension,
                Filter = Settings_AppConst.Default.CompanyExportFile_FilterList,
                FilterIndex = Settings_AppConst.Default.CompanyExportFile_FilterIndex,
                InitialDirectory = Properties.Settings.Default.DirectoryFile_DefaultPath,
                SupportMultiDottedExtensions = true
            };
            if (SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;
            TargetPath = SaveFileDialog.FileName;

            List<CompanyItem> Companies = new List<CompanyItem>();
            Companies = GetExportCompanies();

            string Newline = "";
            if (this.rabNewlineSpace.Checked) Newline = " ";
            if (this.rabNewlineLF.Checked) Newline = @"\n";
            if (this.rabNewlineCRLF.Checked) Newline = @"\r\n";
            if (this.rabNewlineBR.Checked) Newline = @"<br />";
            if (this.rabNewlineCustom.Checked) Newline = this.txtNewlineCustom.Text;

            string Seperator = "";
            if (this.rabSeperatorComma.Checked) Seperator = ",";
            if (this.rabSeperatorSemicolon.Checked) Seperator = ";";
            if (this.rabSeperatorTabulator.Checked) Seperator = "\t";
            if (this.rabSeperatorCustom.Checked) Seperator = this.txtSeperatorCustom.Text;

            try
            {
                this.ExportCompanies(TargetPath, Companies, Newline, Seperator);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0045m, new object[] { ex.Message }), Stringtable._0x0045c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion
    }
}