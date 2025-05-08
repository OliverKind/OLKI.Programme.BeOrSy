/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2025
 * License:     LGPL
 * 
 * Desctiption:
 * Form to import Companies
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
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to import Companies
    /// </summary>
    public partial class CompanyImportForm : Form
    {
        #region Enums
        /// <summary>
        /// Mode to show form
        /// </summary>
        public enum FormMode
        {
            ImportCSV,
            ImportXML
        }
        #endregion

        #region Fields
        /// <summary>
        /// Mode to show form
        /// </summary>
        private readonly FormMode _formMode;

        /// <summary>
        /// Main Project
        /// </summary>
        private readonly src.Project.Project _project;

        /// <summary>
        /// Source Path to get copmanys from
        /// </summary>
        private readonly string _sourcePath;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to import Companies
        /// </summary>
        /// <param name="formMode">Mo to show form</param>
        /// <param name="project">Main Project</param>
        /// <param name="sourcePath">Source Path to get copmanys from</param>
        public CompanyImportForm(FormMode formMode, src.Project.Project project, string sourcePath)
        {
            InitializeComponent();

            this._formMode = formMode;
            this._project = project;
            this._sourcePath = sourcePath;

            if (this._formMode != FormMode.ImportCSV)
            {
                this.btnOk_Click(this, new EventArgs());
            }
        }

        /// <summary>
        /// Impoort Companies from source CSV-File
        /// </summary>
        /// <param name="sourceFile">CSV-File to import from</param>
        /// <param name="project">Project to import companies to</param>
        /// <param name="newline">Replacement for NewLine</param>
        /// <param name="seperator">Seperator for Columns</param>
        /// <returns>True if import from file was sucessfull</returns>
        private bool ImportCompaniesCSV(string sourceFile, src.Project.Project project, string newline, char seperator)
        {
            List<CompanyItem> CompanyImportList = new List<CompanyItem>();
            CSVreader CSVread = new CSVreader
            {
                CommentIndicator = new List<char> { '#' },
                Seperators = new List<char> { seperator }
            };
            int NewCompId = project.IdSet.Comp;

            try
            {
                if (CSVread.ReadCSVfromFile(sourceFile, out Exception ImportException))
                {
                    if (ImportException != null) throw ImportException;
                    for (int i = 1; i < CSVread.CSVrows.Count; i++)
                    {
                        NewCompId++;
                        CompanyItem Company = new CompanyItem(NewCompId);
                        CSVreader.CSVrow CSVrow = CSVread.CSVrows[i];

                        Company.Title = CSVrow.Columns[0];
                        Company.Trade = CSVrow.Columns[1];
                        Company.Terminated = Convert.ToBoolean(CSVrow.Columns[2]);
                        Company.AdressStreet = CSVrow.Columns[3].Replace(newline, "\r\n");
                        Company.AdressPostcode = CSVrow.Columns[4];
                        Company.AdressCity = CSVrow.Columns[5];
                        Company.AdressState = CSVrow.Columns[6];
                        Company.AdressCountry = CSVrow.Columns[7];
                        Company.ContactTelephone = CSVrow.Columns[8];
                        Company.ContactFax = CSVrow.Columns[9];
                        Company.ContactEMail = CSVrow.Columns[10];
                        Company.ContactHomepage = CSVrow.Columns[11];
                        Company.ContactCareerPage = CSVrow.Columns[12];
                        Company.Comment = CSVrow.Columns[13].Replace(newline, "\r\n");

                        CompanyImportList.Add(Company);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0046m, new object[] { sourceFile, ex.Message }), Stringtable._0x0046c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (CompanyItem CompanyItem in CompanyImportList)
            {
                this._project.Companies.Add(CompanyItem.Id, CompanyItem);
            }
            this._project.IdSet.Comp = NewCompId;

            return true;
        }


        /// <summary>
        /// Impoort Companies from source XML-File
        /// </summary>
        /// <param name="sourceFile">XML-File to import from</param>
        /// <param name="project">Project to import companies to</param>
        /// <returns>True if import from file was sucessfull</returns>
        private bool ImportCompaniesXML(string sourceFile, src.Project.Project project)
        {
            List<CompanyItem> CompanyImportList = new List<CompanyItem>();
            int NewCompId = project.IdSet.Comp;
            try
            {

                string RawDataString = File.ReadAllText(sourceFile);
                XElement RawDataXMLData = XElement.Parse(RawDataString);
                //Check Fileversion
                if (!this._project.CheckFileVersion(Serialize.GetFromXElementAttribute(RawDataXMLData, "Version", ""), this._project.ProjectForm)) return false;

                XElement CompanyList = Serialize.GetFromXElement(RawDataXMLData, "CompanyList", new XElement("CompanyList"));
                if (CompanyList == null) return true;
                foreach (XElement CompanyItem in CompanyList.Elements("CompanyItem"))
                {
                    NewCompId++;
                    CompanyItem Company = new CompanyItem(CompanyItem, NewCompId);
                    CompanyImportList.Add(Company);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format(Stringtable._0x0046m, new object[] { sourceFile, ex.Message }), Stringtable._0x0046c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            foreach (CompanyItem CompItem in CompanyImportList)
            {
                this._project.Companies.Add(CompItem.Id, CompItem);
            }
            this._project.IdSet.Comp = NewCompId;

            return true;
        }

        #region Form Events
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
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
                case FormMode.ImportCSV:
                    if (this.ImportCompaniesCSV(this._sourcePath, this._project, Newline, Seperator)) this.Close();
                    break;
                case FormMode.ImportXML:
                    if (this.ImportCompaniesXML(this._sourcePath, this._project)) this.Close();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion
        #endregion
    }
}