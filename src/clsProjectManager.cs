/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Class that provide tools to manage the project
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
using OLKI.Programme.BeOrSy.src.Forms.MainForm;
using OLKI.Programme.BeOrSy.src.Forms.Project;
using System;
using System.IO;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src
{
    /// <summary>
    /// Class that provide tools to manage the project
    /// </summary>
    internal class ProjectManager
    {
        #region Constants
        /// <summary>
        /// Extension for the temporary file, while savein a project to a file
        /// </summary>
        private const string TEMP_FILE_EXTENSION = ".~";
        /// <summary>
        /// The max lengt of the read buffer, to write to a file
        /// </summary>
        private const int WRITE_DATA_BUFFER_LENGTH = 1024;
        #endregion

        #region Events
        /// <summary>
        /// Occurs if the active project was changed, settings or data
        /// </summary>
        internal event EventHandler ActiveProjecChanged;
        /// <summary>
        /// Occurs if a project was open from file or a new project was created
        /// </summary>
        internal event EventHandler ProjecOpenOrNew;
        #endregion

        #region Fields
        /// <summary>
        /// The application main frame to provide direct access to it, withoud using events
        /// </summary>
        private MainForm _mainForm = null;
        #endregion

        #region Properties
        /// <summary>
        /// Get the active project
        /// </summary>
        internal Project.Project ActiveProject { get; set; } = null;
        #endregion

        #region Methodes
        /// <summary>
        /// Initialise a new projectmanager
        /// </summary>
        /// <param name="mainForm">Application MainFrame. Needet to set it disabled and waiting cursor during long running processes</param>
        internal ProjectManager(MainForm mainForm)
        {
            this._mainForm = mainForm;
        }


        /// <summary>
        /// Check if the selected file is already opend
        /// </summary>
        /// <param name="file">File to check if it is opend</param>
        /// <returns>True if the file is opend, otherwiese false</returns>
        private bool FileIsOpen(string file)
        {
            foreach (Form Form in this._mainForm.MdiChildren)
            {
                ProjectForm ProjectForm = ((ProjectForm)Form);
                if (ProjectForm.Project.File != null && ProjectForm.Project.File.FullName == file) return true;
            }
            return false;
        }

        /// <summary>
        /// Creates a new, empty project, force creating a new projectfile
        /// </summary>
        /// <param name="mainForm">Apllication MainForm</param>
        /// <returns>True if a new project was created withoud exceptions</returns>
        internal bool Project_New(MainForm mainForm)
        {
            return this.Project_Open("", true, mainForm);
        }

        /// <summary>
        /// Open a new project with showing the file open dialog
        /// </summary>
        /// <param name="mainForm">Apllication MainForm</param>
        internal bool Project_Open(MainForm mainForm)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog
            {
                DefaultExt = Settings_AppConst.Default.ProjectFile_DefaultExtension,
                Filter = Settings_AppConst.Default.ProjectFile_FilterList,
                FilterIndex = Settings_AppConst.Default.ProjectFile_FilterIndex,
                InitialDirectory = Settings.Default.DirectoryFile_DefaultPath
            };

            DialogResult DialogResult = OpenFileDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                return this.Project_Open(OpenFileDialog.FileName, mainForm);
            }
            return false;
        }
        /// <summary>
        /// Open a new specified project with the specified file or shows the file open dialog file file path ist empth
        /// </summary>
        /// <param name="path">The address of a null-terminated string that specifies the path of the project file to open</param>
        /// <param name="mainForm">Apllication MainForm</param>
        internal bool Project_Open(string path, MainForm mainForm)
        {
            return this.Project_Open(path, false, mainForm);
        }
        /// <summary>
        /// Open a new specified project with the specified file or shows the file open dialog file file path ist empth
        /// </summary>
        /// <param name="path">The address of a null-terminated string that specifies the path of the project file to open</param>
        /// <param name="isNewProject">Specifies that the project to open is a new project and no file path is specified</param>
        /// <param name="mainForm">Apllication MainForm</param>
        private bool Project_Open(string path, bool isNewProject, MainForm mainForm)
        {
            try
            {
                this._mainForm.Enabled = false;
                Cursor.Current = Cursors.WaitCursor;
                Project.Project ProjectToLode = new Project.Project(path);

                // If it ist not an new project that should been loaded, ask for file to open or open the file if path is given
                if (!isNewProject)
                {
                    if (string.IsNullOrEmpty(path))
                    {
                        return this.Project_Open(mainForm);  // Recursive to Project_Open to show the OpenFileDialog
                    }
                    else
                    {
                        if (this.FileIsOpen(path))
                        {
                            MessageBox.Show(Stringtable._0x0008m, Stringtable._0x0008c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        if (!ProjectToLode.FromXElement(File.ReadAllText(path), this._mainForm)) return false;
                    }
                }

                //Final root project to application
                this.ActiveProject = ProjectToLode;
                this.ActiveProject.ProjectChanged += new EventHandler(this.ToggleActiveProjecChanged);

                //Load project form
                if (this.ActiveProject != null)
                {
                    ProjectForm ProjectForm = new ProjectForm(this.ActiveProject)
                    {
                        MdiParent = mainForm
                    };
                    this.ActiveProject.ProjectForm = ProjectForm;
                    ProjectForm.Show();
                    ProjectForm.ListViewIndexChanged += new EventHandler(mainForm.MainForm_MdiChildListViewIndexChanged);
                }

                this.ProjecOpenOrNew?.Invoke(this, EventArgs.Empty);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this._mainForm, string.Format(Stringtable._0x0003m, new object[] { path, ex.Message }), Stringtable._0x0003c, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                this._mainForm.Enabled = true;
                Cursor.Current = Cursors.Arrow;
            }
        }

        /// <summary>
        /// Event handler for an change event in active project and theow the ActiveProjecChanged__Event
        /// </summary>
        private void ToggleActiveProjecChanged(object sender, EventArgs e)
        {
            this.ActiveProjecChanged?.Invoke(sender, e);
        }
        #endregion
    }
}