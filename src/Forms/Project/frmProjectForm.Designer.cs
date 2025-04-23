namespace OLKI.Programme.BeOrSy.src.Forms.Project
{
    partial class ProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.spcMain = new System.Windows.Forms.SplitContainer();
            this.spcCompany = new System.Windows.Forms.SplitContainer();
            this.btnCompanyAdd = new System.Windows.Forms.Button();
            this.btnCompanyEdit = new System.Windows.Forms.Button();
            this.btnCompanyDelete = new System.Windows.Forms.Button();
            this.btnCompanyGoToDir = new System.Windows.Forms.Button();
            this.btnCompanyGoToHomepage = new System.Windows.Forms.Button();
            this.btnCompanyGoToCareerpage = new System.Windows.Forms.Button();
            this.btnCompanyReport = new System.Windows.Forms.Button();
            this.btnCompanyAdressToClipboard = new System.Windows.Forms.Button();
            this.lblCompanyMain = new System.Windows.Forms.Label();
            this.lsvCompany = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvCompanyMain_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_AdressCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_AdressCountry = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_Trade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_ApplicationPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_ApplicationProgress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_ApplicationsDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompany_ReminderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompany_ReminderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_Applications = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvCompanyMain_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlColorMarkers = new System.Windows.Forms.ImageList(this.components);
            this.grbFilter = new System.Windows.Forms.GroupBox();
            this.uscQuickFilterCompanyAppProgress = new OLKI.Programme.BeOrSy.src.Forms.Project.QuickFilterCompanyAppProgress();
            this.nudQuickFilterCompanyId = new System.Windows.Forms.NumericUpDown();
            this.btnFilterCompanyDetail = new System.Windows.Forms.Button();
            this.chkQuickFilterCompanyAppProgressMode = new System.Windows.Forms.CheckBox();
            this.txtQuickFilterCompanyTitle = new System.Windows.Forms.TextBox();
            this.cboQuickFilterCompanyTrade = new System.Windows.Forms.ComboBox();
            this.cboQuickFilterCompanyCity = new System.Windows.Forms.ComboBox();
            this.btnFilterCompany = new System.Windows.Forms.Button();
            this.btnFilterReset = new System.Windows.Forms.Button();
            this.chkQuickFilterCompanyTerminated = new System.Windows.Forms.CheckBox();
            this.lblFilterCity = new System.Windows.Forms.Label();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.lblFilterId = new System.Windows.Forms.Label();
            this.lblFilterTrade = new System.Windows.Forms.Label();
            this.prgCompany = new System.Windows.Forms.PropertyGrid();
            this.lblCompanyDetail = new System.Windows.Forms.Label();
            this.spcApplication = new System.Windows.Forms.SplitContainer();
            this.btnApplicationEdit = new System.Windows.Forms.Button();
            this.btnApplicationDelete = new System.Windows.Forms.Button();
            this.btnApplicationGoToDir = new System.Windows.Forms.Button();
            this.btnApplicationDuplicate = new System.Windows.Forms.Button();
            this.btnApplicationReport = new System.Windows.Forms.Button();
            this.lsvApplication = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvApplication_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Progress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_ProgressDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_ReminderText = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_ReminderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Created = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvApplication_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlApplicationType = new System.Windows.Forms.ImageList(this.components);
            this.btnApplicationAdd = new System.Windows.Forms.Button();
            this.lblApplicationMain = new System.Windows.Forms.Label();
            this.prgApplication = new System.Windows.Forms.PropertyGrid();
            this.lblApplicationDetail = new System.Windows.Forms.Label();
            this.mnuProjectForm = new System.Windows.Forms.MenuStrip();
            this.mnuProjectForm_Company = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_GoToDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectForm_Company_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.farbe1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbe2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbe3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbe4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.grünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hellrotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schwarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weißToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_GoToDir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_Report = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Application_Duplicate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectForm_Application_Filter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuProjectForm_Application_AutoArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_List = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_List_Application = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_List_Reminder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProjectForm_Company_Import = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).BeginInit();
            this.spcMain.Panel1.SuspendLayout();
            this.spcMain.Panel2.SuspendLayout();
            this.spcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompany)).BeginInit();
            this.spcCompany.Panel1.SuspendLayout();
            this.spcCompany.Panel2.SuspendLayout();
            this.spcCompany.SuspendLayout();
            this.grbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuickFilterCompanyId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcApplication)).BeginInit();
            this.spcApplication.Panel1.SuspendLayout();
            this.spcApplication.Panel2.SuspendLayout();
            this.spcApplication.SuspendLayout();
            this.mnuProjectForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcMain
            // 
            this.spcMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcMain.Location = new System.Drawing.Point(0, 0);
            this.spcMain.Name = "spcMain";
            this.spcMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spcMain.Panel1
            // 
            this.spcMain.Panel1.Controls.Add(this.spcCompany);
            this.spcMain.Panel1MinSize = 250;
            // 
            // spcMain.Panel2
            // 
            this.spcMain.Panel2.Controls.Add(this.spcApplication);
            this.spcMain.Panel2MinSize = 200;
            this.spcMain.Size = new System.Drawing.Size(961, 564);
            this.spcMain.SplitterDistance = 335;
            this.spcMain.TabIndex = 3;
            // 
            // spcCompany
            // 
            this.spcCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcCompany.Location = new System.Drawing.Point(0, 0);
            this.spcCompany.Name = "spcCompany";
            // 
            // spcCompany.Panel1
            // 
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyAdd);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyEdit);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyDelete);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyGoToDir);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyGoToHomepage);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyGoToCareerpage);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyReport);
            this.spcCompany.Panel1.Controls.Add(this.btnCompanyAdressToClipboard);
            this.spcCompany.Panel1.Controls.Add(this.lblCompanyMain);
            this.spcCompany.Panel1.Controls.Add(this.lsvCompany);
            this.spcCompany.Panel1.Controls.Add(this.grbFilter);
            this.spcCompany.Panel1MinSize = 550;
            // 
            // spcCompany.Panel2
            // 
            this.spcCompany.Panel2.Controls.Add(this.prgCompany);
            this.spcCompany.Panel2.Controls.Add(this.lblCompanyDetail);
            this.spcCompany.Panel2MinSize = 200;
            this.spcCompany.Size = new System.Drawing.Size(961, 335);
            this.spcCompany.SplitterDistance = 635;
            this.spcCompany.TabIndex = 0;
            this.spcCompany.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spcCompany_SplitterMoved);
            // 
            // btnCompanyAdd
            // 
            this.btnCompanyAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnCompanyAdd.Location = new System.Drawing.Point(3, 304);
            this.btnCompanyAdd.Name = "btnCompanyAdd";
            this.btnCompanyAdd.Size = new System.Drawing.Size(100, 24);
            this.btnCompanyAdd.TabIndex = 0;
            this.btnCompanyAdd.Text = "Hinzufügen";
            this.btnCompanyAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompanyAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompanyAdd.UseVisualStyleBackColor = true;
            this.btnCompanyAdd.Click += new System.EventHandler(this.mnuProjectForm_Company_Add_Click);
            // 
            // btnCompanyEdit
            // 
            this.btnCompanyEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyEdit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Settings;
            this.btnCompanyEdit.Location = new System.Drawing.Point(109, 304);
            this.btnCompanyEdit.Name = "btnCompanyEdit";
            this.btnCompanyEdit.Size = new System.Drawing.Size(100, 24);
            this.btnCompanyEdit.TabIndex = 1;
            this.btnCompanyEdit.Text = "Bearbeiten";
            this.btnCompanyEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompanyEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompanyEdit.UseVisualStyleBackColor = true;
            this.btnCompanyEdit.Click += new System.EventHandler(this.mnuProjectForm_Company_Edit_Click);
            // 
            // btnCompanyDelete
            // 
            this.btnCompanyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompanyDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnCompanyDelete.Location = new System.Drawing.Point(528, 304);
            this.btnCompanyDelete.Name = "btnCompanyDelete";
            this.btnCompanyDelete.Size = new System.Drawing.Size(100, 24);
            this.btnCompanyDelete.TabIndex = 7;
            this.btnCompanyDelete.Text = "Löschen";
            this.btnCompanyDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompanyDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompanyDelete.UseVisualStyleBackColor = true;
            this.btnCompanyDelete.Click += new System.EventHandler(this.mnuProjectForm_Company_Delete_Click);
            // 
            // btnCompanyGoToDir
            // 
            this.btnCompanyGoToDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyGoToDir.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.btnCompanyGoToDir.Location = new System.Drawing.Point(215, 304);
            this.btnCompanyGoToDir.Name = "btnCompanyGoToDir";
            this.btnCompanyGoToDir.Size = new System.Drawing.Size(35, 24);
            this.btnCompanyGoToDir.TabIndex = 2;
            this.btnCompanyGoToDir.UseVisualStyleBackColor = true;
            this.btnCompanyGoToDir.Click += new System.EventHandler(this.mnuProjectForm_Company_GoToDir_Click);
            // 
            // btnCompanyGoToHomepage
            // 
            this.btnCompanyGoToHomepage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyGoToHomepage.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Web;
            this.btnCompanyGoToHomepage.Location = new System.Drawing.Point(297, 304);
            this.btnCompanyGoToHomepage.Name = "btnCompanyGoToHomepage";
            this.btnCompanyGoToHomepage.Size = new System.Drawing.Size(35, 24);
            this.btnCompanyGoToHomepage.TabIndex = 4;
            this.btnCompanyGoToHomepage.UseVisualStyleBackColor = true;
            this.btnCompanyGoToHomepage.Click += new System.EventHandler(this.btnCompanyGoToHomepage_Click);
            // 
            // btnCompanyGoToCareerpage
            // 
            this.btnCompanyGoToCareerpage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyGoToCareerpage.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.WebJob;
            this.btnCompanyGoToCareerpage.Location = new System.Drawing.Point(338, 304);
            this.btnCompanyGoToCareerpage.Name = "btnCompanyGoToCareerpage";
            this.btnCompanyGoToCareerpage.Size = new System.Drawing.Size(35, 24);
            this.btnCompanyGoToCareerpage.TabIndex = 5;
            this.btnCompanyGoToCareerpage.UseVisualStyleBackColor = true;
            this.btnCompanyGoToCareerpage.Click += new System.EventHandler(this.btnCompanyGoToCareerpage_Click);
            // 
            // btnCompanyReport
            // 
            this.btnCompanyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.btnCompanyReport.Location = new System.Drawing.Point(256, 304);
            this.btnCompanyReport.Name = "btnCompanyReport";
            this.btnCompanyReport.Size = new System.Drawing.Size(35, 24);
            this.btnCompanyReport.TabIndex = 3;
            this.btnCompanyReport.UseVisualStyleBackColor = true;
            this.btnCompanyReport.Click += new System.EventHandler(this.mnuProjectForm_Company_Report_Click);
            // 
            // btnCompanyAdressToClipboard
            // 
            this.btnCompanyAdressToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCompanyAdressToClipboard.Enabled = false;
            this.btnCompanyAdressToClipboard.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.AdressMail;
            this.btnCompanyAdressToClipboard.Location = new System.Drawing.Point(378, 304);
            this.btnCompanyAdressToClipboard.Name = "btnCompanyAdressToClipboard";
            this.btnCompanyAdressToClipboard.Size = new System.Drawing.Size(35, 24);
            this.btnCompanyAdressToClipboard.TabIndex = 6;
            this.btnCompanyAdressToClipboard.UseVisualStyleBackColor = true;
            this.btnCompanyAdressToClipboard.Click += new System.EventHandler(this.btnCompanyAdressToClipboard_Click);
            // 
            // lblCompanyMain
            // 
            this.lblCompanyMain.AutoSize = true;
            this.lblCompanyMain.Location = new System.Drawing.Point(3, 7);
            this.lblCompanyMain.Name = "lblCompanyMain";
            this.lblCompanyMain.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyMain.TabIndex = 0;
            this.lblCompanyMain.Text = "Gelistete Firmen";
            // 
            // lsvCompany
            // 
            this.lsvCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvCompany.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvCompanyMain_Name,
            this.chLsvCompanyMain_AdressCity,
            this.chLsvCompanyMain_AdressCountry,
            this.chLsvCompanyMain_Trade,
            this.chLsvCompanyMain_ApplicationPriority,
            this.chLsvCompanyMain_ApplicationProgress,
            this.chLsvCompanyMain_ApplicationsDate,
            this.chLsvCompany_ReminderText,
            this.chLsvCompany_ReminderDate,
            this.chLsvCompanyMain_Comment,
            this.chLsvCompanyMain_Applications,
            this.chLsvCompanyMain_Id});
            this.lsvCompany.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvCompany.ColumnWidths")));
            this.lsvCompany.FullRowSelect = true;
            this.lsvCompany.GridLines = true;
            this.lsvCompany.HideSelection = false;
            this.lsvCompany.Location = new System.Drawing.Point(3, 135);
            this.lsvCompany.Name = "lsvCompany";
            this.lsvCompany.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvCompany.Size = new System.Drawing.Size(625, 163);
            this.lsvCompany.SmallImageList = this.imlColorMarkers;
            this.lsvCompany.TabIndex = 1;
            this.lsvCompany.UseCompatibleStateImageBehavior = false;
            this.lsvCompany.View = System.Windows.Forms.View.Details;
            this.lsvCompany.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvCompany_ColumnClick);
            this.lsvCompany.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lsvCompany_ColumnWidthChanged);
            this.lsvCompany.SelectedIndexChanged += new System.EventHandler(this.lsvCompany_SelectedIndexChanged);
            this.lsvCompany.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvCompany_MouseDoubleClick);
            // 
            // chLsvCompanyMain_Name
            // 
            this.chLsvCompanyMain_Name.Text = "Firma";
            this.chLsvCompanyMain_Name.Width = 240;
            // 
            // chLsvCompanyMain_AdressCity
            // 
            this.chLsvCompanyMain_AdressCity.Text = "Stadt";
            // 
            // chLsvCompanyMain_AdressCountry
            // 
            this.chLsvCompanyMain_AdressCountry.Text = "Land";
            // 
            // chLsvCompanyMain_Trade
            // 
            this.chLsvCompanyMain_Trade.Text = "Branche";
            this.chLsvCompanyMain_Trade.Width = 120;
            // 
            // chLsvCompanyMain_ApplicationPriority
            // 
            this.chLsvCompanyMain_ApplicationPriority.Text = "Max. Priorität der Bewerbung";
            this.chLsvCompanyMain_ApplicationPriority.Width = 30;
            // 
            // chLsvCompanyMain_ApplicationProgress
            // 
            this.chLsvCompanyMain_ApplicationProgress.Text = "Max. Bewerbungsfortschritt";
            this.chLsvCompanyMain_ApplicationProgress.Width = 90;
            // 
            // chLsvCompanyMain_ApplicationsDate
            // 
            this.chLsvCompanyMain_ApplicationsDate.Text = "Zeitpunkt des Fortschritt";
            this.chLsvCompanyMain_ApplicationsDate.Width = 90;
            // 
            // chLsvCompany_ReminderText
            // 
            this.chLsvCompany_ReminderText.Text = "Erinnerung";
            // 
            // chLsvCompany_ReminderDate
            // 
            this.chLsvCompany_ReminderDate.Text = "Zeitpunkt desr Erinnerung";
            // 
            // chLsvCompanyMain_Comment
            // 
            this.chLsvCompanyMain_Comment.Text = "Kommentar";
            this.chLsvCompanyMain_Comment.Width = 280;
            // 
            // chLsvCompanyMain_Applications
            // 
            this.chLsvCompanyMain_Applications.Text = "Bewerbungen";
            // 
            // chLsvCompanyMain_Id
            // 
            this.chLsvCompanyMain_Id.Text = "Id";
            this.chLsvCompanyMain_Id.Width = 30;
            // 
            // imlColorMarkers
            // 
            this.imlColorMarkers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlColorMarkers.ImageStream")));
            this.imlColorMarkers.TransparentColor = System.Drawing.Color.Transparent;
            this.imlColorMarkers.Images.SetKeyName(0, "Company.png");
            this.imlColorMarkers.Images.SetKeyName(1, "01 - Blau.png");
            this.imlColorMarkers.Images.SetKeyName(2, "02 - Cyan.png");
            this.imlColorMarkers.Images.SetKeyName(3, "03 - Durchsichtig.png");
            this.imlColorMarkers.Images.SetKeyName(4, "04 - Gelb.png");
            this.imlColorMarkers.Images.SetKeyName(5, "05 - Grau.png");
            this.imlColorMarkers.Images.SetKeyName(6, "06 - Grün.png");
            this.imlColorMarkers.Images.SetKeyName(7, "07 - Hellrot.png");
            this.imlColorMarkers.Images.SetKeyName(8, "08 - Orange.png");
            this.imlColorMarkers.Images.SetKeyName(9, "09 - Rosa.png");
            this.imlColorMarkers.Images.SetKeyName(10, "10 - Rot.png");
            this.imlColorMarkers.Images.SetKeyName(11, "11 - Schwarz.png");
            this.imlColorMarkers.Images.SetKeyName(12, "12 - Weiß.png");
            this.imlColorMarkers.Images.SetKeyName(13, "00 - (Keine).png");
            // 
            // grbFilter
            // 
            this.grbFilter.Controls.Add(this.uscQuickFilterCompanyAppProgress);
            this.grbFilter.Controls.Add(this.nudQuickFilterCompanyId);
            this.grbFilter.Controls.Add(this.btnFilterCompanyDetail);
            this.grbFilter.Controls.Add(this.chkQuickFilterCompanyAppProgressMode);
            this.grbFilter.Controls.Add(this.txtQuickFilterCompanyTitle);
            this.grbFilter.Controls.Add(this.cboQuickFilterCompanyTrade);
            this.grbFilter.Controls.Add(this.cboQuickFilterCompanyCity);
            this.grbFilter.Controls.Add(this.btnFilterCompany);
            this.grbFilter.Controls.Add(this.btnFilterReset);
            this.grbFilter.Controls.Add(this.chkQuickFilterCompanyTerminated);
            this.grbFilter.Controls.Add(this.lblFilterCity);
            this.grbFilter.Controls.Add(this.lblFilterTitle);
            this.grbFilter.Controls.Add(this.lblFilterId);
            this.grbFilter.Controls.Add(this.lblFilterTrade);
            this.grbFilter.Location = new System.Drawing.Point(91, 3);
            this.grbFilter.Name = "grbFilter";
            this.grbFilter.Size = new System.Drawing.Size(368, 126);
            this.grbFilter.TabIndex = 1;
            this.grbFilter.TabStop = false;
            this.grbFilter.Text = "Filter";
            // 
            // uscQuickFilterCompanyAppProgress
            // 
            this.uscQuickFilterCompanyAppProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uscQuickFilterCompanyAppProgress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uscQuickFilterCompanyAppProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uscQuickFilterCompanyAppProgress.FormattingEnabled = true;
            this.uscQuickFilterCompanyAppProgress.Location = new System.Drawing.Point(87, 99);
            this.uscQuickFilterCompanyAppProgress.Name = "uscQuickFilterCompanyAppProgress";
            this.uscQuickFilterCompanyAppProgress.Size = new System.Drawing.Size(119, 21);
            this.uscQuickFilterCompanyAppProgress.TabIndex = 7;
            this.uscQuickFilterCompanyAppProgress.SelectedIndexChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // nudQuickFilterCompanyId
            // 
            this.nudQuickFilterCompanyId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudQuickFilterCompanyId.Location = new System.Drawing.Point(236, 46);
            this.nudQuickFilterCompanyId.Name = "nudQuickFilterCompanyId";
            this.nudQuickFilterCompanyId.Size = new System.Drawing.Size(49, 20);
            this.nudQuickFilterCompanyId.TabIndex = 10;
            this.nudQuickFilterCompanyId.ThousandsSeparator = true;
            this.nudQuickFilterCompanyId.ValueChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // btnFilterCompanyDetail
            // 
            this.btnFilterCompanyDetail.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter2;
            this.btnFilterCompanyDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterCompanyDetail.Location = new System.Drawing.Point(290, 44);
            this.btnFilterCompanyDetail.Name = "btnFilterCompanyDetail";
            this.btnFilterCompanyDetail.Size = new System.Drawing.Size(72, 23);
            this.btnFilterCompanyDetail.TabIndex = 11;
            this.btnFilterCompanyDetail.Text = "Detail";
            this.btnFilterCompanyDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilterCompanyDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilterCompanyDetail.UseVisualStyleBackColor = true;
            this.btnFilterCompanyDetail.Click += new System.EventHandler(this.mnuProjectForm_Company_Filter_Click);
            // 
            // chkQuickFilterCompanyAppProgressMode
            // 
            this.chkQuickFilterCompanyAppProgressMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkQuickFilterCompanyAppProgressMode.Checked = true;
            this.chkQuickFilterCompanyAppProgressMode.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkQuickFilterCompanyAppProgressMode.Location = new System.Drawing.Point(6, 101);
            this.chkQuickFilterCompanyAppProgressMode.Name = "chkQuickFilterCompanyAppProgressMode";
            this.chkQuickFilterCompanyAppProgressMode.Size = new System.Drawing.Size(75, 17);
            this.chkQuickFilterCompanyAppProgressMode.TabIndex = 6;
            this.chkQuickFilterCompanyAppProgressMode.Text = "Fortschritt:";
            this.chkQuickFilterCompanyAppProgressMode.ThreeState = true;
            this.chkQuickFilterCompanyAppProgressMode.UseVisualStyleBackColor = true;
            this.chkQuickFilterCompanyAppProgressMode.CheckedChanged += new System.EventHandler(this.FilterItem_Changed);
            this.chkQuickFilterCompanyAppProgressMode.CheckStateChanged += new System.EventHandler(this.chkQuickFilterCompanyAppProgressMode_CheckStateChanged);
            // 
            // txtQuickFilterCompanyTitle
            // 
            this.txtQuickFilterCompanyTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQuickFilterCompanyTitle.Location = new System.Drawing.Point(65, 19);
            this.txtQuickFilterCompanyTitle.Name = "txtQuickFilterCompanyTitle";
            this.txtQuickFilterCompanyTitle.Size = new System.Drawing.Size(141, 20);
            this.txtQuickFilterCompanyTitle.TabIndex = 1;
            this.txtQuickFilterCompanyTitle.TextChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // cboQuickFilterCompanyTrade
            // 
            this.cboQuickFilterCompanyTrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboQuickFilterCompanyTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboQuickFilterCompanyTrade.FormattingEnabled = true;
            this.cboQuickFilterCompanyTrade.Location = new System.Drawing.Point(65, 72);
            this.cboQuickFilterCompanyTrade.Name = "cboQuickFilterCompanyTrade";
            this.cboQuickFilterCompanyTrade.Size = new System.Drawing.Size(141, 21);
            this.cboQuickFilterCompanyTrade.TabIndex = 5;
            this.cboQuickFilterCompanyTrade.TextChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // cboQuickFilterCompanyCity
            // 
            this.cboQuickFilterCompanyCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboQuickFilterCompanyCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboQuickFilterCompanyCity.FormattingEnabled = true;
            this.cboQuickFilterCompanyCity.Location = new System.Drawing.Point(65, 45);
            this.cboQuickFilterCompanyCity.Name = "cboQuickFilterCompanyCity";
            this.cboQuickFilterCompanyCity.Size = new System.Drawing.Size(141, 21);
            this.cboQuickFilterCompanyCity.TabIndex = 3;
            this.cboQuickFilterCompanyCity.TextChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // btnFilterCompany
            // 
            this.btnFilterCompany.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter;
            this.btnFilterCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterCompany.Location = new System.Drawing.Point(212, 70);
            this.btnFilterCompany.Name = "btnFilterCompany";
            this.btnFilterCompany.Size = new System.Drawing.Size(150, 23);
            this.btnFilterCompany.TabIndex = 12;
            this.btnFilterCompany.Text = "Filtern";
            this.btnFilterCompany.UseVisualStyleBackColor = true;
            this.btnFilterCompany.Click += new System.EventHandler(this.FilterItem_Changed);
            // 
            // btnFilterReset
            // 
            this.btnFilterReset.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.FilterReset;
            this.btnFilterReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilterReset.Location = new System.Drawing.Point(212, 97);
            this.btnFilterReset.Name = "btnFilterReset";
            this.btnFilterReset.Size = new System.Drawing.Size(150, 23);
            this.btnFilterReset.TabIndex = 13;
            this.btnFilterReset.Text = "Zurücksetzen";
            this.btnFilterReset.UseVisualStyleBackColor = true;
            this.btnFilterReset.Click += new System.EventHandler(this.btnFilterReset_Click);
            // 
            // chkQuickFilterCompanyTerminated
            // 
            this.chkQuickFilterCompanyTerminated.AutoSize = true;
            this.chkQuickFilterCompanyTerminated.Checked = true;
            this.chkQuickFilterCompanyTerminated.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkQuickFilterCompanyTerminated.Location = new System.Drawing.Point(215, 21);
            this.chkQuickFilterCompanyTerminated.Name = "chkQuickFilterCompanyTerminated";
            this.chkQuickFilterCompanyTerminated.Size = new System.Drawing.Size(147, 17);
            this.chkQuickFilterCompanyTerminated.TabIndex = 8;
            this.chkQuickFilterCompanyTerminated.Text = "Aufgelöste Firmen anzeig.";
            this.chkQuickFilterCompanyTerminated.ThreeState = true;
            this.chkQuickFilterCompanyTerminated.UseVisualStyleBackColor = false;
            this.chkQuickFilterCompanyTerminated.CheckStateChanged += new System.EventHandler(this.FilterItem_Changed);
            // 
            // lblFilterCity
            // 
            this.lblFilterCity.AutoSize = true;
            this.lblFilterCity.Location = new System.Drawing.Point(6, 49);
            this.lblFilterCity.Name = "lblFilterCity";
            this.lblFilterCity.Size = new System.Drawing.Size(35, 13);
            this.lblFilterCity.TabIndex = 2;
            this.lblFilterCity.Text = "Stadt:";
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Location = new System.Drawing.Point(6, 22);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(35, 13);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Firma:";
            // 
            // lblFilterId
            // 
            this.lblFilterId.AutoSize = true;
            this.lblFilterId.Location = new System.Drawing.Point(212, 49);
            this.lblFilterId.Name = "lblFilterId";
            this.lblFilterId.Size = new System.Drawing.Size(18, 13);
            this.lblFilterId.TabIndex = 9;
            this.lblFilterId.Text = "id:";
            // 
            // lblFilterTrade
            // 
            this.lblFilterTrade.AutoSize = true;
            this.lblFilterTrade.Location = new System.Drawing.Point(6, 75);
            this.lblFilterTrade.Name = "lblFilterTrade";
            this.lblFilterTrade.Size = new System.Drawing.Size(50, 13);
            this.lblFilterTrade.TabIndex = 4;
            this.lblFilterTrade.Text = "Branche:";
            // 
            // prgCompany
            // 
            this.prgCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgCompany.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.prgCompany.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgCompany.Location = new System.Drawing.Point(3, 23);
            this.prgCompany.Name = "prgCompany";
            this.prgCompany.Size = new System.Drawing.Size(317, 305);
            this.prgCompany.TabIndex = 1;
            this.prgCompany.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgCompany.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgCompany_PropertyValueChanged);
            // 
            // lblCompanyDetail
            // 
            this.lblCompanyDetail.AutoSize = true;
            this.lblCompanyDetail.Location = new System.Drawing.Point(3, 7);
            this.lblCompanyDetail.Name = "lblCompanyDetail";
            this.lblCompanyDetail.Size = new System.Drawing.Size(84, 13);
            this.lblCompanyDetail.TabIndex = 0;
            this.lblCompanyDetail.Text = "Details zur Firma";
            // 
            // spcApplication
            // 
            this.spcApplication.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spcApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcApplication.Location = new System.Drawing.Point(0, 0);
            this.spcApplication.Name = "spcApplication";
            // 
            // spcApplication.Panel1
            // 
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationEdit);
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationDelete);
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationGoToDir);
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationDuplicate);
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationReport);
            this.spcApplication.Panel1.Controls.Add(this.lsvApplication);
            this.spcApplication.Panel1.Controls.Add(this.btnApplicationAdd);
            this.spcApplication.Panel1.Controls.Add(this.lblApplicationMain);
            this.spcApplication.Panel1MinSize = 550;
            // 
            // spcApplication.Panel2
            // 
            this.spcApplication.Panel2.Controls.Add(this.prgApplication);
            this.spcApplication.Panel2.Controls.Add(this.lblApplicationDetail);
            this.spcApplication.Panel2MinSize = 200;
            this.spcApplication.Size = new System.Drawing.Size(961, 225);
            this.spcApplication.SplitterDistance = 635;
            this.spcApplication.TabIndex = 0;
            this.spcApplication.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spcApplication_SplitterMoved);
            // 
            // btnApplicationEdit
            // 
            this.btnApplicationEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplicationEdit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Settings;
            this.btnApplicationEdit.Location = new System.Drawing.Point(107, 194);
            this.btnApplicationEdit.Name = "btnApplicationEdit";
            this.btnApplicationEdit.Size = new System.Drawing.Size(100, 24);
            this.btnApplicationEdit.TabIndex = 1;
            this.btnApplicationEdit.Text = "Bearbeiten";
            this.btnApplicationEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplicationEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplicationEdit.UseVisualStyleBackColor = true;
            this.btnApplicationEdit.Click += new System.EventHandler(this.mnuProjectForm_Application_Edit_Click);
            // 
            // btnApplicationDelete
            // 
            this.btnApplicationDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplicationDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnApplicationDelete.Location = new System.Drawing.Point(528, 194);
            this.btnApplicationDelete.Name = "btnApplicationDelete";
            this.btnApplicationDelete.Size = new System.Drawing.Size(100, 24);
            this.btnApplicationDelete.TabIndex = 5;
            this.btnApplicationDelete.Text = "Löschen";
            this.btnApplicationDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplicationDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplicationDelete.UseVisualStyleBackColor = true;
            this.btnApplicationDelete.Click += new System.EventHandler(this.mnuProjectForm_Application_Delete_Click);
            // 
            // btnApplicationGoToDir
            // 
            this.btnApplicationGoToDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplicationGoToDir.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.btnApplicationGoToDir.Location = new System.Drawing.Point(213, 194);
            this.btnApplicationGoToDir.Name = "btnApplicationGoToDir";
            this.btnApplicationGoToDir.Size = new System.Drawing.Size(35, 24);
            this.btnApplicationGoToDir.TabIndex = 2;
            this.btnApplicationGoToDir.UseVisualStyleBackColor = true;
            this.btnApplicationGoToDir.Click += new System.EventHandler(this.mnuProjectForm_Application_GoToDir_Click);
            // 
            // btnApplicationDuplicate
            // 
            this.btnApplicationDuplicate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplicationDuplicate.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Copy;
            this.btnApplicationDuplicate.Location = new System.Drawing.Point(295, 194);
            this.btnApplicationDuplicate.Name = "btnApplicationDuplicate";
            this.btnApplicationDuplicate.Size = new System.Drawing.Size(35, 24);
            this.btnApplicationDuplicate.TabIndex = 4;
            this.btnApplicationDuplicate.UseVisualStyleBackColor = true;
            this.btnApplicationDuplicate.Click += new System.EventHandler(this.mnuProjectForm_Application_Duplicate_Click);
            // 
            // btnApplicationReport
            // 
            this.btnApplicationReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplicationReport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.btnApplicationReport.Location = new System.Drawing.Point(254, 194);
            this.btnApplicationReport.Name = "btnApplicationReport";
            this.btnApplicationReport.Size = new System.Drawing.Size(35, 24);
            this.btnApplicationReport.TabIndex = 3;
            this.btnApplicationReport.UseVisualStyleBackColor = true;
            this.btnApplicationReport.Click += new System.EventHandler(this.mnuProjectForm_Application_Report_Click);
            // 
            // lsvApplication
            // 
            this.lsvApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvApplication.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvApplication_Title,
            this.chLsvApplication_Number,
            this.chLsvApplication_Priority,
            this.chLsvApplication_Deadline,
            this.chLsvApplication_Progress,
            this.chLsvApplication_ProgressDate,
            this.chLsvApplication_ReminderText,
            this.chLsvApplication_ReminderDate,
            this.chLsvApplication_Created,
            this.chLsvApplication_Id});
            this.lsvApplication.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvApplication.ColumnWidths")));
            this.lsvApplication.FullRowSelect = true;
            this.lsvApplication.GridLines = true;
            this.lsvApplication.HideSelection = false;
            this.lsvApplication.Location = new System.Drawing.Point(3, 23);
            this.lsvApplication.Name = "lsvApplication";
            this.lsvApplication.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvApplication.Size = new System.Drawing.Size(625, 165);
            this.lsvApplication.SmallImageList = this.imlApplicationType;
            this.lsvApplication.TabIndex = 1;
            this.lsvApplication.UseCompatibleStateImageBehavior = false;
            this.lsvApplication.View = System.Windows.Forms.View.Details;
            this.lsvApplication.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvApplication_ColumnClick);
            this.lsvApplication.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lsvApplication_ColumnWidthChanged);
            this.lsvApplication.SelectedIndexChanged += new System.EventHandler(this.lsvApplication_SelectedIndexChanged);
            this.lsvApplication.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvApplication_MouseDoubleClick);
            // 
            // chLsvApplication_Title
            // 
            this.chLsvApplication_Title.Text = "Benennung";
            this.chLsvApplication_Title.Width = 120;
            // 
            // chLsvApplication_Number
            // 
            this.chLsvApplication_Number.Text = "Referenznummer";
            // 
            // chLsvApplication_Priority
            // 
            this.chLsvApplication_Priority.Text = "Priorität";
            this.chLsvApplication_Priority.Width = 30;
            // 
            // chLsvApplication_Deadline
            // 
            this.chLsvApplication_Deadline.Text = "Bewerbungsfrist";
            this.chLsvApplication_Deadline.Width = 120;
            // 
            // chLsvApplication_Progress
            // 
            this.chLsvApplication_Progress.Text = "Fortschritt der Bewerbung";
            this.chLsvApplication_Progress.Width = 120;
            // 
            // chLsvApplication_ProgressDate
            // 
            this.chLsvApplication_ProgressDate.Text = "Zeitpunkt des Fortschritt";
            this.chLsvApplication_ProgressDate.Width = 120;
            // 
            // chLsvApplication_ReminderText
            // 
            this.chLsvApplication_ReminderText.Text = "Nächste Erinnerung Text";
            this.chLsvApplication_ReminderText.Width = 120;
            // 
            // chLsvApplication_ReminderDate
            // 
            this.chLsvApplication_ReminderDate.Text = "Nächste Erinnerung Datum";
            this.chLsvApplication_ReminderDate.Width = 120;
            // 
            // chLsvApplication_Created
            // 
            this.chLsvApplication_Created.Text = "Erstelldatum";
            this.chLsvApplication_Created.Width = 120;
            // 
            // chLsvApplication_Id
            // 
            this.chLsvApplication_Id.Text = "Id";
            this.chLsvApplication_Id.Width = 30;
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
            // btnApplicationAdd
            // 
            this.btnApplicationAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplicationAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnApplicationAdd.Location = new System.Drawing.Point(1, 194);
            this.btnApplicationAdd.Name = "btnApplicationAdd";
            this.btnApplicationAdd.Size = new System.Drawing.Size(100, 24);
            this.btnApplicationAdd.TabIndex = 0;
            this.btnApplicationAdd.Text = "Hinzufügen";
            this.btnApplicationAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApplicationAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApplicationAdd.UseVisualStyleBackColor = true;
            this.btnApplicationAdd.Click += new System.EventHandler(this.mnuProjectForm_Application_Add_Click);
            // 
            // lblApplicationMain
            // 
            this.lblApplicationMain.AutoSize = true;
            this.lblApplicationMain.Location = new System.Drawing.Point(3, 7);
            this.lblApplicationMain.Name = "lblApplicationMain";
            this.lblApplicationMain.Size = new System.Drawing.Size(167, 13);
            this.lblApplicationMain.TabIndex = 0;
            this.lblApplicationMain.Text = "Bewerbungen bei gewählter Firma";
            // 
            // prgApplication
            // 
            this.prgApplication.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgApplication.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.prgApplication.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgApplication.Location = new System.Drawing.Point(3, 23);
            this.prgApplication.Name = "prgApplication";
            this.prgApplication.Size = new System.Drawing.Size(312, 195);
            this.prgApplication.TabIndex = 1;
            this.prgApplication.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgApplication.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgApplication_PropertyValueChanged);
            // 
            // lblApplicationDetail
            // 
            this.lblApplicationDetail.AutoSize = true;
            this.lblApplicationDetail.Location = new System.Drawing.Point(3, 7);
            this.lblApplicationDetail.Name = "lblApplicationDetail";
            this.lblApplicationDetail.Size = new System.Drawing.Size(113, 13);
            this.lblApplicationDetail.TabIndex = 0;
            this.lblApplicationDetail.Text = "Details zur Bewerbung";
            // 
            // mnuProjectForm
            // 
            this.mnuProjectForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectForm_Company,
            this.mnuProjectForm_Application,
            this.mnuProjectForm_List});
            this.mnuProjectForm.Location = new System.Drawing.Point(0, 0);
            this.mnuProjectForm.Name = "mnuProjectForm";
            this.mnuProjectForm.Size = new System.Drawing.Size(961, 24);
            this.mnuProjectForm.TabIndex = 4;
            this.mnuProjectForm.Text = "menuStrip1";
            this.mnuProjectForm.Visible = false;
            // 
            // mnuProjectForm_Company
            // 
            this.mnuProjectForm_Company.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectForm_Company_Add,
            this.mnuProjectForm_Company_Edit,
            this.mnuProjectForm_Company_Delete,
            this.mnuProjectForm_Company_GoToDir,
            this.mnuProjectForm_Company_Report,
            this.toolStripSeparator3,
            this.mnuProjectForm_Company_Filter,
            this.toolStripMenuItem1,
            this.mnuProjectForm_Company_Export,
            this.mnuProjectForm_Company_Import});
            this.mnuProjectForm_Company.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuProjectForm_Company.MergeIndex = 1;
            this.mnuProjectForm_Company.Name = "mnuProjectForm_Company";
            this.mnuProjectForm_Company.Size = new System.Drawing.Size(59, 20);
            this.mnuProjectForm_Company.Text = "Firmen ";
            // 
            // mnuProjectForm_Company_Add
            // 
            this.mnuProjectForm_Company_Add.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.mnuProjectForm_Company_Add.Name = "mnuProjectForm_Company_Add";
            this.mnuProjectForm_Company_Add.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mnuProjectForm_Company_Add.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Add.Text = "Hinzufügen";
            this.mnuProjectForm_Company_Add.Click += new System.EventHandler(this.mnuProjectForm_Company_Add_Click);
            // 
            // mnuProjectForm_Company_Edit
            // 
            this.mnuProjectForm_Company_Edit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Settings;
            this.mnuProjectForm_Company_Edit.Name = "mnuProjectForm_Company_Edit";
            this.mnuProjectForm_Company_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.mnuProjectForm_Company_Edit.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Edit.Text = "Bearbeiten";
            this.mnuProjectForm_Company_Edit.Click += new System.EventHandler(this.mnuProjectForm_Company_Edit_Click);
            // 
            // mnuProjectForm_Company_Delete
            // 
            this.mnuProjectForm_Company_Delete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.mnuProjectForm_Company_Delete.Name = "mnuProjectForm_Company_Delete";
            this.mnuProjectForm_Company_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Delete)));
            this.mnuProjectForm_Company_Delete.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Delete.Text = "Löschen";
            this.mnuProjectForm_Company_Delete.Click += new System.EventHandler(this.mnuProjectForm_Company_Delete_Click);
            // 
            // mnuProjectForm_Company_GoToDir
            // 
            this.mnuProjectForm_Company_GoToDir.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.mnuProjectForm_Company_GoToDir.Name = "mnuProjectForm_Company_GoToDir";
            this.mnuProjectForm_Company_GoToDir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.mnuProjectForm_Company_GoToDir.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_GoToDir.Text = "Ordner Öffnen";
            this.mnuProjectForm_Company_GoToDir.Click += new System.EventHandler(this.mnuProjectForm_Company_GoToDir_Click);
            // 
            // mnuProjectForm_Company_Report
            // 
            this.mnuProjectForm_Company_Report.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.mnuProjectForm_Company_Report.Name = "mnuProjectForm_Company_Report";
            this.mnuProjectForm_Company_Report.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.R)));
            this.mnuProjectForm_Company_Report.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Report.Text = "Bericht erstellen";
            this.mnuProjectForm_Company_Report.Click += new System.EventHandler(this.mnuProjectForm_Company_Report_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(331, 6);
            // 
            // mnuProjectForm_Company_Filter
            // 
            this.mnuProjectForm_Company_Filter.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter2;
            this.mnuProjectForm_Company_Filter.Name = "mnuProjectForm_Company_Filter";
            this.mnuProjectForm_Company_Filter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.mnuProjectForm_Company_Filter.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Filter.Text = "Erweiterter Filter / Suchen";
            this.mnuProjectForm_Company_Filter.Click += new System.EventHandler(this.mnuProjectForm_Company_Filter_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farbe1ToolStripMenuItem,
            this.farbe2ToolStripMenuItem,
            this.farbe3ToolStripMenuItem,
            this.farbe4ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.grünToolStripMenuItem,
            this.hellrotToolStripMenuItem,
            this.rotToolStripMenuItem,
            this.rosaToolStripMenuItem,
            this.rotToolStripMenuItem1,
            this.schwarzToolStripMenuItem,
            this.weißToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(334, 22);
            this.toolStripMenuItem1.Text = "Schnellfarbzuweisung";
            this.toolStripMenuItem1.Visible = false;
            // 
            // farbe1ToolStripMenuItem
            // 
            this.farbe1ToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._00____Keine_;
            this.farbe1ToolStripMenuItem.Name = "farbe1ToolStripMenuItem";
            this.farbe1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D0)));
            this.farbe1ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.farbe1ToolStripMenuItem.Text = "Keine";
            // 
            // farbe2ToolStripMenuItem
            // 
            this.farbe2ToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._01___Blau;
            this.farbe2ToolStripMenuItem.Name = "farbe2ToolStripMenuItem";
            this.farbe2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F1)));
            this.farbe2ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.farbe2ToolStripMenuItem.Text = "Blau";
            // 
            // farbe3ToolStripMenuItem
            // 
            this.farbe3ToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._02___Cyan;
            this.farbe3ToolStripMenuItem.Name = "farbe3ToolStripMenuItem";
            this.farbe3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F2)));
            this.farbe3ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.farbe3ToolStripMenuItem.Text = "Cyan";
            // 
            // farbe4ToolStripMenuItem
            // 
            this.farbe4ToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._03___Durchsichtig;
            this.farbe4ToolStripMenuItem.Name = "farbe4ToolStripMenuItem";
            this.farbe4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F3)));
            this.farbe4ToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.farbe4ToolStripMenuItem.Text = "Durchsichtig";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._04___Gelb;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(272, 22);
            this.toolStripMenuItem2.Text = "Gelb";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._05___Grau;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F5)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(272, 22);
            this.toolStripMenuItem3.Text = "Grau";
            // 
            // grünToolStripMenuItem
            // 
            this.grünToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._06___Grün;
            this.grünToolStripMenuItem.Name = "grünToolStripMenuItem";
            this.grünToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F6)));
            this.grünToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.grünToolStripMenuItem.Text = "Grün";
            // 
            // hellrotToolStripMenuItem
            // 
            this.hellrotToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._07___Hellrot;
            this.hellrotToolStripMenuItem.Name = "hellrotToolStripMenuItem";
            this.hellrotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F7)));
            this.hellrotToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.hellrotToolStripMenuItem.Text = "Hellrot";
            // 
            // rotToolStripMenuItem
            // 
            this.rotToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._08___Orange;
            this.rotToolStripMenuItem.Name = "rotToolStripMenuItem";
            this.rotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F8)));
            this.rotToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.rotToolStripMenuItem.Text = "Orange";
            // 
            // rosaToolStripMenuItem
            // 
            this.rosaToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._09___Rosa;
            this.rosaToolStripMenuItem.Name = "rosaToolStripMenuItem";
            this.rosaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F9)));
            this.rosaToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.rosaToolStripMenuItem.Text = "Rosa";
            // 
            // rotToolStripMenuItem1
            // 
            this.rotToolStripMenuItem1.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._10___Rot;
            this.rotToolStripMenuItem1.Name = "rotToolStripMenuItem1";
            this.rotToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F10)));
            this.rotToolStripMenuItem1.Size = new System.Drawing.Size(272, 22);
            this.rotToolStripMenuItem1.Text = "Rot";
            // 
            // schwarzToolStripMenuItem
            // 
            this.schwarzToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._11___Schwarz;
            this.schwarzToolStripMenuItem.Name = "schwarzToolStripMenuItem";
            this.schwarzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F11)));
            this.schwarzToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.schwarzToolStripMenuItem.Text = "Schwarz";
            // 
            // weißToolStripMenuItem
            // 
            this.weißToolStripMenuItem.Image = global::OLKI.Programme.BeOrSy.Properties.Colormarkers._12___Weiß;
            this.weißToolStripMenuItem.Name = "weißToolStripMenuItem";
            this.weißToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F12)));
            this.weißToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.weißToolStripMenuItem.Text = "Weiß";
            // 
            // mnuProjectForm_Company_Export
            // 
            this.mnuProjectForm_Company_Export.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Export;
            this.mnuProjectForm_Company_Export.Name = "mnuProjectForm_Company_Export";
            this.mnuProjectForm_Company_Export.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuProjectForm_Company_Export.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Export.Text = "Firmen exportieren";
            this.mnuProjectForm_Company_Export.Click += new System.EventHandler(this.mnuProjectForm_Company_Export_Click);
            // 
            // mnuProjectForm_Application
            // 
            this.mnuProjectForm_Application.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectForm_Application_Add,
            this.mnuProjectForm_Application_Edit,
            this.mnuProjectForm_Application_Delete,
            this.mnuProjectForm_Application_GoToDir,
            this.mnuProjectForm_Application_Report,
            this.mnuProjectForm_Application_Duplicate,
            this.toolStripSeparator4,
            this.mnuProjectForm_Application_Filter,
            this.toolStripSeparator1,
            this.mnuProjectForm_Application_AutoArchive});
            this.mnuProjectForm_Application.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuProjectForm_Application.MergeIndex = 2;
            this.mnuProjectForm_Application.Name = "mnuProjectForm_Application";
            this.mnuProjectForm_Application.Size = new System.Drawing.Size(79, 20);
            this.mnuProjectForm_Application.Text = "Bewerbung";
            // 
            // mnuProjectForm_Application_Add
            // 
            this.mnuProjectForm_Application_Add.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.mnuProjectForm_Application_Add.Name = "mnuProjectForm_Application_Add";
            this.mnuProjectForm_Application_Add.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.mnuProjectForm_Application_Add.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Add.Text = "Hinzufügen";
            this.mnuProjectForm_Application_Add.Click += new System.EventHandler(this.mnuProjectForm_Application_Add_Click);
            // 
            // mnuProjectForm_Application_Edit
            // 
            this.mnuProjectForm_Application_Edit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Settings;
            this.mnuProjectForm_Application_Edit.Name = "mnuProjectForm_Application_Edit";
            this.mnuProjectForm_Application_Edit.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.B)));
            this.mnuProjectForm_Application_Edit.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Edit.Text = "Bearbeiten";
            this.mnuProjectForm_Application_Edit.Click += new System.EventHandler(this.mnuProjectForm_Application_Edit_Click);
            // 
            // mnuProjectForm_Application_Delete
            // 
            this.mnuProjectForm_Application_Delete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.mnuProjectForm_Application_Delete.Name = "mnuProjectForm_Application_Delete";
            this.mnuProjectForm_Application_Delete.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Delete)));
            this.mnuProjectForm_Application_Delete.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Delete.Text = "Löschen";
            this.mnuProjectForm_Application_Delete.Click += new System.EventHandler(this.mnuProjectForm_Application_Delete_Click);
            // 
            // mnuProjectForm_Application_GoToDir
            // 
            this.mnuProjectForm_Application_GoToDir.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.mnuProjectForm_Application_GoToDir.Name = "mnuProjectForm_Application_GoToDir";
            this.mnuProjectForm_Application_GoToDir.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.mnuProjectForm_Application_GoToDir.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_GoToDir.Text = "Ordner Öffnen";
            this.mnuProjectForm_Application_GoToDir.Click += new System.EventHandler(this.mnuProjectForm_Application_GoToDir_Click);
            // 
            // mnuProjectForm_Application_Report
            // 
            this.mnuProjectForm_Application_Report.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Report;
            this.mnuProjectForm_Application_Report.Name = "mnuProjectForm_Application_Report";
            this.mnuProjectForm_Application_Report.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.mnuProjectForm_Application_Report.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Report.Text = "Bericht erstellen";
            this.mnuProjectForm_Application_Report.Click += new System.EventHandler(this.mnuProjectForm_Application_Report_Click);
            // 
            // mnuProjectForm_Application_Duplicate
            // 
            this.mnuProjectForm_Application_Duplicate.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Copy;
            this.mnuProjectForm_Application_Duplicate.Name = "mnuProjectForm_Application_Duplicate";
            this.mnuProjectForm_Application_Duplicate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D)));
            this.mnuProjectForm_Application_Duplicate.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Duplicate.Text = "Duplizieren";
            this.mnuProjectForm_Application_Duplicate.Click += new System.EventHandler(this.mnuProjectForm_Application_Duplicate_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuProjectForm_Application_Filter
            // 
            this.mnuProjectForm_Application_Filter.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter;
            this.mnuProjectForm_Application_Filter.Name = "mnuProjectForm_Application_Filter";
            this.mnuProjectForm_Application_Filter.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.mnuProjectForm_Application_Filter.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_Filter.Text = "Filtern / Suchen";
            this.mnuProjectForm_Application_Filter.Click += new System.EventHandler(this.mnuProjectForm_Application_Filter_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // mnuProjectForm_Application_AutoArchive
            // 
            this.mnuProjectForm_Application_AutoArchive.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.AutoArchive;
            this.mnuProjectForm_Application_AutoArchive.Name = "mnuProjectForm_Application_AutoArchive";
            this.mnuProjectForm_Application_AutoArchive.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.mnuProjectForm_Application_AutoArchive.Size = new System.Drawing.Size(270, 22);
            this.mnuProjectForm_Application_AutoArchive.Text = "Automatisch archivieren";
            this.mnuProjectForm_Application_AutoArchive.Click += new System.EventHandler(this.mnuProjectForm_Application_AutoArchive_Click);
            // 
            // mnuProjectForm_List
            // 
            this.mnuProjectForm_List.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProjectForm_List_Application,
            this.mnuProjectForm_List_Reminder});
            this.mnuProjectForm_List.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuProjectForm_List.MergeIndex = 3;
            this.mnuProjectForm_List.Name = "mnuProjectForm_List";
            this.mnuProjectForm_List.Size = new System.Drawing.Size(87, 20);
            this.mnuProjectForm_List.Text = "Auflistungen";
            // 
            // mnuProjectForm_List_Application
            // 
            this.mnuProjectForm_List_Application.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Application;
            this.mnuProjectForm_List_Application.Name = "mnuProjectForm_List_Application";
            this.mnuProjectForm_List_Application.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.mnuProjectForm_List_Application.Size = new System.Drawing.Size(267, 22);
            this.mnuProjectForm_List_Application.Text = "Bewerbungen";
            this.mnuProjectForm_List_Application.Click += new System.EventHandler(this.mnuProjectForm_List_Application_Click);
            // 
            // mnuProjectForm_List_Reminder
            // 
            this.mnuProjectForm_List_Reminder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Reminder;
            this.mnuProjectForm_List_Reminder.Name = "mnuProjectForm_List_Reminder";
            this.mnuProjectForm_List_Reminder.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.mnuProjectForm_List_Reminder.Size = new System.Drawing.Size(267, 22);
            this.mnuProjectForm_List_Reminder.Text = "Erinnerungen";
            this.mnuProjectForm_List_Reminder.Click += new System.EventHandler(this.mnuProjectForm_List_Reminder_Click);
            // 
            // mnuProjectForm_Company_Import
            // 
            this.mnuProjectForm_Company_Import.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Import;
            this.mnuProjectForm_Company_Import.Name = "mnuProjectForm_Company_Import";
            this.mnuProjectForm_Company_Import.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuProjectForm_Company_Import.Size = new System.Drawing.Size(334, 22);
            this.mnuProjectForm_Company_Import.Text = "Firmen importieren";
            this.mnuProjectForm_Company_Import.Click += new System.EventHandler(this.mnuProjectForm_Company_Import_Click);
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 564);
            this.Controls.Add(this.mnuProjectForm);
            this.Controls.Add(this.spcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "ProjectForm";
            this.ShowInTaskbar = false;
            this.Text = "ProjectForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectForm_FormClosing);
            this.Shown += new System.EventHandler(this.ProjectForm_Shown);
            this.Leave += new System.EventHandler(this.ProjectForm_Leave);
            this.spcMain.Panel1.ResumeLayout(false);
            this.spcMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcMain)).EndInit();
            this.spcMain.ResumeLayout(false);
            this.spcCompany.Panel1.ResumeLayout(false);
            this.spcCompany.Panel1.PerformLayout();
            this.spcCompany.Panel2.ResumeLayout(false);
            this.spcCompany.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcCompany)).EndInit();
            this.spcCompany.ResumeLayout(false);
            this.grbFilter.ResumeLayout(false);
            this.grbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuickFilterCompanyId)).EndInit();
            this.spcApplication.Panel1.ResumeLayout(false);
            this.spcApplication.Panel1.PerformLayout();
            this.spcApplication.Panel2.ResumeLayout(false);
            this.spcApplication.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spcApplication)).EndInit();
            this.spcApplication.ResumeLayout(false);
            this.mnuProjectForm.ResumeLayout(false);
            this.mnuProjectForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer spcCompany;
        private System.Windows.Forms.Button btnCompanyAdressToClipboard;
        private System.Windows.Forms.GroupBox grbFilter;
        private System.Windows.Forms.NumericUpDown nudQuickFilterCompanyId;
        private System.Windows.Forms.Button btnFilterCompanyDetail;
        private System.Windows.Forms.Button btnFilterCompany;
        private System.Windows.Forms.Button btnFilterReset;
        private System.Windows.Forms.Label lblFilterCity;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblFilterId;
        private System.Windows.Forms.Label lblFilterTrade;
        private System.Windows.Forms.Label lblCompanyMain;
        private System.Windows.Forms.Label lblCompanyDetail;
        private System.Windows.Forms.SplitContainer spcApplication;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Title;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Number;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Priority;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Deadline;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Progress;
        private System.Windows.Forms.ColumnHeader chLsvApplication_ProgressDate;
        private System.Windows.Forms.ColumnHeader chLsvApplication_ReminderText;
        private System.Windows.Forms.ColumnHeader chLsvApplication_ReminderDate;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Created;
        private System.Windows.Forms.ColumnHeader chLsvApplication_Id;
        private System.Windows.Forms.Label lblApplicationMain;
        private System.Windows.Forms.Label lblApplicationDetail;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem farbe1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbe2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbe3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbe4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_AutoArchive;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_List_Application;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_List_Reminder;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_GoToDir;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Report;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_GoToDir;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Report;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Duplicate;
        private System.Windows.Forms.ToolStripMenuItem grünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hellrotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rosaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schwarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weißToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_Name;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_AdressCity;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_AdressCountry;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_Trade;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_ApplicationPriority;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_ApplicationProgress;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_ApplicationsDate;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_Comment;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_Applications;
        private System.Windows.Forms.ColumnHeader chLsvCompanyMain_Id;
        private System.Windows.Forms.ColumnHeader chLsvCompany_ReminderText;
        private System.Windows.Forms.ColumnHeader chLsvCompany_ReminderDate;
        private QuickFilterCompanyAppProgress uscQuickFilterCompanyAppProgress;
        private System.Windows.Forms.Button btnCompanyReport;
        private System.Windows.Forms.Button btnCompanyGoToCareerpage;
        private System.Windows.Forms.Button btnCompanyGoToHomepage;
        private System.Windows.Forms.Button btnCompanyGoToDir;
        private System.Windows.Forms.Button btnCompanyDelete;
        private System.Windows.Forms.Button btnCompanyEdit;
        private System.Windows.Forms.Button btnCompanyAdd;
        private System.Windows.Forms.CheckBox chkQuickFilterCompanyAppProgressMode;
        private System.Windows.Forms.TextBox txtQuickFilterCompanyTitle;
        private System.Windows.Forms.ComboBox cboQuickFilterCompanyTrade;
        private System.Windows.Forms.ComboBox cboQuickFilterCompanyCity;
        private System.Windows.Forms.CheckBox chkQuickFilterCompanyTerminated;
        private System.Windows.Forms.PropertyGrid prgCompany;
        private System.Windows.Forms.Button btnApplicationReport;
        private System.Windows.Forms.Button btnApplicationDuplicate;
        private System.Windows.Forms.Button btnApplicationGoToDir;
        private System.Windows.Forms.Button btnApplicationDelete;
        private System.Windows.Forms.Button btnApplicationEdit;
        private System.Windows.Forms.Button btnApplicationAdd;
        private System.Windows.Forms.PropertyGrid prgApplication;
        private System.Windows.Forms.ImageList imlColorMarkers;
        private System.Windows.Forms.ImageList imlApplicationType;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Filter;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Add;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Edit;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Delete;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Application_Filter;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_List;
        private System.Windows.Forms.SplitContainer spcMain;
        internal Toolbox.Widgets.SortListView lsvApplication;
        internal Toolbox.Widgets.SortListView lsvCompany;
        internal System.Windows.Forms.MenuStrip mnuProjectForm;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Export;
        private System.Windows.Forms.ToolStripMenuItem mnuProjectForm_Company_Import;
    }
}