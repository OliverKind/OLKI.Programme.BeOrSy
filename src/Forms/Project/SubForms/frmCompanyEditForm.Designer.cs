namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class CompanyEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyEditForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.tpTabCompany_Addition = new System.Windows.Forms.TabPage();
            this.lsvColorMarker = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvColorMarker_Marker = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlColorMarkers = new System.Windows.Forms.ImageList(this.components);
            this.grbComment = new System.Windows.Forms.GroupBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tpTabCompany_Common = new System.Windows.Forms.TabPage();
            this.grbAddress = new System.Windows.Forms.GroupBox();
            this.btnAdressPostcodeEdit = new System.Windows.Forms.Button();
            this.btnAdressPostcodeAuto = new System.Windows.Forms.Button();
            this.btnAdressToClipboard = new System.Windows.Forms.Button();
            this.chkTerminated = new System.Windows.Forms.CheckBox();
            this.cboAdressCountry = new System.Windows.Forms.ComboBox();
            this.cboAdressState = new System.Windows.Forms.ComboBox();
            this.cboAdressCity = new System.Windows.Forms.ComboBox();
            this.txtAdressStreet = new System.Windows.Forms.TextBox();
            this.lblAdressCountry = new System.Windows.Forms.Label();
            this.lblAdressState = new System.Windows.Forms.Label();
            this.lblAdressCity = new System.Windows.Forms.Label();
            this.txtAdressPostcode = new System.Windows.Forms.TextBox();
            this.lblAdressPostcode = new System.Windows.Forms.Label();
            this.lblAdressStreetStreet = new System.Windows.Forms.Label();
            this.AdressStreetAddition = new System.Windows.Forms.Label();
            this.AdressStreetNumber = new System.Windows.Forms.Label();
            this.grbContact = new System.Windows.Forms.GroupBox();
            this.btnContactCareerPage = new System.Windows.Forms.Button();
            this.txtContactCareerPage = new System.Windows.Forms.TextBox();
            this.btnContactHomepage = new System.Windows.Forms.Button();
            this.txtContactHomepage = new System.Windows.Forms.TextBox();
            this.btnContatEMail = new System.Windows.Forms.Button();
            this.txtContactTelephone = new System.Windows.Forms.TextBox();
            this.txtContactFax = new System.Windows.Forms.TextBox();
            this.lblContactCareerPage = new System.Windows.Forms.Label();
            this.txtContactEMail = new System.Windows.Forms.TextBox();
            this.lblContactHomepage = new System.Windows.Forms.Label();
            this.lblContactTelephone = new System.Windows.Forms.Label();
            this.lblContatEMail = new System.Windows.Forms.Label();
            this.lblContactFax = new System.Windows.Forms.Label();
            this.tabCompany = new System.Windows.Forms.TabControl();
            this.tpTabCompany_Contacts = new System.Windows.Forms.TabPage();
            this.uscEditorContacts = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ContactsEditor();
            this.tpTabCompany_Files = new System.Windows.Forms.TabPage();
            this.uscEditorFiles = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.FilesEditor();
            this.tpTabCompany_Reminders = new System.Windows.Forms.TabPage();
            this.uscEditorReminders = new OLKI.Programme.BeOrSy.src.Forms.Project.SubForms.Controles.ReminderEditor();
            this.tpTabCompany_Directory = new System.Windows.Forms.TabPage();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.lblDirectoryInfo = new System.Windows.Forms.Label();
            this.imlRegister = new System.Windows.Forms.ImageList(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTrade = new System.Windows.Forms.Label();
            this.cboTrade = new System.Windows.Forms.ComboBox();
            this.tolCompany = new System.Windows.Forms.ToolStrip();
            this.tolC_btnGoToFolder = new System.Windows.Forms.ToolStripButton();
            this.tolC_lblId = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tolC_btnCreateReport = new System.Windows.Forms.ToolStripButton();
            this.erpEditor = new System.Windows.Forms.ErrorProvider(this.components);
            this.tpTabCompany_Addition.SuspendLayout();
            this.grbComment.SuspendLayout();
            this.tpTabCompany_Common.SuspendLayout();
            this.grbAddress.SuspendLayout();
            this.grbContact.SuspendLayout();
            this.tabCompany.SuspendLayout();
            this.tpTabCompany_Contacts.SuspendLayout();
            this.tpTabCompany_Files.SuspendLayout();
            this.tpTabCompany_Reminders.SuspendLayout();
            this.tpTabCompany_Directory.SuspendLayout();
            this.tolCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(67, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Firmenname:";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTitle.Location = new System.Drawing.Point(85, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(321, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // tpTabCompany_Addition
            // 
            this.tpTabCompany_Addition.Controls.Add(this.lsvColorMarker);
            this.tpTabCompany_Addition.Controls.Add(this.grbComment);
            this.tpTabCompany_Addition.ImageIndex = 1;
            this.tpTabCompany_Addition.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Addition.Name = "tpTabCompany_Addition";
            this.tpTabCompany_Addition.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Addition.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Addition.TabIndex = 1;
            this.tpTabCompany_Addition.Text = "Zusatzinformationen";
            this.tpTabCompany_Addition.UseVisualStyleBackColor = true;
            // 
            // lsvColorMarker
            // 
            this.lsvColorMarker.AllowColumnWidthChange = false;
            this.lsvColorMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvColorMarker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvColorMarker_Marker});
            this.lsvColorMarker.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvColorMarker.ColumnWidths")));
            this.lsvColorMarker.FullRowSelect = true;
            this.lsvColorMarker.GridLines = true;
            this.lsvColorMarker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lsvColorMarker.HideSelection = false;
            this.lsvColorMarker.Location = new System.Drawing.Point(6, 6);
            this.lsvColorMarker.MultiSelect = false;
            this.lsvColorMarker.Name = "lsvColorMarker";
            this.lsvColorMarker.Size = new System.Drawing.Size(95, 226);
            this.lsvColorMarker.SmallImageList = this.imlColorMarkers;
            this.lsvColorMarker.TabIndex = 0;
            this.lsvColorMarker.UseCompatibleStateImageBehavior = false;
            this.lsvColorMarker.View = System.Windows.Forms.View.Details;
            // 
            // chLsvColorMarker_Marker
            // 
            this.chLsvColorMarker_Marker.Text = "Markierung";
            this.chLsvColorMarker_Marker.Width = 90;
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
            // grbComment
            // 
            this.grbComment.Controls.Add(this.txtComment);
            this.grbComment.Location = new System.Drawing.Point(107, 6);
            this.grbComment.Name = "grbComment";
            this.grbComment.Size = new System.Drawing.Size(569, 226);
            this.grbComment.TabIndex = 1;
            this.grbComment.TabStop = false;
            this.grbComment.Text = "Kommentar";
            // 
            // txtComment
            // 
            this.txtComment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtComment.Location = new System.Drawing.Point(5, 19);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtComment.Size = new System.Drawing.Size(557, 201);
            this.txtComment.TabIndex = 0;
            // 
            // tpTabCompany_Common
            // 
            this.tpTabCompany_Common.Controls.Add(this.grbAddress);
            this.tpTabCompany_Common.Controls.Add(this.grbContact);
            this.tpTabCompany_Common.ImageIndex = 0;
            this.tpTabCompany_Common.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Common.Name = "tpTabCompany_Common";
            this.tpTabCompany_Common.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Common.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Common.TabIndex = 0;
            this.tpTabCompany_Common.Text = "Adresse und Kontakt";
            this.tpTabCompany_Common.UseVisualStyleBackColor = true;
            // 
            // grbAddress
            // 
            this.grbAddress.Controls.Add(this.btnAdressPostcodeEdit);
            this.grbAddress.Controls.Add(this.btnAdressPostcodeAuto);
            this.grbAddress.Controls.Add(this.btnAdressToClipboard);
            this.grbAddress.Controls.Add(this.chkTerminated);
            this.grbAddress.Controls.Add(this.cboAdressCountry);
            this.grbAddress.Controls.Add(this.cboAdressState);
            this.grbAddress.Controls.Add(this.cboAdressCity);
            this.grbAddress.Controls.Add(this.txtAdressStreet);
            this.grbAddress.Controls.Add(this.lblAdressCountry);
            this.grbAddress.Controls.Add(this.lblAdressState);
            this.grbAddress.Controls.Add(this.lblAdressCity);
            this.grbAddress.Controls.Add(this.txtAdressPostcode);
            this.grbAddress.Controls.Add(this.lblAdressPostcode);
            this.grbAddress.Controls.Add(this.lblAdressStreetStreet);
            this.grbAddress.Controls.Add(this.AdressStreetAddition);
            this.grbAddress.Controls.Add(this.AdressStreetNumber);
            this.grbAddress.Location = new System.Drawing.Point(6, 6);
            this.grbAddress.Name = "grbAddress";
            this.grbAddress.Size = new System.Drawing.Size(670, 123);
            this.grbAddress.TabIndex = 0;
            this.grbAddress.TabStop = false;
            this.grbAddress.Text = "Adresse";
            // 
            // btnAdressPostcodeEdit
            // 
            this.btnAdressPostcodeEdit.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Settings;
            this.btnAdressPostcodeEdit.Location = new System.Drawing.Point(300, 93);
            this.btnAdressPostcodeEdit.Name = "btnAdressPostcodeEdit";
            this.btnAdressPostcodeEdit.Size = new System.Drawing.Size(35, 24);
            this.btnAdressPostcodeEdit.TabIndex = 7;
            this.btnAdressPostcodeEdit.UseVisualStyleBackColor = true;
            this.btnAdressPostcodeEdit.Click += new System.EventHandler(this.btnAdressPostcodeEdit_Click);
            // 
            // btnAdressPostcodeAuto
            // 
            this.btnAdressPostcodeAuto.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.PostcodeSearch;
            this.btnAdressPostcodeAuto.Location = new System.Drawing.Point(259, 93);
            this.btnAdressPostcodeAuto.Name = "btnAdressPostcodeAuto";
            this.btnAdressPostcodeAuto.Size = new System.Drawing.Size(35, 24);
            this.btnAdressPostcodeAuto.TabIndex = 6;
            this.btnAdressPostcodeAuto.UseVisualStyleBackColor = true;
            this.btnAdressPostcodeAuto.Click += new System.EventHandler(this.btnAdressPostcodeAuto_Click);
            // 
            // btnAdressToClipboard
            // 
            this.btnAdressToClipboard.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.AdressMail;
            this.btnAdressToClipboard.Location = new System.Drawing.Point(629, 93);
            this.btnAdressToClipboard.Name = "btnAdressToClipboard";
            this.btnAdressToClipboard.Size = new System.Drawing.Size(35, 24);
            this.btnAdressToClipboard.TabIndex = 15;
            this.btnAdressToClipboard.UseVisualStyleBackColor = true;
            this.btnAdressToClipboard.Click += new System.EventHandler(this.btnAdressToClipboard_Click);
            // 
            // chkTerminated
            // 
            this.chkTerminated.AutoSize = true;
            this.chkTerminated.Location = new System.Drawing.Point(424, 99);
            this.chkTerminated.Name = "chkTerminated";
            this.chkTerminated.Size = new System.Drawing.Size(129, 17);
            this.chkTerminated.TabIndex = 14;
            this.chkTerminated.Text = "Firma wurde aufgelöst";
            this.chkTerminated.UseVisualStyleBackColor = false;
            // 
            // cboAdressCountry
            // 
            this.cboAdressCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAdressCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressCountry.Location = new System.Drawing.Point(424, 71);
            this.cboAdressCountry.Name = "cboAdressCountry";
            this.cboAdressCountry.Size = new System.Drawing.Size(240, 21);
            this.cboAdressCountry.TabIndex = 13;
            // 
            // cboAdressState
            // 
            this.cboAdressState.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAdressState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressState.Location = new System.Drawing.Point(424, 45);
            this.cboAdressState.Name = "cboAdressState";
            this.cboAdressState.Size = new System.Drawing.Size(240, 21);
            this.cboAdressState.TabIndex = 11;
            // 
            // cboAdressCity
            // 
            this.cboAdressCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAdressCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboAdressCity.Location = new System.Drawing.Point(424, 18);
            this.cboAdressCity.Name = "cboAdressCity";
            this.cboAdressCity.Size = new System.Drawing.Size(240, 21);
            this.cboAdressCity.TabIndex = 9;
            // 
            // txtAdressStreet
            // 
            this.txtAdressStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdressStreet.Location = new System.Drawing.Point(95, 19);
            this.txtAdressStreet.Multiline = true;
            this.txtAdressStreet.Name = "txtAdressStreet";
            this.txtAdressStreet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAdressStreet.Size = new System.Drawing.Size(240, 73);
            this.txtAdressStreet.TabIndex = 3;
            // 
            // lblAdressCountry
            // 
            this.lblAdressCountry.AutoSize = true;
            this.lblAdressCountry.Location = new System.Drawing.Point(352, 74);
            this.lblAdressCountry.Name = "lblAdressCountry";
            this.lblAdressCountry.Size = new System.Drawing.Size(34, 13);
            this.lblAdressCountry.TabIndex = 12;
            this.lblAdressCountry.Text = "Land:";
            // 
            // lblAdressState
            // 
            this.lblAdressState.AutoSize = true;
            this.lblAdressState.Location = new System.Drawing.Point(352, 48);
            this.lblAdressState.Name = "lblAdressState";
            this.lblAdressState.Size = new System.Drawing.Size(66, 13);
            this.lblAdressState.TabIndex = 10;
            this.lblAdressState.Text = "Bundesland:";
            // 
            // lblAdressCity
            // 
            this.lblAdressCity.AutoSize = true;
            this.lblAdressCity.Location = new System.Drawing.Point(352, 21);
            this.lblAdressCity.Name = "lblAdressCity";
            this.lblAdressCity.Size = new System.Drawing.Size(35, 13);
            this.lblAdressCity.TabIndex = 8;
            this.lblAdressCity.Text = "Stadt:";
            // 
            // txtAdressPostcode
            // 
            this.txtAdressPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAdressPostcode.Location = new System.Drawing.Point(95, 97);
            this.txtAdressPostcode.Name = "txtAdressPostcode";
            this.txtAdressPostcode.Size = new System.Drawing.Size(158, 20);
            this.txtAdressPostcode.TabIndex = 5;
            // 
            // lblAdressPostcode
            // 
            this.lblAdressPostcode.AutoSize = true;
            this.lblAdressPostcode.Location = new System.Drawing.Point(6, 100);
            this.lblAdressPostcode.Name = "lblAdressPostcode";
            this.lblAdressPostcode.Size = new System.Drawing.Size(63, 13);
            this.lblAdressPostcode.TabIndex = 4;
            this.lblAdressPostcode.Text = "Postleitzahl:";
            // 
            // lblAdressStreetStreet
            // 
            this.lblAdressStreetStreet.AutoSize = true;
            this.lblAdressStreetStreet.Location = new System.Drawing.Point(6, 22);
            this.lblAdressStreetStreet.Name = "lblAdressStreetStreet";
            this.lblAdressStreetStreet.Size = new System.Drawing.Size(41, 13);
            this.lblAdressStreetStreet.TabIndex = 0;
            this.lblAdressStreetStreet.Text = "Straße:";
            // 
            // AdressStreetAddition
            // 
            this.AdressStreetAddition.AutoSize = true;
            this.AdressStreetAddition.Location = new System.Drawing.Point(6, 74);
            this.AdressStreetAddition.Name = "AdressStreetAddition";
            this.AdressStreetAddition.Size = new System.Drawing.Size(72, 13);
            this.AdressStreetAddition.TabIndex = 2;
            this.AdressStreetAddition.Text = "Adresszusatz:";
            // 
            // AdressStreetNumber
            // 
            this.AdressStreetNumber.AutoSize = true;
            this.AdressStreetNumber.Location = new System.Drawing.Point(6, 48);
            this.AdressStreetNumber.Name = "AdressStreetNumber";
            this.AdressStreetNumber.Size = new System.Drawing.Size(72, 13);
            this.AdressStreetNumber.TabIndex = 1;
            this.AdressStreetNumber.Text = "Hausnummer:";
            // 
            // grbContact
            // 
            this.grbContact.Controls.Add(this.btnContactCareerPage);
            this.grbContact.Controls.Add(this.txtContactCareerPage);
            this.grbContact.Controls.Add(this.btnContactHomepage);
            this.grbContact.Controls.Add(this.txtContactHomepage);
            this.grbContact.Controls.Add(this.btnContatEMail);
            this.grbContact.Controls.Add(this.txtContactTelephone);
            this.grbContact.Controls.Add(this.txtContactFax);
            this.grbContact.Controls.Add(this.lblContactCareerPage);
            this.grbContact.Controls.Add(this.txtContactEMail);
            this.grbContact.Controls.Add(this.lblContactHomepage);
            this.grbContact.Controls.Add(this.lblContactTelephone);
            this.grbContact.Controls.Add(this.lblContatEMail);
            this.grbContact.Controls.Add(this.lblContactFax);
            this.grbContact.Location = new System.Drawing.Point(6, 135);
            this.grbContact.Name = "grbContact";
            this.grbContact.Size = new System.Drawing.Size(670, 97);
            this.grbContact.TabIndex = 1;
            this.grbContact.TabStop = false;
            this.grbContact.Text = "Kontakt";
            // 
            // btnContactCareerPage
            // 
            this.btnContactCareerPage.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.WebJob;
            this.btnContactCareerPage.Location = new System.Drawing.Point(629, 42);
            this.btnContactCareerPage.Name = "btnContactCareerPage";
            this.btnContactCareerPage.Size = new System.Drawing.Size(35, 24);
            this.btnContactCareerPage.TabIndex = 12;
            this.btnContactCareerPage.UseVisualStyleBackColor = true;
            this.btnContactCareerPage.Click += new System.EventHandler(this.btnContactCareerPage_Click);
            // 
            // txtContactCareerPage
            // 
            this.txtContactCareerPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactCareerPage.Location = new System.Drawing.Point(417, 45);
            this.txtContactCareerPage.Name = "txtContactCareerPage";
            this.txtContactCareerPage.Size = new System.Drawing.Size(206, 20);
            this.txtContactCareerPage.TabIndex = 11;
            this.txtContactCareerPage.TextChanged += new System.EventHandler(this.txtContactCareerPage_TextChanged);
            // 
            // btnContactHomepage
            // 
            this.btnContactHomepage.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Web;
            this.btnContactHomepage.Location = new System.Drawing.Point(629, 15);
            this.btnContactHomepage.Name = "btnContactHomepage";
            this.btnContactHomepage.Size = new System.Drawing.Size(35, 24);
            this.btnContactHomepage.TabIndex = 9;
            this.btnContactHomepage.UseVisualStyleBackColor = true;
            this.btnContactHomepage.Click += new System.EventHandler(this.btnContactHomepage_Click);
            // 
            // txtContactHomepage
            // 
            this.txtContactHomepage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactHomepage.Location = new System.Drawing.Point(417, 20);
            this.txtContactHomepage.Name = "txtContactHomepage";
            this.txtContactHomepage.Size = new System.Drawing.Size(206, 20);
            this.txtContactHomepage.TabIndex = 8;
            this.txtContactHomepage.TextChanged += new System.EventHandler(this.txtContactHomepage_TextChanged);
            // 
            // btnContatEMail
            // 
            this.btnContatEMail.Enabled = false;
            this.btnContatEMail.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.EMail;
            this.btnContatEMail.Location = new System.Drawing.Point(300, 68);
            this.btnContatEMail.Name = "btnContatEMail";
            this.btnContatEMail.Size = new System.Drawing.Size(35, 24);
            this.btnContatEMail.TabIndex = 6;
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
            // lblContactCareerPage
            // 
            this.lblContactCareerPage.AutoSize = true;
            this.lblContactCareerPage.Location = new System.Drawing.Point(346, 48);
            this.lblContactCareerPage.Name = "lblContactCareerPage";
            this.lblContactCareerPage.Size = new System.Drawing.Size(65, 13);
            this.lblContactCareerPage.TabIndex = 10;
            this.lblContactCareerPage.Text = "Kariereseite:";
            // 
            // txtContactEMail
            // 
            this.txtContactEMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtContactEMail.Location = new System.Drawing.Point(95, 71);
            this.txtContactEMail.Name = "txtContactEMail";
            this.txtContactEMail.Size = new System.Drawing.Size(199, 20);
            this.txtContactEMail.TabIndex = 5;
            this.txtContactEMail.TextChanged += new System.EventHandler(this.txtContactEMail_TextChanged);
            // 
            // lblContactHomepage
            // 
            this.lblContactHomepage.AutoSize = true;
            this.lblContactHomepage.Location = new System.Drawing.Point(346, 23);
            this.lblContactHomepage.Name = "lblContactHomepage";
            this.lblContactHomepage.Size = new System.Drawing.Size(62, 13);
            this.lblContactHomepage.TabIndex = 7;
            this.lblContactHomepage.Text = "Homepage:";
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
            this.lblContatEMail.Location = new System.Drawing.Point(6, 74);
            this.lblContatEMail.Name = "lblContatEMail";
            this.lblContatEMail.Size = new System.Drawing.Size(80, 13);
            this.lblContatEMail.TabIndex = 4;
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
            // tabCompany
            // 
            this.tabCompany.Controls.Add(this.tpTabCompany_Common);
            this.tabCompany.Controls.Add(this.tpTabCompany_Addition);
            this.tabCompany.Controls.Add(this.tpTabCompany_Contacts);
            this.tabCompany.Controls.Add(this.tpTabCompany_Files);
            this.tabCompany.Controls.Add(this.tpTabCompany_Reminders);
            this.tabCompany.Controls.Add(this.tpTabCompany_Directory);
            this.tabCompany.ImageList = this.imlRegister;
            this.tabCompany.Location = new System.Drawing.Point(12, 38);
            this.tabCompany.Name = "tabCompany";
            this.tabCompany.SelectedIndex = 0;
            this.tabCompany.Size = new System.Drawing.Size(999, 264);
            this.tabCompany.TabIndex = 4;
            // 
            // tpTabCompany_Contacts
            // 
            this.tpTabCompany_Contacts.Controls.Add(this.uscEditorContacts);
            this.tpTabCompany_Contacts.ImageIndex = 2;
            this.tpTabCompany_Contacts.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Contacts.Name = "tpTabCompany_Contacts";
            this.tpTabCompany_Contacts.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Contacts.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Contacts.TabIndex = 5;
            this.tpTabCompany_Contacts.Text = "Ansprechpartner";
            this.tpTabCompany_Contacts.UseVisualStyleBackColor = true;
            // 
            // uscEditorContacts
            // 
            this.uscEditorContacts.ApplicationMode = false;
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
            // tpTabCompany_Files
            // 
            this.tpTabCompany_Files.Controls.Add(this.uscEditorFiles);
            this.tpTabCompany_Files.ImageIndex = 3;
            this.tpTabCompany_Files.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Files.Name = "tpTabCompany_Files";
            this.tpTabCompany_Files.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Files.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Files.TabIndex = 4;
            this.tpTabCompany_Files.Text = "Dateianhänge";
            this.tpTabCompany_Files.UseVisualStyleBackColor = true;
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
            // tpTabCompany_Reminders
            // 
            this.tpTabCompany_Reminders.Controls.Add(this.uscEditorReminders);
            this.tpTabCompany_Reminders.ImageIndex = 4;
            this.tpTabCompany_Reminders.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Reminders.Name = "tpTabCompany_Reminders";
            this.tpTabCompany_Reminders.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Reminders.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Reminders.TabIndex = 3;
            this.tpTabCompany_Reminders.Text = "Erinnerungen";
            this.tpTabCompany_Reminders.UseVisualStyleBackColor = true;
            // 
            // uscEditorReminders
            // 
            this.uscEditorReminders.IdSet = null;
            this.uscEditorReminders.Items = null;
            this.uscEditorReminders.Location = new System.Drawing.Point(6, 6);
            this.uscEditorReminders.Name = "uscEditorReminders";
            this.uscEditorReminders.Size = new System.Drawing.Size(979, 226);
            this.uscEditorReminders.TabIndex = 0;
            this.uscEditorReminders.ItemAdded += new System.EventHandler(this.uscEditorReminders_ItemAdded);
            // 
            // tpTabCompany_Directory
            // 
            this.tpTabCompany_Directory.Controls.Add(this.btnDirectory);
            this.tpTabCompany_Directory.Controls.Add(this.lblDirectory);
            this.tpTabCompany_Directory.Controls.Add(this.txtDirectory);
            this.tpTabCompany_Directory.Controls.Add(this.lblDirectoryInfo);
            this.tpTabCompany_Directory.ImageIndex = 5;
            this.tpTabCompany_Directory.Location = new System.Drawing.Point(4, 23);
            this.tpTabCompany_Directory.Name = "tpTabCompany_Directory";
            this.tpTabCompany_Directory.Padding = new System.Windows.Forms.Padding(3);
            this.tpTabCompany_Directory.Size = new System.Drawing.Size(991, 237);
            this.tpTabCompany_Directory.TabIndex = 6;
            this.tpTabCompany_Directory.Text = "Ordner";
            this.tpTabCompany_Directory.UseVisualStyleBackColor = true;
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
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
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
            this.txtDirectory.TextChanged += new System.EventHandler(this.txtDirectory_TextChanged);
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
            // imlRegister
            // 
            this.imlRegister.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRegister.ImageStream")));
            this.imlRegister.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRegister.Images.SetKeyName(0, "Adress.png");
            this.imlRegister.Images.SetKeyName(1, "AdditionalInfo.png");
            this.imlRegister.Images.SetKeyName(2, "User.png");
            this.imlRegister.Images.SetKeyName(3, "Document.png");
            this.imlRegister.Images.SetKeyName(4, "Reminder.png");
            this.imlRegister.Images.SetKeyName(5, "Open.png");
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
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(412, 15);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(50, 13);
            this.lblTrade.TabIndex = 2;
            this.lblTrade.Text = "Branche:";
            // 
            // cboTrade
            // 
            this.cboTrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboTrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTrade.Location = new System.Drawing.Point(462, 12);
            this.cboTrade.Name = "cboTrade";
            this.cboTrade.Size = new System.Drawing.Size(240, 21);
            this.cboTrade.TabIndex = 3;
            // 
            // tolCompany
            // 
            this.tolCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.tolCompany.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tolCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tolC_btnGoToFolder,
            this.tolC_lblId,
            this.toolStripSeparator1,
            this.tolC_btnCreateReport});
            this.tolCompany.Location = new System.Drawing.Point(1014, 0);
            this.tolCompany.Name = "tolCompany";
            this.tolCompany.Size = new System.Drawing.Size(24, 343);
            this.tolCompany.TabIndex = 8;
            this.tolCompany.Text = "toolStrip1";
            // 
            // tolC_btnGoToFolder
            // 
            this.tolC_btnGoToFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tolC_btnGoToFolder.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.OpenFolder;
            this.tolC_btnGoToFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tolC_btnGoToFolder.Name = "tolC_btnGoToFolder";
            this.tolC_btnGoToFolder.Size = new System.Drawing.Size(21, 20);
            this.tolC_btnGoToFolder.Text = "Bewerbungsordner ö&ffnen";
            this.tolC_btnGoToFolder.Click += new System.EventHandler(this.tolC_btnGoToFolder_Click);
            // 
            // tolC_lblId
            // 
            this.tolC_lblId.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolC_lblId.Name = "tolC_lblId";
            this.tolC_lblId.Size = new System.Drawing.Size(21, 66);
            this.tolC_lblId.Text = "Firma Id: {0}";
            this.tolC_lblId.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
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
            // erpEditor
            // 
            this.erpEditor.ContainerControl = this;
            // 
            // CompanyEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1038, 343);
            this.Controls.Add(this.tolCompany);
            this.Controls.Add(this.cboTrade);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.tabCompany);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyEditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "[Neue Firma]";
            this.tpTabCompany_Addition.ResumeLayout(false);
            this.grbComment.ResumeLayout(false);
            this.grbComment.PerformLayout();
            this.tpTabCompany_Common.ResumeLayout(false);
            this.grbAddress.ResumeLayout(false);
            this.grbAddress.PerformLayout();
            this.grbContact.ResumeLayout(false);
            this.grbContact.PerformLayout();
            this.tabCompany.ResumeLayout(false);
            this.tpTabCompany_Contacts.ResumeLayout(false);
            this.tpTabCompany_Files.ResumeLayout(false);
            this.tpTabCompany_Reminders.ResumeLayout(false);
            this.tpTabCompany_Directory.ResumeLayout(false);
            this.tpTabCompany_Directory.PerformLayout();
            this.tolCompany.ResumeLayout(false);
            this.tolCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TabPage tpTabCompany_Addition;
        private System.Windows.Forms.GroupBox grbComment;
        private System.Windows.Forms.TabPage tpTabCompany_Common;
        private System.Windows.Forms.GroupBox grbAddress;
        private System.Windows.Forms.ComboBox cboAdressCountry;
        private System.Windows.Forms.ComboBox cboAdressState;
        private System.Windows.Forms.ComboBox cboAdressCity;
        private System.Windows.Forms.TextBox txtAdressStreet;
        private System.Windows.Forms.Label lblAdressCountry;
        private System.Windows.Forms.Label lblAdressState;
        private System.Windows.Forms.Label lblAdressCity;
        private System.Windows.Forms.TextBox txtAdressPostcode;
        private System.Windows.Forms.Label lblAdressPostcode;
        private System.Windows.Forms.Label lblAdressStreetStreet;
        private System.Windows.Forms.Label AdressStreetAddition;
        private System.Windows.Forms.Label AdressStreetNumber;
        private System.Windows.Forms.GroupBox grbContact;
        private System.Windows.Forms.Button btnContactCareerPage;
        private System.Windows.Forms.TextBox txtContactCareerPage;
        private System.Windows.Forms.Button btnContactHomepage;
        private System.Windows.Forms.TextBox txtContactHomepage;
        private System.Windows.Forms.Button btnContatEMail;
        private System.Windows.Forms.TextBox txtContactTelephone;
        private System.Windows.Forms.TextBox txtContactFax;
        private System.Windows.Forms.Label lblContactCareerPage;
        private System.Windows.Forms.TextBox txtContactEMail;
        private System.Windows.Forms.Label lblContactHomepage;
        private System.Windows.Forms.Label lblContactTelephone;
        private System.Windows.Forms.Label lblContatEMail;
        private System.Windows.Forms.Label lblContactFax;
        private System.Windows.Forms.TabControl tabCompany;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TabPage tpTabCompany_Reminders;
        private System.Windows.Forms.TabPage tpTabCompany_Files;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.ComboBox cboTrade;
        private System.Windows.Forms.CheckBox chkTerminated;
        internal System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.TabPage tpTabCompany_Contacts;
        private System.Windows.Forms.ToolStrip tolCompany;
        private System.Windows.Forms.ToolStripButton tolC_btnGoToFolder;
        private System.Windows.Forms.ToolStripLabel tolC_lblId;
        private OLKI.Toolbox.Widgets.SortListView lsvColorMarker;
        private System.Windows.Forms.ColumnHeader chLsvColorMarker_Marker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tolC_btnCreateReport;
        private System.Windows.Forms.Button btnAdressToClipboard;
        private System.Windows.Forms.Button btnAdressPostcodeAuto;
        private src.Forms.Project.SubForms.Controles.ContactsEditor uscEditorContacts;
        private src.Forms.Project.SubForms.Controles.FilesEditor uscEditorFiles;
        private src.Forms.Project.SubForms.Controles.ReminderEditor uscEditorReminders;
        private System.Windows.Forms.ImageList imlRegister;
        private System.Windows.Forms.TabPage tpTabCompany_Directory;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label lblDirectoryInfo;
        protected internal System.Windows.Forms.ImageList imlColorMarkers;
        private System.Windows.Forms.ErrorProvider erpEditor;
        private System.Windows.Forms.Button btnAdressPostcodeEdit;
    }
}