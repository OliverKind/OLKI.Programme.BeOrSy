namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ApplicationAutoArchive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationAutoArchive));
            this.btnResetAll = new System.Windows.Forms.Button();
            this.rabProgressNumber = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.lblAdvise = new System.Windows.Forms.Label();
            this.rabProgressDate = new System.Windows.Forms.RadioButton();
            this.rabBeforeDate = new System.Windows.Forms.RadioButton();
            this.mtbBeforeDate = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.mtbProgressDate = new OLKI.Toolbox.Widgets.DateInputAndValidator();
            this.cboProgressNumber = new System.Windows.Forms.ComboBox();
            this.uscQuickFilterCompanyAppProgress = new OLKI.Programme.BeOrSy.src.Forms.Project.QuickFilterCompanyAppProgress();
            this.SuspendLayout();
            // 
            // btnResetAll
            // 
            this.btnResetAll.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResetAll.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Undo;
            this.btnResetAll.Location = new System.Drawing.Point(155, 104);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(125, 23);
            this.btnResetAll.TabIndex = 9;
            this.btnResetAll.Text = "Alle &zurücksetzen";
            this.btnResetAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // rabProgressNumber
            // 
            this.rabProgressNumber.AutoSize = true;
            this.rabProgressNumber.Location = new System.Drawing.Point(12, 77);
            this.rabProgressNumber.Name = "rabProgressNumber";
            this.rabProgressNumber.Size = new System.Drawing.Size(122, 17);
            this.rabProgressNumber.TabIndex = 5;
            this.rabProgressNumber.Text = "Mit einem Fortschritt:";
            this.rabProgressNumber.UseVisualStyleBackColor = true;
            this.rabProgressNumber.CheckedChanged += new System.EventHandler(this.rabProgressNumber_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 104);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "&Schhleißen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExecute.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnExecute.Location = new System.Drawing.Point(12, 104);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(110, 23);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "&Ausführen";
            this.btnExecute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExecute.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecuteClick);
            // 
            // lblAdvise
            // 
            this.lblAdvise.AutoSize = true;
            this.lblAdvise.Location = new System.Drawing.Point(12, 9);
            this.lblAdvise.Name = "lblAdvise";
            this.lblAdvise.Size = new System.Drawing.Size(380, 13);
            this.lblAdvise.TabIndex = 0;
            this.lblAdvise.Text = "Alle Bewerbungen als archiviert markieren, die folgenden Kriterien entsprechen:";
            // 
            // rabProgressDate
            // 
            this.rabProgressDate.AutoSize = true;
            this.rabProgressDate.Location = new System.Drawing.Point(12, 52);
            this.rabProgressDate.Name = "rabProgressDate";
            this.rabProgressDate.Size = new System.Drawing.Size(231, 17);
            this.rabProgressDate.TabIndex = 3;
            this.rabProgressDate.Text = "Deren letzter Status vor diesem Datum liegt:";
            this.rabProgressDate.UseVisualStyleBackColor = true;
            this.rabProgressDate.CheckedChanged += new System.EventHandler(this.rabProgressDate_CheckedChanged);
            // 
            // rabBeforeDate
            // 
            this.rabBeforeDate.AutoSize = true;
            this.rabBeforeDate.Checked = true;
            this.rabBeforeDate.Location = new System.Drawing.Point(12, 26);
            this.rabBeforeDate.Name = "rabBeforeDate";
            this.rabBeforeDate.Size = new System.Drawing.Size(201, 17);
            this.rabBeforeDate.TabIndex = 1;
            this.rabBeforeDate.TabStop = true;
            this.rabBeforeDate.Text = "Die vor dem Datum angelegt wurden:";
            this.rabBeforeDate.UseVisualStyleBackColor = true;
            this.rabBeforeDate.CheckedChanged += new System.EventHandler(this.rabBeforeDate_CheckedChanged);
            // 
            // mtbBeforeDate
            // 
            this.mtbBeforeDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbBeforeDate.Date = null;
            this.mtbBeforeDate.Location = new System.Drawing.Point(249, 25);
            this.mtbBeforeDate.Mask = "00/00/0000";
            this.mtbBeforeDate.Name = "mtbBeforeDate";
            this.mtbBeforeDate.Size = new System.Drawing.Size(147, 20);
            this.mtbBeforeDate.TabIndex = 2;
            this.mtbBeforeDate.TextChanged += new System.EventHandler(this.mtbBeforeDate_TextChanged);
            // 
            // mtbProgressDate
            // 
            this.mtbProgressDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mtbProgressDate.Date = null;
            this.mtbProgressDate.Location = new System.Drawing.Point(249, 51);
            this.mtbProgressDate.Mask = "00/00/0000";
            this.mtbProgressDate.Name = "mtbProgressDate";
            this.mtbProgressDate.Size = new System.Drawing.Size(147, 20);
            this.mtbProgressDate.TabIndex = 4;
            this.mtbProgressDate.TextChanged += new System.EventHandler(this.mtbProgressDate_TextChanged);
            // 
            // cboProgressNumber
            // 
            this.cboProgressNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgressNumber.FormattingEnabled = true;
            this.cboProgressNumber.Items.AddRange(new object[] {
            "<",
            "<=    ",
            "=",
            "!=",
            ">",
            ">="});
            this.cboProgressNumber.Location = new System.Drawing.Point(199, 77);
            this.cboProgressNumber.Name = "cboProgressNumber";
            this.cboProgressNumber.Size = new System.Drawing.Size(44, 21);
            this.cboProgressNumber.TabIndex = 6;
            this.cboProgressNumber.SelectedIndexChanged += new System.EventHandler(this.cboProgressNumber_SelectedIndexChanged);
            // 
            // uscQuickFilterCompanyAppProgress
            // 
            this.uscQuickFilterCompanyAppProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.uscQuickFilterCompanyAppProgress.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.uscQuickFilterCompanyAppProgress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uscQuickFilterCompanyAppProgress.FormattingEnabled = true;
            this.uscQuickFilterCompanyAppProgress.Location = new System.Drawing.Point(249, 77);
            this.uscQuickFilterCompanyAppProgress.Name = "uscQuickFilterCompanyAppProgress";
            this.uscQuickFilterCompanyAppProgress.Size = new System.Drawing.Size(147, 21);
            this.uscQuickFilterCompanyAppProgress.TabIndex = 7;
            this.uscQuickFilterCompanyAppProgress.SelectedIndexChanged += new System.EventHandler(this.uscQuickFilterCompanyAppProgress_SelectedIndexChanged);
            // 
            // ApplicationAutoArchive
            // 
            this.AcceptButton = this.btnExecute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(408, 139);
            this.Controls.Add(this.uscQuickFilterCompanyAppProgress);
            this.Controls.Add(this.cboProgressNumber);
            this.Controls.Add(this.mtbProgressDate);
            this.Controls.Add(this.mtbBeforeDate);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.rabProgressNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lblAdvise);
            this.Controls.Add(this.rabProgressDate);
            this.Controls.Add(this.rabBeforeDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationAutoArchive";
            this.ShowInTaskbar = false;
            this.Text = "Bewerbungen automatisch archivieren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.RadioButton rabProgressNumber;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label lblAdvise;
        private System.Windows.Forms.RadioButton rabProgressDate;
        private System.Windows.Forms.RadioButton rabBeforeDate;
        private Toolbox.Widgets.DateInputAndValidator mtbBeforeDate;
        private Toolbox.Widgets.DateInputAndValidator mtbProgressDate;
        private System.Windows.Forms.ComboBox cboProgressNumber;
        private QuickFilterCompanyAppProgress uscQuickFilterCompanyAppProgress;
    }
}