namespace OLKI.Programme.BeOrSy.src.Forms.PostcodeManger
{
    partial class PostcodeSelectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostcodeSelectorForm));
            this.imlPostcodeSearch = new System.Windows.Forms.ImageList(this.components);
            this.lblSelectPostcode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lsvSelectPostcode = new OLKI.Toolbox.Widgets.SortListView();
            this.chLsvSelectPostcode_Postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvSelectPostcode_City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvSelectPostcode_State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLsvSelectPostcode_Nation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // imlPostcodeSearch
            // 
            this.imlPostcodeSearch.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlPostcodeSearch.ImageStream")));
            this.imlPostcodeSearch.TransparentColor = System.Drawing.Color.Transparent;
            this.imlPostcodeSearch.Images.SetKeyName(0, "PostcodeSearch.png");
            // 
            // lblSelectPostcode
            // 
            this.lblSelectPostcode.AutoSize = true;
            this.lblSelectPostcode.Location = new System.Drawing.Point(12, 9);
            this.lblSelectPostcode.Name = "lblSelectPostcode";
            this.lblSelectPostcode.Size = new System.Drawing.Size(453, 13);
            this.lblSelectPostcode.TabIndex = 4;
            this.lblSelectPostcode.Text = "Zu der Postleitzahl {0} gibt es mehrere Übereinstimmungen. Bitte wählen Sie die p" +
    "assende aus.";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(592, 236);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "&Abbrechen";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Image = global::OLKI.Programme.BeOrSy.Properties.Resources.Ok;
            this.btnOk.Location = new System.Drawing.Point(12, 236);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(110, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "&OK";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lsvSelectPostcode
            // 
            this.lsvSelectPostcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lsvSelectPostcode.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chLsvSelectPostcode_Postcode,
            this.chLsvSelectPostcode_City,
            this.chLsvSelectPostcode_State,
            this.chLsvSelectPostcode_Nation});
            this.lsvSelectPostcode.ColumnWidths = ((System.Collections.Generic.List<int>)(resources.GetObject("lsvSelectPostcode.ColumnWidths")));
            this.lsvSelectPostcode.FullRowSelect = true;
            this.lsvSelectPostcode.GridLines = true;
            this.lsvSelectPostcode.HideSelection = false;
            this.lsvSelectPostcode.Location = new System.Drawing.Point(12, 25);
            this.lsvSelectPostcode.MultiSelect = false;
            this.lsvSelectPostcode.Name = "lsvSelectPostcode";
            this.lsvSelectPostcode.Size = new System.Drawing.Size(690, 205);
            this.lsvSelectPostcode.SmallImageList = this.imlPostcodeSearch;
            this.lsvSelectPostcode.TabIndex = 5;
            this.lsvSelectPostcode.UseCompatibleStateImageBehavior = false;
            this.lsvSelectPostcode.View = System.Windows.Forms.View.Details;
            this.lsvSelectPostcode.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvSelectPostcode_ColumnClick);
            this.lsvSelectPostcode.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.lsvSelectPostcode_ColumnWidthChanged);
            this.lsvSelectPostcode.SelectedIndexChanged += new System.EventHandler(this.lsvSelectPostcode_SelectedIndexChanged);
            this.lsvSelectPostcode.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsvSelectPostcode_MouseDoubleClick);
            // 
            // chLsvSelectPostcode_Postcode
            // 
            this.chLsvSelectPostcode_Postcode.Text = "Postleitzahl";
            this.chLsvSelectPostcode_Postcode.Width = 120;
            // 
            // chLsvSelectPostcode_City
            // 
            this.chLsvSelectPostcode_City.Text = "Stadt";
            this.chLsvSelectPostcode_City.Width = 180;
            // 
            // chLsvSelectPostcode_State
            // 
            this.chLsvSelectPostcode_State.Text = "Bundesland";
            this.chLsvSelectPostcode_State.Width = 180;
            // 
            // chLsvSelectPostcode_Nation
            // 
            this.chLsvSelectPostcode_Nation.Text = "Land";
            this.chLsvSelectPostcode_Nation.Width = 180;
            // 
            // PostcodeSelectorForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(714, 271);
            this.Controls.Add(this.lsvSelectPostcode);
            this.Controls.Add(this.lblSelectPostcode);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PostcodeSelectorForm";
            this.Text = "Bitte auswählen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Toolbox.Widgets.SortListView lsvSelectPostcode;
        private System.Windows.Forms.ColumnHeader chLsvSelectPostcode_Postcode;
        private System.Windows.Forms.ColumnHeader chLsvSelectPostcode_City;
        private System.Windows.Forms.ColumnHeader chLsvSelectPostcode_State;
        private System.Windows.Forms.ColumnHeader chLsvSelectPostcode_Nation;
        private System.Windows.Forms.Label lblSelectPostcode;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ImageList imlPostcodeSearch;
    }
}