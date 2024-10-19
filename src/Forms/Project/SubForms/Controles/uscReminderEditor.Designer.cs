namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles
{
    partial class ReminderEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderEditor));
            this.imlReminder = new System.Windows.Forms.ImageList(this.components);
            this.chLsvReminders_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvItems = new OLKI.Toolbox.Widgets.SortListView();
            this.lblReminderDate = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblReminderTitle = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.chkReminderAcknowledge = new System.Windows.Forms.CheckBox();
            this.lblReminerComment = new System.Windows.Forms.Label();
            this.grpReminderEdit = new System.Windows.Forms.GroupBox();
            this.mtbDate = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemDelete = new System.Windows.Forms.Button();
            this.prgEditor = new System.Windows.Forms.PropertyGrid();
            this.grpReminderEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlReminder
            // 
            this.imlReminder.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlReminder.ImageStream")));
            this.imlReminder.TransparentColor = System.Drawing.Color.Transparent;
            this.imlReminder.Images.SetKeyName(0, "Reminder.png");
            this.imlReminder.Images.SetKeyName(1, "Reminder_Acknowledge.png");
            this.imlReminder.Images.SetKeyName(2, "Christmas.png");
            // 
            // chLsvReminders_Date
            // 
            this.chLsvReminders_Date.Text = "Datum";
            this.chLsvReminders_Date.Width = 90;
            // 
            // chLsvReminders_Title
            // 
            this.chLsvReminders_Title.Text = "Titel";
            this.chLsvReminders_Title.Width = 90;
            // 
            // lsvItems
            // 
            this.lsvItems.AllowColumnWidthChange = false;
            this.lsvItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvReminders_Date,
            this.chLsvReminders_Title});
            this.lsvItems.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvItems.ColumnWidths")));
            this.lsvItems.FullRowSelect = true;
            this.lsvItems.GridLines = true;
            this.lsvItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvItems.HideSelection = false;
            this.lsvItems.Location = new System.Drawing.Point(0, 30);
            this.lsvItems.Name = "lsvItems";
            this.lsvItems.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvItems.Size = new System.Drawing.Size(206, 196);
            this.lsvItems.SmallImageList = this.imlReminder;
            this.lsvItems.TabIndex = 2;
            this.lsvItems.UseCompatibleStateImageBehavior = false;
            this.lsvItems.View = System.Windows.Forms.View.Details;
            this.lsvItems.SelectedIndexChanged += new System.EventHandler(this.lsvItems_SelectedIndexChanged);
            // 
            // lblReminderDate
            // 
            this.lblReminderDate.AutoSize = true;
            this.lblReminderDate.Location = new System.Drawing.Point(6, 25);
            this.lblReminderDate.Name = "lblReminderDate";
            this.lblReminderDate.Size = new System.Drawing.Size(41, 13);
            this.lblReminderDate.TabIndex = 0;
            this.lblReminderDate.Text = "Datum:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(75, 45);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(377, 20);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // lblReminderTitle
            // 
            this.lblReminderTitle.AutoSize = true;
            this.lblReminderTitle.Location = new System.Drawing.Point(6, 49);
            this.lblReminderTitle.Name = "lblReminderTitle";
            this.lblReminderTitle.Size = new System.Drawing.Size(30, 13);
            this.lblReminderTitle.TabIndex = 3;
            this.lblReminderTitle.Text = "Titel:";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(75, 71);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(377, 149);
            this.txtComment.TabIndex = 6;
            this.txtComment.TextChanged += new System.EventHandler(this.txtComment_TextChanged);
            // 
            // chkReminderAcknowledge
            // 
            this.chkReminderAcknowledge.AutoSize = true;
            this.chkReminderAcknowledge.Location = new System.Drawing.Point(385, 21);
            this.chkReminderAcknowledge.Name = "chkReminderAcknowledge";
            this.chkReminderAcknowledge.Size = new System.Drawing.Size(67, 17);
            this.chkReminderAcknowledge.TabIndex = 2;
            this.chkReminderAcknowledge.Text = "Bestätigt";
            this.chkReminderAcknowledge.UseVisualStyleBackColor = true;
            this.chkReminderAcknowledge.CheckedChanged += new System.EventHandler(this.chkReminderAcknowledge_CheckedChanged);
            // 
            // lblReminerComment
            // 
            this.lblReminerComment.AutoSize = true;
            this.lblReminerComment.Location = new System.Drawing.Point(6, 74);
            this.lblReminerComment.Name = "lblReminerComment";
            this.lblReminerComment.Size = new System.Drawing.Size(63, 13);
            this.lblReminerComment.TabIndex = 5;
            this.lblReminerComment.Text = "Kommentar:";
            // 
            // grpReminderEdit
            // 
            this.grpReminderEdit.Controls.Add(this.mtbDate);
            this.grpReminderEdit.Controls.Add(this.lblReminerComment);
            this.grpReminderEdit.Controls.Add(this.chkReminderAcknowledge);
            this.grpReminderEdit.Controls.Add(this.txtComment);
            this.grpReminderEdit.Controls.Add(this.lblReminderTitle);
            this.grpReminderEdit.Controls.Add(this.txtTitle);
            this.grpReminderEdit.Controls.Add(this.lblReminderDate);
            this.grpReminderEdit.Location = new System.Drawing.Point(212, 0);
            this.grpReminderEdit.Name = "grpReminderEdit";
            this.grpReminderEdit.Size = new System.Drawing.Size(458, 226);
            this.grpReminderEdit.TabIndex = 3;
            this.grpReminderEdit.TabStop = false;
            this.grpReminderEdit.Text = "Erinnerung";
            // 
            // mtbDate
            // 
            this.mtbDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbDate.Date = null;
            this.mtbDate.Location = new System.Drawing.Point(75, 19);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.Size = new System.Drawing.Size(80, 20);
            this.mtbDate.TabIndex = 1;
            this.mtbDate.TextChanged += new System.EventHandler(this.mtbDate_TextChanged);
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
            // prgEditor
            // 
            this.prgEditor.HelpVisible = false;
            this.prgEditor.Location = new System.Drawing.Point(676, 0);
            this.prgEditor.Name = "prgEditor";
            this.prgEditor.Size = new System.Drawing.Size(300, 226);
            this.prgEditor.TabIndex = 4;
            this.prgEditor.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgEditor.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgEditor_PropertyValueChanged);
            // 
            // ReminderEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prgEditor);
            this.Controls.Add(this.btnItemDelete);
            this.Controls.Add(this.btnItemAdd);
            this.Controls.Add(this.grpReminderEdit);
            this.Controls.Add(this.lsvItems);
            this.DoubleBuffered = true;
            this.Name = "ReminderEditor";
            this.Size = new System.Drawing.Size(979, 226);
            this.grpReminderEdit.ResumeLayout(false);
            this.grpReminderEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imlReminder;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Date;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Title;
        private OLKI.Toolbox.Widgets.SortListView lsvItems;
        private System.Windows.Forms.Label lblReminderDate;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblReminderTitle;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.CheckBox chkReminderAcknowledge;
        private System.Windows.Forms.Label lblReminerComment;
        private System.Windows.Forms.GroupBox grpReminderEdit;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemDelete;
        private System.Windows.Forms.PropertyGrid prgEditor;
        private Toolbox.Widgets.DateInputAndValidator mtbDate;
    }
}
