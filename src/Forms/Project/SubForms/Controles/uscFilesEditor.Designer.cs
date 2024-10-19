namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    partial class FilesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilesEditor));
            this.grbFileEdit = new System.Windows.Forms.GroupBox();
            this.btnFileLink = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnFileGoTo = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblFileComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblFileTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lsvItems = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvFile_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvFile_FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlFile = new System.Windows.Forms.ImageList(this.components);
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.prgEditor = new System.Windows.Forms.PropertyGrid();
            this.grbFileEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFileEdit
            // 
            this.grbFileEdit.Controls.Add(this.btnFileLink);
            this.grbFileEdit.Controls.Add(this.lblNote);
            this.grbFileEdit.Controls.Add(this.btnFileUpload);
            this.grbFileEdit.Controls.Add(this.btnFileGoTo);
            this.grbFileEdit.Controls.Add(this.lblFilePath);
            this.grbFileEdit.Controls.Add(this.txtFilePath);
            this.grbFileEdit.Controls.Add(this.lblFileComment);
            this.grbFileEdit.Controls.Add(this.txtComment);
            this.grbFileEdit.Controls.Add(this.lblFileTitle);
            this.grbFileEdit.Controls.Add(this.txtTitle);
            this.grbFileEdit.Location = new System.Drawing.Point(212, 0);
            this.grbFileEdit.Name = "grbFileEdit";
            this.grbFileEdit.Size = new System.Drawing.Size(458, 226);
            this.grbFileEdit.TabIndex = 3;
            this.grbFileEdit.TabStop = false;
            this.grbFileEdit.Text = "Dateianhang";
            // 
            // btnFileLink
            // 
            this.btnFileLink.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenToLink;
            this.btnFileLink.Location = new System.Drawing.Point(417, 74);
            this.btnFileLink.Name = "btnFileLink";
            this.btnFileLink.Size = new System.Drawing.Size(35, 24);
            this.btnFileLink.TabIndex = 7;
            this.btnFileLink.UseVisualStyleBackColor = true;
            this.btnFileLink.Click += new System.EventHandler(this.btnFileLink_Click);
            // 
            // lblNote
            // 
            this.lblNote.Location = new System.Drawing.Point(75, 16);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(377, 31);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Sie können entweder eine Datei in der Projektdatei speichern und eine Verknüpfung" +
    " mit einer lokalen Datei herstellen";
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenToUpload;
            this.btnFileUpload.Location = new System.Drawing.Point(376, 74);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(35, 24);
            this.btnFileUpload.TabIndex = 6;
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // btnFileGoTo
            // 
            this.btnFileGoTo.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFile;
            this.btnFileGoTo.Location = new System.Drawing.Point(417, 48);
            this.btnFileGoTo.Name = "btnFileGoTo";
            this.btnFileGoTo.Size = new System.Drawing.Size(35, 24);
            this.btnFileGoTo.TabIndex = 3;
            this.btnFileGoTo.UseVisualStyleBackColor = true;
            this.btnFileGoTo.Click += new System.EventHandler(this.btnFileGoTo_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(6, 80);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(56, 13);
            this.lblFilePath.TabIndex = 4;
            this.lblFilePath.Text = "Dateipfad:";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(75, 76);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(295, 20);
            this.txtFilePath.TabIndex = 5;
            // 
            // lblFileComment
            // 
            this.lblFileComment.AutoSize = true;
            this.lblFileComment.Location = new System.Drawing.Point(6, 102);
            this.lblFileComment.Name = "lblFileComment";
            this.lblFileComment.Size = new System.Drawing.Size(63, 13);
            this.lblFileComment.TabIndex = 8;
            this.lblFileComment.Text = "Kommentar:";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(75, 102);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(377, 118);
            this.txtComment.TabIndex = 9;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // lblFileTitle
            // 
            this.lblFileTitle.AutoSize = true;
            this.lblFileTitle.Location = new System.Drawing.Point(6, 54);
            this.lblFileTitle.Name = "lblFileTitle";
            this.lblFileTitle.Size = new System.Drawing.Size(30, 13);
            this.lblFileTitle.TabIndex = 1;
            this.lblFileTitle.Text = "Titel:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(75, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(336, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lsvItems
            // 
            this.lsvItems.AllowColumnWidthChange = false;
            this.lsvItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvFile_Title,
            this.chLsvFile_FileName});
            this.lsvItems.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvItems.ColumnWidths")));
            this.lsvItems.FullRowSelect = true;
            this.lsvItems.GridLines = true;
            this.lsvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvItems.HideSelection = false;
            this.lsvItems.Location = new System.Drawing.Point(0, 30);
            this.lsvItems.Name = "lsvItems";
            this.lsvItems.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvItems.Size = new System.Drawing.Size(206, 196);
            this.lsvItems.SmallImageList = this.imlFile;
            this.lsvItems.TabIndex = 2;
            this.lsvItems.UseCompatibleStateImageBehavior = false;
            this.lsvItems.View = System.Windows.Forms.View.Details;
            this.lsvItems.SelectedIndexChanged += new System.EventHandler(this.lsvItems_SelectedIndexChanged);
            // 
            // chLsvFile_Title
            // 
            this.chLsvFile_Title.Text = "Titel";
            this.chLsvFile_Title.Width = 90;
            // 
            // chLsvFile_FileName
            // 
            this.chLsvFile_FileName.Text = "Dateiname";
            this.chLsvFile_FileName.Width = 90;
            // 
            // imlFile
            // 
            this.imlFile.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlFile.ImageStream")));
            this.imlFile.TransparentColor = System.Drawing.Color.Transparent;
            this.imlFile.Images.SetKeyName(0, "Document.png");
            this.imlFile.Images.SetKeyName(1, "Document_Link.png");
            this.imlFile.Images.SetKeyName(2, "Document_Upload.png");
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnItemDelete.Location = new System.Drawing.Point(106, 0);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(100, 24);
            this.btnItemDelete.TabIndex = 1;
            this.btnItemDelete.Text = "Löschen";
            this.btnItemDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnItemAdd.Location = new System.Drawing.Point(0, 0);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(100, 24);
            this.btnItemAdd.TabIndex = 0;
            this.btnItemAdd.Text = "Hinzufügen";
            this.btnItemAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // prgEditor
            // 
            this.prgEditor.HelpVisible = false;
            this.prgEditor.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgEditor.Location = new System.Drawing.Point(676, 0);
            this.prgEditor.Name = "prgEditor";
            this.prgEditor.Size = new System.Drawing.Size(300, 226);
            this.prgEditor.TabIndex = 4;
            this.prgEditor.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgEditor.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgEditor_PropertyValueChanged);
            // 
            // FilesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prgEditor);
            this.Controls.Add(this.grbFileEdit);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.lsvItems);
            this.DoubleBuffered = true;
            this.Name = "FilesEditor";
            this.Size = new System.Drawing.Size(979, 226);
            this.grbFileEdit.ResumeLayout(false);
            this.grbFileEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFileEdit;
        private System.Windows.Forms.Button btnFileGoTo;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblFileComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblFileTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemAdd;
        private OLKI.Toolbox.Widgets.SortListView lsvItems;
        private System.Windows.Forms.ColumnHeader chLsvFile_Title;
        private System.Windows.Forms.ColumnHeader chLsvFile_FileName;
        private System.Windows.Forms.ImageList imlFile;
        private System.Windows.Forms.Button btnFileUpload;
        private System.Windows.Forms.PropertyGrid prgEditor;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnFileLink;
    }
}
