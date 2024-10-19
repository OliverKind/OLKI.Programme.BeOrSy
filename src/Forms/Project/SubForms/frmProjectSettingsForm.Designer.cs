namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ProjectSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettingsForm));
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tpTabSettings_Common = new System.Windows.Forms.TabPage();
            this.chkCheckRemindersOnOpen = new System.Windows.Forms.CheckBox();
            this.grbDirectoryFormat = new System.Windows.Forms.GroupBox();
            this.chkSettingsRenameAutosave = new System.Windows.Forms.CheckBox();
            this.btnDirectorysRename = new System.Windows.Forms.Button();
            this.lblDirectoryPreviewAppl = new System.Windows.Forms.Label();
            this.lblDirectoryPreviewComp = new System.Windows.Forms.Label();
            this.txtDirectoryPreviewAppl = new System.Windows.Forms.TextBox();
            this.txtDirectoryPreviewComp = new System.Windows.Forms.TextBox();
            this.lblDirectoryTitleLength = new System.Windows.Forms.Label();
            this.nudDirectoryTitleLength = new System.Windows.Forms.NumericUpDown();
            this.chkDirectoryTitleBeforeId = new System.Windows.Forms.CheckBox();
            this.chkDirectoryAddTitle = new System.Windows.Forms.CheckBox();
            this.chkInstantSave = new System.Windows.Forms.CheckBox();
            this.grbProjectFolder = new System.Windows.Forms.GroupBox();
            this.btnApplTemplPath_GoTo = new System.Windows.Forms.Button();
            this.btnApplTemplPath_Delete = new System.Windows.Forms.Button();
            this.btnApplTemplPath_Browse = new System.Windows.Forms.Button();
            this.txtApplTemplPath = new System.Windows.Forms.TextBox();
            this.lblApplTemplPath = new System.Windows.Forms.Label();
            this.btnCompTemplPath_GoTo = new System.Windows.Forms.Button();
            this.btnProjectDirPath_GoTo = new System.Windows.Forms.Button();
            this.btnCompTemplPath_Delete = new System.Windows.Forms.Button();
            this.btnProjectDirPath_Delete = new System.Windows.Forms.Button();
            this.btnCompTemplPath_Browse = new System.Windows.Forms.Button();
            this.txtCompTemplPath = new System.Windows.Forms.TextBox();
            this.lblCompTemplPath = new System.Windows.Forms.Label();
            this.btnProjectDirPath_Browse = new System.Windows.Forms.Button();
            this.txtProjectDirPath = new System.Windows.Forms.TextBox();
            this.lblProjectDirPath = new System.Windows.Forms.Label();
            this.tpTabSettings_Progress = new System.Windows.Forms.TabPage();
            this.grbAppProgressTemplate = new System.Windows.Forms.GroupBox();
            this.chkTemplateWeight = new System.Windows.Forms.CheckBox();
            this.lblTemplateWeightActivateOverride = new System.Windows.Forms.LinkLabel();
            this.lblTemplateWeight = new System.Windows.Forms.Label();
            this.nudTemplateWeight = new System.Windows.Forms.NumericUpDown();
            this.btnProgressTemplateDelete = new System.Windows.Forms.Button();
            this.btnProgressTemplateAdd = new System.Windows.Forms.Button();
            this.prgProgressTemplateEditor = new OLKI.Toolbox.Widgets.ReadOnlyPropertyGrid();
            this.lsvProgressTemplates = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvProgressTemplates_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvProgressTemplates_Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlProgress = new System.Windows.Forms.ImageList(this.components);
            this.imlRegister = new System.Windows.Forms.ImageList(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.erpProgressList = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabSettings.SuspendLayout();
            this.tpTabSettings_Common.SuspendLayout();
            this.grbDirectoryFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirectoryTitleLength)).BeginInit();
            this.grbProjectFolder.SuspendLayout();
            this.tpTabSettings_Progress.SuspendLayout();
            this.grbAppProgressTemplate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemplateWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProgressList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tpTabSettings_Common);
            this.tabSettings.Controls.Add(this.tpTabSettings_Progress);
            this.tabSettings.ImageList = this.imlRegister;
            this.tabSettings.Location = new System.Drawing.Point(12, 12);
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(688, 468);
            this.tabSettings.TabIndex = 0;
            // 
            // tpTabSettings_Common
            // 
            this.tpTabSettings_Common.Controls.Add(this.chkCheckRemindersOnOpen);
            this.tpTabSettings_Common.Controls.Add(this.grbDirectoryFormat);
            this.tpTabSettings_Common.Controls.Add(this.chkInstantSave);
            this.tpTabSettings_Common.Controls.Add(this.grbProjectFolder);
            this.tpTabSettings_Common.ImageIndex = 0;
            this.tpTabSettings_Common.Location = new System.Drawing.Point(4, 23);
            this.tpTabSettings_Common.Name = "tpTabSettings_Common";
            this.tpTabSettings_Common.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabSettings_Common.Size = new System.Drawing.Size(680, 441);
            this.tpTabSettings_Common.TabIndex = 0;
            this.tpTabSettings_Common.Text = "Allgemeine Einstellungen";
            this.tpTabSettings_Common.UseVisualStyleBackColor = true;
            // 
            // chkCheckRemindersOnOpen
            // 
            this.chkCheckRemindersOnOpen.AutoSize = true;
            this.chkCheckRemindersOnOpen.Location = new System.Drawing.Point(6, 259);
            this.chkCheckRemindersOnOpen.Name = "chkCheckRemindersOnOpen";
            this.chkCheckRemindersOnOpen.Size = new System.Drawing.Size(234, 17);
            this.chkCheckRemindersOnOpen.TabIndex = 2;
            this.chkCheckRemindersOnOpen.Text = "Auf offene Erinnerungen beim Öffnen prüfen";
            // 
            // grbDirectoryFormat
            // 
            this.grbDirectoryFormat.Controls.Add(this.chkSettingsRenameAutosave);
            this.grbDirectoryFormat.Controls.Add(this.btnDirectorysRename);
            this.grbDirectoryFormat.Controls.Add(this.lblDirectoryPreviewAppl);
            this.grbDirectoryFormat.Controls.Add(this.lblDirectoryPreviewComp);
            this.grbDirectoryFormat.Controls.Add(this.txtDirectoryPreviewAppl);
            this.grbDirectoryFormat.Controls.Add(this.txtDirectoryPreviewComp);
            this.grbDirectoryFormat.Controls.Add(this.lblDirectoryTitleLength);
            this.grbDirectoryFormat.Controls.Add(this.nudDirectoryTitleLength);
            this.grbDirectoryFormat.Controls.Add(this.chkDirectoryTitleBeforeId);
            this.grbDirectoryFormat.Controls.Add(this.chkDirectoryAddTitle);
            this.grbDirectoryFormat.Location = new System.Drawing.Point(6, 106);
            this.grbDirectoryFormat.Name = "grbDirectoryFormat";
            this.grbDirectoryFormat.Size = new System.Drawing.Size(668, 147);
            this.grbDirectoryFormat.TabIndex = 1;
            this.grbDirectoryFormat.TabStop = false;
            this.grbDirectoryFormat.Text = "Format für Firmen- / Bewerbungsordner";
            // 
            // chkSettingsRenameAutosave
            // 
            this.chkSettingsRenameAutosave.AutoSize = true;
            this.chkSettingsRenameAutosave.Location = new System.Drawing.Point(150, 122);
            this.chkSettingsRenameAutosave.Name = "chkSettingsRenameAutosave";
            this.chkSettingsRenameAutosave.Size = new System.Drawing.Size(227, 17);
            this.chkSettingsRenameAutosave.TabIndex = 8;
            this.chkSettingsRenameAutosave.Text = "Einstellungen zuvor automatisch speichern";
            // 
            // btnDirectorysRename
            // 
            this.btnDirectorysRename.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Rename;
            this.btnDirectorysRename.Location = new System.Drawing.Point(383, 118);
            this.btnDirectorysRename.Name = "btnDirectorysRename";
            this.btnDirectorysRename.Size = new System.Drawing.Size(279, 23);
            this.btnDirectorysRename.TabIndex = 9;
            this.btnDirectorysRename.Text = "Vorhandene Ordner umbenennen";
            this.btnDirectorysRename.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDirectorysRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDirectorysRename.UseVisualStyleBackColor = true;
            this.btnDirectorysRename.Click += new System.EventHandler(this.btnDirectorysRename_Click);
            // 
            // lblDirectoryPreviewAppl
            // 
            this.lblDirectoryPreviewAppl.AutoSize = true;
            this.lblDirectoryPreviewAppl.Location = new System.Drawing.Point(6, 95);
            this.lblDirectoryPreviewAppl.Name = "lblDirectoryPreviewAppl";
            this.lblDirectoryPreviewAppl.Size = new System.Drawing.Size(138, 13);
            this.lblDirectoryPreviewAppl.TabIndex = 6;
            this.lblDirectoryPreviewAppl.Text = "Beispiel Bewerbungsordner:";
            // 
            // lblDirectoryPreviewComp
            // 
            this.lblDirectoryPreviewComp.AutoSize = true;
            this.lblDirectoryPreviewComp.Location = new System.Drawing.Point(6, 69);
            this.lblDirectoryPreviewComp.Name = "lblDirectoryPreviewComp";
            this.lblDirectoryPreviewComp.Size = new System.Drawing.Size(110, 13);
            this.lblDirectoryPreviewComp.TabIndex = 4;
            this.lblDirectoryPreviewComp.Text = "Beispiel Firmenordner:";
            // 
            // txtDirectoryPreviewAppl
            // 
            this.txtDirectoryPreviewAppl.Location = new System.Drawing.Point(150, 92);
            this.txtDirectoryPreviewAppl.Name = "txtDirectoryPreviewAppl";
            this.txtDirectoryPreviewAppl.ReadOnly = true;
            this.txtDirectoryPreviewAppl.Size = new System.Drawing.Size(512, 20);
            this.txtDirectoryPreviewAppl.TabIndex = 7;
            // 
            // txtDirectoryPreviewComp
            // 
            this.txtDirectoryPreviewComp.Location = new System.Drawing.Point(150, 66);
            this.txtDirectoryPreviewComp.Name = "txtDirectoryPreviewComp";
            this.txtDirectoryPreviewComp.ReadOnly = true;
            this.txtDirectoryPreviewComp.Size = new System.Drawing.Size(512, 20);
            this.txtDirectoryPreviewComp.TabIndex = 5;
            // 
            // lblDirectoryTitleLength
            // 
            this.lblDirectoryTitleLength.AutoSize = true;
            this.lblDirectoryTitleLength.Location = new System.Drawing.Point(445, 19);
            this.lblDirectoryTitleLength.Name = "lblDirectoryTitleLength";
            this.lblDirectoryTitleLength.Size = new System.Drawing.Size(188, 13);
            this.lblDirectoryTitleLength.TabIndex = 2;
            this.lblDirectoryTitleLength.Text = "Zeichen verwenden (0 für unbegrenzt)";
            // 
            // nudDirectoryTitleLength
            // 
            this.nudDirectoryTitleLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudDirectoryTitleLength.Location = new System.Drawing.Point(399, 17);
            this.nudDirectoryTitleLength.Name = "nudDirectoryTitleLength";
            this.nudDirectoryTitleLength.Size = new System.Drawing.Size(40, 20);
            this.nudDirectoryTitleLength.TabIndex = 1;
            this.nudDirectoryTitleLength.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDirectoryTitleLength.ValueChanged += new System.EventHandler(this.nudDirectoryTitleLength_ValueChanged);
            // 
            // chkDirectoryTitleBeforeId
            // 
            this.chkDirectoryTitleBeforeId.AutoSize = true;
            this.chkDirectoryTitleBeforeId.Location = new System.Drawing.Point(6, 43);
            this.chkDirectoryTitleBeforeId.Name = "chkDirectoryTitleBeforeId";
            this.chkDirectoryTitleBeforeId.Size = new System.Drawing.Size(102, 17);
            this.chkDirectoryTitleBeforeId.TabIndex = 3;
            this.chkDirectoryTitleBeforeId.Text = "Name vor der Id";
            this.chkDirectoryTitleBeforeId.UseVisualStyleBackColor = true;
            this.chkDirectoryTitleBeforeId.CheckedChanged += new System.EventHandler(this.chkDirectoryTitleBeforeId_CheckedChanged);
            // 
            // chkDirectoryAddTitle
            // 
            this.chkDirectoryAddTitle.AutoSize = true;
            this.chkDirectoryAddTitle.Location = new System.Drawing.Point(6, 20);
            this.chkDirectoryAddTitle.Name = "chkDirectoryAddTitle";
            this.chkDirectoryAddTitle.Size = new System.Drawing.Size(386, 17);
            this.chkDirectoryAddTitle.TabIndex = 0;
            this.chkDirectoryAddTitle.Text = "Name der Firma oder Bewerbung an Id der Firma oder Bewerbung anhängen";
            this.chkDirectoryAddTitle.UseVisualStyleBackColor = true;
            this.chkDirectoryAddTitle.CheckedChanged += new System.EventHandler(this.chkDirectoryAddTitle_CheckedChanged);
            // 
            // chkInstantSave
            // 
            this.chkInstantSave.AutoSize = true;
            this.chkInstantSave.Location = new System.Drawing.Point(6, 282);
            this.chkInstantSave.Name = "chkInstantSave";
            this.chkInstantSave.Size = new System.Drawing.Size(215, 17);
            this.chkInstantSave.TabIndex = 3;
            this.chkInstantSave.Text = "Änderungen am Projekt sofort speichern";
            // 
            // grbProjectFolder
            // 
            this.grbProjectFolder.Controls.Add(this.btnApplTemplPath_GoTo);
            this.grbProjectFolder.Controls.Add(this.btnApplTemplPath_Delete);
            this.grbProjectFolder.Controls.Add(this.btnApplTemplPath_Browse);
            this.grbProjectFolder.Controls.Add(this.txtApplTemplPath);
            this.grbProjectFolder.Controls.Add(this.lblApplTemplPath);
            this.grbProjectFolder.Controls.Add(this.btnCompTemplPath_GoTo);
            this.grbProjectFolder.Controls.Add(this.btnProjectDirPath_GoTo);
            this.grbProjectFolder.Controls.Add(this.btnCompTemplPath_Delete);
            this.grbProjectFolder.Controls.Add(this.btnProjectDirPath_Delete);
            this.grbProjectFolder.Controls.Add(this.btnCompTemplPath_Browse);
            this.grbProjectFolder.Controls.Add(this.txtCompTemplPath);
            this.grbProjectFolder.Controls.Add(this.lblCompTemplPath);
            this.grbProjectFolder.Controls.Add(this.btnProjectDirPath_Browse);
            this.grbProjectFolder.Controls.Add(this.txtProjectDirPath);
            this.grbProjectFolder.Controls.Add(this.lblProjectDirPath);
            this.grbProjectFolder.Location = new System.Drawing.Point(6, 3);
            this.grbProjectFolder.Name = "grbProjectFolder";
            this.grbProjectFolder.Size = new System.Drawing.Size(668, 97);
            this.grbProjectFolder.TabIndex = 0;
            this.grbProjectFolder.TabStop = false;
            this.grbProjectFolder.Text = "Standardordner und -dateien";
            // 
            // btnApplTemplPath_GoTo
            // 
            this.btnApplTemplPath_GoTo.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.btnApplTemplPath_GoTo.Location = new System.Drawing.Point(545, 68);
            this.btnApplTemplPath_GoTo.Name = "btnApplTemplPath_GoTo";
            this.btnApplTemplPath_GoTo.Size = new System.Drawing.Size(35, 24);
            this.btnApplTemplPath_GoTo.TabIndex = 12;
            this.btnApplTemplPath_GoTo.UseVisualStyleBackColor = true;
            this.btnApplTemplPath_GoTo.Click += new System.EventHandler(this.btnApplTemplPath_GoTo_Click);
            // 
            // btnApplTemplPath_Delete
            // 
            this.btnApplTemplPath_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnApplTemplPath_Delete.Image")));
            this.btnApplTemplPath_Delete.Location = new System.Drawing.Point(627, 68);
            this.btnApplTemplPath_Delete.Name = "btnApplTemplPath_Delete";
            this.btnApplTemplPath_Delete.Size = new System.Drawing.Size(35, 24);
            this.btnApplTemplPath_Delete.TabIndex = 14;
            this.btnApplTemplPath_Delete.UseVisualStyleBackColor = true;
            this.btnApplTemplPath_Delete.Click += new System.EventHandler(this.btnApplTemplPath_Delete_Click);
            // 
            // btnApplTemplPath_Browse
            // 
            this.btnApplTemplPath_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btnApplTemplPath_Browse.Image")));
            this.btnApplTemplPath_Browse.Location = new System.Drawing.Point(586, 68);
            this.btnApplTemplPath_Browse.Name = "btnApplTemplPath_Browse";
            this.btnApplTemplPath_Browse.Size = new System.Drawing.Size(35, 24);
            this.btnApplTemplPath_Browse.TabIndex = 13;
            this.btnApplTemplPath_Browse.UseVisualStyleBackColor = true;
            this.btnApplTemplPath_Browse.Click += new System.EventHandler(this.btnApplTemplPath_Browse_Click);
            // 
            // txtApplTemplPath
            // 
            this.txtApplTemplPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApplTemplPath.Location = new System.Drawing.Point(219, 71);
            this.txtApplTemplPath.Name = "txtApplTemplPath";
            this.txtApplTemplPath.Size = new System.Drawing.Size(320, 20);
            this.txtApplTemplPath.TabIndex = 11;
            // 
            // lblApplTemplPath
            // 
            this.lblApplTemplPath.AutoSize = true;
            this.lblApplTemplPath.Location = new System.Drawing.Point(6, 74);
            this.lblApplTemplPath.Name = "lblApplTemplPath";
            this.lblApplTemplPath.Size = new System.Drawing.Size(166, 13);
            this.lblApplTemplPath.TabIndex = 10;
            this.lblApplTemplPath.Text = "Vorlagenordner für Bewerbungen:";
            // 
            // btnCompTemplPath_GoTo
            // 
            this.btnCompTemplPath_GoTo.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.btnCompTemplPath_GoTo.Location = new System.Drawing.Point(545, 42);
            this.btnCompTemplPath_GoTo.Name = "btnCompTemplPath_GoTo";
            this.btnCompTemplPath_GoTo.Size = new System.Drawing.Size(35, 24);
            this.btnCompTemplPath_GoTo.TabIndex = 7;
            this.btnCompTemplPath_GoTo.UseVisualStyleBackColor = true;
            this.btnCompTemplPath_GoTo.Click += new System.EventHandler(this.btnCompTemplPath_GoTo_Click);
            // 
            // btnProjectDirPath_GoTo
            // 
            this.btnProjectDirPath_GoTo.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.btnProjectDirPath_GoTo.Location = new System.Drawing.Point(545, 15);
            this.btnProjectDirPath_GoTo.Name = "btnProjectDirPath_GoTo";
            this.btnProjectDirPath_GoTo.Size = new System.Drawing.Size(35, 24);
            this.btnProjectDirPath_GoTo.TabIndex = 2;
            this.btnProjectDirPath_GoTo.UseVisualStyleBackColor = true;
            this.btnProjectDirPath_GoTo.Click += new System.EventHandler(this.btnProjectDirPath_GoTo_Click);
            // 
            // btnCompTemplPath_Delete
            // 
            this.btnCompTemplPath_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnCompTemplPath_Delete.Image")));
            this.btnCompTemplPath_Delete.Location = new System.Drawing.Point(627, 42);
            this.btnCompTemplPath_Delete.Name = "btnCompTemplPath_Delete";
            this.btnCompTemplPath_Delete.Size = new System.Drawing.Size(35, 24);
            this.btnCompTemplPath_Delete.TabIndex = 9;
            this.btnCompTemplPath_Delete.UseVisualStyleBackColor = true;
            this.btnCompTemplPath_Delete.Click += new System.EventHandler(this.btnCompTemplPath_Delete_Click);
            // 
            // btnProjectDirPath_Delete
            // 
            this.btnProjectDirPath_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectDirPath_Delete.Image")));
            this.btnProjectDirPath_Delete.Location = new System.Drawing.Point(627, 15);
            this.btnProjectDirPath_Delete.Name = "btnProjectDirPath_Delete";
            this.btnProjectDirPath_Delete.Size = new System.Drawing.Size(35, 24);
            this.btnProjectDirPath_Delete.TabIndex = 4;
            this.btnProjectDirPath_Delete.UseVisualStyleBackColor = true;
            this.btnProjectDirPath_Delete.Click += new System.EventHandler(this.btnProjectDirPath_Delete_Click);
            // 
            // btnCompTemplPath_Browse
            // 
            this.btnCompTemplPath_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btnCompTemplPath_Browse.Image")));
            this.btnCompTemplPath_Browse.Location = new System.Drawing.Point(586, 42);
            this.btnCompTemplPath_Browse.Name = "btnCompTemplPath_Browse";
            this.btnCompTemplPath_Browse.Size = new System.Drawing.Size(35, 24);
            this.btnCompTemplPath_Browse.TabIndex = 8;
            this.btnCompTemplPath_Browse.UseVisualStyleBackColor = true;
            this.btnCompTemplPath_Browse.Click += new System.EventHandler(this.btnCompTemplPath_Browse_Click);
            // 
            // txtCompTemplPath
            // 
            this.txtCompTemplPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCompTemplPath.Location = new System.Drawing.Point(219, 45);
            this.txtCompTemplPath.Name = "txtCompTemplPath";
            this.txtCompTemplPath.Size = new System.Drawing.Size(320, 20);
            this.txtCompTemplPath.TabIndex = 6;
            // 
            // lblCompTemplPath
            // 
            this.lblCompTemplPath.AutoSize = true;
            this.lblCompTemplPath.Location = new System.Drawing.Point(6, 48);
            this.lblCompTemplPath.Name = "lblCompTemplPath";
            this.lblCompTemplPath.Size = new System.Drawing.Size(131, 13);
            this.lblCompTemplPath.TabIndex = 5;
            this.lblCompTemplPath.Text = "Vorlagenordner für Firmen:";
            // 
            // btnProjectDirPath_Browse
            // 
            this.btnProjectDirPath_Browse.Image = ((System.Drawing.Image)(resources.GetObject("btnProjectDirPath_Browse.Image")));
            this.btnProjectDirPath_Browse.Location = new System.Drawing.Point(586, 15);
            this.btnProjectDirPath_Browse.Name = "btnProjectDirPath_Browse";
            this.btnProjectDirPath_Browse.Size = new System.Drawing.Size(35, 24);
            this.btnProjectDirPath_Browse.TabIndex = 3;
            this.btnProjectDirPath_Browse.UseVisualStyleBackColor = true;
            this.btnProjectDirPath_Browse.Click += new System.EventHandler(this.btnProjectDirPath_Browse_Click);
            // 
            // txtProjectDirPath
            // 
            this.txtProjectDirPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtProjectDirPath.Location = new System.Drawing.Point(219, 19);
            this.txtProjectDirPath.Name = "txtProjectDirPath";
            this.txtProjectDirPath.Size = new System.Drawing.Size(320, 20);
            this.txtProjectDirPath.TabIndex = 1;
            // 
            // lblProjectDirPath
            // 
            this.lblProjectDirPath.AutoSize = true;
            this.lblProjectDirPath.Location = new System.Drawing.Point(6, 22);
            this.lblProjectDirPath.Name = "lblProjectDirPath";
            this.lblProjectDirPath.Size = new System.Drawing.Size(207, 13);
            this.lblProjectDirPath.TabIndex = 0;
            this.lblProjectDirPath.Text = "Ordner für Firmen- und Bewerbungsordner:";
            // 
            // tpTabSettings_Progress
            // 
            this.tpTabSettings_Progress.Controls.Add(this.grbAppProgressTemplate);
            this.tpTabSettings_Progress.ImageIndex = 1;
            this.tpTabSettings_Progress.Location = new System.Drawing.Point(4, 23);
            this.tpTabSettings_Progress.Name = "tpTabSettings_Progress";
            this.tpTabSettings_Progress.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabSettings_Progress.Size = new System.Drawing.Size(680, 441);
            this.tpTabSettings_Progress.TabIndex = 2;
            this.tpTabSettings_Progress.Text = "Bewerbungsfortschritt Vorlagen";
            this.tpTabSettings_Progress.UseVisualStyleBackColor = true;
            // 
            // grbAppProgressTemplate
            // 
            this.grbAppProgressTemplate.Controls.Add(this.chkTemplateWeight);
            this.grbAppProgressTemplate.Controls.Add(this.lblTemplateWeightActivateOverride);
            this.grbAppProgressTemplate.Controls.Add(this.lblTemplateWeight);
            this.grbAppProgressTemplate.Controls.Add(this.nudTemplateWeight);
            this.grbAppProgressTemplate.Controls.Add(this.btnProgressTemplateDelete);
            this.grbAppProgressTemplate.Controls.Add(this.btnProgressTemplateAdd);
            this.grbAppProgressTemplate.Controls.Add(this.prgProgressTemplateEditor);
            this.grbAppProgressTemplate.Controls.Add(this.lsvProgressTemplates);
            this.grbAppProgressTemplate.Location = new System.Drawing.Point(6, 3);
            this.grbAppProgressTemplate.Name = "grbAppProgressTemplate";
            this.grbAppProgressTemplate.Size = new System.Drawing.Size(668, 433);
            this.grbAppProgressTemplate.TabIndex = 0;
            this.grbAppProgressTemplate.TabStop = false;
            this.grbAppProgressTemplate.Text = "Vorlagen";
            // 
            // chkTemplateWeight
            // 
            this.chkTemplateWeight.AutoSize = true;
            this.chkTemplateWeight.Location = new System.Drawing.Point(496, 396);
            this.chkTemplateWeight.Name = "chkTemplateWeight";
            this.chkTemplateWeight.Size = new System.Drawing.Size(77, 17);
            this.chkTemplateWeight.TabIndex = 6;
            this.chkTemplateWeight.Text = "Bearbeiten";
            this.chkTemplateWeight.UseVisualStyleBackColor = true;
            this.chkTemplateWeight.CheckedChanged += new System.EventHandler(this.chkTemplateWeight_CheckedChanged);
            // 
            // lblTemplateWeightActivateOverride
            // 
            this.lblTemplateWeightActivateOverride.AutoSize = true;
            this.lblTemplateWeightActivateOverride.Location = new System.Drawing.Point(359, 417);
            this.lblTemplateWeightActivateOverride.Name = "lblTemplateWeightActivateOverride";
            this.lblTemplateWeightActivateOverride.Size = new System.Drawing.Size(303, 13);
            this.lblTemplateWeightActivateOverride.TabIndex = 7;
            this.lblTemplateWeightActivateOverride.TabStop = true;
            this.lblTemplateWeightActivateOverride.Text = "Bearbeiten der Gewichtung in den Einstellungen de-/aktivieren";
            this.lblTemplateWeightActivateOverride.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWeightActivateOverride_LinkClicked);
            // 
            // lblTemplateWeight
            // 
            this.lblTemplateWeight.AutoSize = true;
            this.lblTemplateWeight.Location = new System.Drawing.Point(362, 396);
            this.lblTemplateWeight.Name = "lblTemplateWeight";
            this.lblTemplateWeight.Size = new System.Drawing.Size(67, 13);
            this.lblTemplateWeight.TabIndex = 4;
            this.lblTemplateWeight.Text = "Gewichtung:";
            // 
            // nudTemplateWeight
            // 
            this.nudTemplateWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudTemplateWeight.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTemplateWeight.Location = new System.Drawing.Point(435, 394);
            this.nudTemplateWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTemplateWeight.Name = "nudTemplateWeight";
            this.nudTemplateWeight.Size = new System.Drawing.Size(55, 20);
            this.nudTemplateWeight.TabIndex = 5;
            this.nudTemplateWeight.ThousandsSeparator = true;
            this.nudTemplateWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTemplateWeight.ValueChanged += new System.EventHandler(this.nudTemplateWeight_ValueChanged);
            // 
            // btnProgressTemplateDelete
            // 
            this.btnProgressTemplateDelete.Enabled = false;
            this.btnProgressTemplateDelete.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Delete;
            this.btnProgressTemplateDelete.Location = new System.Drawing.Point(256, 19);
            this.btnProgressTemplateDelete.Name = "btnProgressTemplateDelete";
            this.btnProgressTemplateDelete.Size = new System.Drawing.Size(100, 24);
            this.btnProgressTemplateDelete.TabIndex = 1;
            this.btnProgressTemplateDelete.Text = "Löschen";
            this.btnProgressTemplateDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProgressTemplateDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgressTemplateDelete.UseVisualStyleBackColor = true;
            this.btnProgressTemplateDelete.Click += new System.EventHandler(this.btnProgressTemplateDelete_Click);
            // 
            // btnProgressTemplateAdd
            // 
            this.btnProgressTemplateAdd.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.New;
            this.btnProgressTemplateAdd.Location = new System.Drawing.Point(6, 19);
            this.btnProgressTemplateAdd.Name = "btnProgressTemplateAdd";
            this.btnProgressTemplateAdd.Size = new System.Drawing.Size(100, 24);
            this.btnProgressTemplateAdd.TabIndex = 0;
            this.btnProgressTemplateAdd.Text = "Hinzufügen";
            this.btnProgressTemplateAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProgressTemplateAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProgressTemplateAdd.UseVisualStyleBackColor = true;
            this.btnProgressTemplateAdd.Click += new System.EventHandler(this.btnProgressTemplateAdd_Click);
            // 
            // prgProgressTemplateEditor
            // 
            this.prgProgressTemplateEditor.LineColor = System.Drawing.SystemColors.ControlDark;
            this.prgProgressTemplateEditor.Location = new System.Drawing.Point(362, 19);
            this.prgProgressTemplateEditor.Name = "prgProgressTemplateEditor";
            this.prgProgressTemplateEditor.Size = new System.Drawing.Size(300, 369);
            this.prgProgressTemplateEditor.TabIndex = 3;
            this.prgProgressTemplateEditor.ViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // lsvProgressTemplates
            // 
            this.lsvProgressTemplates.AllowDragAndDropSort = true;
            this.lsvProgressTemplates.AllowDrop = true;
            this.lsvProgressTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvProgressTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvProgressTemplates_Title,
            this.chLsvProgressTemplates_Weight});
            this.lsvProgressTemplates.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvProgressTemplates.ColumnWidths")));
            this.lsvProgressTemplates.FullRowSelect = true;
            this.lsvProgressTemplates.GridLines = true;
            this.lsvProgressTemplates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvProgressTemplates.HideSelection = false;
            this.lsvProgressTemplates.Location = new System.Drawing.Point(6, 46);
            this.lsvProgressTemplates.Name = "lsvProgressTemplates";
            this.lsvProgressTemplates.Size = new System.Drawing.Size(350, 386);
            this.lsvProgressTemplates.SmallImageList = this.imlProgress;
            this.lsvProgressTemplates.TabIndex = 2;
            this.lsvProgressTemplates.UseCompatibleStateImageBehavior = false;
            this.lsvProgressTemplates.View = System.Windows.Forms.View.Details;
            this.lsvProgressTemplates.SelectedIndexChanged += new System.EventHandler(this.lsvProgressTemplates_SelectedIndexChanged);
            this.lsvProgressTemplates.DragDrop += new System.Windows.Forms.DragEventHandler(this.lsvProgressTemplates_DragDrop);
            // 
            // chLsvProgressTemplates_Title
            // 
            this.chLsvProgressTemplates_Title.Text = "Benennung";
            this.chLsvProgressTemplates_Title.Width = 230;
            // 
            // chLsvProgressTemplates_Weight
            // 
            this.chLsvProgressTemplates_Weight.Text = "Gewichtung";
            this.chLsvProgressTemplates_Weight.Width = 90;
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
            // imlRegister
            // 
            this.imlRegister.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRegister.ImageStream")));
            this.imlRegister.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRegister.Images.SetKeyName(0, "Settings.png");
            this.imlRegister.Images.SetKeyName(1, "Progress.png");
            this.imlRegister.Images.SetKeyName(2, "Application.png");
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
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            // 
            // erpProgressList
            // 
            this.erpProgressList.ContainerControl = this;
            // 
            // ProjectSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(712, 521);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tabSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectSettingsForm";
            this.Text = "Projekteinstellungen";
            this.tabSettings.ResumeLayout(false);
            this.tpTabSettings_Common.ResumeLayout(false);
            this.tpTabSettings_Common.PerformLayout();
            this.grbDirectoryFormat.ResumeLayout(false);
            this.grbDirectoryFormat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDirectoryTitleLength)).EndInit();
            this.grbProjectFolder.ResumeLayout(false);
            this.grbProjectFolder.PerformLayout();
            this.tpTabSettings_Progress.ResumeLayout(false);
            this.grbAppProgressTemplate.ResumeLayout(false);
            this.grbAppProgressTemplate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTemplateWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpProgressList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tpTabSettings_Common;
        private System.Windows.Forms.GroupBox grbProjectFolder;
        internal System.Windows.Forms.Button btnCompTemplPath_Delete;
        internal System.Windows.Forms.Button btnProjectDirPath_Delete;
        internal System.Windows.Forms.Button btnCompTemplPath_Browse;
        private System.Windows.Forms.TextBox txtCompTemplPath;
        private System.Windows.Forms.Label lblCompTemplPath;
        internal System.Windows.Forms.Button btnProjectDirPath_Browse;
        private System.Windows.Forms.TextBox txtProjectDirPath;
        private System.Windows.Forms.Label lblProjectDirPath;
        private System.Windows.Forms.TabPage tpTabSettings_Progress;
        private System.Windows.Forms.GroupBox grbAppProgressTemplate;
        private System.Windows.Forms.Label lblTemplateWeight;
        private System.Windows.Forms.NumericUpDown nudTemplateWeight;
        private System.Windows.Forms.Button btnProgressTemplateDelete;
        private System.Windows.Forms.Button btnProgressTemplateAdd;
        private Toolbox.Widgets.ReadOnlyPropertyGrid prgProgressTemplateEditor;
        private Toolbox.Widgets.SortListView lsvProgressTemplates;
        private System.Windows.Forms.ColumnHeader chLsvProgressTemplates_Title;
        private System.Windows.Forms.ColumnHeader chLsvProgressTemplates_Weight;
        private System.Windows.Forms.LinkLabel lblTemplateWeightActivateOverride;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imlRegister;
        internal System.Windows.Forms.Button btnApplTemplPath_GoTo;
        internal System.Windows.Forms.Button btnApplTemplPath_Delete;
        internal System.Windows.Forms.Button btnApplTemplPath_Browse;
        private System.Windows.Forms.TextBox txtApplTemplPath;
        private System.Windows.Forms.Label lblApplTemplPath;
        internal System.Windows.Forms.Button btnCompTemplPath_GoTo;
        internal System.Windows.Forms.Button btnProjectDirPath_GoTo;
        private System.Windows.Forms.CheckBox chkInstantSave;
        private System.Windows.Forms.GroupBox grbDirectoryFormat;
        private System.Windows.Forms.CheckBox chkDirectoryAddTitle;
        private System.Windows.Forms.CheckBox chkDirectoryTitleBeforeId;
        private System.Windows.Forms.Label lblDirectoryTitleLength;
        private System.Windows.Forms.NumericUpDown nudDirectoryTitleLength;
        private System.Windows.Forms.Label lblDirectoryPreviewAppl;
        private System.Windows.Forms.Label lblDirectoryPreviewComp;
        private System.Windows.Forms.TextBox txtDirectoryPreviewAppl;
        private System.Windows.Forms.TextBox txtDirectoryPreviewComp;
        private System.Windows.Forms.CheckBox chkTemplateWeight;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ImageList imlProgress;
        private System.Windows.Forms.ErrorProvider erpProgressList;
        private System.Windows.Forms.Button btnDirectorysRename;
        private System.Windows.Forms.CheckBox chkCheckRemindersOnOpen;
        private System.Windows.Forms.CheckBox chkSettingsRenameAutosave;
    }
}