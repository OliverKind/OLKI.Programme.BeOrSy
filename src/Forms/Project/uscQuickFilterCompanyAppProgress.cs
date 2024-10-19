/*
 * BeOrSy - Bewerbungsorganisationssystem
 * 
 * Copyright:   Oliver Kind - 2024
 * License:     LGPL
 * 
 * Desctiption:
 * Controle to select applocatopm Progress items
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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace OLKI.Programme.BeOrSy.src.Forms.Project
{
    /// <summary>
    /// Controle to select applocatopm Progress items
    /// </summary>
    public class QuickFilterCompanyAppProgress : ComboBox
    {
        #region Properties
        /// <summary>
        /// List List with Progress Items
        /// </summary>
        private Dictionary<int, ProgressItem> _progressList = null;
        /// <summary>
        /// Get or seht the List with Progress Items
        /// </summary>
        [Browsable(false)]
        public Dictionary<int, ProgressItem> ProgressList
        {
            set
            {
                this._progressList = value;
                this.Items.Clear();
                if (this._progressList == null) return;
                foreach (KeyValuePair<int, ProgressItem> StateItem in _progressList)
                {
                    this.Items.Add(StateItem.Value.TitleNoText);
                }
            }
        }

        /// <summary>
        /// Get the selected ProgressItem
        /// </summary>
        public ProgressItem SelectedProgress
        {
            get
            {
                if (this.SelectedIndex == -1) return new ProgressItem(0);
                return this._progressList[this.GetIdFromIndex(this.SelectedIndex)];
            }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Initial a new Controle to select applocatopm Progress items
        /// </summary>
        public QuickFilterCompanyAppProgress()
        {
            this.DoubleBuffered = true;
            this.SuspendLayout();
            this.DrawItem += new DrawItemEventHandler(this.uscQuickFilterCompanyAppState_DrawItem);
            this.ResumeLayout(false);
        }

        /// <summary>
        /// Get the ProgressItem-Id from an Item, defined by the ComboBox Index
        /// </summary>
        /// <param name="searchIndex">Intex of the Item to get the ProgressItem-Id from</param>
        /// <returns>ProgressItem-Id of the Item, defined by the ComboBox Index</returns>
        private int GetIdFromIndex(int searchIndex)
        {
            int i = 0;
            foreach (ProgressItem ProgressItem in this._progressList.Values)
            {
                if (i == searchIndex)
                {
                    return ProgressItem.Id;
                }
                i++;
            }
            return 0;
        }

        private void uscQuickFilterCompanyAppState_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (this._progressList == null) return;
            try
            {
                int Key = this.GetIdFromIndex(e.Index);
                if (Key <= 0) return;

                e.DrawBackground();
                // Create a square filled with the stateanimals color.
                Rectangle rectangle = new Rectangle(2, e.Bounds.Top + 2, e.Bounds.Height, e.Bounds.Height - 4);
                e.Graphics.FillRectangle(new SolidBrush(this._progressList[Key].Color), rectangle);
                // Draw each string in the array
                e.Graphics.DrawString(this._progressList[Key].Title, e.Font, Brushes.Black, new RectangleF(e.Bounds.X + rectangle.Width, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));

                // Draw the focus rectangle if the mouse hovers over an item.
                e.DrawFocusRectangle();
            }
            catch (Exception ex)
            {
                _ = ex;
            }
        }
        #endregion
    }
}