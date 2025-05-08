namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class CompanyImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyImportForm));
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.grbHandleNewline.SuspendLayout();
            this.grbHandleSeperator.SuspendLayout();
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
            this.grbHandleNewline.Location = new System.Drawing.Point(12, 131);
            this.grbHandleNewline.Name = "grbHandleNewline";
            this.grbHandleNewline.Size = new System.Drawing.Size(300, 137);
            this.grbHandleNewline.TabIndex = 2;
            this.grbHandleNewline.TabStop = false;
            this.grbHandleNewline.Text = "Zeilenumbruch wurde ersetzt durch:";
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
            this.grbHandleSeperator.Location = new System.Drawing.Point(12, 12);
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
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(202, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 274);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // CompanyImportForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(324, 309);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grbHandleSeperator);
            this.Controls.Add(this.grbHandleNewline);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompanyImportForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Firmen importieren";
            this.grbHandleNewline.ResumeLayout(false);
            this.grbHandleNewline.PerformLayout();
            this.grbHandleSeperator.ResumeLayout(false);
            this.grbHandleSeperator.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}