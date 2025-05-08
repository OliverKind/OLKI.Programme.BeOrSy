/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to edit application Projects
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
using OLKI.Programme.BeOrSy.src.Forms.Project.SubForms;
using OLKI.Programme.BeOrSy.src.Project;
using OLKI.Programme.BeOrSy.src.Project.Filter;
using OLKI.Programme.BeOrSy.src.Project.ReportCeator;
using OLKI.Toolbox.Common;
using OLKI.Toolbox.Widgets.Invoke;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;

namespace OLKI.Programme.BeOrSy.src.Forms.Project
{
    /// <summary>
    /// Form to edit application Projects
    /// </summary>
    public partial class ProjectForm : Form
    {
        #region Events
        /// <summary>
        /// Will be raised if a ListView Index was changed
        /// </summary>
        public event EventHandler ListViewIndexChanged;
        #endregion

        #region Fields
        /// <summary>
        /// Form to Edit Applications
        /// </summary>
        private ApplicationEditForm _applicationEditForm;

        /// <summary>
        /// Form to Edit Companys
        /// </summary>
        private CompanyEditForm _companyEditForm;

        /// <summary>
        /// Form to Export Companies
        /// </summary>
        private CompanyExportForm _companyExportForm;

        /// <summary>
        /// Form to Import Companies
        /// </summary>
        private CompanyImportForm _companyImportForm;

        /// <summary>
        /// Form to Search Companies
        /// </summary>
        private CompanySearchForm _companySearchForm;

        /// <summary>
        /// Form to show reminders
        /// </summary>
        private ApplicationSearchForm _searchFormApplication;

        /// <summary>
        /// Form to show reminders
        /// </summary>
        private ReminderSearchForm _searchFormReminder;

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properteis
        /// <summary>
        /// Get the main Project
        /// </summary>
        public src.Project.Project Project { get; }
        #endregion

        #region Methodes
        /// <summary>
        /// Create a new Form to edit application Projects
        /// </summary>
        /// <param name="project">Main Project</param>
        public ProjectForm(src.Project.Project project)
        {
            InitializeComponent();
            this.nudQuickFilterCompanyId.Maximum = int.MaxValue;
            this._systemChanged = true;
            this.Project = project;
            this.Project.ProjectChanged += new EventHandler(this.project_ProjectChanged);

            this.lsvApplication_SelectedIndexChanged(this, EventArgs.Empty);  //Used to initial some Controles
            this.lsvCompany_SelectedIndexChanged(this, EventArgs.Empty);  //Used to initial some Controles
            this.lsvApplication.ColumnWidths = this.Project.Settings.LsvAppWidth;
            this.lsvCompany.ColumnWidths = this.Project.Settings.LsvCmpWidth;

            //Initial company Filter
            this.uscQuickFilterCompanyAppProgress.ProgressList = this.Project.Settings.ProgressTemplateList;
            Toolbox.Widgets.Tools.ComboBox.SetToIndex(this.uscQuickFilterCompanyAppProgress, this.Project.Settings.QuickFilterCompanyAppProgress);
            this.chkQuickFilterCompanyAppProgressMode.CheckState = this.Project.Settings.QuickFilterCompanyAppProgressMode;
            this.cboQuickFilterCompanyCity.Text = this.Project.Settings.QuickFilterCompanyCity;
            this.nudQuickFilterCompanyId.Value = this.Project.Settings.QuickFilterCompanyId;
            this.chkQuickFilterCompanyTerminated.CheckState = this.Project.Settings.QuickFilterCompanyTerminated;
            this.txtQuickFilterCompanyTitle.Text = this.Project.Settings.QuickFilterCompanyTitle;
            this.cboQuickFilterCompanyTrade.Text = this.Project.Settings.QuickFilterCompanyTrade;
            project.FillComboBoxDropDown(this.cboQuickFilterCompanyCity, null, null, this.cboQuickFilterCompanyTrade);
            this.chkQuickFilterCompanyAppProgressMode_CheckStateChanged(this, EventArgs.Empty);

            //Load Companys
            List<int> companyFilter = this.ComapnyFastFilter();
            this.FillListViewCompany(companyFilter);
            this.project_ProjectChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Get a List with all Copnays, in the selected fast Filter
        /// </summary>
        /// <returns>List with filteres Companys</returns>
        private List<int> ComapnyFastFilter()
        {
            Company FilterCompany = new Company
            {
                AdressCity = this.cboQuickFilterCompanyCity.Text,
                Id = (int)this.nudQuickFilterCompanyId.Value,
                Progress = this.uscQuickFilterCompanyAppProgress.SelectedProgress == null ? -1 : this.uscQuickFilterCompanyAppProgress.SelectedProgress.Weight,
                ProgressMode = this.chkQuickFilterCompanyAppProgressMode.CheckState,
                Terminated = this.chkQuickFilterCompanyTerminated.CheckState,
                Title = this.txtQuickFilterCompanyTitle.Text,
                Trade = this.cboQuickFilterCompanyTrade.Text
            };
            return FilterCompany.Fast(this.Project.Companies);
        }

        /// <summary>
        /// Fill ListView with all items, they are in filter or with all items if filter is NULL
        /// </summary>
        /// <param name="companyFilter">Filter to list BillItems or NULL to list all BillItems</param>
        private void FillListViewCompany(List<int> companyFilter)
        {
            this.lsvCompany.BeginUpdate();
            this.lsvCompany.Items.Clear();

            foreach (CompanyItem CompanyItem in this.Project.Companies.Values.OrderBy(o => o.TitleNoText))
            {
                if (CompanyItem.Delete == ItemBase.DeleteFlag.None && (companyFilter == null || companyFilter.Contains(CompanyItem.Id)))
                {
                    //Create empty item and fill up by update procedure
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvCompany.FillUpSubItems(NewItem);
                    this.UpdateListViewItemComp(CompanyItem, NewItem);
                    this.lsvCompany.Items.Add(NewItem);
                }
            }
            this.lsvCompany.Sort(this.Project.Settings.LsvCmpOrder);
            this.lsvCompany.EndUpdate();
            this.lsvCompany_SelectedIndexChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Update the defined Application ListViewItem
        /// </summary>
        /// <param name="application">ApplicationItem to get Data from</param>
        /// <param name="listViewItem">ListViewItem to Update</param>
        private void UpdateListViewItemAppl(ApplicationItem application, ListViewItem listViewItem)
        {
            ReminderItem NextReminder = application.ReminderNext;
            ProgressItem ProgressMax = application.ProgressMax;

            listViewItem.BackColor = ProgressMax == null ? Color.Empty : ProgressMax.Color;
            listViewItem.Font = application.ReminderNext == null ? listViewItem.Font : new Font(listViewItem.Font, listViewItem.Font.Style | FontStyle.Bold);
            listViewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(ProgressMax == null ? BackColor : ProgressMax.Color);
            listViewItem.ImageIndex = application.ImageIndex;
            listViewItem.Tag = application.Id;
            listViewItem.Text = application.TitleNoText;

            listViewItem.SubItems[1].Text = application.ReferenceCode;
            listViewItem.SubItems[2].Tag = application.PriorityMeaning;
            listViewItem.SubItems[2].Text = application.Priority == 0 ? "" : application.Priority.ToString();
            listViewItem.SubItems[3].Tag = application.DatePeriodEnd;
            listViewItem.SubItems[3].Text = application.DatePeriodEnd == null ? "" : ((DateTime)application.DatePeriodEnd).ToString(Properties.Settings.Default.DateFormat);
            listViewItem.SubItems[4].Text = ProgressMax == null ? "" : ProgressMax.TitleNoText;
            listViewItem.SubItems[5].Tag = ProgressMax?.Date;
            listViewItem.SubItems[5].Text = ProgressMax == null ? "" : ProgressMax.DateFormated;
            listViewItem.SubItems[6].Text = NextReminder == null ? "" : NextReminder.TitleNoText;
            listViewItem.SubItems[7].Tag = NextReminder?.Date;
            listViewItem.SubItems[7].Text = NextReminder == null ? "" : NextReminder.DateFormated;
            listViewItem.SubItems[8].Tag = application.DateCreated;
            listViewItem.SubItems[8].Text = application.DateCreated == null ? "" : ((DateTime)application.DateCreated).ToString(Properties.Settings.Default.DateFormat);
            listViewItem.SubItems[9].Tag = application.Id;
            listViewItem.SubItems[9].Text = application.Id.ToString();
        }

        /// <summary>
        /// Update the defined Company ListViewItem
        /// </summary>
        /// <param name="company">CompanyItem to get Data from</param>
        /// <param name="listViewItem">ListViewItem to Update</param>
        private void UpdateListViewItemComp(CompanyItem company, ListViewItem listViewItem)
        {
            ReminderItem NextReminder = company.ReminderNext;
            ProgressItem StateWeightetMax = company.ProgressWeightetMax;

            listViewItem.BackColor = StateWeightetMax == null ? Color.Empty : StateWeightetMax.Color;
            listViewItem.Font = company.ReminderNext == null ? listViewItem.Font : new Font(listViewItem.Font, listViewItem.Font.Style | FontStyle.Bold);
            listViewItem.Font = !company.Terminated ? listViewItem.Font : new Font(listViewItem.Font, listViewItem.Font.Style | FontStyle.Strikeout);
            listViewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(StateWeightetMax == null ? BackColor : StateWeightetMax.Color);
            listViewItem.ImageIndex = company.ColorMarker;
            listViewItem.Tag = company.Id;
            listViewItem.Text = company.TitleNoText;

            listViewItem.SubItems[1].Text = company.AdressCity;
            listViewItem.SubItems[2].Text = company.AdressCountry;
            listViewItem.SubItems[3].Text = company.Trade;
            listViewItem.SubItems[4].Tag = company.PriorityMax == 0 ? int.MaxValue : company.PriorityMax;
            listViewItem.SubItems[4].Text = company.PriorityMax == 0 ? "" : company.PriorityMax.ToString();
            listViewItem.SubItems[5].Text = StateWeightetMax == null ? "" : StateWeightetMax.TitleNoText;
            listViewItem.SubItems[6].Tag = StateWeightetMax?.Date;
            listViewItem.SubItems[6].Text = StateWeightetMax == null ? "" : StateWeightetMax.DateFormated;
            listViewItem.SubItems[7].Text = NextReminder == null ? "" : NextReminder.TitleNoText;
            listViewItem.SubItems[8].Tag = NextReminder?.Date;
            listViewItem.SubItems[8].Text = NextReminder == null ? "" : NextReminder.DateFormated;
            listViewItem.SubItems[9].Text = company.Comment;
            listViewItem.SubItems[10].Tag = company.Applications.Count;
            listViewItem.SubItems[10].Text = company.Applications.Count <= 0 ? "" : company.Applications.Count.ToString();
            listViewItem.SubItems[11].Tag = company.Id;
            listViewItem.SubItems[11].Text = company.Id.ToString();
        }

        #region Events
        private void project_ProjectChanged(object sender, EventArgs e)
        {
            FormInv.Text(this, this.Project.ProjectTitle + (this.Project.Changed ? "*" : ""));
            this.prgApplication.Refresh();
            this.prgCompany.Refresh();
        }

        #region Controels
        private void chkQuickFilterCompanyAppProgressMode_CheckStateChanged(object sender, EventArgs e)
        {
            this.uscQuickFilterCompanyAppProgress.Enabled = this.chkQuickFilterCompanyAppProgressMode.CheckState != CheckState.Indeterminate;
        }

        private void lsvApplication_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this._systemChanged) return;
            this.Project.Settings.LsvAppOrder = new List<int> { this.lsvApplication.Sorter.SortColumn, (int)this.lsvApplication.Sorter.Order };
        }

        private void lsvApplication_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (this._systemChanged) return;
            this.Project.Settings.LsvAppWidth = this.lsvApplication.ColumnWidths;
        }

        private void lsvApplication_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.mnuProjectForm_Application_Edit_Click(sender, e);
        }

        private void lsvApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prgApplication.SelectedObject = this.lsvApplication.SelectedItems.Count == 1 ? this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)this.lsvApplication.SelectedItems[0].Tag] : null;

            if (this.lsvApplication.SelectedItems.Count == 1)
            {
                this.btnApplicationDelete.Enabled = true;
                this.btnApplicationDuplicate.Enabled = true;
                this.btnApplicationEdit.Enabled = true;
                this.btnApplicationGoToDir.Enabled = true;
                this.btnApplicationReport.Enabled = true;

                this.mnuProjectForm_Application_Delete.Enabled = true;
                this.mnuProjectForm_Application_Duplicate.Enabled = true;
                this.mnuProjectForm_Application_Edit.Enabled = true;
                this.mnuProjectForm_Application_GoToDir.Enabled = true;
                this.mnuProjectForm_Application_Report.Enabled = true;
            }
            else
            {
                this.btnApplicationDelete.Enabled = this.lsvApplication.SelectedItems.Count > 0;
                this.btnApplicationDuplicate.Enabled = false;
                this.btnApplicationEdit.Enabled = false;
                this.btnApplicationGoToDir.Enabled = false;
                this.btnApplicationReport.Enabled = false;

                this.mnuProjectForm_Application_Delete.Enabled = this.lsvApplication.SelectedItems.Count > 0;
                this.mnuProjectForm_Application_Duplicate.Enabled = false;
                this.mnuProjectForm_Application_Edit.Enabled = false;
                this.mnuProjectForm_Application_GoToDir.Enabled = false;
                this.mnuProjectForm_Application_Report.Enabled = false;
            }

            this.ListViewIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void lsvCompany_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this._systemChanged) return;
            this.Project.Settings.LsvCmpOrder = new List<int> { this.lsvCompany.Sorter.SortColumn, (int)this.lsvCompany.Sorter.Order };
        }

        private void lsvCompany_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (this._systemChanged) return;
            this.Project.Settings.LsvCmpWidth = this.lsvCompany.ColumnWidths;
        }

        private void lsvCompany_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.mnuProjectForm_Company_Edit_Click(sender, e);
        }

        private void lsvCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prgCompany.SelectedObject = this.lsvCompany.SelectedItems.Count == 1 ? this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag] : null;

            this.lsvCompany.BeginUpdate();
            this.lsvApplication.Items.Clear();
            if (this.lsvCompany.SelectedItems.Count == 1)
            {
                CompanyItem SelCompany = this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag];
                foreach (ApplicationItem ApplicationItem in SelCompany.Applications.Values.OrderBy(o => o.DateCreated))
                {
                    if (ApplicationItem.Delete == ItemBase.DeleteFlag.None)
                    {
                        ListViewItem NewItem = new ListViewItem();
                        this.lsvApplication.FillUpSubItems(NewItem);
                        this.UpdateListViewItemAppl(ApplicationItem, NewItem);
                        this.lsvApplication.Items.Add(NewItem);
                    }
                }

                this.btnCompanyAdressToClipboard.Enabled = true;
                this.btnCompanyDelete.Enabled = true;
                this.btnCompanyEdit.Enabled = true;
                this.btnCompanyGoToDir.Enabled = true;
                this.btnCompanyGoToCareerpage.Enabled = Validation.IsValidUri(SelCompany.ContactCareerPage);
                this.btnCompanyGoToHomepage.Enabled = Validation.IsValidUri(SelCompany.ContactHomepage);
                this.btnCompanyReport.Enabled = true;

                this.mnuProjectForm_Application_Add.Enabled = true;
                this.mnuProjectForm_Company_Delete.Enabled = true;
                this.mnuProjectForm_Company_Edit.Enabled = true;
                this.mnuProjectForm_Company_GoToDir.Enabled = true;
                this.mnuProjectForm_Company_Report.Enabled = true;

                this.spcMain.Panel2.Enabled = true;
            }
            else
            {
                this.btnCompanyAdressToClipboard.Enabled = false;
                this.btnCompanyDelete.Enabled = this.lsvCompany.SelectedItems.Count > 0;
                this.btnCompanyEdit.Enabled = false;
                this.btnCompanyGoToDir.Enabled = false;
                this.btnCompanyGoToCareerpage.Enabled = false;
                this.btnCompanyGoToHomepage.Enabled = false;
                this.btnCompanyReport.Enabled = false;

                this.mnuProjectForm_Application_Add.Enabled = false;
                this.mnuProjectForm_Company_Delete.Enabled = this.lsvCompany.SelectedItems.Count > 0;
                this.mnuProjectForm_Company_Edit.Enabled = false;
                this.mnuProjectForm_Company_GoToDir.Enabled = false;
                this.mnuProjectForm_Company_Report.Enabled = false;

                this.spcMain.Panel2.Enabled = false;
            }

            this.lsvApplication.Sort(this.Project.Settings.LsvAppOrder);
            this.lsvApplication_SelectedIndexChanged(sender, e);
            this.lsvCompany.EndUpdate();
        }

        private void prgApplication_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.lsvApplication.SelectedItems.Count == 1) this.UpdateListViewItemAppl((ApplicationItem)this.prgApplication.SelectedObject, this.lsvApplication.SelectedItems[0]);
        }

        private void prgCompany_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count == 1)
            {
                CompanyItem SelCompany = (CompanyItem)this.prgCompany.SelectedObject;
                this.UpdateListViewItemComp(SelCompany, this.lsvCompany.SelectedItems[0]);
                this.btnCompanyGoToCareerpage.Enabled = Validation.IsValidUri(SelCompany.ContactCareerPage);
                this.btnCompanyGoToHomepage.Enabled = Validation.IsValidUri(SelCompany.ContactHomepage);
            }
        }

        private void spcCompany_SplitterMoved(object sender, SplitterEventArgs e)
        {
            try
            {
                this.spcApplication.SplitterDistance = this.spcCompany.SplitterDistance;
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void spcApplication_SplitterMoved(object sender, SplitterEventArgs e)
        {
            try
            {
                this.spcCompany.SplitterDistance = this.spcApplication.SplitterDistance;
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }
        #endregion

        #region Menue and Buttons
        private void btnFilterReset_Click(object sender, EventArgs e)
        {
            this._systemChanged = true;
            this._systemChanged = false;
        }

        private void btnCompanyAdressToClipboard_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;
            Clipboard.SetText(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].AdressFieldSum);
        }

        private void btnCompanyGoToCareerpage_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;

            try
            {
                if (Validation.IsValidUri(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].ContactCareerPage, out Uri Uri)) System.Diagnostics.Process.Start(Uri.ToString());
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void btnCompanyGoToHomepage_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;
            try
            {

                if (Validation.IsValidUri(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].ContactHomepage, out Uri Uri)) System.Diagnostics.Process.Start(Uri.ToString());
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void FilterItem_Changed(object sender, EventArgs e)
        {
            if (this._systemChanged) return;
            List<int> CompanyFilteredList = this.ComapnyFastFilter();

            this.Project.Settings.QuickFilterCompanyAppProgress = this.uscQuickFilterCompanyAppProgress.SelectedProgress.Weight;
            this.Project.Settings.QuickFilterCompanyAppProgressMode = this.chkQuickFilterCompanyAppProgressMode.CheckState;
            this.Project.Settings.QuickFilterCompanyCity = this.cboQuickFilterCompanyCity.Text;
            this.Project.Settings.QuickFilterCompanyId = (int)this.nudQuickFilterCompanyId.Value;
            this.Project.Settings.QuickFilterCompanyTerminated = this.chkQuickFilterCompanyTerminated.CheckState;
            this.Project.Settings.QuickFilterCompanyTitle = this.txtQuickFilterCompanyTitle.Text;
            this.Project.Settings.QuickFilterCompanyTrade = this.cboQuickFilterCompanyTrade.Text;

            this.FillListViewCompany(CompanyFilteredList);
        }

        internal void mnuProjectForm_Application_Add_Click(object sender, EventArgs e)
        {
            CompanyItem CompSel = this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag];
            int NewId = this.Project.IdSet.GetNextId(this.Project.IdSet.Appl);
            this._applicationEditForm = new ApplicationEditForm(new ApplicationItem(NewId), CompSel, this.Project.IdSet.Clone(), this.Project);
            this._applicationEditForm.ItemChanged += new EventHandler(this.applicationEditForm_ApplicationChanged);

            if (this._applicationEditForm.ShowDialog(this) == DialogResult.OK)
            {
                CompSel.Applications.Add(NewId, this._applicationEditForm.Application);
                this._applicationEditForm.Application.ItemChanged += new EventHandler(CompSel.Item_Changed);
                this.Project.IdSet.Appl = NewId;

                ListViewItem NewItem = new ListViewItem();
                this.lsvApplication.FillUpSubItems(NewItem);
                this.UpdateListViewItemAppl(this._applicationEditForm.Application, NewItem);
                this.lsvApplication.Items.Add(NewItem);
                this.lsvApplication.SelectItemByIdTag(NewId);
                this.lsvApplication.LastItemVisible();

                this.Project.Changed = true;
            }
        }

        private void mnuProjectForm_Application_AutoArchive_Click(object sender, EventArgs e)
        {
            ApplicationAutoArchive AutoArchiveForm = new ApplicationAutoArchive(this, this.Project);
            AutoArchiveForm.ShowDialog(this);
            foreach (ListViewItem CompItem in this.lsvCompany.Items)
            {
                this.UpdateListViewItemComp(this.Project.Companies[(int)CompItem.Tag], CompItem);
            }
            if (this.lsvCompany.SelectedItems.Count > 0)
            {
                foreach (ListViewItem ApplItem in this.lsvApplication.Items)
                {
                    this.UpdateListViewItemAppl(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)ApplItem.Tag], ApplItem);
                }
            }
        }

        internal void mnuProjectForm_Application_Delete_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1 || this.lsvApplication.SelectedItems.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0040m, Stringtable._0x0040c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            ItemBase.DeleteFlag DeleteFlag;
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteDirectory;
                    break;
                case DialogResult.No:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteOnlyEntry;
                    break;
                default:
                    return;
            }
            foreach (ListViewItem ApplicationItem in this.lsvApplication.SelectedItems)
            {
                this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)ApplicationItem.Tag].Delete = DeleteFlag;
                ApplicationItem.Remove();
            }
            this.UpdateListViewItemComp(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag], this.lsvCompany.SelectedItems[0]);
            this.Project.Changed = true;
        }

        private void mnuProjectForm_Application_Duplicate_Click(object sender, EventArgs e)
        {
            if (this.lsvApplication.SelectedItems.Count != 1) return;
            CompanyItem CompSel = this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag];
            int NewId = this.Project.IdSet.GetNextId(this.Project.IdSet.Appl);
            ApplicationItem ApplCopy = CompSel.Applications[(int)this.lsvApplication.SelectedItems[0].Tag].Clone();
            ApplCopy.Id = NewId;
            CompSel.Applications.Add(NewId, ApplCopy);
            ApplCopy.ItemChanged += new EventHandler(CompSel.Item_Changed);
            this.Project.IdSet.Appl = NewId;

            this.lsvCompany_SelectedIndexChanged(sender, EventArgs.Empty);
        }

        internal void mnuProjectForm_Application_Edit_Click(object sender, EventArgs e)
        {
            if (this.lsvApplication.SelectedItems.Count != 1) return;
            CompanyItem CompSel = this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag];
            this._applicationEditForm = new ApplicationEditForm(CompSel.Applications[(int)this.lsvApplication.SelectedItems[0].Tag].Clone(), CompSel, this.Project.IdSet.Clone(), this.Project);
            this._applicationEditForm.ItemChanged += new EventHandler(this.applicationEditForm_ApplicationChanged);
            this._applicationEditForm.ShowDialog(this);
        }

        internal void mnuProjectForm_Application_Filter_Click(object sender, EventArgs e)
        {
            this.mnuProjectForm_List_Application_Click(sender, e);
        }

        private void mnuProjectForm_Application_GoToDir_Click(object sender, EventArgs e)
        {
            if (this.lsvApplication.SelectedItems.Count != 1) return;
            this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)this.lsvApplication.SelectedItems[0].Tag].OpenDirectory(this, this.Project, this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag]);
        }

        private void mnuProjectForm_Application_Report_Click(object sender, EventArgs e)
        {
            if (this.lsvApplication.SelectedItems.Count != 1) return;
            Reporter.Application.Create(this, this.Project, (int)this.lsvCompany.SelectedItems[0].Tag, (int)this.lsvApplication.SelectedItems[0].Tag);
        }

        internal void mnuProjectForm_Company_Add_Click(object sender, EventArgs e)
        {
            int NewId = this.Project.IdSet.GetNextId(this.Project.IdSet.Comp);
            this._companyEditForm = new CompanyEditForm(new CompanyItem(NewId), this.Project.IdSet.Clone(), this.Project);
            this._companyEditForm.ItemChanged += new EventHandler(this.companyEditForm_CompanyChanged);

            if (this._companyEditForm.ShowDialog(this) == DialogResult.OK)
            {
                this.Project.Companies.Add(NewId, this._companyEditForm.Company);
                this._companyEditForm.Company.ItemChanged += new EventHandler(this.Project.Item_Changed);
                this.Project.IdSet.Comp = NewId;

                ListViewItem NewItem = new ListViewItem();
                this.lsvCompany.FillUpSubItems(NewItem);
                this.UpdateListViewItemComp(this._companyEditForm.Company, NewItem);
                this.lsvCompany.Items.Add(NewItem);
                this.lsvCompany.SelectItemByIdTag(NewId);
                this.lsvCompany.LastItemVisible();

                this.Project.Changed = true;
            }
        }

        internal void mnuProjectForm_Company_Delete_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x000Fm, Stringtable._0x000Fc, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            ItemBase.DeleteFlag DeleteFlag;
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteDirectory;
                    break;
                case DialogResult.No:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteOnlyEntry;
                    break;
                default:
                    return;
            }
            foreach (ListViewItem CompanyItem in this.lsvCompany.SelectedItems)
            {
                this.Project.Companies[(int)CompanyItem.Tag].Delete = DeleteFlag;
                CompanyItem.Remove();
            }
            this.Project.Changed = true;
        }

        internal void mnuProjectForm_Company_Edit_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;
            this._companyEditForm = new CompanyEditForm(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Clone(), this.Project.IdSet.Clone(), this.Project);
            this._companyEditForm.ItemChanged += new EventHandler(this.companyEditForm_CompanyChanged);
            this._companyEditForm.ShowDialog(this);
        }

        private void mnuProjectForm_Company_Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveFileDialog = new SaveFileDialog
            {
                DefaultExt = Settings_AppConst.Default.CompanyExportFile_DefaultExtension,
                Filter = Settings_AppConst.Default.CompanyExportFile_FilterList,
                FilterIndex = Settings_AppConst.Default.CompanyExportFile_FilterIndex,
                InitialDirectory = Properties.Settings.Default.DirectoryFile_DefaultPath,
                SupportMultiDottedExtensions = true
            };
            if (SaveFileDialog.ShowDialog(this) != DialogResult.OK) return;

            switch (new FileInfo(SaveFileDialog.FileName).Extension.ToLower())
            {
                case ".csv":
                    this._companyExportForm = new CompanyExportForm(this.lsvCompany.Items, this.lsvCompany.SelectedItems, CompanyExportForm.FormMode.ExportCSV, this.Project, SaveFileDialog.FileName);
                    this._companyExportForm.ShowDialog(this);
                    break;
                case ".xml":
                    this._companyExportForm = new CompanyExportForm(this.lsvCompany.Items, this.lsvCompany.SelectedItems, CompanyExportForm.FormMode.ExportXML, this.Project, SaveFileDialog.FileName);
                    this._companyExportForm.ShowDialog(this);
                    break;
                default:
                    return;
            }
        }

        internal void mnuProjectForm_Company_Filter_Click(object sender, EventArgs e)
        {
            this._companySearchForm = new CompanySearchForm(this.Project);
            this._companySearchForm.RequestListResults += new EventHandler(this.filterCompanyForm_RequestListResults);
            this._companySearchForm.Show(this);
        }

        private void mnuProjectForm_Company_Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                DefaultExt = Settings_AppConst.Default.CompanyExportFile_DefaultExtension,
                Filter = Settings_AppConst.Default.CompanyExportFile_FilterList,
                FilterIndex = Settings_AppConst.Default.CompanyExportFile_FilterIndex,
                InitialDirectory = Properties.Settings.Default.DirectoryFile_DefaultPath,
                SupportMultiDottedExtensions = true
            };
            if (OpenFileDialog.ShowDialog(this) != DialogResult.OK) return;

            switch (new FileInfo(OpenFileDialog.FileName).Extension.ToLower())
            {
                case ".csv":
                    this._companyImportForm = new CompanyImportForm(CompanyImportForm.FormMode.ImportCSV, this.Project, OpenFileDialog.FileName);
                    this._companyImportForm.ShowDialog(this);
                    break;
                case ".xml":
                    this._companyImportForm = new CompanyImportForm(CompanyImportForm.FormMode.ImportXML, this.Project, OpenFileDialog.FileName);
                    //this._companyImportForm.ShowDialog(this);
                    break;
                default:
                    return;
            }
            this.FillListViewCompany(null);
        }

        private void filterCompanyForm_RequestListResults(object sender, EventArgs e)
        {
            if (this._companySearchForm == null) return;
            this.FillListViewCompany(this._companySearchForm.CompanyFilteredList);
        }

        private void mnuProjectForm_Company_GoToDir_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;
            this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].OpenDirectory(this, this.Project);
        }

        private void mnuProjectForm_Company_Report_Click(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1) return;
            Reporter.Company.Create(this, this.Project, (int)this.lsvCompany.SelectedItems[0].Tag);
        }

        private void mnuProjectForm_List_Application_Click(object sender, EventArgs e)
        {
            if (this._searchFormApplication != null && this._searchFormApplication.Visible) return;
            this.FillListViewCompany(null);
            this._searchFormApplication = new ApplicationSearchForm(this);
            this._searchFormApplication.Show(this);
        }

        private void mnuProjectForm_List_Reminder_Click(object sender, EventArgs e)
        {
            if (this._searchFormReminder != null && this._searchFormReminder.Visible) return;
            this.FillListViewCompany(null);
            this._searchFormReminder = new ReminderSearchForm(this, false);
            this._searchFormReminder.Show(this);
        }
        #endregion

        #region Form
        /// <summary>
        /// Close the defined Form
        /// </summary>
        /// <param name="formToClose">Form to close</param>
        private void CloseSubForm(Form formToClose)
        {
            try
            {
                if (formToClose != null && !formToClose.IsDisposed) formToClose.Close();
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }

        private void ProjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Project.Changed)
            {
                string ProjectPath = this.Project.File == null ? Stringtable._0x0009 : this.Project.File.FullName;
                DialogResult DialogResult = MessageBox.Show(string.Format(Stringtable._0x002Fm, new object[] { ProjectPath }), Stringtable._0x002Fc, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                // Cancel Closing
                if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                // Save Changes
                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    if (!this.Project.Save())
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }

            this.ProjectForm_Leave(sender, e);
        }

        private void ProjectForm_Shown(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.WindowState = FormWindowState.Maximized;
            }
            this._systemChanged = false;

            //Search for relvant Reminders
            if (this.Project.Settings.CheckRemindersOnOpen && this.Project.HasRemindersToAknowledge)
            {
                if (MessageBox.Show(this, Stringtable._0x002Em, Stringtable._0x002Ec, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (this._searchFormReminder != null && this._searchFormReminder.Visible) return;
                    this.FillListViewCompany(null);
                    this._searchFormReminder = new ReminderSearchForm(this, true);
                    this._searchFormReminder.Show(this);
                }
            }
        }

        private void ProjectForm_Leave(object sender, EventArgs e)
        {
            this.CloseSubForm(this._searchFormApplication);
            this.CloseSubForm(this._companySearchForm);
            this.CloseSubForm(this._searchFormReminder);
        }

        private void applicationEditForm_ApplicationChanged(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1 || this.lsvApplication.SelectedItems.Count != 1 || this._applicationEditForm.Application.NewItemState == ItemBase.NewItemStateFlag.NewInitial) return;
            this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)this.lsvApplication.SelectedItems[0].Tag] = this._applicationEditForm.Application;
            this.Project.IdSet = this._applicationEditForm.IdSet;
            this.UpdateListViewItemComp(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag], this.lsvCompany.SelectedItems[0]);
            this.UpdateListViewItemAppl(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag].Applications[(int)this.lsvApplication.SelectedItems[0].Tag], this.lsvApplication.SelectedItems[0]);
        }

        private void companyEditForm_CompanyChanged(object sender, EventArgs e)
        {
            if (this.lsvCompany.SelectedItems.Count != 1 || this._companyEditForm.Company.NewItemState == ItemBase.NewItemStateFlag.NewInitial) return;
            this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag] = this._companyEditForm.Company;
            this.Project.IdSet = this._companyEditForm.IdSet;
            this.UpdateListViewItemComp(this.Project.Companies[(int)this.lsvCompany.SelectedItems[0].Tag], this.lsvCompany.SelectedItems[0]);
        }
        #endregion
        #endregion
        #endregion
    }
}