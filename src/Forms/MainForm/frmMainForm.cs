/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Main Form of the application
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
using OLKI.Programme.BeOrSy.src.Forms.Project;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using OLKI.Toolbox.Widgets.AboutForm;

namespace OLKI.Programme.BeOrSy.src.Forms.MainForm
{
    /// <summary>
    /// Main Form of the application
    /// </summary>
    public partial class MainForm : Form
    {
        #region Fields
        /// <summary>
        /// Application start up arguments
        /// </summary>
        private readonly string[] _args;

        /// <summary>
        /// Specifies the projectmanager object
        /// </summary>
        private readonly ProjectManager _projectManager = null;
        /// <summary>
        /// Specifies the recent files object
        /// </summary>
        private readonly Toolbox.Common.RecentFiles _recentFiles = new Toolbox.Common.RecentFiles();

        /// <summary>
        /// Original design text for the Statusstrip Application Label
        /// </summary>
        private readonly string _tslApplicat_OrgText;

        /// <summary>
        /// Original design text for the Statusstrip Company Label
        /// </summary>
        private readonly string _tslComapnys_OrgText;

        /// <summary>
        /// Original design text for the Statusstrip Filepath Label
        /// </summary>
        private readonly string _tslFilepath_OrgText;
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new application MainForm
        /// </summary>
        /// <param name="args">Application start up arguments</param>
        internal MainForm(string[] args)
        {
            InitializeComponent();
            this._tslApplicat_OrgText = this.tslApplicat.Text;
            this._tslComapnys_OrgText = this.tslComapnys.Text;
            this._tslFilepath_OrgText = this.tslFilepath.Text;
            this.SetStatusstripLabels((ProjectForm)this.ActiveMdiChild);
            this.SetToolstip((ProjectForm)this.ActiveMdiChild);

            if (Settings_AppVar.Default.MainForm_State != FormWindowState.Minimized) this.WindowState = (FormWindowState)Settings_AppVar.Default.MainForm_State;
            if (Settings_AppVar.Default.MainForm_State == FormWindowState.Normal) this.Size = Settings_AppVar.Default.MainForm_Size;

            this.MainForm_MdiChildActivate(this, EventArgs.Empty);
            this._args = args;
            this.Text = string.Format(this.Text, new object[] { ProductName });

            // Initial ProjectManager
            this._projectManager = new ProjectManager(this);
            this._projectManager.ActiveProjecChanged += new EventHandler(this.ProjectManager_ProjectChanged);
            this._projectManager.ProjecOpenOrNew += new EventHandler(this.ProjectManager_ProjecOpenOrNew);

            // Initial rectent files
            this._recentFiles.MaxLength = Settings.Default.RecentFiles_MaxLength;
            this._recentFiles.Seperator = Settings_AppConst.Default.RecentFiles_Seperator;
            this._recentFiles.SetFromString(Settings_AppVar.Default.RecentFiles_FileList);
            //this.SetRecentFilesSettingsAndMenue(); --> Raisid while loading inital projects
        }

        /// <summary>
        /// Load the inial projects
        /// </summary>
        /// <param name="args">Application start up arguments</param>
        private void LoadInitialProject(string[] args)
        {
            bool OpenByArg = false;
            // Load project file from args
            foreach (string Arg in args)
            {
                if (new FileInfo(Arg).Exists)
                {
                    OpenByArg = true;
                    this._projectManager.Project_Open(Arg, this);
                    break;
                }
            }

            // Load default project file
            if (!OpenByArg && this._projectManager.ActiveProject == null && !string.IsNullOrEmpty(Settings.Default.Startup_DefaultFileOpen))
            {
                this._projectManager.Project_Open(Settings.Default.Startup_DefaultFileOpen, this);
            }

            // Load empty project
            if (!OpenByArg && this._projectManager.ActiveProject == null && Settings.Default.Startup_DefaultLoadEmptyProject)
            {
                this._projectManager.Project_New(this);
            }

            // Raise Events to inital form
            this.ProjectManager_ProjectChanged(this, EventArgs.Empty);
            this.SetRecentFilesSettingsAndMenue();
        }


        /// <summary>
        /// Add a new item to recent file list and sets the menue item
        /// </summary>
        private void SetRecentFilesSettingsAndMenue()
        {
            if (this._projectManager.ActiveProject != null && this._projectManager.ActiveProject.File != null && !string.IsNullOrEmpty(this._projectManager.ActiveProject.File.FullName))
            {
                this._recentFiles.AddToList(this._projectManager.ActiveProject.File.FullName);
                Settings_AppVar.Default.RecentFiles_FileList = this._recentFiles.GetAsString();
                Settings_AppVar.Default.Save();
            }

            this._recentFiles.SetMenueItem(0, this.mnuMain_File_RecentFiles_File0, this.mnuMain_File_RecentFiles, this.mnuMain_File_SepRecentFiles);
            this._recentFiles.SetMenueItem(1, this.mnuMain_File_RecentFiles_File1, this.mnuMain_File_RecentFiles, this.mnuMain_File_SepRecentFiles);
            this._recentFiles.SetMenueItem(2, this.mnuMain_File_RecentFiles_File2, this.mnuMain_File_RecentFiles, this.mnuMain_File_SepRecentFiles);
            this._recentFiles.SetMenueItem(3, this.mnuMain_File_RecentFiles_File3, this.mnuMain_File_RecentFiles, this.mnuMain_File_SepRecentFiles);
        }

        /// <summary>
        /// Set the status strip labels
        /// </summary>
        /// <param name="ActiveMdiChild">The Active MDI-Child</param>
        private void SetStatusstripLabels(ProjectForm ActiveMdiChild)
        {
            if (ActiveMdiChild != null)
            {
                this.tslComapnys.Text = string.Format(this._tslComapnys_OrgText, new object[] { ActiveMdiChild.Project.CountComp });
                this.tslApplicat.Text = string.Format(this._tslApplicat_OrgText, new object[] { ActiveMdiChild.Project.CountAppl });
                this.tslFilepath.Text = string.Format(this._tslFilepath_OrgText, new object[] { ActiveMdiChild.Project.File != null && !string.IsNullOrEmpty(ActiveMdiChild.Project.File.FullName) ? ActiveMdiChild.Project.File.FullName : "-" });

                this.tslFilepath.Enabled = ActiveMdiChild.Project.File != null && !string.IsNullOrEmpty(ActiveMdiChild.Project.File.FullName);
                this.tslFileDefS.Enabled = ActiveMdiChild.Project.File != null && !string.IsNullOrEmpty(ActiveMdiChild.Project.File.FullName);
            }
            else
            {
                this.tslComapnys.Text = string.Format(this._tslComapnys_OrgText, new object[] { "-" });
                this.tslApplicat.Text = string.Format(this._tslApplicat_OrgText, new object[] { "-" });
                this.tslFilepath.Text = string.Format(this._tslFilepath_OrgText, new object[] { "-" });

                this.tslFilepath.Enabled = false;
                this.tslFileDefS.Enabled = false;
            }
        }

        /// <summary>
        /// Set the Toolstrip
        /// </summary>
        private void SetToolstip(ProjectForm ActiveMdiChild)
        {
            if (ActiveMdiChild != null)
            {
                this.tolMain_Save.Enabled = true;

                tolMain_Application.Enabled = true;
                tolMain_Application_Add.Enabled = true;
                tolMain_Application_Delete.Enabled = ActiveMdiChild.lsvCompany.SelectedItems.Count == 1 && ActiveMdiChild.lsvApplication.SelectedItems.Count == 1;
                tolMain_Application_Edit.Enabled = ActiveMdiChild.lsvCompany.SelectedItems.Count == 1 && ActiveMdiChild.lsvApplication.SelectedItems.Count == 1;
                tolMain_Application_Filter.Enabled = true;

                tolMain_Company.Enabled = true;
                tolMain_Company_Add.Enabled = true;
                tolMain_Company_Delete.Enabled = ActiveMdiChild.lsvCompany.SelectedItems.Count == 1;
                tolMain_Company_Edit.Enabled = ActiveMdiChild.lsvCompany.SelectedItems.Count == 1;
                tolMain_Company_Filter.Enabled = true;
            }
            else
            {
                this.tolMain_Save.Enabled = false;

                tolMain_Application.Enabled = false;
                tolMain_Application_Add.Enabled = false;
                tolMain_Application_Delete.Enabled = false;
                tolMain_Application_Edit.Enabled = false;
                tolMain_Application_Filter.Enabled = false;

                tolMain_Company.Enabled = false;
                tolMain_Company_Add.Enabled = false;
                tolMain_Company_Edit.Enabled = false;
                tolMain_Company_Delete.Enabled = false;
                tolMain_Company_Filter.Enabled = false;
            }
        }
        #region Events
        #region Form Events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Delete Temp files
            bool DelError = false;
            foreach (string fileItem in Settings_AppVar.Default.TempFileList.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries))
            {
                try
                {
                    System.IO.File.Delete(fileItem);
                }
                catch (Exception ex)
                {
                    _ = ex;
                    DelError = true;
                }
            }
            if (DelError)
            {
                this.Invoke((Action)delegate { MessageBox.Show(this, Stringtable._0x0021m, Stringtable._0x0021c, MessageBoxButtons.OK, MessageBoxIcon.Error); });
            }
            Settings_AppVar.Default.TempFileList = "";
            Settings_AppVar.Default.Save();
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] Files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            this.LoadInitialProject(Files);
        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.All : DragDropEffects.None;
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            ProjectForm ActiveMdiChild = (ProjectForm)this.ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                this.mnuMain_File_Close.Enabled = true;
                this.mnuMain_File_Save.Enabled = true;
                this.mnuMain_File_SaveAs.Enabled = true;

                this._projectManager.ActiveProject = ActiveMdiChild.Project;
            }
            else
            {
                this.mnuMain_File_Close.Enabled = false;
                this.mnuMain_File_Save.Enabled = false;
                this.mnuMain_File_SaveAs.Enabled = false;

                if (this._projectManager != null) this._projectManager.ActiveProject = null;
            }

            this.SetStatusstripLabels(ActiveMdiChild);
            this.SetToolstip(ActiveMdiChild);
        }

        public void MainForm_MdiChildListViewIndexChanged(object sender, EventArgs e)
        {
            this.SetToolstip((ProjectForm)this.ActiveMdiChild);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            // Initial project on startup
            this.LoadInitialProject(this._args);

            // Check for file association
            if (Settings.Default.FileAssociation_CheckOnStartup) Program.CheckFileAssociationAndSet(false);

            // Check for Updates for the Apllication
            if (Settings.Default.AppUpdate_CheckAtStartUp) Program.CheckForUpdate(this, true);
        }
        #endregion

        #region Menu Events
        #region File
        private void mnuMain_File_New_Click(object sender, EventArgs e)
        {
            this._projectManager.Project_New(this);

            // Raise Events to inital form
            this.ProjectManager_ProjectChanged(this, EventArgs.Empty);
        }

        private void mnuMain_File_Open_Click(object sender, EventArgs e)
        {
            if (this._projectManager.Project_Open(this)) this.SetRecentFilesSettingsAndMenue();
        }

        private void mnuMain_File_Close_Click(object sender, EventArgs e)
        {
            if (this._projectManager.ActiveProject == null) return;
            this._projectManager.ActiveProject.Close();
        }

        private void mnuMain_File_Save_Click(object sender, EventArgs e)
        {
            if (this._projectManager.ActiveProject == null) return;
            this._projectManager.ActiveProject.Save();
        }

        private void mnuMain_File_SaveAs_Click(object sender, EventArgs e)
        {
            if (this._projectManager.ActiveProject == null) return;
            if (this._projectManager.ActiveProject.SaveAs()) this.SetRecentFilesSettingsAndMenue();
        }

        private void mnuMain_File_Projectsettings_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ChangeSettings(this);
        }

        private void mnuMain_File_RecentFiles_File0_Click(object sender, EventArgs e)
        {
            this._projectManager.Project_Open(this._recentFiles.FileList[0], this);
        }
        private void mnuMain_File_RecentFiles_File1_Click(object sender, EventArgs e)
        {
            this._projectManager.Project_Open(this._recentFiles.FileList[1], this);
        }
        private void mnuMain_File_RecentFiles_File2_Click(object sender, EventArgs e)
        {
            this._projectManager.Project_Open(this._recentFiles.FileList[2], this);
        }
        private void mnuMain_File_RecentFiles_File3_Click(object sender, EventArgs e)
        {
            this._projectManager.Project_Open(this._recentFiles.FileList[3], this);
        }

        private void mnuMain_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extras
        private void mnuMain_Extras_Options_Click(object sender, EventArgs e)
        {
            SubForms.ApplicationSettingsForm ApplicationSettingsForm = new SubForms.ApplicationSettingsForm();
            if (ApplicationSettingsForm.ShowDialog(this) == DialogResult.OK)
            {
                if (ApplicationSettingsForm.ClearRecentFiles)
                {
                    this._recentFiles.FileList.Clear();
                    this.SetRecentFilesSettingsAndMenue();
                }
            }
        }
        #endregion

        #region Window
        private void mnuMain_Window_Cascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void mnuMain_Window_Horizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void mnuMain_Window_Vertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuMain_Window_Statusbar_Click(object sender, EventArgs e)
        {
            this.stsMain.Visible = this.mnuMain_Window_Statusbar.Checked;
        }
        #endregion

        #region Help
        private void mnuMain_Help_Info_Click(object sender, EventArgs e)
        {
            System.Reflection.Assembly Assembly = System.Reflection.Assembly.GetExecutingAssembly();
            Image AppImage = Resources.program_symbol_256;
            Image ProImage = Resources.project_symbol_256;
            AboutForm AboutForm = new AboutForm(Assembly, AppImage, ProImage)
            {
                Credits = Resources.Credits,
                LicenseDirectory = Path.GetDirectoryName(Assembly.Location) + @"\Licenses\",
                ShowUpdateControles = true,
                UpdateOnStartup = Settings.Default.AppUpdate_CheckAtStartUp
            };
            AboutForm.Show(this);
        }

        private void mnuMain_Help_CheckUpdate_Click(object sender, EventArgs e)
        {
            Program.CheckForUpdate(this, false);
        }
        #endregion
        #endregion

        #region Statusstrip Events
        private void tslFilepath_Click(object sender, EventArgs e)
        {
            if (this._projectManager.ActiveProject != null && this._projectManager.ActiveProject.File != null && !string.IsNullOrEmpty(this._projectManager.ActiveProject.File.FullName))
            {
                System.Diagnostics.Process.Start("explorer.exe", "/e,/select," + this._projectManager.ActiveProject.File.FullName);
            }
        }

        private void tslFilepath_EnabledChanged(object sender, EventArgs e)
        {
            this.tslFilepath.Visible = this.tslFilepath.Enabled;
        }

        private void tslFileDefS_Click(object sender, EventArgs e)
        {
            if (this._projectManager.ActiveProject != null && this._projectManager.ActiveProject.File != null && !string.IsNullOrEmpty(this._projectManager.ActiveProject.File.FullName))
            {
                Settings.Default.Startup_DefaultFileOpen = this._projectManager.ActiveProject.File.FullName;
                Settings.Default.Save();
                MessageBox.Show(string.Format(Stringtable._0x003Bm, new object[] { Settings.Default.Startup_DefaultFileOpen }), Stringtable._0x003Bc, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tslFileDefS_EnabledChanged(object sender, EventArgs e)
        {
            this.tslFileDefS.Visible = this.tslFileDefS.Enabled;
        }
        #endregion

        #region Tollstrip Events
        private void tolMain_Application_Add_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Application_Add_Click(sender, e);
        }

        private void tolMain_Application_Delete_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Application_Delete_Click(sender, e);
        }

        private void tolMain_Application_Edit_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Application_Edit_Click(sender, e);
        }

        private void tolMain_Application_Filter_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Application_Filter_Click(sender, e);
        }

        private void tolMain_Company_Add_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Company_Add_Click(sender, e);
        }

        private void tolMain_Company_Delete_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Company_Delete_Click(sender, e);
        }

        private void tolMain_Company_Edit_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Company_Edit_Click(sender, e);
        }

        private void tolMain_Company_Filter_Click(object sender, EventArgs e)
        {
            this._projectManager.ActiveProject.ProjectForm.mnuProjectForm_Company_Filter_Click(sender, e);
        }

        private void tolMain_New_Click(object sender, EventArgs e)
        {
            this.mnuMain_File_New_Click(sender, e);
        }

        private void tolMain_Open_Click(object sender, EventArgs e)
        {
            this.mnuMain_File_Open_Click(sender, e);
        }

        private void tolMain_Save_Click(object sender, EventArgs e)
        {
            this.mnuMain_File_Save_Click(sender, e);
        }
        #endregion

        #region Projec Events
        private void ProjectManager_ProjectChanged(object sender, EventArgs e)
        {
            this.SetStatusstripLabels((ProjectForm)this.ActiveMdiChild);
        }

        private void ProjectManager_ProjecOpenOrNew(object sender, EventArgs e)
        {
            //Nothing to do at this application
        }
        #endregion
        #endregion
        #endregion
    }
}