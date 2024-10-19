/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Editor Control to edit File attachments
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
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    /// <summary>
    /// Editor Control to edit File attachments
    /// </summary>
    public partial class FilesEditor : UserControl
    {
        #region Events
        /// <summary>
        /// Raised if a Item was added
        /// </summary>
        public event EventHandler ItemAdded;
        #endregion

        #region Fields
        /// <summary>
        /// Open file Dialog Form, for this Editor
        /// </summary>
        private OpenFileDialog _openFileDialog;

        /// <summary>
        /// ToolTip Controle for this Editor
        /// </summary>
        private ToolTip _tolToolTip = new ToolTip();

        /// <summary>
        /// Changes are system intern
        /// </summary>
        private bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// File Items for the Editor
        /// </summary>
        private Dictionary<int, FileItem> _items = null;
        /// <summary>
        /// Get or set the Filte Items for the Editor
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, FileItem> Items
        {
            get => this._items;
            set
            {
                this._items = value;
                this.ListItems();
            }
        }

        /// <summary>
        /// Get or set the IdSet for this Editor
        /// </summary>
        [Browsable(false)]
        public IdSet IdSet { get; set; }

        /// <summary>
        /// Selected File Item
        /// </summary>
        [Browsable(false)]
        public FileItem SelectedItem { get; private set; } = null;
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Editor Control to edit Files
        /// </summary>
        public FilesEditor()
        {
            InitializeComponent();
#if !DEBUG
            this.Width -= this.prgEditor.Width - this.prgEditor.Margin.Left - this.prgEditor.Right - this.grbFileEdit.Margin.Right;
            this.prgEditor.Enabled = false;
            this.prgEditor.Visible = false;
#endif
            this._openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Properties.Settings.Default.DirectoryFile_DefaultPath,
                Multiselect = false
            };

            this._tolToolTip.SetToolTip(this.btnFileGoTo, Stringtable._0x000B);
            this._tolToolTip.SetToolTip(this.btnFileLink, Stringtable._0x000D);
            this._tolToolTip.SetToolTip(this.btnFileUpload, Stringtable._0x000C);
        }

        /// <summary>
        /// Update Controles to handle the File
        /// </summary>
        private void UpdateControles()
        {
            FileItem File = this.SelectedItem == null ? new FileItem(0) : this.SelectedItem;
            switch (File.AttachType)
            {
                case FileItem.FileAttachType.Upload:
                    this.btnFileGoTo.Enabled = true;
                    this.txtFilePath.Text = File.Name;
                    break;
                case FileItem.FileAttachType.Linked:
                    this.btnFileGoTo.Enabled = true;
                    this.txtFilePath.Text = File.Path;
                    break;
                default:
                    this.btnFileGoTo.Enabled = false;
                    this.txtFilePath.Text = "";
                    break;
            }
        }

        #region Manage Files
        /// <summary>
        /// List File Items to ListView
        /// </summary>
        private void ListItems()
        {
            this.lsvItems.Items.Clear();
            this.lsvItems_SelectedIndexChanged(this, EventArgs.Empty);
            if (this._items == null || this._items.Count == 0) return;

            foreach (FileItem FileItem in this._items.Values.OrderBy(o => o.Title))
            {
                if (FileItem.Delete == ItemBase.DeleteFlag.None)
                {
                    //Create empty item and fill up by update procedure
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvItems.FillUpSubItems(NewItem);
                    this.UpdateListViewItem(FileItem, NewItem);
                    this.lsvItems.Items.Add(NewItem);
                }
            }
        }

        /// <summary>
        /// Update the defined File Item in ListView
        /// </summary>
        /// <param name="file">File to update in ListView</param>
        /// <param name="listViewItem">ListViewItem to update</param>
        private void UpdateListViewItem(FileItem file, ListViewItem listViewItem)
        {
            listViewItem.ImageIndex = (int)file.AttachType;
            listViewItem.Tag = file.Id;
            listViewItem.Text = file.TitleNoText;
            listViewItem.SubItems[1].Text = file.Name;
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            int NewId = this.IdSet.GetNextId(this.IdSet.File);
            this.IdSet.File = NewId;
            FileItem NewFile = new FileItem(NewId);
            this.Items.Add(NewId, NewFile);

            ListViewItem NewItem = new ListViewItem();
            this.lsvItems.FillUpSubItems(NewItem);
            this.UpdateListViewItem(NewFile, NewItem);
            this.lsvItems.Items.Add(NewItem);
            this.lsvItems.SelectItemByIdTag(NewId);
            this.lsvItems.LastItemVisible();
            this.ItemAdded?.Invoke(sender, e);
        }

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            if (this.lsvItems.Items.Count == 0) return;

            DialogResult DialogResult = MessageBox.Show(Stringtable._0x0012m, Stringtable._0x0012c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);
            ItemBase.DeleteFlag DeleteFlag;
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    DeleteFlag = ItemBase.DeleteFlag.DeleteDirectory;
                    break;
                default:
                    DeleteFlag = ItemBase.DeleteFlag.None;
                    return;
            }
            foreach (ListViewItem FileItem in this.lsvItems.SelectedItems)
            {
                this.Items[(int)FileItem.Tag].Delete = DeleteFlag;
                FileItem.Remove();
            }
        }

        private void lsvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._systemChanged = true;
            if (this.lsvItems.SelectedItems.Count == 1)
            {
                this.SelectedItem = this.Items[(int)this.lsvItems.SelectedItems[0].Tag];
                this.btnItemDelete.Enabled = true;
                this.grbFileEdit.Enabled = true;
                this.prgEditor.SelectedObject = this.SelectedItem;
                this.txtComment.Text = this.SelectedItem.Comment;
                this.txtFilePath.Text = this.SelectedItem.Path;
                this.txtTitle.Text = this.SelectedItem.Title;
            }
            else
            {
                this.SelectedItem = null;
                this.btnItemDelete.Enabled = this.lsvItems.SelectedItems.Count > 0;
                this.grbFileEdit.Enabled = false;
                this.prgEditor.SelectedObject = null;
                this.txtComment.Text = "";
                this.txtFilePath.Text = "";
                this.txtTitle.Text = "";
            }
            this.UpdateControles();
            this._systemChanged = false;
        }
        #endregion

        #region Edit File
        private void btnFileGoTo_Click(object sender, EventArgs e)
        {
            this.SelectedItem.OpenFile(this);
        }

        private void btnFileLink_Click(object sender, EventArgs e)
        {
            if (this._openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (this.SelectedItem.AttachType != FileItem.FileAttachType.None && MessageBox.Show(this, Stringtable._0x0013m, Stringtable._0x0013c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                this.SelectedItem.FileBase64 = "";
                this.SelectedItem.Name = new System.IO.FileInfo(this._openFileDialog.FileName).Name;
                this.SelectedItem.Path = this._openFileDialog.FileName;

                this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
                this.UpdateControles();
                this.prgEditor.Refresh();
            }
        }

        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            if (this._openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                if (this.SelectedItem.AttachType != FileItem.FileAttachType.None && MessageBox.Show(this, Stringtable._0x0013m, Stringtable._0x0013c, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
                this.SelectedItem.LoadFile(this, this._openFileDialog.FileName);
                this.SelectedItem.Name = new System.IO.FileInfo(this._openFileDialog.FileName).Name;
                this.SelectedItem.Path = "";

                this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
                this.UpdateControles();
                this.prgEditor.Refresh();
            }
        }

        private void prgEditor_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if (this._systemChanged || this.lsvItems.SelectedItems.Count != 1) return;
            this.lsvItems_SelectedIndexChanged(this, EventArgs.Empty);
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
        }

        private void txtComment_TextChanged(object sender, EventArgs e)
        {
            if (this._systemChanged || this.lsvItems.SelectedItems.Count != 1) return;
            this.SelectedItem.Comment = this.txtComment.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            if (this._systemChanged || this.lsvItems.SelectedItems.Count != 1) return;
            this.SelectedItem.Title = this.txtTitle.Text;
            this.UpdateListViewItem(this.SelectedItem, this.lsvItems.SelectedItems[0]);
            this.prgEditor.Refresh();
        }
        #endregion
        #endregion
    }
}