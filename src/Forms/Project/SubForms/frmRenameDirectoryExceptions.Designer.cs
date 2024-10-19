namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class RenameDirectoryExceptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameDirectoryExceptions));
            this.label1 = new System.Windows.Forms.Label();
            this.lsvRenameExceptions = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvRenameError_SrcPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvRenameError_DestPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvRenameError_Exception = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlRenameExceptions = new System.Windows.Forms.ImageList(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDestPathGoTo = new System.Windows.Forms.Button();
            this.btnSrcPathGoTo = new System.Windows.Forms.Button();
            this.lblException = new System.Windows.Forms.Label();
            this.txtException = new System.Windows.Forms.TextBox();
            this.lblDestPathGoTo = new System.Windows.Forms.Label();
            this.txtDestPath = new System.Windows.Forms.TextBox();
            this.txtSrcPath = new System.Windows.Forms.TextBox();
            this.lblSrcPath = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Einige Ordner konnten nicht umbenannt werden.";
            // 
            // lsvRenameExceptions
            // 
            this.lsvRenameExceptions.AllowDragAndDropSort = true;
            this.lsvRenameExceptions.AllowDrop = true;
            this.lsvRenameExceptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvRenameExceptions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvRenameError_SrcPath,
            this.chLsvRenameError_DestPath,
            this.chLsvRenameError_Exception});
            this.lsvRenameExceptions.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvRenameExceptions.ColumnWidths")));
            this.lsvRenameExceptions.FullRowSelect = true;
            this.lsvRenameExceptions.GridLines = true;
            this.lsvRenameExceptions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvRenameExceptions.HideSelection = false;
            this.lsvRenameExceptions.Location = new System.Drawing.Point(12, 25);
            this.lsvRenameExceptions.MultiSelect = false;
            this.lsvRenameExceptions.Name = "lsvRenameExceptions";
            this.lsvRenameExceptions.Size = new System.Drawing.Size(776, 279);
            this.lsvRenameExceptions.SmallImageList = this.imlRenameExceptions;
            this.lsvRenameExceptions.TabIndex = 1;
            this.lsvRenameExceptions.UseCompatibleStateImageBehavior = false;
            this.lsvRenameExceptions.View = System.Windows.Forms.View.Details;
            this.lsvRenameExceptions.SelectedIndexChanged += new System.EventHandler(this.lsvRenameExceptions_SelectedIndexChanged);
            // 
            // chLsvRenameError_SrcPath
            // 
            this.chLsvRenameError_SrcPath.Text = "Quelleordner";
            this.chLsvRenameError_SrcPath.Width = 250;
            // 
            // chLsvRenameError_DestPath
            // 
            this.chLsvRenameError_DestPath.Text = "Zielordner";
            this.chLsvRenameError_DestPath.Width = 250;
            // 
            // chLsvRenameError_Exception
            // 
            this.chLsvRenameError_Exception.Text = "Fehler";
            this.chLsvRenameError_Exception.Width = 200;
            // 
            // imlRenameExceptions
            // 
            this.imlRenameExceptions.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlRenameExceptions.ImageStream")));
            this.imlRenameExceptions.TransparentColor = System.Drawing.Color.Transparent;
            this.imlRenameExceptions.Images.SetKeyName(0, "Company.png");
            this.imlRenameExceptions.Images.SetKeyName(1, "Application.png");
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 426);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(776, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "&Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDestPathGoTo
            // 
            this.btnDestPathGoTo.Image = ((System.Drawing.Image)(resources.GetObject("btnDestPathGoTo.Image")));
            this.btnDestPathGoTo.Location = new System.Drawing.Point(753, 336);
            this.btnDestPathGoTo.Name = "btnDestPathGoTo";
            this.btnDestPathGoTo.Size = new System.Drawing.Size(35, 24);
            this.btnDestPathGoTo.TabIndex = 7;
            this.btnDestPathGoTo.UseVisualStyleBackColor = true;
            this.btnDestPathGoTo.Click += new System.EventHandler(this.btnDestPathGoTo_Click);
            // 
            // btnSrcPathGoTo
            // 
            this.btnSrcPathGoTo.Image = ((System.Drawing.Image)(resources.GetObject("btnSrcPathGoTo.Image")));
            this.btnSrcPathGoTo.Location = new System.Drawing.Point(753, 306);
            this.btnSrcPathGoTo.Name = "btnSrcPathGoTo";
            this.btnSrcPathGoTo.Size = new System.Drawing.Size(35, 24);
            this.btnSrcPathGoTo.TabIndex = 4;
            this.btnSrcPathGoTo.UseVisualStyleBackColor = true;
            this.btnSrcPathGoTo.Click += new System.EventHandler(this.btnSrcPathGoTo_Click);
            // 
            // lblException
            // 
            this.lblException.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(12, 365);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(39, 13);
            this.lblException.TabIndex = 8;
            this.lblException.Text = "Fehler:";
            // 
            // txtException
            // 
            this.txtException.Location = new System.Drawing.Point(58, 362);
            this.txtException.Multiline = true;
            this.txtException.Name = "txtException";
            this.txtException.ReadOnly = true;
            this.txtException.Size = new System.Drawing.Size(730, 58);
            this.txtException.TabIndex = 9;
            // 
            // lblDestPathGoTo
            // 
            this.lblDestPathGoTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDestPathGoTo.AutoSize = true;
            this.lblDestPathGoTo.Location = new System.Drawing.Point(12, 339);
            this.lblDestPathGoTo.Name = "lblDestPathGoTo";
            this.lblDestPathGoTo.Size = new System.Drawing.Size(27, 13);
            this.lblDestPathGoTo.TabIndex = 5;
            this.lblDestPathGoTo.Text = "Ziel:";
            // 
            // txtDestPath
            // 
            this.txtDestPath.Location = new System.Drawing.Point(58, 336);
            this.txtDestPath.Name = "txtDestPath";
            this.txtDestPath.ReadOnly = true;
            this.txtDestPath.Size = new System.Drawing.Size(689, 20);
            this.txtDestPath.TabIndex = 6;
            // 
            // txtSrcPath
            // 
            this.txtSrcPath.Location = new System.Drawing.Point(58, 310);
            this.txtSrcPath.Name = "txtSrcPath";
            this.txtSrcPath.ReadOnly = true;
            this.txtSrcPath.Size = new System.Drawing.Size(689, 20);
            this.txtSrcPath.TabIndex = 3;
            // 
            // lblSrcPath
            // 
            this.lblSrcPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSrcPath.AutoSize = true;
            this.lblSrcPath.Location = new System.Drawing.Point(12, 313);
            this.lblSrcPath.Name = "lblSrcPath";
            this.lblSrcPath.Size = new System.Drawing.Size(40, 13);
            this.lblSrcPath.TabIndex = 2;
            this.lblSrcPath.Text = "Quelle:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(688, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RenameDirectoryExceptions
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDestPathGoTo);
            this.Controls.Add(this.btnSrcPathGoTo);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.txtException);
            this.Controls.Add(this.lblDestPathGoTo);
            this.Controls.Add(this.txtDestPath);
            this.Controls.Add(this.txtSrcPath);
            this.Controls.Add(this.lblSrcPath);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lsvRenameExceptions);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenameDirectoryExceptions";
            this.Text = "Fehler beim Umbenennen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Toolbox.Widgets.SortListView lsvRenameExceptions;
        private System.Windows.Forms.ColumnHeader chLsvRenameError_SrcPath;
        private System.Windows.Forms.ColumnHeader chLsvRenameError_DestPath;
        private System.Windows.Forms.ColumnHeader chLsvRenameError_Exception;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDestPathGoTo;
        private System.Windows.Forms.Button btnSrcPathGoTo;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.TextBox txtException;
        private System.Windows.Forms.Label lblDestPathGoTo;
        private System.Windows.Forms.TextBox txtDestPath;
        private System.Windows.Forms.TextBox txtSrcPath;
        private System.Windows.Forms.Label lblSrcPath;
        private System.Windows.Forms.ImageList imlRenameExceptions;
        private System.Windows.Forms.Button btnCancel;
    }
}