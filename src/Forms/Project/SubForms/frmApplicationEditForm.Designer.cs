namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ApplicationEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationEditForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tolApplication = new System.Windows.Forms.ToolStrip();
            this.tolA_btnGoToFolder = new System.Windows.Forms.ToolStripButton();
            this.tolA_lblId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolA_btnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.imlRegister = new System.Windows.Forms.ImageList(this.components);
            this.tabApplication = new System.Windows.Forms.TabControl();
            this.tpTabApplication_Common = new System.Windows.Forms.TabPage();
            this.grbCommon = new System.Windows.Forms.GroupBox();
            this.mtbDatePeriodStart = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.mtbDatePeriodEnd = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.mtbDateCreated = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.lblDatePeriodStart = new System.Windows.Forms.Label();
            this.lblDatePeriodEnd = new System.Windows.Forms.Label();
            this.chkArchive = new System.Windows.Forms.CheckBox();
            this.txtReferenceCode = new System.Windows.Forms.TextBox();
            this.lblReferenceCode = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.chkSpeculativeApplication = new System.Windows.Forms.CheckBox();
            this.grbComment = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tpTabApplication_Progress = new System.Windows.Forms.TabPage();
            this.uscProgressEditor = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ProgressEditor();
            this.tpTabApplication_Contact = new System.Windows.Forms.TabPage();
            this.uscEditorContacts = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ContactsEditor();
            this.tpTabApplication_Files = new System.Windows.Forms.TabPage();
            this.uscEditorFiles = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.FilesEditor();
            this.tpTabApplication_Reminders = new System.Windows.Forms.TabPage();
            this.uscEditorReminders = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ReminderEditor();
            this.tpTabApplication_Directory = new System.Windows.Forms.TabPage();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectoryInfo = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.nudPriority = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tolApplication.SuspendLayout();
            this.tabApplication.SuspendLayout();
            this.tpTabApplication_Common.SuspendLayout();
            this.grbCommon.SuspendLayout();
            this.grbComment.SuspendLayout();
            this.tpTabApplication_Progress.SuspendLayout();
            this.tpTabApplication_Contact.SuspendLayout();
            this.tpTabApplication_Files.SuspendLayout();
            this.tpTabApplication_Reminders.SuspendLayout();
            this.tpTabApplication_Directory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(592, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Accept;
            this.btnAccept.Location = new System.Drawing.Point(128, 308);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(110, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "Ü&bernehmen";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 308);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tolApplication
            // 
            this.tolApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.tolApplication.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolA_btnGoToFolder,
            this.tolA_lblId,
            this.toolStripSeparator1,
            this.tolA_btnCreateReport});
            this.tolApplication.Location = new System.Drawing.Point(1014, 0);
            this.tolApplication.Name = "tolApplication";
            this.tolApplication.Size = new System.Drawing.Size(24, 343);
            this.tolApplication.TabIndex = 8;
            this.tolApplication.Text = "toolStrip1";
            // 
            // tolA_btnGoToFolder
            // 
            this.tolA_btnGoToFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolA_btnGoToFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolA_btnGoToFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolA_btnGoToFolder.Name = "tolA_btnGoToFolder";
            this.tolA_btnGoToFolder.Size = new System.Drawing.Size(21, 20);
            this.tolA_btnGoToFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolA_btnGoToFolder.Click += new System.EventHandler(this.tolA_btnGoToFolder_Click);
            // 
            // tolA_lblId
            // 
            this.tolA_lblId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolA_lblId.Name = "tolA_lblId";
            this.tolA_lblId.Size = new System.Drawing.Size(21, 95);
            this.tolA_lblId.Text = "Bewerbung Id: {0}";
            this.tolA_lblId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // tolA_btnCreateReport
            // 
            this.tolA_btnCreateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolA_btnCreateReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.tolA_btnCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolA_btnCreateReport.Name = "tolA_btnCreateReport";
            this.tolA_btnCreateReport.Size = new System.Drawing.Size(21, 20);
            this.tolA_btnCreateReport.Text = "Bericht erstellen";
            this.tolA_btnCreateReport.Click += new System.EventHandler(this.tolA_btnCreateReport_Click);
            // 
            // imlRegister
            // 
            this.imlRegister.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRegister.ImageStream")));
            this.imlRegister.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRegister.Images.SetKeyName(0, "Application.png");
            this.imlRegister.Images.SetKeyName(1, "Progress.png");
            this.imlRegister.Images.SetKeyName(2, "User.png");
            this.imlRegister.Images.SetKeyName(3, "Document.png");
            this.imlRegister.Images.SetKeyName(4, "Reminder.png");
            this.imlRegister.Images.SetKeyName(5, "Open.png");
            // 
            // tabApplication
            // 
            this.tabApplication.Controls.Add(this.tpTabApplication_Common);
            this.tabApplication.Controls.Add(this.tpTabApplication_Progress);
            this.tabApplication.Controls.Add(this.tpTabApplication_Contact);
            this.tabApplication.Controls.Add(this.tpTabApplication_Files);
            this.tabApplication.Controls.Add(this.tpTabApplication_Reminders);
            this.tabApplication.Controls.Add(this.tpTabApplication_Directory);
            this.tabApplication.ImageList = this.imlRegister;
            this.tabApplication.Location = new System.Drawing.Point(12, 38);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.SelectedIndex = 0;
            this.tabApplication.Size = new System.Drawing.Size(999, 264);
            this.tabApplication.TabIndex = 4;
            // 
            // tpTabApplication_Common
            // 
            this.tpTabApplication_Common.Controls.Add(this.grbCommon);
            this.tpTabApplication_Common.Controls.Add(this.grbComment);
            this.tpTabApplication_Common.ImageIndex = 0;
            this.tpTabApplication_Common.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Common.Name = "tpTabApplication_Common";
            this.tpTabApplication_Common.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Common.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Common.TabIndex = 0;
            this.tpTabApplication_Common.Text = "Allgemein";
            this.tpTabApplication_Common.UseVisualStyleBackColor = true;
            // 
            // grbCommon
            // 
            this.grbCommon.Controls.Add(this.mtbDatePeriodStart);
            this.grbCommon.Controls.Add(this.mtbDatePeriodEnd);
            this.grbCommon.Controls.Add(this.mtbDateCreated);
            this.grbCommon.Controls.Add(this.lblDatePeriodStart);
            this.grbCommon.Controls.Add(this.lblDatePeriodEnd);
            this.grbCommon.Controls.Add(this.chkArchive);
            this.grbCommon.Controls.Add(this.txtReferenceCode);
            this.grbCommon.Controls.Add(this.lblReferenceCode);
            this.grbCommon.Controls.Add(this.lblDateCreated);
            this.grbCommon.Controls.Add(this.chkSpeculativeApplication);
            this.grbCommon.Location = new System.Drawing.Point(6, 6);
            this.grbCommon.Name = "grbCommon";
            this.grbCommon.Size = new System.Drawing.Size(670, 97);
            this.grbCommon.TabIndex = 0;
            this.grbCommon.TabStop = false;
            this.grbCommon.Text = "Allgemein";
            // 
            // mtbDatePeriodStart
            // 
            this.mtbDatePeriodStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbDatePeriodStart.Date = null;
            this.mtbDatePeriodStart.Location = new System.Drawing.Point(156, 71);
            this.mtbDatePeriodStart.Mask = "00/00/0000";
            this.mtbDatePeriodStart.Name = "mtbDatePeriodStart";
            this.mtbDatePeriodStart.Size = new System.Drawing.Size(80, 20);
            this.mtbDatePeriodStart.TabIndex = 5;
            // 
            // mtbDatePeriodEnd
            // 
            this.mtbDatePeriodEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbDatePeriodEnd.Date = null;
            this.mtbDatePeriodEnd.Location = new System.Drawing.Point(156, 45);
            this.mtbDatePeriodEnd.Mask = "00/00/0000";
            this.mtbDatePeriodEnd.Name = "mtbDatePeriodEnd";
            this.mtbDatePeriodEnd.Size = new System.Drawing.Size(80, 20);
            this.mtbDatePeriodEnd.TabIndex = 3;
            // 
            // mtbDateCreated
            // 
            this.mtbDateCreated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbDateCreated.Date = null;
            this.mtbDateCreated.Location = new System.Drawing.Point(156, 19);
            this.mtbDateCreated.Mask = "00/00/0000";
            this.mtbDateCreated.Name = "mtbDateCreated";
            this.mtbDateCreated.Size = new System.Drawing.Size(80, 20);
            this.mtbDateCreated.TabIndex = 1;
            // 
            // lblDatePeriodStart
            // 
            this.lblDatePeriodStart.AutoSize = true;
            this.lblDatePeriodStart.Location = new System.Drawing.Point(6, 75);
            this.lblDatePeriodStart.Name = "lblDatePeriodStart";
            this.lblDatePeriodStart.Size = new System.Drawing.Size(136, 13);
            this.lblDatePeriodStart.TabIndex = 4;
            this.lblDatePeriodStart.Text = "Ende Bewerbungszeitraum:";
            // 
            // lblDatePeriodEnd
            // 
            this.lblDatePeriodEnd.AutoSize = true;
            this.lblDatePeriodEnd.Location = new System.Drawing.Point(6, 48);
            this.lblDatePeriodEnd.Name = "lblDatePeriodEnd";
            this.lblDatePeriodEnd.Size = new System.Drawing.Size(144, 13);
            this.lblDatePeriodEnd.TabIndex = 2;
            this.lblDatePeriodEnd.Text = "Beginn Bewerbungszeitraum:";
            // 
            // chkArchive
            // 
            this.chkArchive.AutoSize = true;
            this.chkArchive.Location = new System.Drawing.Point(373, 74);
            this.chkArchive.Name = "chkArchive";
            this.chkArchive.Size = new System.Drawing.Size(126, 17);
            this.chkArchive.TabIndex = 9;
            this.chkArchive.Text = "Bewerbung archiviert";
            this.chkArchive.UseVisualStyleBackColor = true;
            // 
            // txtReferenceCode
            // 
            this.txtReferenceCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReferenceCode.Location = new System.Drawing.Point(373, 19);
            this.txtReferenceCode.Name = "txtReferenceCode";
            this.txtReferenceCode.Size = new System.Drawing.Size(291, 20);
            this.txtReferenceCode.TabIndex = 7;
            // 
            // lblReferenceCode
            // 
            this.lblReferenceCode.AutoSize = true;
            this.lblReferenceCode.Location = new System.Drawing.Point(277, 22);
            this.lblReferenceCode.Name = "lblReferenceCode";
            this.lblReferenceCode.Size = new System.Drawing.Size(90, 13);
            this.lblReferenceCode.TabIndex = 6;
            this.lblReferenceCode.Text = "Referenznummer:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Location = new System.Drawing.Point(6, 25);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(108, 13);
            this.lblDateCreated.TabIndex = 0;
            this.lblDateCreated.Text = "Bewerbung angelegt:";
            // 
            // chkSpeculativeApplication
            // 
            this.chkSpeculativeApplication.AutoSize = true;
            this.chkSpeculativeApplication.Location = new System.Drawing.Point(373, 48);
            this.chkSpeculativeApplication.Name = "chkSpeculativeApplication";
            this.chkSpeculativeApplication.Size = new System.Drawing.Size(112, 17);
            this.chkSpeculativeApplication.TabIndex = 8;
            this.chkSpeculativeApplication.Text = "Initiativbewerbung";
            this.chkSpeculativeApplication.UseVisualStyleBackColor = true;
            // 
            // grbComment
            // 
            this.grbComment.Controls.Add(this.txtComment);
            this.grbComment.Location = new System.Drawing.Point(6, 109);
            this.grbComment.Name = "grbComment";
            this.grbComment.Size = new System.Drawing.Size(670, 123);
            this.grbComment.TabIndex = 1;
            this.grbComment.TabStop = false;
            this.grbComment.Text = "Kommentar";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(9, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(655, 98);
            this.txtComment.TabIndex = 0;
            // 
            // tpTabApplication_Progress
            // 
            this.tpTabApplication_Progress.Controls.Add(this.uscProgressEditor);
            this.tpTabApplication_Progress.ImageIndex = 1;
            this.tpTabApplication_Progress.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Progress.Name = "tpTabApplication_Progress";
            this.tpTabApplication_Progress.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Progress.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Progress.TabIndex = 5;
            this.tpTabApplication_Progress.Text = "Fortschritt";
            this.tpTabApplication_Progress.UseVisualStyleBackColor = true;
            // 
            // uscStateEditor
            // 
            this.uscProgressEditor.IdSet = null;
            this.uscProgressEditor.Items = null;
            this.uscProgressEditor.Location = new System.Drawing.Point(6, 6);
            this.uscProgressEditor.Name = "uscStateEditor";
            this.uscProgressEditor.Size = new System.Drawing.Size(979, 226);
            this.uscProgressEditor.TabIndex = 0;
            // 
            // tpTabApplication_Contact
            // 
            this.tpTabApplication_Contact.Controls.Add(this.uscEditorContacts);
            this.tpTabApplication_Contact.ImageIndex = 2;
            this.tpTabApplication_Contact.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Contact.Name = "tpTabApplication_Contact";
            this.tpTabApplication_Contact.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Contact.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Contact.TabIndex = 2;
            this.tpTabApplication_Contact.Text = "Ansprechpartner";
            this.tpTabApplication_Contact.UseVisualStyleBackColor = true;
            // 
            // uscEditorContacts
            // 
            this.uscEditorContacts.ApplicationMode = true;
            this.uscEditorContacts.AssociatedContacts = ((System.Collections.Generic.List<int>)(resources.GetObject("uscEditorContacts.AssociatedContacts")));
            this.uscEditorContacts.CompanyId = 0;
            this.uscEditorContacts.IdSet = null;
            this.uscEditorContacts.Items = null;
            this.uscEditorContacts.Location = new System.Drawing.Point(6, 6);
            this.uscEditorContacts.Name = "uscEditorContacts";
            this.uscEditorContacts.Project = null;
            this.uscEditorContacts.Size = new System.Drawing.Size(979, 226);
            this.uscEditorContacts.TabIndex = 0;
            this.uscEditorContacts.ItemAddedOrAssociationChanged += new System.EventHandler(this.uscEditorContacts_ItemAddedOrAssociationChanged);
            // 
            // tpTabApplication_Files
            // 
            this.tpTabApplication_Files.Controls.Add(this.uscEditorFiles);
            this.tpTabApplication_Files.ImageIndex = 3;
            this.tpTabApplication_Files.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Files.Name = "tpTabApplication_Files";
            this.tpTabApplication_Files.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Files.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Files.TabIndex = 4;
            this.tpTabApplication_Files.Text = "Dateianhänge";
            this.tpTabApplication_Files.UseVisualStyleBackColor = true;
            // 
            // uscEditorFiles
            // 
            this.uscEditorFiles.IdSet = null;
            this.uscEditorFiles.Items = null;
            this.uscEditorFiles.Location = new System.Drawing.Point(6, 6);
            this.uscEditorFiles.Name = "uscEditorFiles";
            this.uscEditorFiles.Size = new System.Drawing.Size(979, 226);
            this.uscEditorFiles.TabIndex = 0;
            // 
            // tpTabApplication_Reminders
            // 
            this.tpTabApplication_Reminders.Controls.Add(this.uscEditorReminders);
            this.tpTabApplication_Reminders.ImageIndex = 4;
            this.tpTabApplication_Reminders.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Reminders.Name = "tpTabApplication_Reminders";
            this.tpTabApplication_Reminders.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Reminders.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Reminders.TabIndex = 3;
            this.tpTabApplication_Reminders.Text = "Erinnerungen";
            this.tpTabApplication_Reminders.UseVisualStyleBackColor = true;
            // 
            // uscEditorReminders
            // 
            this.uscEditorReminders.IdSet = null;
            this.uscEditorReminders.Items = null;
            this.uscEditorReminders.Location = new System.Drawing.Point(6, 6);
            this.uscEditorReminders.Name = "uscEditorReminders";
            this.uscEditorReminders.Size = new System.Drawing.Size(979, 226);
            this.uscEditorReminders.TabIndex = 0;
            // 
            // tpTabApplication_Directory
            // 
            this.tpTabApplication_Directory.Controls.Add(this.btnDirectory);
            this.tpTabApplication_Directory.Controls.Add(this.lblDirectory);
            this.tpTabApplication_Directory.Controls.Add(this.txtDirectory);
            this.tpTabApplication_Directory.Controls.Add(this.lblDirectoryInfo);
            this.tpTabApplication_Directory.ImageIndex = 5;
            this.tpTabApplication_Directory.Location = new System.Drawing.Point(4, 23);
            this.tpTabApplication_Directory.Name = "tpTabApplication_Directory";
            this.tpTabApplication_Directory.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabApplication_Directory.Size = new System.Drawing.Size(991, 237);
            this.tpTabApplication_Directory.TabIndex = 6;
            this.tpTabApplication_Directory.Text = "Ordner";
            this.tpTabApplication_Directory.UseVisualStyleBackColor = true;
            // 
            // btnDirectory
            // 
            this.btnDirectory.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Open;
            this.btnDirectory.Location = new System.Drawing.Point(576, 43);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(100, 23);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.Text = "Durchsuchen";
            this.btnDirectory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectory.UseVisualStyleBackColor = true;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(6, 48);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(32, 13);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Pfad:";
            // 
            // txtDirectory
            // 
            this.txtDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDirectory.Location = new System.Drawing.Point(44, 45);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(526, 20);
            this.txtDirectory.TabIndex = 2;
            // 
            // lblDirectoryInfo
            // 
            this.lblDirectoryInfo.AutoSize = true;
            this.lblDirectoryInfo.Location = new System.Drawing.Point(6, 3);
            this.lblDirectoryInfo.Name = "lblDirectoryInfo";
            this.lblDirectoryInfo.Size = new System.Drawing.Size(460, 39);
            this.lblDirectoryInfo.TabIndex = 0;
            this.lblDirectoryInfo.Text = resources.GetString("lblDirectoryInfo.Text");
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(591, 15);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(45, 13);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priorität:";
            // 
            // nudPriority
            // 
            this.nudPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudPriority.Location = new System.Drawing.Point(642, 12);
            this.nudPriority.Name = "nudPriority";
            this.nudPriority.Size = new System.Drawing.Size(60, 20);
            this.nudPriority.TabIndex = 3;
            this.nudPriority.ThousandsSeparator = true;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(48, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(459, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
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
            // ApplicationEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1038, 343);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.nudPriority);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabApplication);
            this.Controls.Add(this.tolApplication);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationEditForm";
            this.ShowInTaskbar = false;
            this.Text = "[Neue Bewerbung]";
            this.tolApplication.ResumeLayout(false);
            this.tolApplication.PerformLayout();
            this.tabApplication.ResumeLayout(false);
            this.tpTabApplication_Common.ResumeLayout(false);
            this.grbCommon.ResumeLayout(false);
            this.grbCommon.PerformLayout();
            this.grbComment.ResumeLayout(false);
            this.grbComment.PerformLayout();
            this.tpTabApplication_Progress.ResumeLayout(false);
            this.tpTabApplication_Contact.ResumeLayout(false);
            this.tpTabApplication_Files.ResumeLayout(false);
            this.tpTabApplication_Reminders.ResumeLayout(false);
            this.tpTabApplication_Directory.ResumeLayout(false);
            this.tpTabApplication_Directory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ToolStrip tolApplication;
        private System.Windows.Forms.ToolStripButton tolA_btnCreateReport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tolA_btnGoToFolder;
        private System.Windows.Forms.ToolStripLabel tolA_lblId;
        private System.Windows.Forms.ImageList imlRegister;
        private System.Windows.Forms.TabControl tabApplication;
        private System.Windows.Forms.TabPage tpTabApplication_Common;
        private System.Windows.Forms.GroupBox grbCommon;
        private System.Windows.Forms.CheckBox chkArchive;
        private System.Windows.Forms.TextBox txtReferenceCode;
        private System.Windows.Forms.Label lblReferenceCode;
        private System.Windows.Forms.Label lblDateCreated;
        private System.Windows.Forms.CheckBox chkSpeculativeApplication;
        private System.Windows.Forms.GroupBox grbComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TabPage tpTabApplication_Progress;
        private System.Windows.Forms.TabPage tpTabApplication_Contact;
        private System.Windows.Forms.TabPage tpTabApplication_Files;
        private System.Windows.Forms.TabPage tpTabApplication_Reminders;
        private System.Windows.Forms.TabPage tpTabApplication_Directory;
        private Controles.ContactsEditor uscEditorContacts;
        private Controles.FilesEditor uscEditorFiles;
        private Controles.ReminderEditor uscEditorReminders;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lblDirectoryInfo;
        private System.Windows.Forms.Label lblDatePeriodStart;
        private System.Windows.Forms.Label lblDatePeriodEnd;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.NumericUpDown nudPriority;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private Toolbox.Widgets.DateInputAndValidator mtbDateCreated;
        private Toolbox.Widgets.DateInputAndValidator mtbDatePeriodStart;
        private Toolbox.Widgets.DateInputAndValidator mtbDatePeriodEnd;
        private Controles.ProgressEditor uscProgressEditor;
    }
}