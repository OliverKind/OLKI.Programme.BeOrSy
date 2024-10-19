/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to show exception while renaming Company and Application direcotrys
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

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to show exception while renaming Company and Application direcotrys
    /// </summary>
    public partial class RenameDirectoryExceptions : Form
    {
        #region Methods
        /// <summary>
        /// Initial a new Form to show exception while renaming Company and Application direcotrys
        /// </summary>
        /// <param name="exceptions"></param>
        public RenameDirectoryExceptions(List<ProjectSettingsForm.RenameException> exceptions)
        {
            InitializeComponent();
            this.lsvRenameExceptions_SelectedIndexChanged(this, EventArgs.Empty);

            this.lsvRenameExceptions.Items.Clear();
            foreach (ProjectSettingsForm.RenameException ExItem in exceptions)
            {
                ListViewItem NewItem = new ListViewItem();
                this.lsvRenameExceptions.FillUpSubItems(NewItem);
                NewItem.ImageIndex = ExItem.IsAppDir ? 1 : 0;
                NewItem.Tag = ExItem;
                NewItem.Text = ExItem.SrcPath == null ? "" : ExItem.SrcPath.FullName;
                NewItem.SubItems[1].Text = ExItem.DestPath == null ? "" : ExItem.DestPath.FullName;
                NewItem.SubItems[2].Text = ExItem.Exception.Message;
                this.lsvRenameExceptions.Items.Add(NewItem);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDestPathGoTo_Click(object sender, EventArgs e)
        {
            if (this.lsvRenameExceptions.SelectedItems.Count != 1) return;
            System.IO.DirectoryInfo DestPath = ((ProjectSettingsForm.RenameException)this.lsvRenameExceptions.SelectedItems[0].Tag).SrcPath;
            if (DestPath != null) Toolbox.DirectoryAndFile.Directory.Open(DestPath.FullName, false);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSrcPathGoTo_Click(object sender, EventArgs e)
        {
            if (this.lsvRenameExceptions.SelectedItems.Count != 1) return;
            System.IO.DirectoryInfo SrcPath = ((ProjectSettingsForm.RenameException)this.lsvRenameExceptions.SelectedItems[0].Tag).SrcPath;
            if (SrcPath != null) Toolbox.DirectoryAndFile.Directory.Open(SrcPath.FullName, false);
        }

        private void lsvRenameExceptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvRenameExceptions.SelectedItems.Count != 1)
            {
                this.btnDestPathGoTo.Enabled = false;
                this.btnSrcPathGoTo.Enabled = false;
                this.txtDestPath.Text = "";
                this.txtException.Text = "";
                this.txtSrcPath.Text = "";
                return;
            }

            ProjectSettingsForm.RenameException ExItem = (ProjectSettingsForm.RenameException)this.lsvRenameExceptions.SelectedItems[0].Tag;

            this.btnDestPathGoTo.Enabled = ExItem.DestPath != null && !string.IsNullOrEmpty(ExItem.DestPath.FullName);
            this.btnSrcPathGoTo.Enabled = ExItem.SrcPath != null && !string.IsNullOrEmpty(ExItem.SrcPath.FullName);
            this.txtDestPath.Text = ExItem.DestPath != null ? ExItem.DestPath.FullName : "";
            this.txtException.Text = ExItem.Exception.Message;
            this.txtSrcPath.Text = ExItem.SrcPath != null ? ExItem.SrcPath.FullName : "";
        }
        #endregion
    }
}