namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    partial class ProgressEditor
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressEditor));
            this.prgEditor = new System.Windows.Forms.PropertyGrid();
            this.mtbDate = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.lblStateDate = new System.Windows.Forms.Label();
            this.btnShowClassSelector = new System.Windows.Forms.Button();
            this.nudWeight = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblStateTitle = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.imlProgress = new System.Windows.Forms.ImageList(this.components);
            this.chLsvProgresses_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvProgresses_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblStateComment = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.grpProgressEdit = new System.Windows.Forms.GroupBox();
            this.chkProgressFinishedLowPriority = new System.Windows.Forms.CheckBox();
            this.chkProgressFinished = new System.Windows.Forms.CheckBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblWeightActivateOverride = new System.Windows.Forms.LinkLabel();
            this.chkWeight = new System.Windows.Forms.CheckBox();
            this.lsvItems = new OLKI.Toolbox.Widgets.SortListView();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.erpItemsList = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).BeginInit();
            this.grpProgressEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpItemsList)).BeginInit();
            this.SuspendLayout();
            // 
            // prgEditor
            // 
            this.prgEditor.HelpVisible = false;
            this.prgEditor.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgEditor.Location = new System.Drawing.Point(679, 0);
            this.prgEditor.Name = "prgEditor";
            this.prgEditor.Size = new System.Drawing.Size(300, 226);
            this.prgEditor.TabIndex = 4;
            this.prgEditor.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgEditor.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgEditor_PropertyValueChanged);
            // 
            // mtbDate
            // 
            this.mtbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbDate.Date = null;
            this.mtbDate.Location = new System.Drawing.Point(75, 101);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(80, 20);
            this.mtbDate.TabIndex = 8;
            this.mtbDate.TextChanged += new System.EventHandler(this.mtbDate_TextChanged);
            // 
            // lblStateDate
            // 
            this.lblStateDate.AutoSize = true;
            this.lblStateDate.Location = new System.Drawing.Point(6, 105);
            this.lblStateDate.Name = "lblStateDate";
            this.lblStateDate.Size = new System.Drawing.Size(41, 13);
            this.lblStateDate.TabIndex = 7;
            this.lblStateDate.Text = "Datum:";
            // 
            // btnShowClassSelector
            // 
            this.btnShowClassSelector.Location = new System.Drawing.Point(75, 19);
            this.btnShowClassSelector.Name = "btnShowClassSelector";
            this.btnShowClassSelector.Size = new System.Drawing.Size(377, 24);
            this.btnShowClassSelector.TabIndex = 0;
            this.btnShowClassSelector.Text = "Grundtyp auswählen";
            this.btnShowClassSelector.UseVisualStyleBackColor = false;
            this.btnShowClassSelector.Click += new System.EventHandler(this.btnShowClassSelector_Click);
            // 
            // nudWeight
            // 
            this.nudWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudWeight.Location = new System.Drawing.Point(75, 49);
            this.nudWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWeight.Name = "nudWeight";
            this.nudWeight.Size = new System.Drawing.Size(55, 20);
            this.nudWeight.TabIndex = 2;
            this.nudWeight.ThousandsSeparator = true;
            this.nudWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudWeight.ValueChanged += new System.EventHandler(this.nudWeigt_ValueChanged);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(75, 75);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(377, 20);
            this.txtTitle.TabIndex = 6;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblStateTitle
            // 
            this.lblStateTitle.AutoSize = true;
            this.lblStateTitle.Location = new System.Drawing.Point(6, 78);
            this.lblStateTitle.Name = "lblStateTitle";
            this.lblStateTitle.Size = new System.Drawing.Size(30, 13);
            this.lblStateTitle.TabIndex = 5;
            this.lblStateTitle.Text = "Titel:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(161, 101);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(291, 20);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Farbe";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.BackColorChanged += new System.EventHandler(this.btnColor_BackColorChanged);
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnItemDelete.Location = new System.Drawing.Point(107, 0);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(100, 24);
            this.btnItemDelete.TabIndex = 1;
            this.btnItemDelete.Text = "Löschen";
            this.btnItemDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // imlProgress
            // 
            this.imlProgress.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlProgress.ImageStream")));
            this.imlProgress.TransparentColor = System.Drawing.Color.Transparent;
            this.imlProgress.Images.SetKeyName(0, "Progress_Active.png");
            this.imlProgress.Images.SetKeyName(1, "Progress_Finish.png");
            this.imlProgress.Images.SetKeyName(2, "Progress_FinishLowPriority.png");
            this.imlProgress.Images.SetKeyName(3, "Progress.png");
            // 
            // chLsvProgresses_Title
            // 
            this.chLsvProgresses_Title.Text = "Titel";
            this.chLsvProgresses_Title.Width = 90;
            // 
            // chLsvProgresses_Date
            // 
            this.chLsvProgresses_Date.Text = "Datum";
            this.chLsvProgresses_Date.Width = 90;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(75, 150);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(377, 70);
            this.txtComment.TabIndex = 13;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblStateComment
            // 
            this.lblStateComment.AutoSize = true;
            this.lblStateComment.Location = new System.Drawing.Point(6, 153);
            this.lblStateComment.Name = "lblStateComment";
            this.lblStateComment.Size = new System.Drawing.Size(63, 13);
            this.lblStateComment.TabIndex = 12;
            this.lblStateComment.Text = "Kommentar:";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnItemAdd.Location = new System.Drawing.Point(1, 0);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(100, 24);
            this.btnItemAdd.TabIndex = 0;
            this.btnItemAdd.Text = "Hinzufügen";
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // grpProgressEdit
            // 
            this.grpProgressEdit.Controls.Add(this.chkProgressFinishedLowPriority);
            this.grpProgressEdit.Controls.Add(this.chkProgressFinished);
            this.grpProgressEdit.Controls.Add(this.lblWeight);
            this.grpProgressEdit.Controls.Add(this.lblWeightActivateOverride);
            this.grpProgressEdit.Controls.Add(this.chkWeight);
            this.grpProgressEdit.Controls.Add(this.mtbDate);
            this.grpProgressEdit.Controls.Add(this.lblStateDate);
            this.grpProgressEdit.Controls.Add(this.btnShowClassSelector);
            this.grpProgressEdit.Controls.Add(this.nudWeight);
            this.grpProgressEdit.Controls.Add(this.txtTitle);
            this.grpProgressEdit.Controls.Add(this.lblStateTitle);
            this.grpProgressEdit.Controls.Add(this.btnColor);
            this.grpProgressEdit.Controls.Add(this.txtComment);
            this.grpProgressEdit.Controls.Add(this.lblStateComment);
            this.grpProgressEdit.Location = new System.Drawing.Point(213, 0);
            this.grpProgressEdit.Name = "grpProgressEdit";
            this.grpProgressEdit.Size = new System.Drawing.Size(458, 226);
            this.grpProgressEdit.TabIndex = 3;
            this.grpProgressEdit.TabStop = false;
            this.grpProgressEdit.Text = "Bewerbungsfortschritt";
            // 
            // chkProgressFinishedLowPriority
            // 
            this.chkProgressFinishedLowPriority.AutoSize = true;
            this.chkProgressFinishedLowPriority.Location = new System.Drawing.Point(279, 127);
            this.chkProgressFinishedLowPriority.Name = "chkProgressFinishedLowPriority";
            this.chkProgressFinishedLowPriority.Size = new System.Drawing.Size(118, 17);
            this.chkProgressFinishedLowPriority.TabIndex = 11;
            this.chkProgressFinishedLowPriority.Text = "mit geringer Priorität";
            this.chkProgressFinishedLowPriority.UseVisualStyleBackColor = true;
            this.chkProgressFinishedLowPriority.CheckedChanged += new System.EventHandler(this.chkProgressFinishedLowPriority_CheckedChanged);
            // 
            // chkProgressFinished
            // 
            this.chkProgressFinished.AutoSize = true;
            this.chkProgressFinished.Location = new System.Drawing.Point(75, 127);
            this.chkProgressFinished.Name = "chkProgressFinished";
            this.chkProgressFinished.Size = new System.Drawing.Size(198, 17);
            this.chkProgressFinished.TabIndex = 10;
            this.chkProgressFinished.Text = "Bewerbungsvorgang abgeschlossen";
            this.chkProgressFinished.UseVisualStyleBackColor = true;
            this.chkProgressFinished.CheckedChanged += new System.EventHandler(this.chkProgressFinished_CheckedChanged);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 51);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(52, 13);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Gewicht.:";
            // 
            // lblWeightActivateOverride
            // 
            this.lblWeightActivateOverride.AutoSize = true;
            this.lblWeightActivateOverride.Location = new System.Drawing.Point(219, 51);
            this.lblWeightActivateOverride.Name = "lblWeightActivateOverride";
            this.lblWeightActivateOverride.Size = new System.Drawing.Size(215, 13);
            this.lblWeightActivateOverride.TabIndex = 4;
            this.lblWeightActivateOverride.TabStop = true;
            this.lblWeightActivateOverride.Text = "Funktion in den Einstellungen de-/aktivieren";
            this.lblWeightActivateOverride.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWeightActivateOverride_LinkClicked);
            // 
            // chkWeight
            // 
            this.chkWeight.AutoSize = true;
            this.chkWeight.Location = new System.Drawing.Point(136, 50);
            this.chkWeight.Name = "chkWeight";
            this.chkWeight.Size = new System.Drawing.Size(77, 17);
            this.chkWeight.TabIndex = 3;
            this.chkWeight.Text = "Bearbeiten";
            this.chkWeight.UseVisualStyleBackColor = true;
            this.chkWeight.CheckedChanged += new System.EventHandler(this.chkWeight_CheckedChanged);
            // 
            // lsvItems
            // 
            this.lsvItems.AllowDragAndDropSort = true;
            this.lsvItems.AllowDrop = true;
            this.lsvItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvProgresses_Date,
            this.chLsvProgresses_Title});
            this.lsvItems.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvItems.ColumnWidths")));
            this.lsvItems.FullRowSelect = true;
            this.lsvItems.GridLines = true;
            this.lsvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvItems.HideSelection = false;
            this.lsvItems.Location = new System.Drawing.Point(1, 30);
            this.lsvItems.Name = "lsvItems";
            this.lsvItems.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvItems.Size = new System.Drawing.Size(206, 196);
            this.lsvItems.SmallImageList = this.imlProgress;
            this.lsvItems.TabIndex = 2;
            this.lsvItems.UseCompatibleStateImageBehavior = false;
            this.lsvItems.View = System.Windows.Forms.View.Details;
            this.lsvItems.SelectedIndexChanged += new System.EventHandler(this.lsvItemss_SelectedIndexChanged);
            this.lsvItems.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsvItems_DragDrop);
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // erpItemsList
            // 
            this.erpItemsList.ContainerControl = this;
            // 
            // ProgressEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prgEditor);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.grpProgressEdit);
            this.Controls.Add(this.lsvItems);
            this.Name = "ProgressEditor";
            this.Size = new System.Drawing.Size(979, 226);
            ((System.ComponentModel.ISupportInitialize)(this.nudWeight)).EndInit();
            this.grpProgressEdit.ResumeLayout(false);
            this.grpProgressEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpItemsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgEditor;
        private Toolbox.Widgets.DateInputAndValidator mtbDate;
        private System.Windows.Forms.Label lblStateDate;
        private System.Windows.Forms.Button btnShowClassSelector;
        private System.Windows.Forms.NumericUpDown nudWeight;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblStateTitle;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.ImageList imlProgress;
        private System.Windows.Forms.ColumnHeader chLsvProgresses_Title;
        private System.Windows.Forms.ColumnHeader chLsvProgresses_Date;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblStateComment;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.GroupBox grpProgressEdit;
        private Toolbox.Widgets.SortListView lsvItems;
        private System.Windows.Forms.CheckBox chkWeight;
        private System.Windows.Forms.LinkLabel lblWeightActivateOverride;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ErrorProvider erpItemsList;
        private System.Windows.Forms.CheckBox chkProgressFinishedLowPriority;
        private System.Windows.Forms.CheckBox chkProgressFinished;
    }
}
