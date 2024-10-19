namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    partial class ContactsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsEditor));
            this.lsvItems = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvContacts_FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_Division = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_Telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_EMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvContacts_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlContact = new System.Windows.Forms.ImageList(this.components);
            this.chkOnlyChecked = new System.Windows.Forms.CheckBox();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.btnItemEdit = new System.Windows.Forms.Button();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnContactReport = new System.Windows.Forms.Button();
            this.prgEditor = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // lsvItems
            // 
            this.lsvItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvContacts_FirstName,
            this.chLsvContacts_LastName,
            this.chLsvContacts_Position,
            this.chLsvContacts_Division,
            this.chLsvContacts_Telephone,
            this.chLsvContacts_EMail,
            this.chLsvContacts_Comment});
            this.lsvItems.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvItems.ColumnWidths")));
            this.lsvItems.FullRowSelect = true;
            this.lsvItems.GridLines = true;
            this.lsvItems.HideSelection = false;
            this.lsvItems.Location = new System.Drawing.Point(0, 30);
            this.lsvItems.Name = "lsvItems";
            this.lsvItems.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvItems.Size = new System.Drawing.Size(670, 196);
            this.lsvItems.SmallImageList = this.imlContact;
            this.lsvItems.TabIndex = 5;
            this.lsvItems.UseCompatibleStateImageBehavior = false;
            this.lsvItems.View = System.Windows.Forms.View.Details;
            this.lsvItems.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsvIttemss_ItemChecked);
            this.lsvItems.SelectedIndexChanged += new System.EventHandler(this.lsvItems_SelectedIndexChanged);
            this.lsvItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvItems_MouseDoubleClick);
            // 
            // chLsvContacts_FirstName
            // 
            this.chLsvContacts_FirstName.Text = "Vorname";
            this.chLsvContacts_FirstName.Width = 120;
            // 
            // chLsvContacts_LastName
            // 
            this.chLsvContacts_LastName.Text = "Nachname";
            this.chLsvContacts_LastName.Width = 120;
            // 
            // chLsvContacts_Position
            // 
            this.chLsvContacts_Position.Text = "Position";
            // 
            // chLsvContacts_Division
            // 
            this.chLsvContacts_Division.Text = "Abteilung";
            // 
            // chLsvContacts_Telephone
            // 
            this.chLsvContacts_Telephone.Text = "Telefon";
            // 
            // chLsvContacts_EMail
            // 
            this.chLsvContacts_EMail.Text = "E-Mail";
            this.chLsvContacts_EMail.Width = 120;
            // 
            // chLsvContacts_Comment
            // 
            this.chLsvContacts_Comment.Text = "Kommentar";
            this.chLsvContacts_Comment.Width = 120;
            // 
            // imlContact
            // 
            this.imlContact.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlContact.ImageStream")));
            this.imlContact.TransparentColor = System.Drawing.Color.Transparent;
            this.imlContact.Images.SetKeyName(0, "User.png");
            // 
            // chkOnlyChecked
            // 
            this.chkOnlyChecked.AutoSize = true;
            this.chkOnlyChecked.Location = new System.Drawing.Point(253, 5);
            this.chkOnlyChecked.Name = "chkOnlyChecked";
            this.chkOnlyChecked.Size = new System.Drawing.Size(262, 17);
            this.chkOnlyChecked.TabIndex = 3;
            this.chkOnlyChecked.Text = "Nur mit Bewerbung verknüpfte Kontakte anzeigen";
            this.chkOnlyChecked.UseVisualStyleBackColor = true;
            this.chkOnlyChecked.CheckedChanged += new System.EventHandler(this.chkOnlyChecked_CheckedChanged);
            // 
            // btnItemDelete
            // 
            this.btnItemDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnItemDelete.Location = new System.Drawing.Point(570, 0);
            this.btnItemDelete.Name = "btnItemDelete";
            this.btnItemDelete.Size = new System.Drawing.Size(100, 24);
            this.btnItemDelete.TabIndex = 4;
            this.btnItemDelete.Text = "Löschen";
            this.btnItemDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemDelete.UseVisualStyleBackColor = true;
            this.btnItemDelete.Click += new System.EventHandler(this.btnItemDelete_Click);
            // 
            // btnItemEdit
            // 
            this.btnItemEdit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Properties;
            this.btnItemEdit.Location = new System.Drawing.Point(106, 0);
            this.btnItemEdit.Name = "btnItemEdit";
            this.btnItemEdit.Size = new System.Drawing.Size(100, 24);
            this.btnItemEdit.TabIndex = 1;
            this.btnItemEdit.Text = "Bearbeiten";
            this.btnItemEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItemEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnItemEdit.UseVisualStyleBackColor = true;
            this.btnItemEdit.Click += new System.EventHandler(this.btnItemEdit_Click);
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
            // btnContactReport
            // 
            this.btnContactReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.btnContactReport.Location = new System.Drawing.Point(212, 0);
            this.btnContactReport.Name = "btnContactReport";
            this.btnContactReport.Size = new System.Drawing.Size(35, 24);
            this.btnContactReport.TabIndex = 2;
            this.btnContactReport.UseVisualStyleBackColor = true;
            this.btnContactReport.Click += new System.EventHandler(this.btnContactReport_Click);
            // 
            // prgEditor
            // 
            this.prgEditor.HelpVisible = false;
            this.prgEditor.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgEditor.Location = new System.Drawing.Point(676, 0);
            this.prgEditor.Name = "prgEditor";
            this.prgEditor.Size = new System.Drawing.Size(300, 226);
            this.prgEditor.TabIndex = 6;
            this.prgEditor.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgEditor.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgEditor_PropertyValueChanged);
            // 
            // ContactsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prgEditor);
            this.Controls.Add(this.btnContactReport);
            this.Controls.Add(this.chkOnlyChecked);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemEdit);
            this.Controls.Add(this.lsvItems);
            this.Controls.Add(this.btnItemAdd);
            this.DoubleBuffered = true;
            this.Name = "ContactsEditor";
            this.Size = new System.Drawing.Size(979, 226);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.Button btnItemEdit;
        private OLKI.Toolbox.Widgets.SortListView lsvItems;
        private System.Windows.Forms.ColumnHeader chLsvContacts_FirstName;
        private System.Windows.Forms.ColumnHeader chLsvContacts_LastName;
        private System.Windows.Forms.ColumnHeader chLsvContacts_Position;
        private System.Windows.Forms.ColumnHeader chLsvContacts_Division;
        private System.Windows.Forms.ColumnHeader chLsvContacts_Telephone;
        private System.Windows.Forms.ColumnHeader chLsvContacts_EMail;
        private System.Windows.Forms.ColumnHeader chLsvContacts_Comment;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.ImageList imlContact;
        private System.Windows.Forms.CheckBox chkOnlyChecked;
        internal System.Windows.Forms.Button btnContactReport;
        private System.Windows.Forms.PropertyGrid prgEditor;
    }
}
