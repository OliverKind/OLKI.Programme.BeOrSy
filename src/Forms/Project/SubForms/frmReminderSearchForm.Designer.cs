namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ReminderSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderSearchForm));
            this.mtbFilterDateTo = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.mtbFilterDateFrom = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.lblFilterStart = new System.Windows.Forms.Label();
            this.lblFilterEnd = new System.Windows.Forms.Label();
            this.tslApplicationsSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.chLsvReminders_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvReminders = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvReminders_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_Application = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_CompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_ApplicationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvReminders_ReminderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlReminders = new System.Windows.Forms.ImageList(this.components);
            this.stsApplicationList = new System.Windows.Forms.StatusStrip();
            this.tslApplicationsTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslApplicationsList = new System.Windows.Forms.ToolStripStatusLabel();
            this.tolListReminders = new System.Windows.Forms.ToolStrip();
            this.tolLR_btnGoToCompFolder = new System.Windows.Forms.ToolStripButton();
            this.tolLR_lblCompId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tolLR_btnGoToApplFolder = new System.Windows.Forms.ToolStripButton();
            this.tolLR_lblApplId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tolLR_btnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.chkFilterAcknowledge = new System.Windows.Forms.CheckBox();
            this.lblFilterText = new System.Windows.Forms.Label();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnListReminders = new System.Windows.Forms.Button();
            this.grbFilterReminderAssociated = new System.Windows.Forms.GroupBox();
            this.chkFilterSourceCompany = new System.Windows.Forms.CheckBox();
            this.chkFilterSourceApplication = new System.Windows.Forms.CheckBox();
            this.imlProgressState = new System.Windows.Forms.ImageList(this.components);
            this.grbReminderEdit = new System.Windows.Forms.GroupBox();
            this.btnReminderDelete = new System.Windows.Forms.Button();
            this.chkReminderAcknowledge = new System.Windows.Forms.CheckBox();
            this.mtbReminderDate = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.txtReminderTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReminderApplication = new System.Windows.Forms.TextBox();
            this.txtReminderCompany = new System.Windows.Forms.TextBox();
            this.lblReminerComment = new System.Windows.Forms.Label();
            this.txtReminderComment = new System.Windows.Forms.TextBox();
            this.lblReminderTitle = new System.Windows.Forms.Label();
            this.lblReminderDate = new System.Windows.Forms.Label();
            this.stsApplicationList.SuspendLayout();
            this.tolListReminders.SuspendLayout();
            this.grbFilter.SuspendLayout();
            this.grbFilterReminderAssociated.SuspendLayout();
            this.grbReminderEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtbFilterDateTo
            // 
            this.mtbFilterDateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbFilterDateTo.Date = null;
            this.mtbFilterDateTo.Location = new System.Drawing.Point(169, 19);
            this.mtbFilterDateTo.Mask = "00/00/0000";
            this.mtbFilterDateTo.Name = "mtbFilterDateTo";
            this.mtbFilterDateTo.Size = new System.Drawing.Size(99, 20);
            this.mtbFilterDateTo.TabIndex = 3;
            // 
            // mtbFilterDateFrom
            // 
            this.mtbFilterDateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbFilterDateFrom.Date = null;
            this.mtbFilterDateFrom.Location = new System.Drawing.Point(38, 19);
            this.mtbFilterDateFrom.Mask = "00/00/0000";
            this.mtbFilterDateFrom.Name = "mtbFilterDateFrom";
            this.mtbFilterDateFrom.Size = new System.Drawing.Size(99, 20);
            this.mtbFilterDateFrom.TabIndex = 1;
            // 
            // lblFilterStart
            // 
            this.lblFilterStart.AutoSize = true;
            this.lblFilterStart.Location = new System.Drawing.Point(6, 22);
            this.lblFilterStart.Name = "lblFilterStart";
            this.lblFilterStart.Size = new System.Drawing.Size(26, 13);
            this.lblFilterStart.TabIndex = 0;
            this.lblFilterStart.Text = "Von";
            // 
            // lblFilterEnd
            // 
            this.lblFilterEnd.AutoSize = true;
            this.lblFilterEnd.Location = new System.Drawing.Point(143, 22);
            this.lblFilterEnd.Name = "lblFilterEnd";
            this.lblFilterEnd.Size = new System.Drawing.Size(20, 13);
            this.lblFilterEnd.TabIndex = 2;
            this.lblFilterEnd.Text = "bis";
            // 
            // tslApplicationsSelected
            // 
            this.tslApplicationsSelected.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.tslApplicationsSelected.Name = "tslApplicationsSelected";
            this.tslApplicationsSelected.Size = new System.Drawing.Size(219, 17);
            this.tslApplicationsSelected.Text = "Erinnerungen für Bericht ausgewählt: {0}";
            // 
            // chLsvReminders_Title
            // 
            this.chLsvReminders_Title.Text = "Titel";
            this.chLsvReminders_Title.Width = 180;
            // 
            // chLsvReminders_Date
            // 
            this.chLsvReminders_Date.Text = "Datum";
            this.chLsvReminders_Date.Width = 90;
            // 
            // lsvReminders
            // 
            this.lsvReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvReminders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvReminders_Title,
            this.chLsvReminders_Comment,
            this.chLsvReminders_Date,
            this.chLsvReminders_Company,
            this.chLsvReminders_Application,
            this.chLsvReminders_CompanyId,
            this.chLsvReminders_ApplicationId,
            this.chLsvReminders_ReminderId});
            this.lsvReminders.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvReminders.ColumnWidths")));
            this.lsvReminders.FullRowSelect = true;
            this.lsvReminders.GridLines = true;
            this.lsvReminders.HideSelection = false;
            this.lsvReminders.Location = new System.Drawing.Point(6, 242);
            this.lsvReminders.Name = "lsvReminders";
            this.lsvReminders.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvReminders.Size = new System.Drawing.Size(804, 434);
            this.lsvReminders.SmallImageList = this.imlReminders;
            this.lsvReminders.TabIndex = 1;
            this.lsvReminders.UseCompatibleStateImageBehavior = false;
            this.lsvReminders.View = System.Windows.Forms.View.Details;
            this.lsvReminders.SelectedIndexChanged += new System.EventHandler(this.lsvReminders_SelectedIndexChanged);
            // 
            // chLsvReminders_Comment
            // 
            this.chLsvReminders_Comment.Text = "Kommentar";
            this.chLsvReminders_Comment.Width = 180;
            // 
            // chLsvReminders_Company
            // 
            this.chLsvReminders_Company.Text = "Firma";
            this.chLsvReminders_Company.Width = 120;
            // 
            // chLsvReminders_Application
            // 
            this.chLsvReminders_Application.Text = "Bewerbung";
            this.chLsvReminders_Application.Width = 120;
            // 
            // chLsvReminders_CompanyId
            // 
            this.chLsvReminders_CompanyId.Text = "Id der Firma";
            this.chLsvReminders_CompanyId.Width = 30;
            // 
            // chLsvReminders_ApplicationId
            // 
            this.chLsvReminders_ApplicationId.Text = "Id der Bewerbung";
            this.chLsvReminders_ApplicationId.Width = 30;
            // 
            // chLsvReminders_ReminderId
            // 
            this.chLsvReminders_ReminderId.Text = "Id der Erinnerung";
            this.chLsvReminders_ReminderId.Width = 30;
            // 
            // imlReminders
            // 
            this.imlReminders.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlReminders.ImageStream")));
            this.imlReminders.TransparentColor = System.Drawing.Color.Transparent;
            this.imlReminders.Images.SetKeyName(0, "Reminder_Company.png");
            this.imlReminders.Images.SetKeyName(1, "Reminder_Company_Acknowledge.png");
            this.imlReminders.Images.SetKeyName(2, "Reminder_Application.png");
            this.imlReminders.Images.SetKeyName(3, "Reminder_Application_Acknowledge.png");
            this.imlReminders.Images.SetKeyName(4, "Reminder.png");
            // 
            // stsApplicationList
            // 
            this.stsApplicationList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslApplicationsTotal,
            this.tslApplicationsList,
            this.tslApplicationsSelected});
            this.stsApplicationList.Location = new System.Drawing.Point(0, 679);
            this.stsApplicationList.Name = "stsApplicationList";
            this.stsApplicationList.Size = new System.Drawing.Size(819, 22);
            this.stsApplicationList.SizingGrip = false;
            this.stsApplicationList.TabIndex = 4;
            this.stsApplicationList.Text = "statusStrip1";
            // 
            // tslApplicationsTotal
            // 
            this.tslApplicationsTotal.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.tslApplicationsTotal.Name = "tslApplicationsTotal";
            this.tslApplicationsTotal.Size = new System.Drawing.Size(155, 17);
            this.tslApplicationsTotal.Text = "Erinnerungen Insgesamt: {0}";
            // 
            // tslApplicationsList
            // 
            this.tslApplicationsList.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.tslApplicationsList.Name = "tslApplicationsList";
            this.tslApplicationsList.Size = new System.Drawing.Size(158, 17);
            this.tslApplicationsList.Text = "Erinnerungen in der Liste: {0}";
            // 
            // tolListReminders
            // 
            this.tolListReminders.Dock = System.Windows.Forms.DockStyle.Right;
            this.tolListReminders.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolListReminders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolLR_btnGoToCompFolder,
            this.tolLR_lblCompId,
            this.toolStripSeparator2,
            this.tolLR_btnGoToApplFolder,
            this.tolLR_lblApplId,
            this.toolStripSeparator3,
            this.tolLR_btnCreateReport});
            this.tolListReminders.Location = new System.Drawing.Point(819, 0);
            this.tolListReminders.Name = "tolListReminders";
            this.tolListReminders.Size = new System.Drawing.Size(24, 701);
            this.tolListReminders.TabIndex = 3;
            this.tolListReminders.Text = "toolStrip1";
            // 
            // tolLR_btnGoToCompFolder
            // 
            this.tolLR_btnGoToCompFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLR_btnGoToCompFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolLR_btnGoToCompFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLR_btnGoToCompFolder.Name = "tolLR_btnGoToCompFolder";
            this.tolLR_btnGoToCompFolder.Size = new System.Drawing.Size(21, 20);
            this.tolLR_btnGoToCompFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolLR_btnGoToCompFolder.Click += new System.EventHandler(this.tolLR_btnGoToCompFolder_Click);
            // 
            // tolLR_lblCompId
            // 
            this.tolLR_lblCompId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolLR_lblCompId.Name = "tolLR_lblCompId";
            this.tolLR_lblCompId.Size = new System.Drawing.Size(21, 66);
            this.tolLR_lblCompId.Text = "Firma Id: {0}";
            this.tolLR_lblCompId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // tolLR_btnGoToApplFolder
            // 
            this.tolLR_btnGoToApplFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLR_btnGoToApplFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolLR_btnGoToApplFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLR_btnGoToApplFolder.Name = "tolLR_btnGoToApplFolder";
            this.tolLR_btnGoToApplFolder.Size = new System.Drawing.Size(21, 20);
            this.tolLR_btnGoToApplFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolLR_btnGoToApplFolder.Click += new System.EventHandler(this.tolLR_btnGoToApplFolder_Click);
            // 
            // tolLR_lblApplId
            // 
            this.tolLR_lblApplId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolLR_lblApplId.Name = "tolLR_lblApplId";
            this.tolLR_lblApplId.Size = new System.Drawing.Size(21, 95);
            this.tolLR_lblApplId.Text = "Bewerbung Id: {0}";
            this.tolLR_lblApplId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(21, 6);
            // 
            // tolLR_btnCreateReport
            // 
            this.tolLR_btnCreateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLR_btnCreateReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.tolLR_btnCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLR_btnCreateReport.Name = "tolLR_btnCreateReport";
            this.tolLR_btnCreateReport.Size = new System.Drawing.Size(21, 20);
            this.tolLR_btnCreateReport.Text = "Bericht erstellen";
            this.tolLR_btnCreateReport.Click += new System.EventHandler(this.tolLR_btnCreateReport_Click);
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.chkFilterAcknowledge);
            this.grbFilter.Controls.Add(this.mtbFilterDateTo);
            this.grbFilter.Controls.Add(this.lblFilterText);
            this.grbFilter.Controls.Add(this.mtbFilterDateFrom);
            this.grbFilter.Controls.Add(this.txtFilterText);
            this.grbFilter.Controls.Add(this.btnCancel);
            this.grbFilter.Controls.Add(this.lblFilterStart);
            this.grbFilter.Controls.Add(this.lblFilterEnd);
            this.grbFilter.Controls.Add(this.btnListReminders);
            this.grbFilter.Controls.Add(this.grbFilterReminderAssociated);
            this.grbFilter.Location = new System.Drawing.Point(12, 12);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(286, 224);
            this.grbFilter.TabIndex = 0;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filtereinstellungen";
            // 
            // chkFilterAcknowledge
            // 
            this.chkFilterAcknowledge.AutoSize = true;
            this.chkFilterAcknowledge.Checked = true;
            this.chkFilterAcknowledge.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFilterAcknowledge.Location = new System.Drawing.Point(6, 45);
            this.chkFilterAcknowledge.Name = "chkFilterAcknowledge";
            this.chkFilterAcknowledge.Size = new System.Drawing.Size(65, 17);
            this.chkFilterAcknowledge.TabIndex = 4;
            this.chkFilterAcknowledge.Text = "Gelesen";
            this.chkFilterAcknowledge.ThreeState = true;
            this.chkFilterAcknowledge.UseVisualStyleBackColor = true;
            // 
            // lblFilterText
            // 
            this.lblFilterText.AutoSize = true;
            this.lblFilterText.Location = new System.Drawing.Point(6, 142);
            this.lblFilterText.Name = "lblFilterText";
            this.lblFilterText.Size = new System.Drawing.Size(31, 13);
            this.lblFilterText.TabIndex = 6;
            this.lblFilterText.Text = "Text:";
            // 
            // txtFilterText
            // 
            this.txtFilterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFilterText.Location = new System.Drawing.Point(43, 139);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(237, 20);
            this.txtFilterText.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnListReminders
            // 
            this.btnListReminders.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Search;
            this.btnListReminders.Location = new System.Drawing.Point(6, 195);
            this.btnListReminders.Name = "btnListReminders";
            this.btnListReminders.Size = new System.Drawing.Size(274, 23);
            this.btnListReminders.TabIndex = 9;
            this.btnListReminders.Text = "Erinnerungen suchen";
            this.btnListReminders.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListReminders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListReminders.UseVisualStyleBackColor = true;
            this.btnListReminders.Click += new System.EventHandler(this.btnListReminders_Click);
            // 
            // grbFilterReminderAssociated
            // 
            this.grbFilterReminderAssociated.Controls.Add(this.chkFilterSourceCompany);
            this.grbFilterReminderAssociated.Controls.Add(this.chkFilterSourceApplication);
            this.grbFilterReminderAssociated.Location = new System.Drawing.Point(6, 68);
            this.grbFilterReminderAssociated.Name = "grbFilterReminderAssociated";
            this.grbFilterReminderAssociated.Size = new System.Drawing.Size(274, 65);
            this.grbFilterReminderAssociated.TabIndex = 5;
            this.grbFilterReminderAssociated.TabStop = false;
            this.grbFilterReminderAssociated.Text = "Zuordnung";
            // 
            // chkFilterSourceCompany
            // 
            this.chkFilterSourceCompany.AutoSize = true;
            this.chkFilterSourceCompany.Checked = true;
            this.chkFilterSourceCompany.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFilterSourceCompany.Location = new System.Drawing.Point(6, 42);
            this.chkFilterSourceCompany.Name = "chkFilterSourceCompany";
            this.chkFilterSourceCompany.Size = new System.Drawing.Size(51, 17);
            this.chkFilterSourceCompany.TabIndex = 1;
            this.chkFilterSourceCompany.Text = "Firma";
            this.chkFilterSourceCompany.ThreeState = true;
            this.chkFilterSourceCompany.UseVisualStyleBackColor = true;
            // 
            // chkFilterSourceApplication
            // 
            this.chkFilterSourceApplication.AutoSize = true;
            this.chkFilterSourceApplication.Checked = true;
            this.chkFilterSourceApplication.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFilterSourceApplication.Location = new System.Drawing.Point(6, 19);
            this.chkFilterSourceApplication.Name = "chkFilterSourceApplication";
            this.chkFilterSourceApplication.Size = new System.Drawing.Size(80, 17);
            this.chkFilterSourceApplication.TabIndex = 0;
            this.chkFilterSourceApplication.Text = "Bewerbung";
            this.chkFilterSourceApplication.ThreeState = true;
            this.chkFilterSourceApplication.UseVisualStyleBackColor = true;
            // 
            // imlProgressState
            // 
            this.imlProgressState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlProgressState.ImageStream")));
            this.imlProgressState.TransparentColor = System.Drawing.Color.Transparent;
            this.imlProgressState.Images.SetKeyName(0, "Progress_Active.png");
            this.imlProgressState.Images.SetKeyName(1, "Progress_Finish.png");
            this.imlProgressState.Images.SetKeyName(2, "Progress_FinishLowPriority.png");
            // 
            // grbReminderEdit
            // 
            this.grbReminderEdit.Controls.Add(this.btnReminderDelete);
            this.grbReminderEdit.Controls.Add(this.chkReminderAcknowledge);
            this.grbReminderEdit.Controls.Add(this.mtbReminderDate);
            this.grbReminderEdit.Controls.Add(this.txtReminderTitle);
            this.grbReminderEdit.Controls.Add(this.label4);
            this.grbReminderEdit.Controls.Add(this.label3);
            this.grbReminderEdit.Controls.Add(this.txtReminderApplication);
            this.grbReminderEdit.Controls.Add(this.txtReminderCompany);
            this.grbReminderEdit.Controls.Add(this.lblReminerComment);
            this.grbReminderEdit.Controls.Add(this.txtReminderComment);
            this.grbReminderEdit.Controls.Add(this.lblReminderTitle);
            this.grbReminderEdit.Controls.Add(this.lblReminderDate);
            this.grbReminderEdit.Location = new System.Drawing.Point(321, 12);
            this.grbReminderEdit.Name = "grbReminderEdit";
            this.grbReminderEdit.Size = new System.Drawing.Size(495, 224);
            this.grbReminderEdit.TabIndex = 2;
            this.grbReminderEdit.TabStop = false;
            this.grbReminderEdit.Text = "Gewählte Erinnerung:";
            // 
            // btnReminderDelete
            // 
            this.btnReminderDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnReminderDelete.Location = new System.Drawing.Point(6, 194);
            this.btnReminderDelete.Name = "btnReminderDelete";
            this.btnReminderDelete.Size = new System.Drawing.Size(81, 24);
            this.btnReminderDelete.TabIndex = 10;
            this.btnReminderDelete.Text = "Löschen";
            this.btnReminderDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReminderDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReminderDelete.UseVisualStyleBackColor = true;
            this.btnReminderDelete.Click += new System.EventHandler(this.btnReminderDelete_Click);
            // 
            // chkReminderAcknowledge
            // 
            this.chkReminderAcknowledge.AutoSize = true;
            this.chkReminderAcknowledge.Location = new System.Drawing.Point(422, 70);
            this.chkReminderAcknowledge.Name = "chkReminderAcknowledge";
            this.chkReminderAcknowledge.Size = new System.Drawing.Size(67, 17);
            this.chkReminderAcknowledge.TabIndex = 6;
            this.chkReminderAcknowledge.Text = "Bestätigt";
            this.chkReminderAcknowledge.UseVisualStyleBackColor = true;
            this.chkReminderAcknowledge.CheckedChanged += new System.EventHandler(this.chkReminderAcknowledge_CheckedChanged);
            // 
            // mtbReminderDate
            // 
            this.mtbReminderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbReminderDate.Date = null;
            this.mtbReminderDate.Location = new System.Drawing.Point(93, 71);
            this.mtbReminderDate.Mask = "00/00/0000";
            this.mtbReminderDate.Name = "mtbReminderDate";
            this.mtbReminderDate.Size = new System.Drawing.Size(99, 20);
            this.mtbReminderDate.TabIndex = 5;
            this.mtbReminderDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbReminderDate_MaskInputRejected);
            // 
            // txtReminderTitle
            // 
            this.txtReminderTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReminderTitle.Location = new System.Drawing.Point(93, 97);
            this.txtReminderTitle.Name = "txtReminderTitle";
            this.txtReminderTitle.Size = new System.Drawing.Size(396, 20);
            this.txtReminderTitle.TabIndex = 8;
            this.txtReminderTitle.TextChanged += new System.EventHandler(this.txtReminderTitle_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bewerbung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firma:";
            // 
            // txtReminderApplication
            // 
            this.txtReminderApplication.Location = new System.Drawing.Point(93, 45);
            this.txtReminderApplication.Name = "txtReminderApplication";
            this.txtReminderApplication.ReadOnly = true;
            this.txtReminderApplication.Size = new System.Drawing.Size(396, 20);
            this.txtReminderApplication.TabIndex = 3;
            // 
            // txtReminderCompany
            // 
            this.txtReminderCompany.Location = new System.Drawing.Point(93, 19);
            this.txtReminderCompany.Name = "txtReminderCompany";
            this.txtReminderCompany.ReadOnly = true;
            this.txtReminderCompany.Size = new System.Drawing.Size(396, 20);
            this.txtReminderCompany.TabIndex = 1;
            // 
            // lblReminerComment
            // 
            this.lblReminerComment.AutoSize = true;
            this.lblReminerComment.Location = new System.Drawing.Point(6, 126);
            this.lblReminerComment.Name = "lblReminerComment";
            this.lblReminerComment.Size = new System.Drawing.Size(31, 13);
            this.lblReminerComment.TabIndex = 9;
            this.lblReminerComment.Text = "Text:";
            // 
            // txtReminderComment
            // 
            this.txtReminderComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReminderComment.Location = new System.Drawing.Point(93, 123);
            this.txtReminderComment.Multiline = true;
            this.txtReminderComment.Name = "txtReminderComment";
            this.txtReminderComment.Size = new System.Drawing.Size(396, 95);
            this.txtReminderComment.TabIndex = 10;
            this.txtReminderComment.TextChanged += new System.EventHandler(this.txtReminderComment_TextChanged);
            // 
            // lblReminderTitle
            // 
            this.lblReminderTitle.AutoSize = true;
            this.lblReminderTitle.Location = new System.Drawing.Point(6, 100);
            this.lblReminderTitle.Name = "lblReminderTitle";
            this.lblReminderTitle.Size = new System.Drawing.Size(30, 13);
            this.lblReminderTitle.TabIndex = 7;
            this.lblReminderTitle.Text = "Titel:";
            // 
            // lblReminderDate
            // 
            this.lblReminderDate.AutoSize = true;
            this.lblReminderDate.Location = new System.Drawing.Point(6, 74);
            this.lblReminderDate.Name = "lblReminderDate";
            this.lblReminderDate.Size = new System.Drawing.Size(41, 13);
            this.lblReminderDate.TabIndex = 4;
            this.lblReminderDate.Text = "Datum:";
            // 
            // ReminderSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(843, 701);
            this.Controls.Add(this.grbReminderEdit);
            this.Controls.Add(this.lsvReminders);
            this.Controls.Add(this.stsApplicationList);
            this.Controls.Add(this.tolListReminders);
            this.Controls.Add(this.grbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderSearchForm";
            this.Text = "Erinnerungen suchen in: {0}";
            this.stsApplicationList.ResumeLayout(false);
            this.stsApplicationList.PerformLayout();
            this.tolListReminders.ResumeLayout(false);
            this.tolListReminders.PerformLayout();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            this.grbFilterReminderAssociated.ResumeLayout(false);
            this.grbFilterReminderAssociated.PerformLayout();
            this.grbReminderEdit.ResumeLayout(false);
            this.grbReminderEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFilterStart;
        private System.Windows.Forms.Label lblFilterEnd;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsSelected;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Title;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Date;
        private Toolbox.Widgets.SortListView lsvReminders;
        private System.Windows.Forms.ColumnHeader chLsvReminders_CompanyId;
        private System.Windows.Forms.ColumnHeader chLsvReminders_ApplicationId;
        protected internal System.Windows.Forms.ImageList imlReminders;
        private System.Windows.Forms.StatusStrip stsApplicationList;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsTotal;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsList;
        private System.Windows.Forms.ToolStrip tolListReminders;
        private System.Windows.Forms.ToolStripButton tolLR_btnGoToCompFolder;
        private System.Windows.Forms.ToolStripLabel tolLR_lblCompId;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tolLR_btnGoToApplFolder;
        private System.Windows.Forms.ToolStripLabel tolLR_lblApplId;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tolLR_btnCreateReport;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.Button btnListReminders;
        private System.Windows.Forms.GroupBox grbFilterReminderAssociated;
        private System.Windows.Forms.CheckBox chkFilterSourceCompany;
        private System.Windows.Forms.CheckBox chkFilterSourceApplication;
        private Toolbox.Widgets.DateInputAndValidator mtbFilterDateTo;
        private Toolbox.Widgets.DateInputAndValidator mtbFilterDateFrom;
        private System.Windows.Forms.ImageList imlProgressState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilterText;
        private System.Windows.Forms.Label lblFilterText;
        private System.Windows.Forms.CheckBox chkFilterAcknowledge;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Company;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Application;
        private System.Windows.Forms.GroupBox grbReminderEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReminderApplication;
        private System.Windows.Forms.TextBox txtReminderCompany;
        private System.Windows.Forms.Label lblReminerComment;
        private System.Windows.Forms.TextBox txtReminderComment;
        private System.Windows.Forms.Label lblReminderTitle;
        private System.Windows.Forms.Label lblReminderDate;
        private System.Windows.Forms.TextBox txtReminderTitle;
        private Toolbox.Widgets.DateInputAndValidator mtbReminderDate;
        private System.Windows.Forms.CheckBox chkReminderAcknowledge;
        private System.Windows.Forms.ColumnHeader chLsvReminders_Comment;
        private System.Windows.Forms.ColumnHeader chLsvReminders_ReminderId;
        private System.Windows.Forms.Button btnReminderDelete;
    }
}