/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to auto archive Applications
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
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to auto archive Applications
    /// </summary>
    public partial class ApplicationAutoArchive : Form
    {
        #region Enums
        /// <summary>
        /// Ahto Archive Mode
        /// </summary>
        private enum ArchiveMode
        {
            BeforeDate,
            ProgressDate,
            ProgressNumber
        }
        #endregion

        #region Fields
        /// <summary>
        /// Archive Mode
        /// </summary>
        private ArchiveMode _archiveMode;

        /// <summary>
        /// Project with applications
        /// </summary>
        private readonly src.Project.Project _project;

        /// <summary>
        /// Project Form
        /// </summary>
        private readonly IWin32Window _projectForm;
        #endregion

        #region Methods
        /// <summary>
        /// Form to automatical set archive to Applications
        /// </summary>
        /// <param name="owner">Owner Form for MesssageBox</param>
        /// <param name="project">Project with applications</param>
        public ApplicationAutoArchive(IWin32Window owner, src.Project.Project project)
        {
            InitializeComponent();
            this._project = project;
            this._projectForm = owner;

            Toolbox.Widgets.Tools.ComboBox.SetToFirstIndex(this.cboProgressNumber);
            Toolbox.Widgets.Tools.ComboBox.AutoDropDownWidth(this.cboProgressNumber);

            this.uscQuickFilterCompanyAppProgress.ProgressList = this._project.Settings.ProgressTemplateList;
            Toolbox.Widgets.Tools.ComboBox.SetToFirstIndex(this.uscQuickFilterCompanyAppProgress);

            this.rabBeforeDate_CheckedChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Auto archive Applications with creation Date before threshold
        /// </summary>
        private void AutoArchiveBeforeDate()
        {
            foreach (CompanyItem Comp in this._project.Companies.Values)
            {
                foreach (ApplicationItem Appl in Comp.Applications.Values)
                {
                    if (Appl.DateCreated == null) continue;
                    if (DateTime.Compare((DateTime)Appl.DateCreated, (DateTime)this.mtbBeforeDate.Date) < 0)
                    {
                        Appl.Archive = true;
                    }
                }
            }
        }

        /// <summary>
        /// Auto archive Applications with Progress Date before threshold
        /// </summary>
        private void AutoArchiveProgressDate()
        {
            foreach (CompanyItem Comp in this._project.Companies.Values)
            {
                foreach (ApplicationItem Appl in Comp.Applications.Values)
                {
                    if (Appl.ProgressMax == null) continue;
                    if (Appl.ProgressMax.Date == null) continue;
                    if (DateTime.Compare((DateTime)Appl.ProgressMax.Date, (DateTime)this.mtbBeforeDate.Date) < 0)
                    {
                        Appl.Archive = true;
                    }
                }
            }

        }

        /// <summary>
        /// Auto archive Applications with progess number by threshold
        /// </summary>
        private void AutoArchiveProgressNumber()
        {
            int WeightLimit = this.uscQuickFilterCompanyAppProgress.SelectedProgress.Weight;
            foreach (CompanyItem Comp in this._project.Companies.Values)
            {
                foreach (ApplicationItem Appl in Comp.Applications.Values)
                {
                    if (Appl.ProgressMax == null) continue;

                    if (this.cboProgressNumber.Text == "<" && Appl.ProgressMax.Weight < WeightLimit) Appl.Archive = true;
                    if (this.cboProgressNumber.Text == "<=" && Appl.ProgressMax.Weight <= WeightLimit) Appl.Archive = true;
                    if (this.cboProgressNumber.Text == "=" && Appl.ProgressMax.Weight == WeightLimit) Appl.Archive = true;
                    if (this.cboProgressNumber.Text == "!=" && Appl.ProgressMax.Weight != WeightLimit) Appl.Archive = true;
                    if (this.cboProgressNumber.Text == ">" && Appl.ProgressMax.Weight > WeightLimit) Appl.Archive = true;
                    if (this.cboProgressNumber.Text == ">=" && Appl.ProgressMax.Weight >= WeightLimit) Appl.Archive = true;

                }
            }
        }

        /// <summary>
        /// Set the execute Button to enabled, if inputs are valid.
        /// </summary>
        private void SetExecuteButton()
        {
            switch (this._archiveMode)
            {
                case ArchiveMode.BeforeDate:
                    this.btnExecute.Enabled = this.mtbBeforeDate.IsValidDate && this.mtbBeforeDate.Date != null;
                    break;
                case ArchiveMode.ProgressDate:
                    this.btnExecute.Enabled = this.mtbProgressDate.IsValidDate && this.mtbProgressDate.Date != null;
                    break;
                case ArchiveMode.ProgressNumber:
                    this.btnExecute.Enabled = this.cboProgressNumber.SelectionStart >= 0 && this.uscQuickFilterCompanyAppProgress.SelectionStart >= 0;
                    break;
                default:
                    this.btnExecute.Enabled = false;
                    break;
            }
        }

        #region Form Events
        #region Buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecuteClick(object sender, EventArgs e)
        {
            bool ProjectInstantSave = this._project.Settings.InstantSave;
            this._project.Settings.InstantSave = false;
            try
            {
                switch (this._archiveMode)
                {
                    case ArchiveMode.BeforeDate:
                        this.AutoArchiveBeforeDate();
                        break;
                    case ArchiveMode.ProgressDate:
                        this.AutoArchiveProgressDate();
                        break;
                    case ArchiveMode.ProgressNumber:
                        this.AutoArchiveProgressNumber();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this._projectForm, string.Format(Stringtable._0x0043m, new object[] { ex.Message }), Stringtable._0x0043c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this._project.Settings.InstantSave = ProjectInstantSave;
            }
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            bool ProjectInstantSave = this._project.Settings.InstantSave;
            this._project.Settings.InstantSave = false;
            try
            {
                foreach (CompanyItem Comp in this._project.Companies.Values)
                {
                    foreach (ApplicationItem Appl in Comp.Applications.Values)
                    {
                        Appl.Archive = false;
                    }
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this._projectForm, string.Format(Stringtable._0x0043m, new object[] { ex.Message }), Stringtable._0x0043c, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this._project.Settings.InstantSave = ProjectInstantSave;
                this._project.Changed = true;
            }
        }
        #endregion

        #region Filter set
        private void cboProgressNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetExecuteButton();
        }

        private void mtbBeforeDate_TextChanged(object sender, EventArgs e)
        {
            this.SetExecuteButton();
        }

        private void mtbProgressDate_TextChanged(object sender, EventArgs e)
        {
            this.SetExecuteButton();
        }

        private void uscQuickFilterCompanyAppProgress_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SetExecuteButton();
        }
        #endregion

        #region Mode Select
        private void rabBeforeDate_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rabBeforeDate.Checked) this._archiveMode = ArchiveMode.BeforeDate;
            if (this.rabProgressDate.Checked) this._archiveMode = ArchiveMode.ProgressDate;
            if (this.rabProgressNumber.Checked) this._archiveMode = ArchiveMode.ProgressNumber;

            this.SetExecuteButton();
        }

        private void rabProgressDate_CheckedChanged(object sender, EventArgs e)
        {
            this.rabBeforeDate_CheckedChanged(sender, e);
        }

        private void rabProgressNumber_CheckedChanged(object sender, EventArgs e)
        {
            this.rabBeforeDate_CheckedChanged(sender, e);
        }
        #endregion
        #endregion
        #endregion
    }
}