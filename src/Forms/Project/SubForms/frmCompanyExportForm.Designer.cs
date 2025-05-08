namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class CompanyExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyExportForm));
            this.rabNewlineSpace = new System.Windows.Forms.RadioButton();
            this.rabNewlineLF = new System.Windows.Forms.RadioButton();
            this.rabNewlineCRLF = new System.Windows.Forms.RadioButton();
            this.rabNewlineBR = new System.Windows.Forms.RadioButton();
            this.rabNewlineCustom = new System.Windows.Forms.RadioButton();
            this.grbHandleNewline = new System.Windows.Forms.GroupBox();
            this.txtNewlineCustom = new System.Windows.Forms.TextBox();
            this.grbHandleSeperator = new System.Windows.Forms.GroupBox();
            this.txtSeperatorCustom = new System.Windows.Forms.TextBox();
            this.rabSeperatorComma = new System.Windows.Forms.RadioButton();
            this.rabSeperatorCustom = new System.Windows.Forms.RadioButton();
            this.rabSeperatorSemicolon = new System.Windows.Forms.RadioButton();
            this.rabSeperatorTabulator = new System.Windows.Forms.RadioButton();
            this.grbExportScope = new System.Windows.Forms.GroupBox();
            this.rabExportAll = new System.Windows.Forms.RadioButton();
            this.rabExportSel = new System.Windows.Forms.RadioButton();
            this.rabExportFil = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHandleNewline.SuspendLayout();
            this.grbHandleSeperator.SuspendLayout();
            this.grbExportScope.SuspendLayout();
            this.SuspendLayout();
            // 
            // rabNewlineSpace
            // 
            this.rabNewlineSpace.AutoSize = true;
            this.rabNewlineSpace.Checked = true;
            this.rabNewlineSpace.Location = new System.Drawing.Point(6, 19);
            this.rabNewlineSpace.Name = "rabNewlineSpace";
            this.rabNewlineSpace.Size = new System.Drawing.Size(83, 17);
            this.rabNewlineSpace.TabIndex = 0;
            this.rabNewlineSpace.TabStop = true;
            this.rabNewlineSpace.Text = "Leerzeichen";
            this.rabNewlineSpace.UseVisualStyleBackColor = true;
            // 
            // rabNewlineLF
            // 
            this.rabNewlineLF.AutoSize = true;
            this.rabNewlineLF.Location = new System.Drawing.Point(6, 42);
            this.rabNewlineLF.Name = "rabNewlineLF";
            this.rabNewlineLF.Size = new System.Drawing.Size(107, 17);
            this.rabNewlineLF.TabIndex = 1;
            this.rabNewlineLF.Text = "\\n - Zeichenfolge";
            this.rabNewlineLF.UseVisualStyleBackColor = true;
            // 
            // rabNewlineCRLF
            // 
            this.rabNewlineCRLF.AutoSize = true;
            this.rabNewlineCRLF.Location = new System.Drawing.Point(6, 65);
            this.rabNewlineCRLF.Name = "rabNewlineCRLF";
            this.rabNewlineCRLF.Size = new System.Drawing.Size(115, 17);
            this.rabNewlineCRLF.TabIndex = 2;
            this.rabNewlineCRLF.Text = "\\r\\n - Zeichenfolge";
            this.rabNewlineCRLF.UseVisualStyleBackColor = true;
            // 
            // rabNewlineBR
            // 
            this.rabNewlineBR.AutoSize = true;
            this.rabNewlineBR.Location = new System.Drawing.Point(6, 88);
            this.rabNewlineBR.Name = "rabNewlineBR";
            this.rabNewlineBR.Size = new System.Drawing.Size(125, 17);
            this.rabNewlineBR.TabIndex = 3;
            this.rabNewlineBR.Text = "<br /> - Zeichenfolge";
            this.rabNewlineBR.UseVisualStyleBackColor = true;
            // 
            // rabNewlineCustom
            // 
            this.rabNewlineCustom.AutoSize = true;
            this.rabNewlineCustom.Location = new System.Drawing.Point(6, 111);
            this.rabNewlineCustom.Name = "rabNewlineCustom";
            this.rabNewlineCustom.Size = new System.Drawing.Size(107, 17);
            this.rabNewlineCustom.TabIndex = 4;
            this.rabNewlineCustom.Text = "Benutzerdefiniert:";
            this.rabNewlineCustom.UseVisualStyleBackColor = true;
            // 
            // grbHandleNewline
            // 
            this.grbHandleNewline.Controls.Add(this.txtNewlineCustom);
            this.grbHandleNewline.Controls.Add(this.rabNewlineSpace);
            this.grbHandleNewline.Controls.Add(this.rabNewlineCustom);
            this.grbHandleNewline.Controls.Add(this.rabNewlineLF);
            this.grbHandleNewline.Controls.Add(this.rabNewlineBR);
            this.grbHandleNewline.Controls.Add(this.rabNewlineCRLF);
            this.grbHandleNewline.Location = new System.Drawing.Point(12, 225);
            this.grbHandleNewline.Name = "grbHandleNewline";
            this.grbHandleNewline.Size = new System.Drawing.Size(300, 137);
            this.grbHandleNewline.TabIndex = 2;
            this.grbHandleNewline.TabStop = false;
            this.grbHandleNewline.Text = "Zeilenumbruch ersetzen durch:";
            // 
            // txtNewlineCustom
            // 
            this.txtNewlineCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNewlineCustom.Location = new System.Drawing.Point(119, 111);
            this.txtNewlineCustom.Name = "txtNewlineCustom";
            this.txtNewlineCustom.Size = new System.Drawing.Size(175, 20);
            this.txtNewlineCustom.TabIndex = 5;
            // 
            // grbHandleSeperator
            // 
            this.grbHandleSeperator.Controls.Add(this.txtSeperatorCustom);
            this.grbHandleSeperator.Controls.Add(this.rabSeperatorComma);
            this.grbHandleSeperator.Controls.Add(this.rabSeperatorCustom);
            this.grbHandleSeperator.Controls.Add(this.rabSeperatorSemicolon);
            this.grbHandleSeperator.Controls.Add(this.rabSeperatorTabulator);
            this.grbHandleSeperator.Location = new System.Drawing.Point(12, 106);
            this.grbHandleSeperator.Name = "grbHandleSeperator";
            this.grbHandleSeperator.Size = new System.Drawing.Size(300, 113);
            this.grbHandleSeperator.TabIndex = 1;
            this.grbHandleSeperator.TabStop = false;
            this.grbHandleSeperator.Text = "Trennzeichen:";
            // 
            // txtSeperatorCustom
            // 
            this.txtSeperatorCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSeperatorCustom.Location = new System.Drawing.Point(119, 87);
            this.txtSeperatorCustom.MaxLength = 1;
            this.txtSeperatorCustom.Name = "txtSeperatorCustom";
            this.txtSeperatorCustom.Size = new System.Drawing.Size(175, 20);
            this.txtSeperatorCustom.TabIndex = 4;
            // 
            // rabSeperatorComma
            // 
            this.rabSeperatorComma.AutoSize = true;
            this.rabSeperatorComma.Location = new System.Drawing.Point(6, 19);
            this.rabSeperatorComma.Name = "rabSeperatorComma";
            this.rabSeperatorComma.Size = new System.Drawing.Size(60, 17);
            this.rabSeperatorComma.TabIndex = 0;
            this.rabSeperatorComma.Text = "Komma";
            this.rabSeperatorComma.UseVisualStyleBackColor = true;
            // 
            // rabSeperatorCustom
            // 
            this.rabSeperatorCustom.AutoSize = true;
            this.rabSeperatorCustom.Location = new System.Drawing.Point(6, 88);
            this.rabSeperatorCustom.Name = "rabSeperatorCustom";
            this.rabSeperatorCustom.Size = new System.Drawing.Size(107, 17);
            this.rabSeperatorCustom.TabIndex = 3;
            this.rabSeperatorCustom.Text = "Benutzerdefiniert:";
            this.rabSeperatorCustom.UseVisualStyleBackColor = true;
            // 
            // rabSeperatorSemicolon
            // 
            this.rabSeperatorSemicolon.AutoSize = true;
            this.rabSeperatorSemicolon.Checked = true;
            this.rabSeperatorSemicolon.Location = new System.Drawing.Point(6, 42);
            this.rabSeperatorSemicolon.Name = "rabSeperatorSemicolon";
            this.rabSeperatorSemicolon.Size = new System.Drawing.Size(74, 17);
            this.rabSeperatorSemicolon.TabIndex = 1;
            this.rabSeperatorSemicolon.TabStop = true;
            this.rabSeperatorSemicolon.Text = "Semikolon";
            this.rabSeperatorSemicolon.UseVisualStyleBackColor = true;
            // 
            // rabSeperatorTabulator
            // 
            this.rabSeperatorTabulator.AutoSize = true;
            this.rabSeperatorTabulator.Location = new System.Drawing.Point(6, 65);
            this.rabSeperatorTabulator.Name = "rabSeperatorTabulator";
            this.rabSeperatorTabulator.Size = new System.Drawing.Size(70, 17);
            this.rabSeperatorTabulator.TabIndex = 2;
            this.rabSeperatorTabulator.Text = "Tabulator";
            this.rabSeperatorTabulator.UseVisualStyleBackColor = false;
            // 
            // grbExportScope
            // 
            this.grbExportScope.Controls.Add(this.rabExportAll);
            this.grbExportScope.Controls.Add(this.rabExportSel);
            this.grbExportScope.Controls.Add(this.rabExportFil);
            this.grbExportScope.Location = new System.Drawing.Point(12, 12);
            this.grbExportScope.Name = "grbExportScope";
            this.grbExportScope.Size = new System.Drawing.Size(300, 88);
            this.grbExportScope.TabIndex = 0;
            this.grbExportScope.TabStop = false;
            this.grbExportScope.Text = "Exportieren:";
            // 
            // rabExportAll
            // 
            this.rabExportAll.AutoSize = true;
            this.rabExportAll.Checked = true;
            this.rabExportAll.Location = new System.Drawing.Point(6, 19);
            this.rabExportAll.Name = "rabExportAll";
            this.rabExportAll.Size = new System.Drawing.Size(76, 17);
            this.rabExportAll.TabIndex = 0;
            this.rabExportAll.TabStop = true;
            this.rabExportAll.Text = "Alle Firmen";
            this.rabExportAll.UseVisualStyleBackColor = true;
            // 
            // rabExportSel
            // 
            this.rabExportSel.AutoSize = true;
            this.rabExportSel.Location = new System.Drawing.Point(6, 42);
            this.rabExportSel.Name = "rabExportSel";
            this.rabExportSel.Size = new System.Drawing.Size(120, 17);
            this.rabExportSel.TabIndex = 1;
            this.rabExportSel.Text = "Ausgewählte Firmen";
            this.rabExportSel.UseVisualStyleBackColor = true;
            // 
            // rabExportFil
            // 
            this.rabExportFil.AutoSize = true;
            this.rabExportFil.Location = new System.Drawing.Point(6, 65);
            this.rabExportFil.Name = "rabExportFil";
            this.rabExportFil.Size = new System.Drawing.Size(101, 17);
            this.rabExportFil.TabIndex = 2;
            this.rabExportFil.Text = "Gefilterte Firmen";
            this.rabExportFil.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 446);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 446);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Es werden nur die Firmendaten exportiert.\r\nNicht exportiert werden:\r\n- Bewerbunge" +
    "n\r\n- Dateianhänge\r\n- Erinnerungen\r\n- Kontakte";
            // 
            // CompanyExportForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbExportScope);
            this.Controls.Add(this.grbHandleSeperator);
            this.Controls.Add(this.grbHandleNewline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyExportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Firmen exportieren";
            this.grbHandleNewline.ResumeLayout(false);
            this.grbHandleNewline.PerformLayout();
            this.grbHandleSeperator.ResumeLayout(false);
            this.grbHandleSeperator.PerformLayout();
            this.grbExportScope.ResumeLayout(false);
            this.grbExportScope.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rabNewlineSpace;
        private System.Windows.Forms.RadioButton rabNewlineLF;
        private System.Windows.Forms.RadioButton rabNewlineCRLF;
        private System.Windows.Forms.RadioButton rabNewlineBR;
        private System.Windows.Forms.RadioButton rabNewlineCustom;
        private System.Windows.Forms.GroupBox grbHandleNewline;
        private System.Windows.Forms.TextBox txtNewlineCustom;
        private System.Windows.Forms.GroupBox grbHandleSeperator;
        private System.Windows.Forms.RadioButton rabSeperatorComma;
        private System.Windows.Forms.RadioButton rabSeperatorCustom;
        private System.Windows.Forms.RadioButton rabSeperatorSemicolon;
        private System.Windows.Forms.RadioButton rabSeperatorTabulator;
        private System.Windows.Forms.TextBox txtSeperatorCustom;
        private System.Windows.Forms.GroupBox grbExportScope;
        private System.Windows.Forms.RadioButton rabExportAll;
        private System.Windows.Forms.RadioButton rabExportSel;
        private System.Windows.Forms.RadioButton rabExportFil;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
    }
}