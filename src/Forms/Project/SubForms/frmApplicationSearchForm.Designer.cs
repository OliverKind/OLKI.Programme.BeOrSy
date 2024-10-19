namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ApplicationSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSearchForm));
            this.chLsvProgressFilter_Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbFilterDate = new System.Windows.Forms.GroupBox();
            this.mtbFilterDateTo = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.mtbFilterDateFrom = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.rabDateFilterLastProgress = new System.Windows.Forms.RadioButton();
            this.rabDateFilterFirstProgress = new System.Windows.Forms.RadioButton();
            this.rabDateFilterApplicationCreated = new System.Windows.Forms.RadioButton();
            this.lblFilterStart = new System.Windows.Forms.Label();
            this.lblFilterEnd = new System.Windows.Forms.Label();
            this.tslApplicationsSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.chLsvListApplication_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_ReferenceCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvApplication = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvListApplication_ProgressDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_Company = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_CompanyId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvListApplication_ApplicationId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlApplicationType = new System.Windows.Forms.ImageList(this.components);
            this.stsApplicationList = new System.Windows.Forms.StatusStrip();
            this.tslApplicationsTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslApplicationsList = new System.Windows.Forms.ToolStripStatusLabel();
            this.chLsvProgressFilter_Text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tolListApplication = new System.Windows.Forms.ToolStrip();
            this.tolLA_btnGoToComFolder = new System.Windows.Forms.ToolStripButton();
            this.tolLA_lblComId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tolLA_btnGoToAppFolder = new System.Windows.Forms.ToolStripButton();
            this.tolLA_lblAppId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tolLA_btnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.chkFilterApplicationTypeSpeculative = new System.Windows.Forms.CheckBox();
            this.lblFilterText = new System.Windows.Forms.Label();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboFilterPriority = new System.Windows.Forms.ComboBox();
            this.lblFilterPriority = new System.Windows.Forms.Label();
            this.nudFilterPriority = new System.Windows.Forms.NumericUpDown();
            this.btnListApplications = new System.Windows.Forms.Button();
            this.grbFilterProgress = new System.Windows.Forms.GroupBox();
            this.lsvProgressFilter = new OLKI.Toolbox.Widgets.SortListView();
            this.imlProgressState = new System.Windows.Forms.ImageList(this.components);
            this.grbFilterDate.SuspendLayout();
            this.stsApplicationList.SuspendLayout();
            this.tolListApplication.SuspendLayout();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterPriority)).BeginInit();
            this.grbFilterProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // chLsvProgressFilter_Weight
            // 
            this.chLsvProgressFilter_Weight.Text = "Gewichtung";
            this.chLsvProgressFilter_Weight.Width = 90;
            // 
            // grbFilterDate
            // 
            this.grbFilterDate.Controls.Add(this.mtbFilterDateTo);
            this.grbFilterDate.Controls.Add(this.mtbFilterDateFrom);
            this.grbFilterDate.Controls.Add(this.rabDateFilterLastProgress);
            this.grbFilterDate.Controls.Add(this.rabDateFilterFirstProgress);
            this.grbFilterDate.Controls.Add(this.rabDateFilterApplicationCreated);
            this.grbFilterDate.Controls.Add(this.lblFilterStart);
            this.grbFilterDate.Controls.Add(this.lblFilterEnd);
            this.grbFilterDate.Location = new System.Drawing.Point(6, 19);
            this.grbFilterDate.Name = "grbFilterDate";
            this.grbFilterDate.Size = new System.Drawing.Size(274, 114);
            this.grbFilterDate.TabIndex = 0;
            this.grbFilterDate.TabStop = false;
            this.grbFilterDate.Text = "Bewerbungsdatum im Zeitraum";
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
            // rabDateFilterLastProgress
            // 
            this.rabDateFilterLastProgress.AutoSize = true;
            this.rabDateFilterLastProgress.Location = new System.Drawing.Point(38, 91);
            this.rabDateFilterLastProgress.Name = "rabDateFilterLastProgress";
            this.rabDateFilterLastProgress.Size = new System.Drawing.Size(162, 17);
            this.rabDateFilterLastProgress.TabIndex = 6;
            this.rabDateFilterLastProgress.Text = "Letzter Bewerbungsfortschritt";
            this.rabDateFilterLastProgress.UseVisualStyleBackColor = true;
            // 
            // rabDateFilterFirstProgress
            // 
            this.rabDateFilterFirstProgress.AutoSize = true;
            this.rabDateFilterFirstProgress.Checked = true;
            this.rabDateFilterFirstProgress.Location = new System.Drawing.Point(38, 68);
            this.rabDateFilterFirstProgress.Name = "rabDateFilterFirstProgress";
            this.rabDateFilterFirstProgress.Size = new System.Drawing.Size(157, 17);
            this.rabDateFilterFirstProgress.TabIndex = 5;
            this.rabDateFilterFirstProgress.TabStop = true;
            this.rabDateFilterFirstProgress.Text = "Erster Bewerbungsfortschritt";
            this.rabDateFilterFirstProgress.UseVisualStyleBackColor = true;
            // 
            // rabDateFilterApplicationCreated
            // 
            this.rabDateFilterApplicationCreated.AutoSize = true;
            this.rabDateFilterApplicationCreated.Location = new System.Drawing.Point(38, 45);
            this.rabDateFilterApplicationCreated.Name = "rabDateFilterApplicationCreated";
            this.rabDateFilterApplicationCreated.Size = new System.Drawing.Size(157, 17);
            this.rabDateFilterApplicationCreated.TabIndex = 4;
            this.rabDateFilterApplicationCreated.Text = "Erstelldatum der Bewerbung";
            this.rabDateFilterApplicationCreated.UseVisualStyleBackColor = true;
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
            this.tslApplicationsSelected.Size = new System.Drawing.Size(221, 17);
            this.tslApplicationsSelected.Text = "Bewerbungen für Bericht ausgewählt: {0}";
            // 
            // chLsvListApplication_Title
            // 
            this.chLsvListApplication_Title.Text = "Titel";
            this.chLsvListApplication_Title.Width = 200;
            // 
            // chLsvListApplication_ReferenceCode
            // 
            this.chLsvListApplication_ReferenceCode.Text = "Referenznummer";
            // 
            // chLsvListApplication_Date
            // 
            this.chLsvListApplication_Date.Text = "Datum";
            this.chLsvListApplication_Date.Width = 90;
            // 
            // chLsvListApplication_Progress
            // 
            this.chLsvListApplication_Progress.Text = "Fortschritt";
            this.chLsvListApplication_Progress.Width = 150;
            // 
            // lsvApplication
            // 
            this.lsvApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvApplication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvListApplication_Title,
            this.chLsvListApplication_ReferenceCode,
            this.chLsvListApplication_Date,
            this.chLsvListApplication_Progress,
            this.chLsvListApplication_ProgressDate,
            this.chLsvListApplication_Company,
            this.chLsvListApplication_CompanyId,
            this.chLsvListApplication_ApplicationId});
            this.lsvApplication.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvApplication.ColumnWidths")));
            this.lsvApplication.FullRowSelect = true;
            this.lsvApplication.GridLines = true;
            this.lsvApplication.HideSelection = false;
            this.lsvApplication.Location = new System.Drawing.Point(12, 415);
            this.lsvApplication.Name = "lsvApplication";
            this.lsvApplication.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvApplication.Size = new System.Drawing.Size(804, 261);
            this.lsvApplication.SmallImageList = this.imlApplicationType;
            this.lsvApplication.TabIndex = 1;
            this.lsvApplication.UseCompatibleStateImageBehavior = false;
            this.lsvApplication.View = System.Windows.Forms.View.Details;
            this.lsvApplication.SelectedIndexChanged += new System.EventHandler(this.lsvApplication_SelectedIndexChanged);
            // 
            // chLsvListApplication_ProgressDate
            // 
            this.chLsvListApplication_ProgressDate.Text = "Datum des Fortschrittes";
            this.chLsvListApplication_ProgressDate.Width = 90;
            // 
            // chLsvListApplication_Company
            // 
            this.chLsvListApplication_Company.Text = "Firma";
            this.chLsvListApplication_Company.Width = 140;
            // 
            // chLsvListApplication_CompanyId
            // 
            this.chLsvListApplication_CompanyId.Text = "Id der Firma";
            this.chLsvListApplication_CompanyId.Width = 30;
            // 
            // chLsvListApplication_ApplicationId
            // 
            this.chLsvListApplication_ApplicationId.Text = "Id der Bewerbung";
            this.chLsvListApplication_ApplicationId.Width = 30;
            // 
            // imlApplicationType
            // 
            this.imlApplicationType.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlApplicationType.ImageStream")));
            this.imlApplicationType.TransparentColor = System.Drawing.Color.Transparent;
            this.imlApplicationType.Images.SetKeyName(0, "Application.png");
            this.imlApplicationType.Images.SetKeyName(1, "Application_Vacant.png");
            this.imlApplicationType.Images.SetKeyName(2, "Application_VacantArchive.png");
            this.imlApplicationType.Images.SetKeyName(3, "Application_Speculative.png");
            this.imlApplicationType.Images.SetKeyName(4, "Application_SpeculativeArchive.png");
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
            this.stsApplicationList.TabIndex = 3;
            this.stsApplicationList.Text = "statusStrip1";
            // 
            // tslApplicationsTotal
            // 
            this.tslApplicationsTotal.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.tslApplicationsTotal.Name = "tslApplicationsTotal";
            this.tslApplicationsTotal.Size = new System.Drawing.Size(157, 17);
            this.tslApplicationsTotal.Text = "Bewerbungen Insgesamt: {0}";
            // 
            // tslApplicationsList
            // 
            this.tslApplicationsList.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.tslApplicationsList.Name = "tslApplicationsList";
            this.tslApplicationsList.Size = new System.Drawing.Size(160, 17);
            this.tslApplicationsList.Text = "Bewerbungen in der Liste: {0}";
            // 
            // chLsvProgressFilter_Text
            // 
            this.chLsvProgressFilter_Text.Text = "Benennung";
            this.chLsvProgressFilter_Text.Width = 330;
            // 
            // tolListApplication
            // 
            this.tolListApplication.Dock = System.Windows.Forms.DockStyle.Right;
            this.tolListApplication.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolListApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolLA_btnGoToComFolder,
            this.tolLA_lblComId,
            this.toolStripSeparator2,
            this.tolLA_btnGoToAppFolder,
            this.tolLA_lblAppId,
            this.toolStripSeparator3,
            this.tolLA_btnCreateReport});
            this.tolListApplication.Location = new System.Drawing.Point(819, 0);
            this.tolListApplication.Name = "tolListApplication";
            this.tolListApplication.Size = new System.Drawing.Size(24, 701);
            this.tolListApplication.TabIndex = 2;
            this.tolListApplication.Text = "toolStrip1";
            // 
            // tolLA_btnGoToComFolder
            // 
            this.tolLA_btnGoToComFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLA_btnGoToComFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolLA_btnGoToComFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLA_btnGoToComFolder.Name = "tolLA_btnGoToComFolder";
            this.tolLA_btnGoToComFolder.Size = new System.Drawing.Size(21, 20);
            this.tolLA_btnGoToComFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolLA_btnGoToComFolder.Click += new System.EventHandler(this.tolLA_btnGoToComFolder_Click);
            // 
            // tolLA_lblComId
            // 
            this.tolLA_lblComId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolLA_lblComId.Name = "tolLA_lblComId";
            this.tolLA_lblComId.Size = new System.Drawing.Size(21, 66);
            this.tolLA_lblComId.Text = "Firma Id: {0}";
            this.tolLA_lblComId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(21, 6);
            // 
            // tolLA_btnGoToAppFolder
            // 
            this.tolLA_btnGoToAppFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLA_btnGoToAppFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolLA_btnGoToAppFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLA_btnGoToAppFolder.Name = "tolLA_btnGoToAppFolder";
            this.tolLA_btnGoToAppFolder.Size = new System.Drawing.Size(21, 20);
            this.tolLA_btnGoToAppFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolLA_btnGoToAppFolder.Click += new System.EventHandler(this.tolLA_btnGoToAppFolder_Click);
            // 
            // tolLA_lblAppId
            // 
            this.tolLA_lblAppId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolLA_lblAppId.Name = "tolLA_lblAppId";
            this.tolLA_lblAppId.Size = new System.Drawing.Size(21, 95);
            this.tolLA_lblAppId.Text = "Bewerbung Id: {0}";
            this.tolLA_lblAppId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(21, 6);
            // 
            // tolLA_btnCreateReport
            // 
            this.tolLA_btnCreateReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolLA_btnCreateReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.tolLA_btnCreateReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolLA_btnCreateReport.Name = "tolLA_btnCreateReport";
            this.tolLA_btnCreateReport.Size = new System.Drawing.Size(21, 20);
            this.tolLA_btnCreateReport.Text = "Bericht erstellen";
            this.tolLA_btnCreateReport.Click += new System.EventHandler(this.tolLA_btnCreateReport_Click);
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.chkFilterApplicationTypeSpeculative);
            this.grbFilter.Controls.Add(this.lblFilterText);
            this.grbFilter.Controls.Add(this.txtFilterText);
            this.grbFilter.Controls.Add(this.btnCancel);
            this.grbFilter.Controls.Add(this.cboFilterPriority);
            this.grbFilter.Controls.Add(this.lblFilterPriority);
            this.grbFilter.Controls.Add(this.nudFilterPriority);
            this.grbFilter.Controls.Add(this.btnListApplications);
            this.grbFilter.Controls.Add(this.grbFilterProgress);
            this.grbFilter.Controls.Add(this.grbFilterDate);
            this.grbFilter.Location = new System.Drawing.Point(12, 12);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(804, 397);
            this.grbFilter.TabIndex = 0;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filtereinstellungen";
            // 
            // chkFilterApplicationTypeSpeculative
            // 
            this.chkFilterApplicationTypeSpeculative.AutoSize = true;
            this.chkFilterApplicationTypeSpeculative.Checked = true;
            this.chkFilterApplicationTypeSpeculative.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkFilterApplicationTypeSpeculative.Location = new System.Drawing.Point(6, 139);
            this.chkFilterApplicationTypeSpeculative.Name = "chkFilterApplicationTypeSpeculative";
            this.chkFilterApplicationTypeSpeculative.Size = new System.Drawing.Size(112, 17);
            this.chkFilterApplicationTypeSpeculative.TabIndex = 1;
            this.chkFilterApplicationTypeSpeculative.Text = "Initiativbewerbung";
            this.chkFilterApplicationTypeSpeculative.ThreeState = true;
            this.chkFilterApplicationTypeSpeculative.UseVisualStyleBackColor = true;
            // 
            // lblFilterText
            // 
            this.lblFilterText.AutoSize = true;
            this.lblFilterText.Location = new System.Drawing.Point(6, 192);
            this.lblFilterText.Name = "lblFilterText";
            this.lblFilterText.Size = new System.Drawing.Size(31, 13);
            this.lblFilterText.TabIndex = 5;
            this.lblFilterText.Text = "Text:";
            // 
            // txtFilterText
            // 
            this.txtFilterText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFilterText.Location = new System.Drawing.Point(51, 189);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(229, 20);
            this.txtFilterText.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 338);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cboFilterPriority
            // 
            this.cboFilterPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterPriority.FormattingEnabled = true;
            this.cboFilterPriority.Items.AddRange(new object[] {
            "Nicht bewerten",
            "Ist kleiner oder gleich",
            "Ist gleisch",
            "Ist größer oder gleich",
            "Ist ungleich"});
            this.cboFilterPriority.Location = new System.Drawing.Point(57, 162);
            this.cboFilterPriority.Name = "cboFilterPriority";
            this.cboFilterPriority.Size = new System.Drawing.Size(144, 21);
            this.cboFilterPriority.TabIndex = 3;
            this.cboFilterPriority.SelectedIndexChanged += new System.EventHandler(this.cboFilterPriority_SelectedIndexChanged);
            // 
            // lblFilterPriority
            // 
            this.lblFilterPriority.AutoSize = true;
            this.lblFilterPriority.Location = new System.Drawing.Point(6, 165);
            this.lblFilterPriority.Name = "lblFilterPriority";
            this.lblFilterPriority.Size = new System.Drawing.Size(45, 13);
            this.lblFilterPriority.TabIndex = 2;
            this.lblFilterPriority.Text = "Priorität:";
            // 
            // nudFilterPriority
            // 
            this.nudFilterPriority.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudFilterPriority.Location = new System.Drawing.Point(207, 163);
            this.nudFilterPriority.Name = "nudFilterPriority";
            this.nudFilterPriority.Size = new System.Drawing.Size(73, 20);
            this.nudFilterPriority.TabIndex = 4;
            this.nudFilterPriority.ThousandsSeparator = true;
            // 
            // btnListApplications
            // 
            this.btnListApplications.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Search;
            this.btnListApplications.Location = new System.Drawing.Point(6, 368);
            this.btnListApplications.Name = "btnListApplications";
            this.btnListApplications.Size = new System.Drawing.Size(274, 23);
            this.btnListApplications.TabIndex = 8;
            this.btnListApplications.Text = "Bewerbungen suchen";
            this.btnListApplications.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListApplications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListApplications.UseVisualStyleBackColor = true;
            this.btnListApplications.Click += new System.EventHandler(this.btnListApplications_Click);
            // 
            // grbFilterProgress
            // 
            this.grbFilterProgress.Controls.Add(this.lsvProgressFilter);
            this.grbFilterProgress.Location = new System.Drawing.Point(286, 19);
            this.grbFilterProgress.Name = "grbFilterProgress";
            this.grbFilterProgress.Size = new System.Drawing.Size(512, 372);
            this.grbFilterProgress.TabIndex = 7;
            this.grbFilterProgress.TabStop = false;
            this.grbFilterProgress.Text = "Fortschritt der Bewerbung";
            // 
            // lsvProgressFilter
            // 
            this.lsvProgressFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvProgressFilter.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvProgressFilter_Text,
            this.chLsvProgressFilter_Weight});
            this.lsvProgressFilter.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvProgressFilter.ColumnWidths")));
            this.lsvProgressFilter.FullRowSelect = true;
            this.lsvProgressFilter.GridLines = true;
            this.lsvProgressFilter.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvProgressFilter.HideSelection = false;
            this.lsvProgressFilter.Location = new System.Drawing.Point(6, 19);
            this.lsvProgressFilter.Name = "lsvProgressFilter";
            this.lsvProgressFilter.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvProgressFilter.Size = new System.Drawing.Size(500, 347);
            this.lsvProgressFilter.SmallImageList = this.imlProgressState;
            this.lsvProgressFilter.TabIndex = 0;
            this.lsvProgressFilter.UseCompatibleStateImageBehavior = false;
            this.lsvProgressFilter.View = System.Windows.Forms.View.Details;
            // 
            // imlProgressState
            // 
            this.imlProgressState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlProgressState.ImageStream")));
            this.imlProgressState.TransparentColor = System.Drawing.Color.Transparent;
            this.imlProgressState.Images.SetKeyName(0, "Progress_Active.png");
            this.imlProgressState.Images.SetKeyName(1, "Progress_Finish.png");
            this.imlProgressState.Images.SetKeyName(2, "Progress_FinishLowPriority.png");
            // 
            // ApplicationSearchForm
            // 
            this.AcceptButton = this.btnListApplications;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(843, 701);
            this.Controls.Add(this.lsvApplication);
            this.Controls.Add(this.stsApplicationList);
            this.Controls.Add(this.tolListApplication);
            this.Controls.Add(this.grbFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSearchForm";
            this.Text = "Bewerbungen suchen in: {0}";
            this.grbFilterDate.ResumeLayout(false);
            this.grbFilterDate.PerformLayout();
            this.stsApplicationList.ResumeLayout(false);
            this.stsApplicationList.PerformLayout();
            this.tolListApplication.ResumeLayout(false);
            this.tolListApplication.PerformLayout();
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFilterPriority)).EndInit();
            this.grbFilterProgress.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader chLsvProgressFilter_Weight;
        private System.Windows.Forms.GroupBox grbFilterDate;
        private System.Windows.Forms.RadioButton rabDateFilterLastProgress;
        private System.Windows.Forms.RadioButton rabDateFilterFirstProgress;
        private System.Windows.Forms.RadioButton rabDateFilterApplicationCreated;
        private System.Windows.Forms.Label lblFilterStart;
        private System.Windows.Forms.Label lblFilterEnd;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsSelected;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_Title;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_ReferenceCode;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_Date;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_Progress;
        private Toolbox.Widgets.SortListView lsvApplication;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_ProgressDate;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_Company;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_CompanyId;
        private System.Windows.Forms.ColumnHeader chLsvListApplication_ApplicationId;
        protected internal System.Windows.Forms.ImageList imlApplicationType;
        private System.Windows.Forms.StatusStrip stsApplicationList;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsTotal;
        private System.Windows.Forms.ToolStripStatusLabel tslApplicationsList;
        private System.Windows.Forms.ColumnHeader chLsvProgressFilter_Text;
        private System.Windows.Forms.ToolStrip tolListApplication;
        private System.Windows.Forms.ToolStripButton tolLA_btnGoToComFolder;
        private System.Windows.Forms.ToolStripLabel tolLA_lblComId;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tolLA_btnGoToAppFolder;
        private System.Windows.Forms.ToolStripLabel tolLA_lblAppId;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tolLA_btnCreateReport;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.ComboBox cboFilterPriority;
        private System.Windows.Forms.Label lblFilterPriority;
        private System.Windows.Forms.NumericUpDown nudFilterPriority;
        private System.Windows.Forms.Button btnListApplications;
        private System.Windows.Forms.CheckBox chkFilterApplicationTypeSpeculative;
        private System.Windows.Forms.GroupBox grbFilterProgress;
        private OLKI.Toolbox.Widgets.SortListView lsvProgressFilter;
        private Toolbox.Widgets.DateInputAndValidator mtbFilterDateTo;
        private Toolbox.Widgets.DateInputAndValidator mtbFilterDateFrom;
        private System.Windows.Forms.ImageList imlProgressState;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFilterText;
        private System.Windows.Forms.Label lblFilterText;
    }
}