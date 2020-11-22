namespace AeroMaterialHandlingDatabaseApplication
{
    partial class fViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fViewPage));
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scDivide = new System.Windows.Forms.SplitContainer();
            this.flp1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnSearchResult = new System.Windows.Forms.Panel();
            this.tbViewLongDescription = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.lbViewTittle = new System.Windows.Forms.Label();
            this.tbViewShortDescription = new System.Windows.Forms.TextBox();
            this.pbDisplayImage = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btNewEntry = new System.Windows.Forms.Button();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btLogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDivide)).BeginInit();
            this.scDivide.Panel1.SuspendLayout();
            this.scDivide.Panel2.SuspendLayout();
            this.scDivide.SuspendLayout();
            this.pnSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "Radio",
            "2 Button",
            "FLEX",
            "Megnetek",
            "FLEX DUO",
            "MRX",
            "OSHA 1910.179",
            "INSPECTIONS",
            "REQUIREMENTS",
            "FLAT",
            "CABLE",
            "GRIP",
            "REMKE",
            "DOW",
            "PE",
            "Power Electronics",
            "Explosion proof",
            "Classified Environment",
            "Control Panel",
            "Control Enclosure",
            "DISC",
            "Personality",
            "Assessment",
            "CUSTOMER",
            "ID",
            "CODES",
            "KEY",
            "LEGEND",
            "DATABASE",
            "OSHA",
            "INSPECTION",
            "CHECKLIST",
            "MHI",
            "Load Swing",
            "Swing Manager",
            "Harrington",
            "Mini hand Chain hoist"});
            this.tbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(584, 63);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(747, 53);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(1367, 64);
            this.btSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(173, 54);
            this.btSearch.TabIndex = 2;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scDivide);
            this.groupBox1.Location = new System.Drawing.Point(16, 196);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(2080, 690);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // scDivide
            // 
            this.scDivide.BackColor = System.Drawing.Color.Yellow;
            this.scDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scDivide.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scDivide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scDivide.IsSplitterFixed = true;
            this.scDivide.Location = new System.Drawing.Point(4, 19);
            this.scDivide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scDivide.Name = "scDivide";
            // 
            // scDivide.Panel1
            // 
            this.scDivide.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scDivide.Panel1.Controls.Add(this.flp1);
            this.scDivide.Panel1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scDivide.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.scDivide.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.scDivide_Panel1_MouseClick);
            // 
            // scDivide.Panel2
            // 
            this.scDivide.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scDivide.Panel2.Controls.Add(this.pnSearchResult);
            this.scDivide.Panel2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scDivide.Size = new System.Drawing.Size(2072, 667);
            this.scDivide.SplitterDistance = 717;
            this.scDivide.SplitterWidth = 5;
            this.scDivide.TabIndex = 0;
            this.scDivide.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.scDivide_SplitterMoved);
            // 
            // flp1
            // 
            this.flp1.AutoScroll = true;
            this.flp1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flp1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp1.Location = new System.Drawing.Point(23, 21);
            this.flp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp1.Name = "flp1";
            this.flp1.Size = new System.Drawing.Size(1177, 626);
            this.flp1.TabIndex = 0;
            this.flp1.WrapContents = false;
            this.flp1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel_MouseClick);
            // 
            // pnSearchResult
            // 
            this.pnSearchResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnSearchResult.Controls.Add(this.tbViewLongDescription);
            this.pnSearchResult.Controls.Add(this.lblTags);
            this.pnSearchResult.Controls.Add(this.btEdit);
            this.pnSearchResult.Controls.Add(this.lbViewTittle);
            this.pnSearchResult.Controls.Add(this.tbViewShortDescription);
            this.pnSearchResult.Controls.Add(this.pbDisplayImage);
            this.pnSearchResult.Controls.Add(this.groupBox2);
            this.pnSearchResult.Location = new System.Drawing.Point(0, 21);
            this.pnSearchResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnSearchResult.Name = "pnSearchResult";
            this.pnSearchResult.Size = new System.Drawing.Size(1775, 626);
            this.pnSearchResult.TabIndex = 0;
            this.pnSearchResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnSearchResult_MouseClick);
            // 
            // tbViewLongDescription
            // 
            this.tbViewLongDescription.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbViewLongDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbViewLongDescription.Location = new System.Drawing.Point(372, 260);
            this.tbViewLongDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbViewLongDescription.Multiline = true;
            this.tbViewLongDescription.Name = "tbViewLongDescription";
            this.tbViewLongDescription.Size = new System.Drawing.Size(908, 306);
            this.tbViewLongDescription.TabIndex = 12;
            this.tbViewLongDescription.Text = resources.GetString("tbViewLongDescription.Text");
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(367, 580);
            this.lblTags.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(176, 29);
            this.lblTags.TabIndex = 14;
            this.lblTags.Text = "Tags: SAMPLE";
            // 
            // btEdit
            // 
            this.btEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.Location = new System.Drawing.Point(1669, 580);
            this.btEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(73, 43);
            this.btEdit.TabIndex = 15;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // lbViewTittle
            // 
            this.lbViewTittle.AutoSize = true;
            this.lbViewTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewTittle.Location = new System.Drawing.Point(365, 38);
            this.lbViewTittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbViewTittle.Name = "lbViewTittle";
            this.lbViewTittle.Size = new System.Drawing.Size(71, 36);
            this.lbViewTittle.TabIndex = 1;
            this.lbViewTittle.Text = "Title";
            // 
            // tbViewShortDescription
            // 
            this.tbViewShortDescription.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbViewShortDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbViewShortDescription.Location = new System.Drawing.Point(372, 100);
            this.tbViewShortDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbViewShortDescription.Multiline = true;
            this.tbViewShortDescription.Name = "tbViewShortDescription";
            this.tbViewShortDescription.Size = new System.Drawing.Size(908, 152);
            this.tbViewShortDescription.TabIndex = 16;
            this.tbViewShortDescription.Text = "This is for the short description.";
            // 
            // pbDisplayImage
            // 
            this.pbDisplayImage.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Logo_Complete_Short_Hook_Transparent_300dpi_405_;
            this.pbDisplayImage.InitialImage = null;
            this.pbDisplayImage.Location = new System.Drawing.Point(7, 4);
            this.pbDisplayImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDisplayImage.Name = "pbDisplayImage";
            this.pbDisplayImage.Size = new System.Drawing.Size(199, 167);
            this.pbDisplayImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDisplayImage.TabIndex = 0;
            this.pbDisplayImage.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1452, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(291, 561);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btNewEntry
            // 
            this.btNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewEntry.Location = new System.Drawing.Point(1765, 148);
            this.btNewEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNewEntry.Name = "btNewEntry";
            this.btNewEntry.Size = new System.Drawing.Size(119, 41);
            this.btNewEntry.TabIndex = 6;
            this.btNewEntry.Text = "New Entry";
            this.btNewEntry.UseVisualStyleBackColor = true;
            this.btNewEntry.Click += new System.EventHandler(this.btNewEntry_Click);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Hook_only_HD_Black_Shadow_Transparent_406_;
            this.pbUser.Location = new System.Drawing.Point(1904, 15);
            this.pbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(192, 156);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 4;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Logo_Complete_Short_Hook_Transparent_300dpi_405_;
            this.pbLogo.Location = new System.Drawing.Point(16, 15);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(204, 156);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // btLogout
            // 
            this.btLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btLogout.Location = new System.Drawing.Point(1951, 894);
            this.btLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(141, 38);
            this.btLogout.TabIndex = 7;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // fViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1924, 937);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.btNewEntry);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbUser);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fViewPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aero Material Handling";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.scDivide.Panel1.ResumeLayout(false);
            this.scDivide.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDivide)).EndInit();
            this.scDivide.ResumeLayout(false);
            this.pnSearchResult.ResumeLayout(false);
            this.pnSearchResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDisplayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer scDivide;
        private System.Windows.Forms.TextBox tbViewLongDescription;
        private System.Windows.Forms.Label lbViewTittle;
        private System.Windows.Forms.PictureBox pbDisplayImage;
        private System.Windows.Forms.Button btNewEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox tbViewShortDescription;
        private System.Windows.Forms.FlowLayoutPanel flp1;
        private System.Windows.Forms.Panel pnSearchResult;
        private System.Windows.Forms.Button btLogout;
    }
}