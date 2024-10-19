namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ContactEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactEditForm));
            this.tpTabContact_Files = new System.Windows.Forms.TabPage();
            this.uscEditorFiles = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.FilesEditor();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtContactCellphone = new System.Windows.Forms.TextBox();
            this.lblContactCellphone = new System.Windows.Forms.Label();
            this.btnContatEMail = new System.Windows.Forms.Button();
            this.txtContactTelephone = new System.Windows.Forms.TextBox();
            this.txtContactFax = new System.Windows.Forms.TextBox();
            this.txtContactEMail = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tolCt_lblId = new System.Windows.Forms.ToolStripLabel();
            this.tolContact = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolC_btnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtNameFirst = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblContactTelephone = new System.Windows.Forms.Label();
            this.lblContatEMail = new System.Windows.Forms.Label();
            this.lblContactFax = new System.Windows.Forms.Label();
            this.txtNameLast = new System.Windows.Forms.TextBox();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.grbComment = new System.Windows.Forms.GroupBox();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.grbMiscellaneous = new System.Windows.Forms.GroupBox();
            this.tpTabContact_Common = new System.Windows.Forms.TabPage();
            this.tapContact = new System.Windows.Forms.TabControl();
            this.imlRegister = new System.Windows.Forms.ImageList(this.components);
            this.txtNameTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.erpEditor = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpTabContact_Files.SuspendLayout();
            this.tolContact.SuspendLayout();
            this.grbContact.SuspendLayout();
            this.grbComment.SuspendLayout();
            this.grbMiscellaneous.SuspendLayout();
            this.tpTabContact_Common.SuspendLayout();
            this.tapContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // tpTabContact_Files
            // 
            this.tpTabContact_Files.Controls.Add(this.uscEditorFiles);
            this.tpTabContact_Files.ImageIndex = 1;
            this.tpTabContact_Files.Location = new System.Drawing.Point(4, 23);
            this.tpTabContact_Files.Name = "tpTabContact_Files";
            this.tpTabContact_Files.Size = new System.Drawing.Size(682, 237);
            this.tpTabContact_Files.TabIndex = 4;
            this.tpTabContact_Files.Text = "Dateianhänge";
            this.tpTabContact_Files.UseVisualStyleBackColor = true;
            // 
            // uscEditorFiles
            // 
            this.uscEditorFiles.IdSet = null;
            this.uscEditorFiles.Items = null;
            this.uscEditorFiles.Location = new System.Drawing.Point(6, 6);
            this.uscEditorFiles.Name = "uscEditorFiles";
            this.uscEditorFiles.Size = new System.Drawing.Size(979, 226);
            this.uscEditorFiles.TabIndex = 0;
            this.uscEditorFiles.ItemAdded += new System.EventHandler(this.uscEditorFiles_ItemAdded);
            // 
            // btnAccept
            // 
            this.btnAccept.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Accept;
            this.btnAccept.Location = new System.Drawing.Point(128, 310);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(110, 23);
            this.btnAccept.TabIndex = 9;
            this.btnAccept.Text = "Ü&bernehmen";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // txtContactCellphone
            // 
            this.txtContactCellphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactCellphone.Location = new System.Drawing.Point(95, 71);
            this.txtContactCellphone.Name = "txtContactCellphone";
            this.txtContactCellphone.Size = new System.Drawing.Size(240, 20);
            this.txtContactCellphone.TabIndex = 5;
            // 
            // lblContactCellphone
            // 
            this.lblContactCellphone.AutoSize = true;
            this.lblContactCellphone.Location = new System.Drawing.Point(6, 74);
            this.lblContactCellphone.Name = "lblContactCellphone";
            this.lblContactCellphone.Size = new System.Drawing.Size(72, 13);
            this.lblContactCellphone.TabIndex = 4;
            this.lblContactCellphone.Text = "Mobilnummer:";
            // 
            // btnContatEMail
            // 
            this.btnContatEMail.Enabled = false;
            this.btnContatEMail.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.EMail;
            this.btnContatEMail.Location = new System.Drawing.Point(300, 94);
            this.btnContatEMail.Name = "btnContatEMail";
            this.btnContatEMail.Size = new System.Drawing.Size(35, 24);
            this.btnContatEMail.TabIndex = 8;
            this.btnContatEMail.UseVisualStyleBackColor = true;
            this.btnContatEMail.Click += new System.EventHandler(this.btnContatEMail_Click);
            // 
            // txtContactTelephone
            // 
            this.txtContactTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactTelephone.Location = new System.Drawing.Point(95, 19);
            this.txtContactTelephone.Name = "txtContactTelephone";
            this.txtContactTelephone.Size = new System.Drawing.Size(240, 20);
            this.txtContactTelephone.TabIndex = 1;
            // 
            // txtContactFax
            // 
            this.txtContactFax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactFax.Location = new System.Drawing.Point(95, 45);
            this.txtContactFax.Name = "txtContactFax";
            this.txtContactFax.Size = new System.Drawing.Size(240, 20);
            this.txtContactFax.TabIndex = 3;
            // 
            // txtContactEMail
            // 
            this.txtContactEMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactEMail.Location = new System.Drawing.Point(95, 97);
            this.txtContactEMail.Name = "txtContactEMail";
            this.txtContactEMail.Size = new System.Drawing.Size(199, 20);
            this.txtContactEMail.TabIndex = 7;
            this.txtContactEMail.TextChanged += new System.EventHandler(this.txtContactEMail_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(592, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tolCt_lblId
            // 
            this.tolCt_lblId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolCt_lblId.Name = "tolCt_lblId";
            this.tolCt_lblId.Size = new System.Drawing.Size(21, 76);
            this.tolCt_lblId.Text = "Kontakt Id: {0}";
            this.tolCt_lblId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tolContact
            // 
            this.tolContact.Dock = System.Windows.Forms.DockStyle.Right;
            this.tolContact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolCt_lblId,
            this.toolStripSeparator1,
            this.tolC_btnCreateReport});
            this.tolContact.Location = new System.Drawing.Point(705, 0);
            this.tolContact.Name = "tolContact";
            this.tolContact.Size = new System.Drawing.Size(24, 345);
            this.tolContact.TabIndex = 7;
            this.tolContact.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // tolC_btnCreateReport
            // 
            this.tolC_btnCreateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolC_btnCreateReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.tolC_btnCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolC_btnCreateReport.Name = "tolC_btnCreateReport";
            this.tolC_btnCreateReport.Size = new System.Drawing.Size(21, 20);
            this.tolC_btnCreateReport.Text = "Bericht erstellen";
            this.tolC_btnCreateReport.Click += new System.EventHandler(this.tolC_btnCreateReport_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(418, 15);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(62, 13);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Nachname:";
            // 
            // txtNameFirst
            // 
            this.txtNameFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNameFirst.Location = new System.Drawing.Point(212, 12);
            this.txtNameFirst.Name = "txtNameFirst";
            this.txtNameFirst.Size = new System.Drawing.Size(200, 20);
            this.txtNameFirst.TabIndex = 3;
            this.txtNameFirst.TextChanged += new System.EventHandler(this.txtNameXXX_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(154, 15);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(52, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "Vorname:";
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 310);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblContactTelephone
            // 
            this.lblContactTelephone.AutoSize = true;
            this.lblContactTelephone.Location = new System.Drawing.Point(6, 22);
            this.lblContactTelephone.Name = "lblContactTelephone";
            this.lblContactTelephone.Size = new System.Drawing.Size(83, 13);
            this.lblContactTelephone.TabIndex = 0;
            this.lblContactTelephone.Text = "Telefonnummer:";
            // 
            // lblContatEMail
            // 
            this.lblContatEMail.AutoSize = true;
            this.lblContatEMail.Location = new System.Drawing.Point(6, 100);
            this.lblContatEMail.Name = "lblContatEMail";
            this.lblContatEMail.Size = new System.Drawing.Size(80, 13);
            this.lblContatEMail.TabIndex = 6;
            this.lblContatEMail.Text = "E-Mail-Adresse:";
            // 
            // lblContactFax
            // 
            this.lblContactFax.AutoSize = true;
            this.lblContactFax.Location = new System.Drawing.Point(6, 48);
            this.lblContactFax.Name = "lblContactFax";
            this.lblContactFax.Size = new System.Drawing.Size(64, 13);
            this.lblContactFax.TabIndex = 2;
            this.lblContactFax.Text = "Faxnummer:";
            // 
            // txtNameLast
            // 
            this.txtNameLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNameLast.Location = new System.Drawing.Point(486, 12);
            this.txtNameLast.Name = "txtNameLast";
            this.txtNameLast.Size = new System.Drawing.Size(200, 20);
            this.txtNameLast.TabIndex = 5;
            this.txtNameLast.TextChanged += new System.EventHandler(this.txtNameXXX_TextChanged);
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.txtContactCellphone);
            this.grbContact.Controls.Add(this.lblContactCellphone);
            this.grbContact.Controls.Add(this.btnContatEMail);
            this.grbContact.Controls.Add(this.txtContactTelephone);
            this.grbContact.Controls.Add(this.txtContactFax);
            this.grbContact.Controls.Add(this.txtContactEMail);
            this.grbContact.Controls.Add(this.lblContactTelephone);
            this.grbContact.Controls.Add(this.lblContatEMail);
            this.grbContact.Controls.Add(this.lblContactFax);
            this.grbContact.Location = new System.Drawing.Point(335, 6);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(341, 123);
            this.grbContact.TabIndex = 1;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Kontakt";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(6, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(658, 72);
            this.txtComment.TabIndex = 0;
            // 
            // grbComment
            // 
            this.grbComment.Controls.Add(this.txtComment);
            this.grbComment.Location = new System.Drawing.Point(6, 135);
            this.grbComment.Name = "grbComment";
            this.grbComment.Size = new System.Drawing.Size(670, 97);
            this.grbComment.TabIndex = 2;
            this.grbComment.TabStop = false;
            this.grbComment.Text = "Kommentar";
            // 
            // txtDivision
            // 
            this.txtDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDivision.Location = new System.Drawing.Point(66, 19);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(251, 20);
            this.txtDivision.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPosition.Location = new System.Drawing.Point(66, 45);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(251, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(6, 22);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(54, 13);
            this.lblDivision.TabIndex = 0;
            this.lblDivision.Text = "Abteilung:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(6, 48);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(47, 13);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // grbMiscellaneous
            // 
            this.grbMiscellaneous.Controls.Add(this.txtDivision);
            this.grbMiscellaneous.Controls.Add(this.txtPosition);
            this.grbMiscellaneous.Controls.Add(this.lblDivision);
            this.grbMiscellaneous.Controls.Add(this.lblPosition);
            this.grbMiscellaneous.Location = new System.Drawing.Point(6, 6);
            this.grbMiscellaneous.Name = "grbMiscellaneous";
            this.grbMiscellaneous.Size = new System.Drawing.Size(323, 123);
            this.grbMiscellaneous.TabIndex = 0;
            this.grbMiscellaneous.TabStop = false;
            this.grbMiscellaneous.Text = "Zusatzinformationen";
            // 
            // tpTabContact_Common
            // 
            this.tpTabContact_Common.Controls.Add(this.grbMiscellaneous);
            this.tpTabContact_Common.Controls.Add(this.grbComment);
            this.tpTabContact_Common.Controls.Add(this.grbContact);
            this.tpTabContact_Common.ImageIndex = 0;
            this.tpTabContact_Common.Location = new System.Drawing.Point(4, 23);
            this.tpTabContact_Common.Name = "tpTabContact_Common";
            this.tpTabContact_Common.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabContact_Common.Size = new System.Drawing.Size(682, 237);
            this.tpTabContact_Common.TabIndex = 0;
            this.tpTabContact_Common.Text = "Allgemein";
            this.tpTabContact_Common.UseVisualStyleBackColor = true;
            // 
            // tapContact
            // 
            this.tapContact.Controls.Add(this.tpTabContact_Common);
            this.tapContact.Controls.Add(this.tpTabContact_Files);
            this.tapContact.ImageList = this.imlRegister;
            this.tapContact.Location = new System.Drawing.Point(12, 40);
            this.tapContact.Name = "tapContact";
            this.tapContact.SelectedIndex = 0;
            this.tapContact.Size = new System.Drawing.Size(690, 264);
            this.tapContact.TabIndex = 6;
            // 
            // imlRegister
            // 
            this.imlRegister.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRegister.ImageStream")));
            this.imlRegister.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRegister.Images.SetKeyName(0, "User.png");
            this.imlRegister.Images.SetKeyName(1, "Document.png");
            // 
            // txtNameTitle
            // 
            this.txtNameTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNameTitle.Location = new System.Drawing.Point(48, 12);
            this.txtNameTitle.Name = "txtNameTitle";
            this.txtNameTitle.Size = new System.Drawing.Size(100, 20);
            this.txtNameTitle.TabIndex = 1;
            this.txtNameTitle.TextChanged += new System.EventHandler(this.txtNameXXX_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Titel:";
            // 
            // erpEditor
            // 
            this.erpEditor.ContainerControl = this;
            // 
            // ContactEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(729, 345);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tolContact);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtNameFirst);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNameLast);
            this.Controls.Add(this.tapContact);
            this.Controls.Add(this.txtNameTitle);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactEditForm";
            this.Text = "frmContactEdit";
            this.tpTabContact_Files.ResumeLayout(false);
            this.tolContact.ResumeLayout(false);
            this.tolContact.PerformLayout();
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            this.grbComment.ResumeLayout(false);
            this.grbComment.PerformLayout();
            this.grbMiscellaneous.ResumeLayout(false);
            this.grbMiscellaneous.PerformLayout();
            this.tpTabContact_Common.ResumeLayout(false);
            this.tapContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tpTabContact_Files;
        internal System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TextBox txtContactCellphone;
        private System.Windows.Forms.Label lblContactCellphone;
        private System.Windows.Forms.Button btnContatEMail;
        private System.Windows.Forms.TextBox txtContactTelephone;
        private System.Windows.Forms.TextBox txtContactFax;
        private System.Windows.Forms.TextBox txtContactEMail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripLabel tolCt_lblId;
        private System.Windows.Forms.ToolStrip tolContact;
        private System.Windows.Forms.ToolStripButton tolC_btnCreateReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtNameFirst;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblContactTelephone;
        private System.Windows.Forms.Label lblContatEMail;
        private System.Windows.Forms.Label lblContactFax;
        private System.Windows.Forms.TextBox txtNameLast;
        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.GroupBox grbComment;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox grbMiscellaneous;
        private System.Windows.Forms.TabPage tpTabContact_Common;
        private System.Windows.Forms.TabControl tapContact;
        private System.Windows.Forms.TextBox txtNameTitle;
        private System.Windows.Forms.Label lblTitle;
        private Controles.FilesEditor uscEditorFiles;
        private System.Windows.Forms.ErrorProvider erpEditor;
        private System.Windows.Forms.ImageList imlRegister;
    }
}