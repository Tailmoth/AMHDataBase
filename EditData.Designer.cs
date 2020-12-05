﻿namespace AeroMaterialHandlingDatabaseApplication
{
    partial class fEditPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEditPage));
            this.tbEditTitle = new System.Windows.Forms.TextBox();
            this.tbEditShortDesc = new System.Windows.Forms.TextBox();
            this.btEditSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEditLongDesc = new System.Windows.Forms.TextBox();
            this.btEditClear = new System.Windows.Forms.Button();
            this.btEditExit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbEditAddTags = new System.Windows.Forms.TextBox();
            this.btTagAdd = new System.Windows.Forms.Button();
            this.gbDragDrop = new System.Windows.Forms.GroupBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btEditRemove = new System.Windows.Forms.Button();
            this.btEditAdd = new System.Windows.Forms.Button();
            this.btEditDeleteTag = new System.Windows.Forms.Button();
            this.btEditAddImage = new System.Windows.Forms.Button();
            this.pbRegister = new System.Windows.Forms.PictureBox();
            this.clbTagList = new System.Windows.Forms.ListBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbDragDrop = new System.Windows.Forms.TextBox();
            this.gbDragDrop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEditTitle
            // 
            this.tbEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditTitle.Location = new System.Drawing.Point(329, 12);
            this.tbEditTitle.Name = "tbEditTitle";
            this.tbEditTitle.Size = new System.Drawing.Size(264, 38);
            this.tbEditTitle.TabIndex = 1;
            // 
            // tbEditShortDesc
            // 
            this.tbEditShortDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEditShortDesc.Location = new System.Drawing.Point(343, 280);
            this.tbEditShortDesc.Multiline = true;
            this.tbEditShortDesc.Name = "tbEditShortDesc";
            this.tbEditShortDesc.Size = new System.Drawing.Size(350, 37);
            this.tbEditShortDesc.TabIndex = 5;
            // 
            // btEditSave
            // 
            this.btEditSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btEditSave.Location = new System.Drawing.Point(716, 408);
            this.btEditSave.Name = "btEditSave";
            this.btEditSave.Size = new System.Drawing.Size(102, 40);
            this.btEditSave.TabIndex = 9;
            this.btEditSave.Text = "Save";
            this.btEditSave.UseVisualStyleBackColor = true;
            this.btEditSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(241, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(239, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tags:";
            // 
            // tbEditLongDesc
            // 
            this.tbEditLongDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbEditLongDesc.Location = new System.Drawing.Point(343, 323);
            this.tbEditLongDesc.Multiline = true;
            this.tbEditLongDesc.Name = "tbEditLongDesc";
            this.tbEditLongDesc.Size = new System.Drawing.Size(350, 160);
            this.tbEditLongDesc.TabIndex = 36;
            // 
            // btEditClear
            // 
            this.btEditClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btEditClear.Location = new System.Drawing.Point(824, 408);
            this.btEditClear.Name = "btEditClear";
            this.btEditClear.Size = new System.Drawing.Size(102, 40);
            this.btEditClear.TabIndex = 37;
            this.btEditClear.Text = "Clear";
            this.btEditClear.UseVisualStyleBackColor = true;
            this.btEditClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btEditExit
            // 
            this.btEditExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btEditExit.Location = new System.Drawing.Point(932, 408);
            this.btEditExit.Name = "btEditExit";
            this.btEditExit.Size = new System.Drawing.Size(102, 40);
            this.btEditExit.TabIndex = 38;
            this.btEditExit.Text = "Exit";
            this.btEditExit.UseVisualStyleBackColor = true;
            this.btEditExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label15.Location = new System.Drawing.Point(106, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(231, 31);
            this.label15.TabIndex = 39;
            this.label15.Text = "Short Description:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label16.Location = new System.Drawing.Point(111, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(226, 31);
            this.label16.TabIndex = 40;
            this.label16.Text = "Long Description:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // tbEditAddTags
            // 
            this.tbEditAddTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEditAddTags.Location = new System.Drawing.Point(329, 87);
            this.tbEditAddTags.Name = "tbEditAddTags";
            this.tbEditAddTags.Size = new System.Drawing.Size(206, 44);
            this.tbEditAddTags.TabIndex = 41;
            // 
            // btTagAdd
            // 
            this.btTagAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTagAdd.Location = new System.Drawing.Point(541, 94);
            this.btTagAdd.Name = "btTagAdd";
            this.btTagAdd.Size = new System.Drawing.Size(119, 37);
            this.btTagAdd.TabIndex = 43;
            this.btTagAdd.Text = "Add Tag";
            this.btTagAdd.UseVisualStyleBackColor = true;
            this.btTagAdd.Click += new System.EventHandler(this.btTagAdd_Click);
            // 
            // gbDragDrop
            // 
            this.gbDragDrop.Controls.Add(this.tbDragDrop);
            this.gbDragDrop.Controls.Add(this.pbUser);
            this.gbDragDrop.Controls.Add(this.label3);
            this.gbDragDrop.Location = new System.Drawing.Point(765, 15);
            this.gbDragDrop.Name = "gbDragDrop";
            this.gbDragDrop.Size = new System.Drawing.Size(229, 324);
            this.gbDragDrop.TabIndex = 44;
            this.gbDragDrop.TabStop = false;
            this.gbDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.groupBox1_DragDrop);
            this.gbDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.gbDragDrop_DragEnter);
            this.gbDragDrop.DragOver += new System.Windows.Forms.DragEventHandler(this.gbDragDrop_DragOver);
            // 
            // pbUser
            // 
            this.pbUser.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Hook_only_HD_Black_Shadow_Transparent_406_;
            this.pbUser.Location = new System.Drawing.Point(45, 50);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(80, 53);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 5;
            this.pbUser.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(41, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Drag files over hook";
            // 
            // btEditRemove
            // 
            this.btEditRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btEditRemove.Location = new System.Drawing.Point(882, 362);
            this.btEditRemove.Name = "btEditRemove";
            this.btEditRemove.Size = new System.Drawing.Size(123, 40);
            this.btEditRemove.TabIndex = 45;
            this.btEditRemove.Text = "Remove";
            this.btEditRemove.UseVisualStyleBackColor = true;
            // 
            // btEditAdd
            // 
            this.btEditAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btEditAdd.Location = new System.Drawing.Point(754, 362);
            this.btEditAdd.Name = "btEditAdd";
            this.btEditAdd.Size = new System.Drawing.Size(107, 40);
            this.btEditAdd.TabIndex = 46;
            this.btEditAdd.Text = "Add";
            this.btEditAdd.UseVisualStyleBackColor = true;
            this.btEditAdd.Click += new System.EventHandler(this.btEditAdd_Click);
            // 
            // btEditDeleteTag
            // 
            this.btEditDeleteTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditDeleteTag.Location = new System.Drawing.Point(541, 137);
            this.btEditDeleteTag.Name = "btEditDeleteTag";
            this.btEditDeleteTag.Size = new System.Drawing.Size(119, 43);
            this.btEditDeleteTag.TabIndex = 47;
            this.btEditDeleteTag.Text = "Delete";
            this.btEditDeleteTag.UseVisualStyleBackColor = true;
            this.btEditDeleteTag.Click += new System.EventHandler(this.btEditDeleteTag_Click);
            // 
            // btEditAddImage
            // 
            this.btEditAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditAddImage.Location = new System.Drawing.Point(45, 212);
            this.btEditAddImage.Name = "btEditAddImage";
            this.btEditAddImage.Size = new System.Drawing.Size(137, 39);
            this.btEditAddImage.TabIndex = 48;
            this.btEditAddImage.Text = "Add Image";
            this.btEditAddImage.UseVisualStyleBackColor = true;
            this.btEditAddImage.Click += new System.EventHandler(this.btEditAddImage_Click);
            // 
            // pbRegister
            // 
            this.pbRegister.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbRegister.Location = new System.Drawing.Point(12, 12);
            this.pbRegister.Name = "pbRegister";
            this.pbRegister.Size = new System.Drawing.Size(221, 194);
            this.pbRegister.TabIndex = 10;
            this.pbRegister.TabStop = false;
            this.pbRegister.Click += new System.EventHandler(this.pbRegister_Click);
            // 
            // clbTagList
            // 
            this.clbTagList.FormattingEnabled = true;
            this.clbTagList.Location = new System.Drawing.Point(329, 138);
            this.clbTagList.Name = "clbTagList";
            this.clbTagList.Size = new System.Drawing.Size(206, 69);
            this.clbTagList.TabIndex = 49;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::AeroMaterialHandlingDatabaseApplication.Properties.Resources.Logo_Complete_Short_Hook_Transparent_300dpi_405_;
            this.pbLogo.Location = new System.Drawing.Point(88, 394);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(164, 139);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 50;
            this.pbLogo.TabStop = false;
            // 
            // tbDragDrop
            // 
            this.tbDragDrop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tbDragDrop.Location = new System.Drawing.Point(17, 122);
            this.tbDragDrop.Multiline = true;
            this.tbDragDrop.Name = "tbDragDrop";
            this.tbDragDrop.Size = new System.Drawing.Size(195, 180);
            this.tbDragDrop.TabIndex = 6;
            // 
            // fEditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1057, 559);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.clbTagList);
            this.Controls.Add(this.btEditAddImage);
            this.Controls.Add(this.btEditDeleteTag);
            this.Controls.Add(this.btEditAdd);
            this.Controls.Add(this.btEditRemove);
            this.Controls.Add(this.gbDragDrop);
            this.Controls.Add(this.btTagAdd);
            this.Controls.Add(this.tbEditAddTags);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btEditExit);
            this.Controls.Add(this.btEditClear);
            this.Controls.Add(this.tbEditLongDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbRegister);
            this.Controls.Add(this.btEditSave);
            this.Controls.Add(this.tbEditShortDesc);
            this.Controls.Add(this.tbEditTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fEditPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Page";
            this.Load += new System.EventHandler(this.fEditPage_Load);
            this.gbDragDrop.ResumeLayout(false);
            this.gbDragDrop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEditTitle;
        private System.Windows.Forms.TextBox tbEditShortDesc;
        private System.Windows.Forms.Button btEditSave;
        private System.Windows.Forms.PictureBox pbRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEditLongDesc;
        private System.Windows.Forms.Button btEditClear;
        private System.Windows.Forms.Button btEditExit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbEditAddTags;
        private System.Windows.Forms.Button btTagAdd;
        private System.Windows.Forms.GroupBox gbDragDrop;
        private System.Windows.Forms.Button btEditRemove;
        private System.Windows.Forms.Button btEditAdd;
        private System.Windows.Forms.Button btEditDeleteTag;
        private System.Windows.Forms.Button btEditAddImage;
        private System.Windows.Forms.ListBox clbTagList;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.TextBox tbDragDrop;
    }
}