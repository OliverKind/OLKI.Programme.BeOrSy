/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Form to select Postcodes
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

using OLKI.Programme.BeOrSy.src.PostcodeManger;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.PostcodeManger
{
    /// <summary>
    /// Form to select Postcodes
    /// </summary>
    public partial class PostcodeSelectorForm : Form
    {
        #region Fields
        /// <summary>
        /// Changes are system intern
        /// </summary>
        private readonly bool _systemChanged = false;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the selected Postcode Item
        /// </summary>
        public PostcodeItem SelectedPostcode { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Initial a new Form to select Postcodes
        /// </summary>
        /// <param name="PostcodeList">List with Postcodes</param>
        /// <param name="searchCode">Postcode to search for</param>
        public PostcodeSelectorForm(List<PostcodeItem> PostcodeList, string searchCode)
        {
            InitializeComponent();

            this.lblSelectPostcode.Text = string.Format(this.lblSelectPostcode.Text, new object[] { searchCode });

            this._systemChanged = true;
            this.lsvSelectPostcode.Items.Clear();
            foreach (PostcodeItem PostcodeItem in PostcodeList)
            {
                ListViewItem NewItem = new ListViewItem();
                this.lsvSelectPostcode.FillUpSubItems(NewItem);
                NewItem.Checked = PostcodeItem.CodeActive;
                NewItem.ImageIndex = 0;
                NewItem.Tag = PostcodeItem;
                NewItem.Text = PostcodeItem.CodePostcode;

                NewItem.SubItems[1].Text = PostcodeItem.CodeCity;
                NewItem.SubItems[2].Text = PostcodeItem.CodeState;
                NewItem.SubItems[3].Text = PostcodeItem.CodeNation;

                this.lsvSelectPostcode.Items.Add(NewItem);
            }

            this.lsvSelectPostcode.Sort(Properties.Settings.Default.LsvSelectPostcodeOrder);
            if (!string.IsNullOrEmpty(Properties.Settings.Default.LsvSelectPostcodeWidth)) this.lsvSelectPostcode.ColumnWidths = Properties.Settings.Default.LsvSelectPostcodeWidth.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).Select(s => int.Parse(s)).ToList();
            this._systemChanged = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lsvSelectPostcode_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (this._systemChanged) return;
            Properties.Settings.Default.LsvSelectPostcodeOrder = string.Join(";", new List<int> { this.lsvSelectPostcode.Sorter.SortColumn, (int)this.lsvSelectPostcode.Sorter.Order });
            Properties.Settings.Default.Save();
        }

        private void lsvSelectPostcode_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            if (this._systemChanged) return;
            Properties.Settings.Default.LsvSelectPostcodeWidth = string.Join(";", this.lsvSelectPostcode.ColumnWidths);
            Properties.Settings.Default.Save();
        }

        private void lsvSelectPostcode_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.lsvSelectPostcode.SelectedItems.Count != 1) return;
            this.lsvSelectPostcode_SelectedIndexChanged(sender, e);
            this.btnOk_Click(sender, e);
        }

        private void lsvSelectPostcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvSelectPostcode.SelectedItems.Count != 1) return;
            this.SelectedPostcode = (PostcodeItem)this.lsvSelectPostcode.SelectedItems[0].Tag;
        }
        #endregion
    }
}