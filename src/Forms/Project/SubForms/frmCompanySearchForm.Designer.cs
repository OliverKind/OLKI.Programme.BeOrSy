namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class CompanySearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySearchForm));
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.nudContactId = new System.Windows.Forms.NumericUpDown();
            this.lblContactId = new System.Windows.Forms.Label();
            this.txtContactText = new System.Windows.Forms.TextBox();
            this.lblContactText = new System.Windows.Forms.Label();
            this.txtContactDiverse = new System.Windows.Forms.TextBox();
            this.lblContactDiverse = new System.Windows.Forms.Label();
            this.cboAdressCountry = new System.Windows.Forms.ComboBox();
            this.cboAdressState = new System.Windows.Forms.ComboBox();
            this.chLsvColorMarker_Marker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboAdressCity = new System.Windows.Forms.ComboBox();
            this.lblAdressCountry = new System.Windows.Forms.Label();
            this.lblAdressState = new System.Windows.Forms.Label();
            this.lblAdressCity = new System.Windows.Forms.Label();
            this.txtAdressPostcode = new System.Windows.Forms.TextBox();
            this.lblAdressPostcode = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.chkAppProgressMode = new System.Windows.Forms.CheckBox();
            this.lblAppStateTo = new System.Windows.Forms.Label();
            this.lsvColorMarker = new System.Windows.Forms.ListView();
            this.imlColorMarkers = new System.Windows.Forms.ImageList(this.components);
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblAdressStreet = new System.Windows.Forms.Label();
            this.chkCloseAfterSucessSearch = new System.Windows.Forms.CheckBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.grbAdress = new System.Windows.Forms.GroupBox();
            this.cboTrade = new System.Windows.Forms.ComboBox();
            this.lblTrade = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.chkTerminated = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.uscProgressStateTo = new OLKI.Programme.BeOrSy.src.Forms.Project.QuickFilterCompanyAppProgress();
            this.uscAppProgressFrom = new OLKI.Programme.BeOrSy.src.Forms.Project.QuickFilterCompanyAppProgress();
            this.grbApplication = new System.Windows.Forms.GroupBox();
            this.nudApplicationtId = new System.Windows.Forms.NumericUpDown();
            this.lblApplicationtId = new System.Windows.Forms.Label();
            this.txtApplicationText = new System.Windows.Forms.TextBox();
            this.lblApplicationText = new System.Windows.Forms.Label();
            this.grbContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.grbAdress.SuspendLayout();
            this.grbApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplicationtId)).BeginInit();
            this.SuspendLayout();
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.nudContactId);
            this.grbContact.Controls.Add(this.lblContactId);
            this.grbContact.Controls.Add(this.txtContactText);
            this.grbContact.Controls.Add(this.lblContactText);
            this.grbContact.Controls.Add(this.txtContactDiverse);
            this.grbContact.Controls.Add(this.lblContactDiverse);
            this.grbContact.Location = new System.Drawing.Point(12, 327);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(429, 71);
            this.grbContact.TabIndex = 15;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Kontakt";
            // 
            // nudContactId
            // 
            this.nudContactId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudContactId.Location = new System.Drawing.Point(352, 20);
            this.nudContactId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudContactId.Name = "nudContactId";
            this.nudContactId.Size = new System.Drawing.Size(71, 20);
            this.nudContactId.TabIndex = 3;
            this.nudContactId.ThousandsSeparator = true;
            // 
            // lblContactId
            // 
            this.lblContactId.AutoSize = true;
            this.lblContactId.Location = new System.Drawing.Point(328, 23);
            this.lblContactId.Name = "lblContactId";
            this.lblContactId.Size = new System.Drawing.Size(18, 13);
            this.lblContactId.TabIndex = 2;
            this.lblContactId.Text = "id:";
            // 
            // txtContactText
            // 
            this.txtContactText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactText.Location = new System.Drawing.Point(114, 19);
            this.txtContactText.Name = "txtContactText";
            this.txtContactText.Size = new System.Drawing.Size(208, 20);
            this.txtContactText.TabIndex = 1;
            // 
            // lblContactText
            // 
            this.lblContactText.AutoSize = true;
            this.lblContactText.Location = new System.Drawing.Point(6, 22);
            this.lblContactText.Name = "lblContactText";
            this.lblContactText.Size = new System.Drawing.Size(102, 13);
            this.lblContactText.TabIndex = 0;
            this.lblContactText.Text = "Name / Kommentar:";
            // 
            // txtContactDiverse
            // 
            this.txtContactDiverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactDiverse.Location = new System.Drawing.Point(114, 45);
            this.txtContactDiverse.Name = "txtContactDiverse";
            this.txtContactDiverse.Size = new System.Drawing.Size(309, 20);
            this.txtContactDiverse.TabIndex = 5;
            // 
            // lblContactDiverse
            // 
            this.lblContactDiverse.AutoSize = true;
            this.lblContactDiverse.Location = new System.Drawing.Point(6, 48);
            this.lblContactDiverse.Name = "lblContactDiverse";
            this.lblContactDiverse.Size = new System.Drawing.Size(95, 13);
            this.lblContactDiverse.TabIndex = 4;
            this.lblContactDiverse.Text = "Nummern / E-Mail:";
            // 
            // cboAdressCountry
            // 
            this.cboAdressCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressCountry.Location = new System.Drawing.Point(78, 125);
            this.cboAdressCountry.Name = "cboAdressCountry";
            this.cboAdressCountry.Size = new System.Drawing.Size(345, 21);
            this.cboAdressCountry.TabIndex = 9;
            // 
            // cboAdressState
            // 
            this.cboAdressState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressState.Location = new System.Drawing.Point(78, 98);
            this.cboAdressState.Name = "cboAdressState";
            this.cboAdressState.Size = new System.Drawing.Size(345, 21);
            this.cboAdressState.TabIndex = 7;
            // 
            // chLsvColorMarker_Marker
            // 
            this.chLsvColorMarker_Marker.Text = "Markierung";
            this.chLsvColorMarker_Marker.Width = 90;
            // 
            // btnFilter
            // 
            this.btnFilter.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Filter2;
            this.btnFilter.Location = new System.Drawing.Point(12, 427);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(530, 23);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "Filtern";
            this.btnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(392, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Schließen";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboAdressCity
            // 
            this.cboAdressCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressCity.Location = new System.Drawing.Point(78, 71);
            this.cboAdressCity.Name = "cboAdressCity";
            this.cboAdressCity.Size = new System.Drawing.Size(345, 21);
            this.cboAdressCity.TabIndex = 5;
            // 
            // lblAdressCountry
            // 
            this.lblAdressCountry.AutoSize = true;
            this.lblAdressCountry.Location = new System.Drawing.Point(6, 128);
            this.lblAdressCountry.Name = "lblAdressCountry";
            this.lblAdressCountry.Size = new System.Drawing.Size(34, 13);
            this.lblAdressCountry.TabIndex = 8;
            this.lblAdressCountry.Text = "Land:";
            // 
            // lblAdressState
            // 
            this.lblAdressState.AutoSize = true;
            this.lblAdressState.Location = new System.Drawing.Point(6, 101);
            this.lblAdressState.Name = "lblAdressState";
            this.lblAdressState.Size = new System.Drawing.Size(66, 13);
            this.lblAdressState.TabIndex = 6;
            this.lblAdressState.Text = "Bundesland:";
            // 
            // lblAdressCity
            // 
            this.lblAdressCity.AutoSize = true;
            this.lblAdressCity.Location = new System.Drawing.Point(6, 74);
            this.lblAdressCity.Name = "lblAdressCity";
            this.lblAdressCity.Size = new System.Drawing.Size(32, 13);
            this.lblAdressCity.TabIndex = 4;
            this.lblAdressCity.Text = "Statt:";
            // 
            // txtAdressPostcode
            // 
            this.txtAdressPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdressPostcode.Location = new System.Drawing.Point(78, 45);
            this.txtAdressPostcode.Name = "txtAdressPostcode";
            this.txtAdressPostcode.Size = new System.Drawing.Size(345, 20);
            this.txtAdressPostcode.TabIndex = 3;
            // 
            // lblAdressPostcode
            // 
            this.lblAdressPostcode.AutoSize = true;
            this.lblAdressPostcode.Location = new System.Drawing.Point(6, 48);
            this.lblAdressPostcode.Name = "lblAdressPostcode";
            this.lblAdressPostcode.Size = new System.Drawing.Size(63, 13);
            this.lblAdressPostcode.TabIndex = 2;
            this.lblAdressPostcode.Text = "Postleitzahl:";
            // 
            // nudId
            // 
            this.nudId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudId.Location = new System.Drawing.Point(471, 12);
            this.nudId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(71, 20);
            this.nudId.TabIndex = 3;
            this.nudId.ThousandsSeparator = true;
            // 
            // chkAppProgressMode
            // 
            this.chkAppProgressMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAppProgressMode.Checked = true;
            this.chkAppProgressMode.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkAppProgressMode.Location = new System.Drawing.Point(12, 93);
            this.chkAppProgressMode.Name = "chkAppProgressMode";
            this.chkAppProgressMode.Size = new System.Drawing.Size(84, 17);
            this.chkAppProgressMode.TabIndex = 9;
            this.chkAppProgressMode.Text = "Fortschritt:";
            this.chkAppProgressMode.ThreeState = true;
            this.chkAppProgressMode.UseVisualStyleBackColor = true;
            this.chkAppProgressMode.CheckStateChanged += new System.EventHandler(this.chkAppProgressMode_CheckStateChanged);
            // 
            // lblAppStateTo
            // 
            this.lblAppStateTo.AutoSize = true;
            this.lblAppStateTo.Location = new System.Drawing.Point(313, 94);
            this.lblAppStateTo.Name = "lblAppStateTo";
            this.lblAppStateTo.Size = new System.Drawing.Size(23, 13);
            this.lblAppStateTo.TabIndex = 11;
            this.lblAppStateTo.Text = "bis:";
            // 
            // lsvColorMarker
            // 
            this.lsvColorMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvColorMarker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvColorMarker_Marker});
            this.lsvColorMarker.FullRowSelect = true;
            this.lsvColorMarker.GridLines = true;
            this.lsvColorMarker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvColorMarker.HideSelection = false;
            this.lsvColorMarker.Location = new System.Drawing.Point(447, 118);
            this.lsvColorMarker.MultiSelect = false;
            this.lsvColorMarker.Name = "lsvColorMarker";
            this.lsvColorMarker.Scrollable = false;
            this.lsvColorMarker.Size = new System.Drawing.Size(95, 274);
            this.lsvColorMarker.SmallImageList = this.imlColorMarkers;
            this.lsvColorMarker.TabIndex = 13;
            this.lsvColorMarker.UseCompatibleStateImageBehavior = false;
            this.lsvColorMarker.View = System.Windows.Forms.View.Details;
            // 
            // imlColorMarkers
            // 
            this.imlColorMarkers.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlColorMarkers.ImageStream")));
            this.imlColorMarkers.TransparentColor = System.Drawing.Color.Transparent;
            this.imlColorMarkers.Images.SetKeyName(0, "00 - (Keine).png");
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
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdressStreet.Location = new System.Drawing.Point(78, 19);
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.Size = new System.Drawing.Size(345, 20);
            this.txtAdressStreet.TabIndex = 1;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 68);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(63, 13);
            this.lblComment.TabIndex = 7;
            this.lblComment.Text = "Kommentar:";
            // 
            // lblAdressStreet
            // 
            this.lblAdressStreet.AutoSize = true;
            this.lblAdressStreet.Location = new System.Drawing.Point(6, 22);
            this.lblAdressStreet.Name = "lblAdressStreet";
            this.lblAdressStreet.Size = new System.Drawing.Size(48, 13);
            this.lblAdressStreet.TabIndex = 0;
            this.lblAdressStreet.Text = "Adresse:";
            // 
            // chkCloseAfterSucessSearch
            // 
            this.chkCloseAfterSucessSearch.AutoSize = true;
            this.chkCloseAfterSucessSearch.Location = new System.Drawing.Point(12, 404);
            this.chkCloseAfterSucessSearch.Name = "chkCloseAfterSucessSearch";
            this.chkCloseAfterSucessSearch.Size = new System.Drawing.Size(290, 17);
            this.chkCloseAfterSucessSearch.TabIndex = 16;
            this.chkCloseAfterSucessSearch.Text = "Bei erfolgreicher Suche, Formular automatisch schließen";
            this.chkCloseAfterSucessSearch.UseVisualStyleBackColor = true;
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(81, 65);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(461, 20);
            this.txtComment.TabIndex = 8;
            // 
            // grbAdress
            // 
            this.grbAdress.Controls.Add(this.cboAdressCountry);
            this.grbAdress.Controls.Add(this.cboAdressState);
            this.grbAdress.Controls.Add(this.cboAdressCity);
            this.grbAdress.Controls.Add(this.lblAdressCountry);
            this.grbAdress.Controls.Add(this.lblAdressState);
            this.grbAdress.Controls.Add(this.lblAdressCity);
            this.grbAdress.Controls.Add(this.txtAdressPostcode);
            this.grbAdress.Controls.Add(this.lblAdressPostcode);
            this.grbAdress.Controls.Add(this.txtAdressStreet);
            this.grbAdress.Controls.Add(this.lblAdressStreet);
            this.grbAdress.Location = new System.Drawing.Point(12, 118);
            this.grbAdress.Name = "grbAdress";
            this.grbAdress.Size = new System.Drawing.Size(429, 152);
            this.grbAdress.TabIndex = 14;
            this.grbAdress.TabStop = false;
            this.grbAdress.Text = "Adresse";
            // 
            // cboTrade
            // 
            this.cboTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTrade.Location = new System.Drawing.Point(81, 38);
            this.cboTrade.Name = "cboTrade";
            this.cboTrade.Size = new System.Drawing.Size(299, 21);
            this.cboTrade.TabIndex = 5;
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(12, 41);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(50, 13);
            this.lblTrade.TabIndex = 4;
            this.lblTrade.Text = "Branche:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(81, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 20);
            this.txtTitle.TabIndex = 1;
            // 
            // chkTerminated
            // 
            this.chkTerminated.AutoSize = true;
            this.chkTerminated.Checked = true;
            this.chkTerminated.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkTerminated.Location = new System.Drawing.Point(386, 41);
            this.chkTerminated.Name = "chkTerminated";
            this.chkTerminated.Size = new System.Drawing.Size(156, 17);
            this.chkTerminated.TabIndex = 6;
            this.chkTerminated.Text = "Aufgelöste Firmen anzeigen";
            this.chkTerminated.ThreeState = true;
            this.chkTerminated.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Firma:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(447, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "id:";
            // 
            // uscProgressStateTo
            // 
            this.uscProgressStateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uscProgressStateTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uscProgressStateTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uscProgressStateTo.FormattingEnabled = true;
            this.uscProgressStateTo.Location = new System.Drawing.Point(342, 91);
            this.uscProgressStateTo.Name = "uscProgressStateTo";
            this.uscProgressStateTo.Size = new System.Drawing.Size(200, 21);
            this.uscProgressStateTo.TabIndex = 12;
            // 
            // uscAppProgressFrom
            // 
            this.uscAppProgressFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uscAppProgressFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uscAppProgressFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uscAppProgressFrom.FormattingEnabled = true;
            this.uscAppProgressFrom.Location = new System.Drawing.Point(102, 91);
            this.uscAppProgressFrom.Name = "uscAppProgressFrom";
            this.uscAppProgressFrom.Size = new System.Drawing.Size(200, 21);
            this.uscAppProgressFrom.TabIndex = 10;
            // 
            // grbApplication
            // 
            this.grbApplication.Controls.Add(this.nudApplicationtId);
            this.grbApplication.Controls.Add(this.lblApplicationtId);
            this.grbApplication.Controls.Add(this.txtApplicationText);
            this.grbApplication.Controls.Add(this.lblApplicationText);
            this.grbApplication.Location = new System.Drawing.Point(12, 276);
            this.grbApplication.Name = "grbApplication";
            this.grbApplication.Size = new System.Drawing.Size(429, 45);
            this.grbApplication.TabIndex = 19;
            this.grbApplication.TabStop = false;
            this.grbApplication.Text = "Bewerbung:";
            // 
            // nudApplicationtId
            // 
            this.nudApplicationtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.nudApplicationtId.Location = new System.Drawing.Point(352, 20);
            this.nudApplicationtId.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudApplicationtId.Name = "nudApplicationtId";
            this.nudApplicationtId.Size = new System.Drawing.Size(71, 20);
            this.nudApplicationtId.TabIndex = 3;
            this.nudApplicationtId.ThousandsSeparator = true;
            // 
            // lblApplicationtId
            // 
            this.lblApplicationtId.AutoSize = true;
            this.lblApplicationtId.Location = new System.Drawing.Point(328, 23);
            this.lblApplicationtId.Name = "lblApplicationtId";
            this.lblApplicationtId.Size = new System.Drawing.Size(18, 13);
            this.lblApplicationtId.TabIndex = 2;
            this.lblApplicationtId.Text = "id:";
            // 
            // txtApplicationText
            // 
            this.txtApplicationText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtApplicationText.Location = new System.Drawing.Point(114, 19);
            this.txtApplicationText.Name = "txtApplicationText";
            this.txtApplicationText.Size = new System.Drawing.Size(208, 20);
            this.txtApplicationText.TabIndex = 1;
            // 
            // lblApplicationText
            // 
            this.lblApplicationText.AutoSize = true;
            this.lblApplicationText.Location = new System.Drawing.Point(6, 22);
            this.lblApplicationText.Name = "lblApplicationText";
            this.lblApplicationText.Size = new System.Drawing.Size(94, 13);
            this.lblApplicationText.TabIndex = 0;
            this.lblApplicationText.Text = "Titel / Kommentar:";
            // 
            // CompanySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(554, 462);
            this.Controls.Add(this.grbApplication);
            this.Controls.Add(this.uscProgressStateTo);
            this.Controls.Add(this.uscAppProgressFrom);
            this.Controls.Add(this.grbContact);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.chkAppProgressMode);
            this.Controls.Add(this.lblAppStateTo);
            this.Controls.Add(this.lsvColorMarker);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.chkCloseAfterSucessSearch);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.grbAdress);
            this.Controls.Add(this.cboTrade);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.chkTerminated);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanySearchForm";
            this.Text = "Firmen filtern in: {0}";
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudContactId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.grbAdress.ResumeLayout(false);
            this.grbAdress.PerformLayout();
            this.grbApplication.ResumeLayout(false);
            this.grbApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplicationtId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.TextBox txtContactText;
        private System.Windows.Forms.Label lblContactText;
        private System.Windows.Forms.TextBox txtContactDiverse;
        private System.Windows.Forms.Label lblContactDiverse;
        private System.Windows.Forms.ComboBox cboAdressCountry;
        private System.Windows.Forms.ComboBox cboAdressState;
        private System.Windows.Forms.ColumnHeader chLsvColorMarker_Marker;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboAdressCity;
        private System.Windows.Forms.Label lblAdressCountry;
        private System.Windows.Forms.Label lblAdressState;
        private System.Windows.Forms.Label lblAdressCity;
        private System.Windows.Forms.TextBox txtAdressPostcode;
        private System.Windows.Forms.Label lblAdressPostcode;
        private System.Windows.Forms.NumericUpDown nudId;
        private System.Windows.Forms.CheckBox chkAppProgressMode;
        private System.Windows.Forms.Label lblAppStateTo;
        private System.Windows.Forms.ListView lsvColorMarker;
        private System.Windows.Forms.TextBox txtAdressStreet;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblAdressStreet;
        private System.Windows.Forms.CheckBox chkCloseAfterSucessSearch;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.GroupBox grbAdress;
        private System.Windows.Forms.ComboBox cboTrade;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.CheckBox chkTerminated;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblId;
        private Project.QuickFilterCompanyAppProgress uscAppProgressFrom;
        private Project.QuickFilterCompanyAppProgress uscProgressStateTo;
        protected internal System.Windows.Forms.ImageList imlColorMarkers;
        private System.Windows.Forms.NumericUpDown nudContactId;
        private System.Windows.Forms.Label lblContactId;
        private System.Windows.Forms.GroupBox grbApplication;
        private System.Windows.Forms.NumericUpDown nudApplicationtId;
        private System.Windows.Forms.Label lblApplicationtId;
        private System.Windows.Forms.TextBox txtApplicationText;
        private System.Windows.Forms.Label lblApplicationText;
    }
}