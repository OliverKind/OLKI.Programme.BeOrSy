namespace OLKI.Programme.BeOrSy.src.Forms.MainForm.SubForms
{
    partial class ApplicationSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationSettingsForm));
            this.tpTabSettings_Common = new System.Windows.Forms.TabPage();
            this.chkAppUpdateCheckAtStartUp = new System.Windows.Forms.CheckBox();
            this.btnSetDefaults = new System.Windows.Forms.Button();
            this.grbFormating = new System.Windows.Forms.GroupBox();
            this.lblDateTimeFormatPreview = new System.Windows.Forms.Label();
            this.lblDateFormatPreview = new System.Windows.Forms.Label();
            this.txtDateTimeFormat = new System.Windows.Forms.TextBox();
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.txtDateFormat = new System.Windows.Forms.TextBox();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.chkFileAssociationCheckOnStartup = new System.Windows.Forms.CheckBox();
            this.grbProjectFolder = new System.Windows.Forms.GroupBox();
            this.btnStartupDefaultFileOpen_Delete = new System.Windows.Forms.Button();
            this.btnDirectoryFileDefaultPath_Delete = new System.Windows.Forms.Button();
            this.btnStartupDefaultFileOpen_Browse = new System.Windows.Forms.Button();
            this.txtStartupDefaultFileOpen = new System.Windows.Forms.TextBox();
            this.lblStartupDefaultFileOpen = new System.Windows.Forms.Label();
            this.btnDirectoryFileDefaultPath_Browse = new System.Windows.Forms.Button();
            this.txtDirectoryFileDefaultPath = new System.Windows.Forms.TextBox();
            this.lblDirectoryFileDefaultPath = new System.Windows.Forms.Label();
            this.grbRecentFiles = new System.Windows.Forms.GroupBox();
            this.btnRecentFilesClear = new System.Windows.Forms.Button();
            this.nudNumRecentFiles = new System.Windows.Forms.NumericUpDown();
            this.lblNumRecentFiles = new System.Windows.Forms.Label();
            this.btnCheckFileAssociation = new System.Windows.Forms.Button();
            this.chkProgressAllowWeightOverride = new System.Windows.Forms.CheckBox();
            this.btnPostcodeExport = new System.Windows.Forms.Button();
            this.btnPostcodeImport = new System.Windows.Forms.Button();
            this.btnPostcodeDelete = new System.Windows.Forms.Button();
            this.btnPostcodeAdd = new System.Windows.Forms.Button();
            this.grbPostcodeFilter = new System.Windows.Forms.GroupBox();
            this.btnPostcodeFilter = new System.Windows.Forms.Button();
            this.lblFilterPostcodeNati = new System.Windows.Forms.Label();
            this.txtPostcodeFilterNati = new System.Windows.Forms.TextBox();
            this.lblFilterPostcodeCity = new System.Windows.Forms.Label();
            this.txtPostcodeFilterCity = new System.Windows.Forms.TextBox();
            this.tpTabSettings_Postcode = new System.Windows.Forms.TabPage();
            this.chkPostcodeSettAllActive = new System.Windows.Forms.CheckBox();
            this.nudPostcodeListItemsWarning = new System.Windows.Forms.NumericUpDown();
            this.lblPostcodeListItemsWarning = new System.Windows.Forms.Label();
            this.pnlManagePostcode = new System.Windows.Forms.Panel();
            this.btnPostcodeCancelShow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.epbListPostcodeProgress = new OLKI.Toolbox.Widgets.ExtProgressBar();
            this.lsvPostcodes = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvPostcodes_Postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvPostcodes_City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvPostcodes_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvPostcodes_Nation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prgPostcodeData = new OLKI.Toolbox.Widgets.ReadOnlyPropertyGrid();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpTabSettings_AppProgress = new System.Windows.Forms.TabPage();
            this.chkProgressNewSetActualDate = new System.Windows.Forms.CheckBox();
            this.grbProgressAllowWeightOverride = new System.Windows.Forms.GroupBox();
            this.lblAppProgressAllowWeightOverride = new System.Windows.Forms.Label();
            this.imlRegister = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.erpDateFormat = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpTabSettings_Common.SuspendLayout();
            this.grbFormating.SuspendLayout();
            this.grbProjectFolder.SuspendLayout();
            this.grbRecentFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRecentFiles)).BeginInit();
            this.grbPostcodeFilter.SuspendLayout();
            this.tpTabSettings_Postcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPostcodeListItemsWarning)).BeginInit();
            this.pnlManagePostcode.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tpTabSettings_AppProgress.SuspendLayout();
            this.grbProgressAllowWeightOverride.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateFormat)).BeginInit();
            this.SuspendLayout();
            // 
            // tpTabSettings_Common
            // 
            this.tpTabSettings_Common.Controls.Add(this.chkAppUpdateCheckAtStartUp);
            this.tpTabSettings_Common.Controls.Add(this.btnSetDefaults);
            this.tpTabSettings_Common.Controls.Add(this.grbFormating);
            this.tpTabSettings_Common.Controls.Add(this.chkFileAssociationCheckOnStartup);
            this.tpTabSettings_Common.Controls.Add(this.grbProjectFolder);
            this.tpTabSettings_Common.Controls.Add(this.grbRecentFiles);
            this.tpTabSettings_Common.Controls.Add(this.btnCheckFileAssociation);
            this.tpTabSettings_Common.ImageIndex = 0;
            this.tpTabSettings_Common.Location = new System.Drawing.Point(4, 23);
            this.tpTabSettings_Common.Name = "tpTabSettings_Common";
            this.tpTabSettings_Common.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabSettings_Common.Size = new System.Drawing.Size(680, 441);
            this.tpTabSettings_Common.TabIndex = 0;
            this.tpTabSettings_Common.Text = "Allgemeine Einstellungen";
            this.tpTabSettings_Common.UseVisualStyleBackColor = true;
            // 
            // chkAppUpdateCheckAtStartUp
            // 
            this.chkAppUpdateCheckAtStartUp.AutoSize = true;
            this.chkAppUpdateCheckAtStartUp.Location = new System.Drawing.Point(6, 240);
            this.chkAppUpdateCheckAtStartUp.Name = "chkAppUpdateCheckAtStartUp";
            this.chkAppUpdateCheckAtStartUp.Size = new System.Drawing.Size(248, 17);
            this.chkAppUpdateCheckAtStartUp.TabIndex = 5;
            this.chkAppUpdateCheckAtStartUp.Text = "Auf neue Programmversionen beim Start prüfen";
            this.chkAppUpdateCheckAtStartUp.UseVisualStyleBackColor = true;
            // 
            // btnSetDefaults
            // 
            this.btnSetDefaults.Location = new System.Drawing.Point(468, 412);
            this.btnSetDefaults.Name = "btnSetDefaults";
            this.btnSetDefaults.Size = new System.Drawing.Size(206, 23);
            this.btnSetDefaults.TabIndex = 6;
            this.btnSetDefaults.Text = "Standardeinstellungen wiederherstellen";
            this.btnSetDefaults.UseVisualStyleBackColor = true;
            this.btnSetDefaults.Click += new System.EventHandler(this.btnSetDefaults_Click);
            // 
            // grbFormating
            // 
            this.grbFormating.Controls.Add(this.lblDateTimeFormatPreview);
            this.grbFormating.Controls.Add(this.lblDateFormatPreview);
            this.grbFormating.Controls.Add(this.txtDateTimeFormat);
            this.grbFormating.Controls.Add(this.lblDateTimeFormat);
            this.grbFormating.Controls.Add(this.txtDateFormat);
            this.grbFormating.Controls.Add(this.lblDateFormat);
            this.grbFormating.Location = new System.Drawing.Point(6, 80);
            this.grbFormating.Name = "grbFormating";
            this.grbFormating.Size = new System.Drawing.Size(665, 71);
            this.grbFormating.TabIndex = 1;
            this.grbFormating.TabStop = false;
            this.grbFormating.Text = "Formatierung";
            // 
            // lblDateTimeFormatPreview
            // 
            this.lblDateTimeFormatPreview.AutoSize = true;
            this.lblDateTimeFormatPreview.Location = new System.Drawing.Point(251, 48);
            this.lblDateTimeFormatPreview.Name = "lblDateTimeFormatPreview";
            this.lblDateTimeFormatPreview.Size = new System.Drawing.Size(133, 13);
            this.lblDateTimeFormatPreview.TabIndex = 5;
            this.lblDateTimeFormatPreview.Text = "lblDateTimeFormatPreview";
            // 
            // lblDateFormatPreview
            // 
            this.lblDateFormatPreview.AutoSize = true;
            this.lblDateFormatPreview.Location = new System.Drawing.Point(251, 22);
            this.lblDateFormatPreview.Name = "lblDateFormatPreview";
            this.lblDateFormatPreview.Size = new System.Drawing.Size(110, 13);
            this.lblDateFormatPreview.TabIndex = 2;
            this.lblDateFormatPreview.Text = "lblDateFormatPreview";
            // 
            // txtDateTimeFormat
            // 
            this.txtDateTimeFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDateTimeFormat.Location = new System.Drawing.Point(95, 45);
            this.txtDateTimeFormat.Name = "txtDateTimeFormat";
            this.txtDateTimeFormat.Size = new System.Drawing.Size(150, 20);
            this.txtDateTimeFormat.TabIndex = 4;
            this.txtDateTimeFormat.TextChanged += new System.EventHandler(this.txtDateTimeFormat_TextChanged);
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.AutoSize = true;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(6, 48);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(83, 13);
            this.lblDateTimeFormat.TabIndex = 3;
            this.lblDateTimeFormat.Text = "Datum und Zeit:";
            // 
            // txtDateFormat
            // 
            this.txtDateFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDateFormat.Location = new System.Drawing.Point(95, 19);
            this.txtDateFormat.Name = "txtDateFormat";
            this.txtDateFormat.Size = new System.Drawing.Size(150, 20);
            this.txtDateFormat.TabIndex = 1;
            this.txtDateFormat.TextChanged += new System.EventHandler(this.txtDateFormat_TextChanged);
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.Location = new System.Drawing.Point(6, 21);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(41, 13);
            this.lblDateFormat.TabIndex = 0;
            this.lblDateFormat.Text = "Datum:";
            // 
            // chkFileAssociationCheckOnStartup
            // 
            this.chkFileAssociationCheckOnStartup.AutoSize = true;
            this.chkFileAssociationCheckOnStartup.Location = new System.Drawing.Point(146, 215);
            this.chkFileAssociationCheckOnStartup.Name = "chkFileAssociationCheckOnStartup";
            this.chkFileAssociationCheckOnStartup.Size = new System.Drawing.Size(185, 17);
            this.chkFileAssociationCheckOnStartup.TabIndex = 4;
            this.chkFileAssociationCheckOnStartup.Text = "Dateizuordnung beim Start Prüfen";
            // 
            // grbProjectFolder
            // 
            this.grbProjectFolder.Controls.Add(this.btnStartupDefaultFileOpen_Delete);
            this.grbProjectFolder.Controls.Add(this.btnDirectoryFileDefaultPath_Delete);
            this.grbProjectFolder.Controls.Add(this.btnStartupDefaultFileOpen_Browse);
            this.grbProjectFolder.Controls.Add(this.txtStartupDefaultFileOpen);
            this.grbProjectFolder.Controls.Add(this.lblStartupDefaultFileOpen);
            this.grbProjectFolder.Controls.Add(this.btnDirectoryFileDefaultPath_Browse);
            this.grbProjectFolder.Controls.Add(this.txtDirectoryFileDefaultPath);
            this.grbProjectFolder.Controls.Add(this.lblDirectoryFileDefaultPath);
            this.grbProjectFolder.Location = new System.Drawing.Point(6, 3);
            this.grbProjectFolder.Name = "grbProjectFolder";
            this.grbProjectFolder.Size = new System.Drawing.Size(665, 71);
            this.grbProjectFolder.TabIndex = 0;
            this.grbProjectFolder.TabStop = false;
            this.grbProjectFolder.Text = "Standardordner und -dateien";
            // 
            // btnStartupDefaultFileOpen_Delete
            // 
            this.btnStartupDefaultFileOpen_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnStartupDefaultFileOpen_Delete.Image")));
            this.btnStartupDefaultFileOpen_Delete.Location = new System.Drawing.Point(624, 42);
            this.btnStartupDefaultFileOpen_Delete.Name = "btnStartupDefaultFileOpen_Delete";
            this.btnStartupDefaultFileOpen_Delete.Size = new System.Drawing.Size(35, 24);
            this.btnStartupDefaultFileOpen_Delete.TabIndex = 7;
            this.btnStartupDefaultFileOpen_Delete.UseVisualStyleBackColor = true;
            this.btnStartupDefaultFileOpen_Delete.Click += new System.EventHandler(this.btnStartupDefaultFileOpen_Delete_Click);
            // 
            // btnDirectoryFileDefaultPath_Delete
            // 
            this.btnDirectoryFileDefaultPath_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectoryFileDefaultPath_Delete.Image")));
            this.btnDirectoryFileDefaultPath_Delete.Location = new System.Drawing.Point(624, 15);
            this.btnDirectoryFileDefaultPath_Delete.Name = "btnDirectoryFileDefaultPath_Delete";
            this.btnDirectoryFileDefaultPath_Delete.Size = new System.Drawing.Size(35, 24);
            this.btnDirectoryFileDefaultPath_Delete.TabIndex = 3;
            this.btnDirectoryFileDefaultPath_Delete.UseVisualStyleBackColor = true;
            this.btnDirectoryFileDefaultPath_Delete.Click += new System.EventHandler(this.btnDirectoryFileDefaultPath_Delete_Click);
            // 
            // btnStartupDefaultFileOpen_Browse
            // 
            this.btnStartupDefaultFileOpen_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btnStartupDefaultFileOpen_Browse.Image")));
            this.btnStartupDefaultFileOpen_Browse.Location = new System.Drawing.Point(583, 42);
            this.btnStartupDefaultFileOpen_Browse.Name = "btnStartupDefaultFileOpen_Browse";
            this.btnStartupDefaultFileOpen_Browse.Size = new System.Drawing.Size(35, 24);
            this.btnStartupDefaultFileOpen_Browse.TabIndex = 6;
            this.btnStartupDefaultFileOpen_Browse.UseVisualStyleBackColor = true;
            this.btnStartupDefaultFileOpen_Browse.Click += new System.EventHandler(this.btnStartupDefaultFileOpen_Browse_Click);
            // 
            // txtStartupDefaultFileOpen
            // 
            this.txtStartupDefaultFileOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtStartupDefaultFileOpen.Location = new System.Drawing.Point(140, 45);
            this.txtStartupDefaultFileOpen.Name = "txtStartupDefaultFileOpen";
            this.txtStartupDefaultFileOpen.Size = new System.Drawing.Size(437, 20);
            this.txtStartupDefaultFileOpen.TabIndex = 5;
            // 
            // lblStartupDefaultFileOpen
            // 
            this.lblStartupDefaultFileOpen.AutoSize = true;
            this.lblStartupDefaultFileOpen.Location = new System.Drawing.Point(6, 48);
            this.lblStartupDefaultFileOpen.Name = "lblStartupDefaultFileOpen";
            this.lblStartupDefaultFileOpen.Size = new System.Drawing.Size(128, 13);
            this.lblStartupDefaultFileOpen.TabIndex = 4;
            this.lblStartupDefaultFileOpen.Text = "Datei beim starten öffnen:";
            // 
            // btnDirectoryFileDefaultPath_Browse
            // 
            this.btnDirectoryFileDefaultPath_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btnDirectoryFileDefaultPath_Browse.Image")));
            this.btnDirectoryFileDefaultPath_Browse.Location = new System.Drawing.Point(583, 15);
            this.btnDirectoryFileDefaultPath_Browse.Name = "btnDirectoryFileDefaultPath_Browse";
            this.btnDirectoryFileDefaultPath_Browse.Size = new System.Drawing.Size(35, 24);
            this.btnDirectoryFileDefaultPath_Browse.TabIndex = 2;
            this.btnDirectoryFileDefaultPath_Browse.UseVisualStyleBackColor = true;
            this.btnDirectoryFileDefaultPath_Browse.Click += new System.EventHandler(this.btnDirectoryFileDefaultPath_Browse_Click);
            // 
            // txtDirectoryFileDefaultPath
            // 
            this.txtDirectoryFileDefaultPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDirectoryFileDefaultPath.Location = new System.Drawing.Point(140, 19);
            this.txtDirectoryFileDefaultPath.Name = "txtDirectoryFileDefaultPath";
            this.txtDirectoryFileDefaultPath.Size = new System.Drawing.Size(437, 20);
            this.txtDirectoryFileDefaultPath.TabIndex = 1;
            // 
            // lblDirectoryFileDefaultPath
            // 
            this.lblDirectoryFileDefaultPath.AutoSize = true;
            this.lblDirectoryFileDefaultPath.Location = new System.Drawing.Point(6, 22);
            this.lblDirectoryFileDefaultPath.Name = "lblDirectoryFileDefaultPath";
            this.lblDirectoryFileDefaultPath.Size = new System.Drawing.Size(83, 13);
            this.lblDirectoryFileDefaultPath.TabIndex = 0;
            this.lblDirectoryFileDefaultPath.Text = "Standardordner:";
            // 
            // grbRecentFiles
            // 
            this.grbRecentFiles.Controls.Add(this.btnRecentFilesClear);
            this.grbRecentFiles.Controls.Add(this.nudNumRecentFiles);
            this.grbRecentFiles.Controls.Add(this.lblNumRecentFiles);
            this.grbRecentFiles.Location = new System.Drawing.Point(6, 157);
            this.grbRecentFiles.Name = "grbRecentFiles";
            this.grbRecentFiles.Size = new System.Drawing.Size(665, 48);
            this.grbRecentFiles.TabIndex = 2;
            this.grbRecentFiles.TabStop = false;
            this.grbRecentFiles.Text = "Zuletzt geöffnete Dateien";
            // 
            // btnRecentFilesClear
            // 
            this.btnRecentFilesClear.Location = new System.Drawing.Point(280, 19);
            this.btnRecentFilesClear.Name = "btnRecentFilesClear";
            this.btnRecentFilesClear.Size = new System.Drawing.Size(110, 23);
            this.btnRecentFilesClear.TabIndex = 2;
            this.btnRecentFilesClear.Text = "Liste leeren";
            this.btnRecentFilesClear.UseVisualStyleBackColor = true;
            this.btnRecentFilesClear.Click += new System.EventHandler(this.btnRecentFilesClear_Click);
            // 
            // nudNumRecentFiles
            // 
            this.nudNumRecentFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudNumRecentFiles.Location = new System.Drawing.Point(245, 19);
            this.nudNumRecentFiles.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudNumRecentFiles.Name = "nudNumRecentFiles";
            this.nudNumRecentFiles.Size = new System.Drawing.Size(29, 20);
            this.nudNumRecentFiles.TabIndex = 1;
            // 
            // lblNumRecentFiles
            // 
            this.lblNumRecentFiles.AutoSize = true;
            this.lblNumRecentFiles.Location = new System.Drawing.Point(6, 21);
            this.lblNumRecentFiles.Name = "lblNumRecentFiles";
            this.lblNumRecentFiles.Size = new System.Drawing.Size(233, 13);
            this.lblNumRecentFiles.TabIndex = 0;
            this.lblNumRecentFiles.Text = "Anzahl der zuletzt geöffneten Dateien anzeigen:";
            // 
            // btnCheckFileAssociation
            // 
            this.btnCheckFileAssociation.Location = new System.Drawing.Point(6, 211);
            this.btnCheckFileAssociation.Name = "btnCheckFileAssociation";
            this.btnCheckFileAssociation.Size = new System.Drawing.Size(134, 23);
            this.btnCheckFileAssociation.TabIndex = 3;
            this.btnCheckFileAssociation.Text = "Dateizuordnung prüfen";
            this.btnCheckFileAssociation.UseVisualStyleBackColor = true;
            this.btnCheckFileAssociation.Click += new System.EventHandler(this.btnCheckFileAssociation_Click);
            // 
            // chkProgressAllowWeightOverride
            // 
            this.chkProgressAllowWeightOverride.AutoSize = true;
            this.chkProgressAllowWeightOverride.Location = new System.Drawing.Point(6, 19);
            this.chkProgressAllowWeightOverride.Name = "chkProgressAllowWeightOverride";
            this.chkProgressAllowWeightOverride.Size = new System.Drawing.Size(232, 17);
            this.chkProgressAllowWeightOverride.TabIndex = 0;
            this.chkProgressAllowWeightOverride.Text = "Erlaube das Überschreiben der Gewichtung";
            this.chkProgressAllowWeightOverride.CheckedChanged += new System.EventHandler(this.chkProgressAllowWeightOverride_CheckedChanged);
            // 
            // btnPostcodeExport
            // 
            this.btnPostcodeExport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Export;
            this.btnPostcodeExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostcodeExport.Location = new System.Drawing.Point(212, 0);
            this.btnPostcodeExport.Name = "btnPostcodeExport";
            this.btnPostcodeExport.Size = new System.Drawing.Size(100, 24);
            this.btnPostcodeExport.TabIndex = 3;
            this.btnPostcodeExport.Text = "Exportieren";
            this.btnPostcodeExport.UseVisualStyleBackColor = true;
            this.btnPostcodeExport.Click += new System.EventHandler(this.btnPostcodeExport_Click);
            // 
            // btnPostcodeImport
            // 
            this.btnPostcodeImport.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Import;
            this.btnPostcodeImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostcodeImport.Location = new System.Drawing.Point(106, 0);
            this.btnPostcodeImport.Name = "btnPostcodeImport";
            this.btnPostcodeImport.Size = new System.Drawing.Size(100, 24);
            this.btnPostcodeImport.TabIndex = 2;
            this.btnPostcodeImport.Text = "Importieren";
            this.btnPostcodeImport.UseVisualStyleBackColor = true;
            this.btnPostcodeImport.Click += new System.EventHandler(this.btnPostcodeImport_Click);
            // 
            // btnPostcodeDelete
            // 
            this.btnPostcodeDelete.Enabled = false;
            this.btnPostcodeDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnPostcodeDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostcodeDelete.Location = new System.Drawing.Point(362, 0);
            this.btnPostcodeDelete.Name = "btnPostcodeDelete";
            this.btnPostcodeDelete.Size = new System.Drawing.Size(100, 24);
            this.btnPostcodeDelete.TabIndex = 4;
            this.btnPostcodeDelete.Text = "Löschen";
            this.btnPostcodeDelete.UseVisualStyleBackColor = true;
            this.btnPostcodeDelete.Click += new System.EventHandler(this.btnPostcodeDelete_Click);
            // 
            // btnPostcodeAdd
            // 
            this.btnPostcodeAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnPostcodeAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostcodeAdd.Location = new System.Drawing.Point(0, 0);
            this.btnPostcodeAdd.Name = "btnPostcodeAdd";
            this.btnPostcodeAdd.Size = new System.Drawing.Size(100, 24);
            this.btnPostcodeAdd.TabIndex = 1;
            this.btnPostcodeAdd.Text = "Hinzufügen";
            this.btnPostcodeAdd.UseVisualStyleBackColor = true;
            this.btnPostcodeAdd.Click += new System.EventHandler(this.btnPostcodeAdd_Click);
            // 
            // grbPostcodeFilter
            // 
            this.grbPostcodeFilter.Controls.Add(this.btnPostcodeFilter);
            this.grbPostcodeFilter.Controls.Add(this.lblFilterPostcodeNati);
            this.grbPostcodeFilter.Controls.Add(this.txtPostcodeFilterNati);
            this.grbPostcodeFilter.Controls.Add(this.lblFilterPostcodeCity);
            this.grbPostcodeFilter.Controls.Add(this.txtPostcodeFilterCity);
            this.grbPostcodeFilter.Location = new System.Drawing.Point(6, 3);
            this.grbPostcodeFilter.Name = "grbPostcodeFilter";
            this.grbPostcodeFilter.Size = new System.Drawing.Size(462, 49);
            this.grbPostcodeFilter.TabIndex = 0;
            this.grbPostcodeFilter.TabStop = false;
            this.grbPostcodeFilter.Text = "Filtern";
            // 
            // btnPostcodeFilter
            // 
            this.btnPostcodeFilter.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter;
            this.btnPostcodeFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostcodeFilter.Location = new System.Drawing.Point(341, 17);
            this.btnPostcodeFilter.Name = "btnPostcodeFilter";
            this.btnPostcodeFilter.Size = new System.Drawing.Size(115, 23);
            this.btnPostcodeFilter.TabIndex = 4;
            this.btnPostcodeFilter.Text = "Filtern";
            this.btnPostcodeFilter.UseVisualStyleBackColor = true;
            this.btnPostcodeFilter.Click += new System.EventHandler(this.btnPostcodeFilter_Click);
            // 
            // lblFilterPostcodeNati
            // 
            this.lblFilterPostcodeNati.AutoSize = true;
            this.lblFilterPostcodeNati.Location = new System.Drawing.Point(6, 22);
            this.lblFilterPostcodeNati.Name = "lblFilterPostcodeNati";
            this.lblFilterPostcodeNati.Size = new System.Drawing.Size(34, 13);
            this.lblFilterPostcodeNati.TabIndex = 0;
            this.lblFilterPostcodeNati.Text = "Land:";
            // 
            // txtPostcodeFilterNati
            // 
            this.txtPostcodeFilterNati.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPostcodeFilterNati.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPostcodeFilterNati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPostcodeFilterNati.Location = new System.Drawing.Point(46, 19);
            this.txtPostcodeFilterNati.Name = "txtPostcodeFilterNati";
            this.txtPostcodeFilterNati.Size = new System.Drawing.Size(121, 20);
            this.txtPostcodeFilterNati.TabIndex = 1;
            // 
            // lblFilterPostcodeCity
            // 
            this.lblFilterPostcodeCity.AutoSize = true;
            this.lblFilterPostcodeCity.Location = new System.Drawing.Point(173, 22);
            this.lblFilterPostcodeCity.Name = "lblFilterPostcodeCity";
            this.lblFilterPostcodeCity.Size = new System.Drawing.Size(35, 13);
            this.lblFilterPostcodeCity.TabIndex = 2;
            this.lblFilterPostcodeCity.Text = "Stadt:";
            // 
            // txtPostcodeFilterCity
            // 
            this.txtPostcodeFilterCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtPostcodeFilterCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPostcodeFilterCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPostcodeFilterCity.Location = new System.Drawing.Point(214, 19);
            this.txtPostcodeFilterCity.Name = "txtPostcodeFilterCity";
            this.txtPostcodeFilterCity.Size = new System.Drawing.Size(121, 20);
            this.txtPostcodeFilterCity.TabIndex = 3;
            // 
            // tpTabSettings_Postcode
            // 
            this.tpTabSettings_Postcode.Controls.Add(this.chkPostcodeSettAllActive);
            this.tpTabSettings_Postcode.Controls.Add(this.nudPostcodeListItemsWarning);
            this.tpTabSettings_Postcode.Controls.Add(this.lblPostcodeListItemsWarning);
            this.tpTabSettings_Postcode.Controls.Add(this.pnlManagePostcode);
            this.tpTabSettings_Postcode.Controls.Add(this.btnPostcodeCancelShow);
            this.tpTabSettings_Postcode.Controls.Add(this.label3);
            this.tpTabSettings_Postcode.Controls.Add(this.epbListPostcodeProgress);
            this.tpTabSettings_Postcode.Controls.Add(this.lsvPostcodes);
            this.tpTabSettings_Postcode.Controls.Add(this.grbPostcodeFilter);
            this.tpTabSettings_Postcode.Controls.Add(this.prgPostcodeData);
            this.tpTabSettings_Postcode.ImageIndex = 1;
            this.tpTabSettings_Postcode.Location = new System.Drawing.Point(4, 23);
            this.tpTabSettings_Postcode.Name = "tpTabSettings_Postcode";
            this.tpTabSettings_Postcode.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabSettings_Postcode.Size = new System.Drawing.Size(680, 441);
            this.tpTabSettings_Postcode.TabIndex = 1;
            this.tpTabSettings_Postcode.Text = "Postleitzahlen verwalten";
            this.tpTabSettings_Postcode.UseVisualStyleBackColor = true;
            // 
            // chkPostcodeSettAllActive
            // 
            this.chkPostcodeSettAllActive.AutoSize = true;
            this.chkPostcodeSettAllActive.Location = new System.Drawing.Point(6, 394);
            this.chkPostcodeSettAllActive.Name = "chkPostcodeSettAllActive";
            this.chkPostcodeSettAllActive.Size = new System.Drawing.Size(286, 17);
            this.chkPostcodeSettAllActive.TabIndex = 15;
            this.chkPostcodeSettAllActive.Text = "Aktivstatus, für die Suche, für alle Postleitzahlen setzen";
            this.chkPostcodeSettAllActive.ThreeState = true;
            this.chkPostcodeSettAllActive.UseVisualStyleBackColor = true;
            this.chkPostcodeSettAllActive.CheckedChanged += new System.EventHandler(this.chkPostcodeSettAllActive_CheckedChanged);
            // 
            // nudPostcodeListItemsWarning
            // 
            this.nudPostcodeListItemsWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudPostcodeListItemsWarning.Location = new System.Drawing.Point(226, 415);
            this.nudPostcodeListItemsWarning.Name = "nudPostcodeListItemsWarning";
            this.nudPostcodeListItemsWarning.Size = new System.Drawing.Size(100, 20);
            this.nudPostcodeListItemsWarning.TabIndex = 14;
            this.nudPostcodeListItemsWarning.ThousandsSeparator = true;
            // 
            // lblPostcodeListItemsWarning
            // 
            this.lblPostcodeListItemsWarning.AutoSize = true;
            this.lblPostcodeListItemsWarning.Location = new System.Drawing.Point(6, 417);
            this.lblPostcodeListItemsWarning.Name = "lblPostcodeListItemsWarning";
            this.lblPostcodeListItemsWarning.Size = new System.Drawing.Size(214, 13);
            this.lblPostcodeListItemsWarning.TabIndex = 13;
            this.lblPostcodeListItemsWarning.Text = "Warnung bei langer Liste (0 für unbegrenzt):";
            // 
            // pnlManagePostcode
            // 
            this.pnlManagePostcode.Controls.Add(this.btnPostcodeDelete);
            this.pnlManagePostcode.Controls.Add(this.btnPostcodeAdd);
            this.pnlManagePostcode.Controls.Add(this.btnPostcodeExport);
            this.pnlManagePostcode.Controls.Add(this.btnPostcodeImport);
            this.pnlManagePostcode.Location = new System.Drawing.Point(6, 58);
            this.pnlManagePostcode.Name = "pnlManagePostcode";
            this.pnlManagePostcode.Size = new System.Drawing.Size(462, 24);
            this.pnlManagePostcode.TabIndex = 12;
            this.pnlManagePostcode.EnabledChanged += new System.EventHandler(this.pnlManagePostcode_EnabledChanged);
            // 
            // btnPostcodeCancelShow
            // 
            this.btnPostcodeCancelShow.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnPostcodeCancelShow.Location = new System.Drawing.Point(112, 198);
            this.btnPostcodeCancelShow.Name = "btnPostcodeCancelShow";
            this.btnPostcodeCancelShow.Size = new System.Drawing.Size(462, 23);
            this.btnPostcodeCancelShow.TabIndex = 10;
            this.btnPostcodeCancelShow.Text = "Abbrechen";
            this.btnPostcodeCancelShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPostcodeCancelShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPostcodeCancelShow.UseVisualStyleBackColor = true;
            this.btnPostcodeCancelShow.VisibleChanged += new System.EventHandler(this.btnPostcodeCancelShow_VisibleChanged);
            this.btnPostcodeCancelShow.Click += new System.EventHandler(this.btnPostcodeCancelShow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // epbListPostcodeProgress
            // 
            this.epbListPostcodeProgress.AutoByteDimension = false;
            this.epbListPostcodeProgress.ByteDimension = OLKI.Toolbox.DirectoryAndFile.FileSize.Dimension.NoDimension;
            this.epbListPostcodeProgress.DecimalDigits = ((uint)(0u));
            this.epbListPostcodeProgress.HideDimensionGrowMode = OLKI.Toolbox.Widgets.ExtProgressBar.HideDimensionMode.GrowProgressBar;
            this.epbListPostcodeProgress.Location = new System.Drawing.Point(52, 143);
            this.epbListPostcodeProgress.MaxValue = ((long)(-1));
            this.epbListPostcodeProgress.MinimumSize = new System.Drawing.Size(300, 23);
            this.epbListPostcodeProgress.Name = "epbListPostcodeProgress";
            this.epbListPostcodeProgress.ShowDimensionComboBox = false;
            this.epbListPostcodeProgress.Size = new System.Drawing.Size(462, 49);
            this.epbListPostcodeProgress.TabIndex = 6;
            this.epbListPostcodeProgress.Value = ((long)(-1));
            // 
            // lsvPostcodes
            // 
            this.lsvPostcodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvPostcodes.CheckBoxes = true;
            this.lsvPostcodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvPostcodes_Postcode,
            this.chLsvPostcodes_City,
            this.chLsvPostcodes_State,
            this.chLsvPostcodes_Nation});
            this.lsvPostcodes.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvPostcodes.ColumnWidths")));
            this.lsvPostcodes.FullRowSelect = true;
            this.lsvPostcodes.GridLines = true;
            this.lsvPostcodes.HideSelection = false;
            this.lsvPostcodes.Location = new System.Drawing.Point(6, 88);
            this.lsvPostcodes.Name = "lsvPostcodes";
            this.lsvPostcodes.SelectAllKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.lsvPostcodes.Size = new System.Drawing.Size(462, 300);
            this.lsvPostcodes.TabIndex = 5;
            this.lsvPostcodes.UseCompatibleStateImageBehavior = false;
            this.lsvPostcodes.View = System.Windows.Forms.View.Details;
            this.lsvPostcodes.SelectedIndexChanged += new System.EventHandler(this.lsvPostcodes_SelectedIndexChanged);
            this.lsvPostcodes.VisibleChanged += new System.EventHandler(this.lsvPostcodes_VisibleChanged);
            this.lsvPostcodes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsvPostcodes_KeyDown);
            // 
            // chLsvPostcodes_Postcode
            // 
            this.chLsvPostcodes_Postcode.Text = "Postleitzahl";
            this.chLsvPostcodes_Postcode.Width = 90;
            // 
            // chLsvPostcodes_City
            // 
            this.chLsvPostcodes_City.Text = "Stadt";
            this.chLsvPostcodes_City.Width = 90;
            // 
            // chLsvPostcodes_State
            // 
            this.chLsvPostcodes_State.Text = "Bundesland";
            this.chLsvPostcodes_State.Width = 120;
            // 
            // chLsvPostcodes_Nation
            // 
            this.chLsvPostcodes_Nation.Text = "Land";
            this.chLsvPostcodes_Nation.Width = 120;
            // 
            // prgPostcodeData
            // 
            this.prgPostcodeData.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgPostcodeData.Location = new System.Drawing.Point(474, 6);
            this.prgPostcodeData.Name = "prgPostcodeData";
            this.prgPostcodeData.Size = new System.Drawing.Size(200, 429);
            this.prgPostcodeData.TabIndex = 8;
            this.prgPostcodeData.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.prgPostcodeData.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.prgPostcodeData_PropertyValueChanged);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpTabSettings_Common);
            this.tabSettings.Controls.Add(this.tpTabSettings_Postcode);
            this.tabSettings.Controls.Add(this.tpTabSettings_AppProgress);
            this.tabSettings.ImageList = this.imlRegister;
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(688, 468);
            this.tabSettings.TabIndex = 0;
            // 
            // tpTabSettings_AppProgress
            // 
            this.tpTabSettings_AppProgress.Controls.Add(this.chkProgressNewSetActualDate);
            this.tpTabSettings_AppProgress.Controls.Add(this.grbProgressAllowWeightOverride);
            this.tpTabSettings_AppProgress.ImageIndex = 2;
            this.tpTabSettings_AppProgress.Location = new System.Drawing.Point(4, 23);
            this.tpTabSettings_AppProgress.Name = "tpTabSettings_AppProgress";
            this.tpTabSettings_AppProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabSettings_AppProgress.Size = new System.Drawing.Size(680, 441);
            this.tpTabSettings_AppProgress.TabIndex = 2;
            this.tpTabSettings_AppProgress.Text = "Bewerbungsfortschritt";
            this.tpTabSettings_AppProgress.UseVisualStyleBackColor = true;
            // 
            // chkProgressNewSetActualDate
            // 
            this.chkProgressNewSetActualDate.AutoSize = true;
            this.chkProgressNewSetActualDate.Location = new System.Drawing.Point(6, 6);
            this.chkProgressNewSetActualDate.Name = "chkProgressNewSetActualDate";
            this.chkProgressNewSetActualDate.Size = new System.Drawing.Size(314, 17);
            this.chkProgressNewSetActualDate.TabIndex = 0;
            this.chkProgressNewSetActualDate.Text = "Beim Anlegen eines Fortschritts das aktuelle Datum eintragen";
            // 
            // grbProgressAllowWeightOverride
            // 
            this.grbProgressAllowWeightOverride.Controls.Add(this.chkProgressAllowWeightOverride);
            this.grbProgressAllowWeightOverride.Controls.Add(this.lblAppProgressAllowWeightOverride);
            this.grbProgressAllowWeightOverride.Location = new System.Drawing.Point(6, 29);
            this.grbProgressAllowWeightOverride.Name = "grbProgressAllowWeightOverride";
            this.grbProgressAllowWeightOverride.Size = new System.Drawing.Size(668, 122);
            this.grbProgressAllowWeightOverride.TabIndex = 1;
            this.grbProgressAllowWeightOverride.TabStop = false;
            this.grbProgressAllowWeightOverride.Text = "Gewichtung überschreiben";
            // 
            // lblAppProgressAllowWeightOverride
            // 
            this.lblAppProgressAllowWeightOverride.AutoSize = true;
            this.lblAppProgressAllowWeightOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppProgressAllowWeightOverride.Location = new System.Drawing.Point(6, 39);
            this.lblAppProgressAllowWeightOverride.Name = "lblAppProgressAllowWeightOverride";
            this.lblAppProgressAllowWeightOverride.Size = new System.Drawing.Size(566, 80);
            this.lblAppProgressAllowWeightOverride.TabIndex = 1;
            this.lblAppProgressAllowWeightOverride.Text = "Es wird empfohlen die Gewichtung automatisch berechnen zu lassen.\r\n\r\nFalsche Eing" +
    "aben der Gewichtung können zu unerwarteten Verhalten\r\nder Anwendung führen.\r\n";
            // 
            // imlRegister
            // 
            this.imlRegister.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRegister.ImageStream")));
            this.imlRegister.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRegister.Images.SetKeyName(0, "Settings.png");
            this.imlRegister.Images.SetKeyName(1, "PostcodeSearch.ico");
            this.imlRegister.Images.SetKeyName(2, "Progress.png");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(590, 486);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 486);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // erpDateFormat
            // 
            this.erpDateFormat.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erpDateFormat.ContainerControl = this;
            // 
            // ApplicationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(712, 521);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Anwendungseinstellungen";
            this.tpTabSettings_Common.ResumeLayout(false);
            this.tpTabSettings_Common.PerformLayout();
            this.grbFormating.ResumeLayout(false);
            this.grbFormating.PerformLayout();
            this.grbProjectFolder.ResumeLayout(false);
            this.grbProjectFolder.PerformLayout();
            this.grbRecentFiles.ResumeLayout(false);
            this.grbRecentFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRecentFiles)).EndInit();
            this.grbPostcodeFilter.ResumeLayout(false);
            this.grbPostcodeFilter.PerformLayout();
            this.tpTabSettings_Postcode.ResumeLayout(false);
            this.tpTabSettings_Postcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPostcodeListItemsWarning)).EndInit();
            this.pnlManagePostcode.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tpTabSettings_AppProgress.ResumeLayout(false);
            this.tpTabSettings_AppProgress.PerformLayout();
            this.grbProgressAllowWeightOverride.ResumeLayout(false);
            this.grbProgressAllowWeightOverride.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpDateFormat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpTabSettings_Common;
        private System.Windows.Forms.GroupBox grbProjectFolder;
        internal System.Windows.Forms.Button btnStartupDefaultFileOpen_Delete;
        internal System.Windows.Forms.Button btnDirectoryFileDefaultPath_Delete;
        internal System.Windows.Forms.Button btnStartupDefaultFileOpen_Browse;
        private System.Windows.Forms.TextBox txtStartupDefaultFileOpen;
        private System.Windows.Forms.Label lblStartupDefaultFileOpen;
        internal System.Windows.Forms.Button btnDirectoryFileDefaultPath_Browse;
        private System.Windows.Forms.TextBox txtDirectoryFileDefaultPath;
        private System.Windows.Forms.Label lblDirectoryFileDefaultPath;
        private System.Windows.Forms.GroupBox grbRecentFiles;
        internal System.Windows.Forms.Button btnRecentFilesClear;
        private System.Windows.Forms.NumericUpDown nudNumRecentFiles;
        private System.Windows.Forms.Label lblNumRecentFiles;
        internal System.Windows.Forms.Button btnCheckFileAssociation;
        private System.Windows.Forms.Button btnPostcodeExport;
        private System.Windows.Forms.Button btnPostcodeImport;
        private Toolbox.Widgets.SortListView lsvPostcodes;
        private System.Windows.Forms.ColumnHeader chLsvPostcodes_Postcode;
        private System.Windows.Forms.ColumnHeader chLsvPostcodes_City;
        private System.Windows.Forms.ColumnHeader chLsvPostcodes_State;
        private System.Windows.Forms.ColumnHeader chLsvPostcodes_Nation;
        private System.Windows.Forms.Button btnPostcodeDelete;
        private System.Windows.Forms.Button btnPostcodeAdd;
        private System.Windows.Forms.GroupBox grbPostcodeFilter;
        private System.Windows.Forms.Button btnPostcodeFilter;
        private System.Windows.Forms.Label lblFilterPostcodeNati;
        private System.Windows.Forms.TextBox txtPostcodeFilterNati;
        private System.Windows.Forms.Label lblFilterPostcodeCity;
        private System.Windows.Forms.TextBox txtPostcodeFilterCity;
        private Toolbox.Widgets.ReadOnlyPropertyGrid prgPostcodeData;
        private System.Windows.Forms.TabPage tpTabSettings_Postcode;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imlRegister;
        private Toolbox.Widgets.ExtProgressBar epbListPostcodeProgress;
        private System.Windows.Forms.GroupBox grbFormating;
        private System.Windows.Forms.TextBox txtDateTimeFormat;
        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.TextBox txtDateFormat;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.CheckBox chkFileAssociationCheckOnStartup;
        private System.Windows.Forms.TabPage tpTabSettings_AppProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDateFormatPreview;
        private System.Windows.Forms.Label lblDateTimeFormatPreview;
        private System.Windows.Forms.CheckBox chkProgressAllowWeightOverride;
        private System.Windows.Forms.Label lblAppProgressAllowWeightOverride;
        private System.Windows.Forms.ErrorProvider erpDateFormat;
        private System.Windows.Forms.CheckBox chkAppUpdateCheckAtStartUp;
        private System.Windows.Forms.Button btnSetDefaults;
        private System.Windows.Forms.Button btnPostcodeCancelShow;
        private System.Windows.Forms.Panel pnlManagePostcode;
        private System.Windows.Forms.NumericUpDown nudPostcodeListItemsWarning;
        private System.Windows.Forms.Label lblPostcodeListItemsWarning;
        private System.Windows.Forms.CheckBox chkPostcodeSettAllActive;
        private System.Windows.Forms.GroupBox grbProgressAllowWeightOverride;
        private System.Windows.Forms.CheckBox chkProgressNewSetActualDate;
    }
}