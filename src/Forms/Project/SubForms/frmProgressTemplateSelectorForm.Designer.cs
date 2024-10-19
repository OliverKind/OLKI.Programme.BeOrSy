namespace OLKI.Programme.BeOrSy.src.Forms.Project.SubForms
{
    partial class ProgressTemplateSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressTemplateSelectorForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lsvProgressTemplates = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvProgressTemplates_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvProgressTemplates_Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imlProgressState = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(358, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnAccept.Location = new System.Drawing.Point(12, 355);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 24);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Vorlage übernehmen";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lsvProgressTemplates
            // 
            this.lsvProgressTemplates.AllowColumnWidthChange = false;
            this.lsvProgressTemplates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvProgressTemplates.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvProgressTemplates_Title,
            this.chLsvProgressTemplates_Weight});
            this.lsvProgressTemplates.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvProgressTemplates.ColumnWidths")));
            this.lsvProgressTemplates.FullRowSelect = true;
            this.lsvProgressTemplates.GridLines = true;
            this.lsvProgressTemplates.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvProgressTemplates.HideSelection = false;
            this.lsvProgressTemplates.Location = new System.Drawing.Point(12, 12);
            this.lsvProgressTemplates.MultiSelect = false;
            this.lsvProgressTemplates.Name = "lsvProgressTemplates";
            this.lsvProgressTemplates.Size = new System.Drawing.Size(446, 337);
            this.lsvProgressTemplates.SmallImageList = this.imlProgressState;
            this.lsvProgressTemplates.TabIndex = 3;
            this.lsvProgressTemplates.UseCompatibleStateImageBehavior = false;
            this.lsvProgressTemplates.View = System.Windows.Forms.View.Details;
            this.lsvProgressTemplates.SelectedIndexChanged += new System.EventHandler(this.lsvProgressTemplates_SelectedIndexChanged);
            this.lsvProgressTemplates.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvProgressTemplates_MouseDoubleClick);
            // 
            // chLsvProgressTemplates_Title
            // 
            this.chLsvProgressTemplates_Title.Text = "Benennung";
            this.chLsvProgressTemplates_Title.Width = 330;
            // 
            // chLsvProgressTemplates_Weight
            // 
            this.chLsvProgressTemplates_Weight.Text = "Gewichtung";
            this.chLsvProgressTemplates_Weight.Width = 90;
            // 
            // imlProgressState
            // 
            this.imlProgressState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlProgressState.ImageStream")));
            this.imlProgressState.TransparentColor = System.Drawing.Color.Transparent;
            this.imlProgressState.Images.SetKeyName(0, "Progress_Active.png");
            this.imlProgressState.Images.SetKeyName(1, "Progress_Finish.png");
            this.imlProgressState.Images.SetKeyName(2, "Progress_FinishLowPriority.png");
            // 
            // ProgressTemplateSelectorForm
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(470, 391);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lsvProgressTemplates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressTemplateSelectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vorlage auswählen";
            this.Shown += new System.EventHandler(this.ProgressTemplateSelector_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private Toolbox.Widgets.SortListView lsvProgressTemplates;
        private System.Windows.Forms.ColumnHeader chLsvProgressTemplates_Weight;
        private System.Windows.Forms.ColumnHeader chLsvProgressTemplates_Title;
        private System.Windows.Forms.ImageList imlProgressState;
    }
}