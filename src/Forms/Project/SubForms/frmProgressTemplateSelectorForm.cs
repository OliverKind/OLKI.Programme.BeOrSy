/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to get Progress Templates
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

using OLKI.Programme.BeOrSy.src.Project;
using OLKI.Programme.BeOrSy.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    /// <summary>
    /// Form to get Progress Templates
    /// </summary>
    public partial class ProgressTemplateSelectorForm : Form
    {
        #region Properties
        /// <summary>
        /// Reminders for the Editor
        /// </summary>
        private Dictionary<int, ProgressItem> _items = null;
        /// <summary>
        /// Get or set the Reminder for the Editor
        /// </summary>
        public Dictionary<int, ProgressItem> Items
        {
            get => this._items;
            set
            {
                this._items = value;
                this.ListItems();
            }
        }

        /// <summary>
        /// Get or set the selected Template
        /// </summary>
        public ProgressItem SelectedTemplate { get; private set; } = null;
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to get Progress Templates
        /// </summary>
        public ProgressTemplateSelectorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// List Progress Items to ListView
        /// </summary>
        private void ListItems()
        {
            this.lsvProgressTemplates.Items.Clear();
            this.lsvProgressTemplates_SelectedIndexChanged(this, EventArgs.Empty);
            if (this._items == null || this._items.Count == 0) return;

            foreach (ProgressItem ProgressItem in this._items.Values.OrderBy(o => o.Order))
            {
                if (ProgressItem.Delete == ItemBase.DeleteFlag.None)
                {
                    ListViewItem NewItem = new ListViewItem();
                    this.lsvProgressTemplates.FillUpSubItems(NewItem);
                    NewItem.BackColor = ProgressItem.Color;
                    NewItem.ForeColor = Toolbox.ColorAndPicture.Color.IdealTextColor(NewItem.BackColor);
                    NewItem.ImageIndex = (int)ProgressItem.State;
                    NewItem.Tag = ProgressItem.Id;
                    NewItem.Text = ProgressItem.TitleNoText;
                    NewItem.SubItems[1].Text = string.Format("{0} - {1}", new object[] { ProgressItem.Weight, ProgressItem.Weight + Settings_AppConst.Default.ProgressWeightWidth });
                    this.lsvProgressTemplates.Items.Add(NewItem);
                }
            }
            this.lsvProgressTemplates.LastItemVisible();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.lsvProgressTemplates.SelectedItems.Count != 1) return;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProgressTemplateSelector_Shown(object sender, EventArgs e)
        {
            this.lsvProgressTemplates_SelectedIndexChanged(sender, e);
        }

        private void lsvProgressTemplates_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.btnAccept_Click(sender, EventArgs.Empty);
        }

        private void lsvProgressTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAccept.Enabled = this.lsvProgressTemplates.SelectedItems.Count == 1;
            this.SelectedTemplate = null;
            if (this.lsvProgressTemplates.SelectedItems.Count != 1) return;

            this.SelectedTemplate = this.Items[(int)this.lsvProgressTemplates.SelectedItems[0].Tag];
        }
        #endregion
    }
}