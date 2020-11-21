namespace SiteRecipe.WinForms
{
    partial class frmManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCategories));
            this.NewCatGrBox = new System.Windows.Forms.GroupBox();
            this.CatNameLbl = new System.Windows.Forms.Label();
            this.CatNameTxt = new System.Windows.Forms.TextBox();
            this.RemoveCatGrBox = new System.Windows.Forms.GroupBox();
            this.CatChckLstBox = new System.Windows.Forms.CheckedListBox();
            this.UpdateCatGrBox = new System.Windows.Forms.GroupBox();
            this.NewNameCatLbl = new System.Windows.Forms.Label();
            this.NewNameCatTxt = new System.Windows.Forms.TextBox();
            this.CatListBox = new System.Windows.Forms.ListBox();
            this.SaveCatBtn = new System.Windows.Forms.Button();
            this.NewCatGrBox.SuspendLayout();
            this.RemoveCatGrBox.SuspendLayout();
            this.UpdateCatGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewCatGrBox
            // 
            this.NewCatGrBox.Controls.Add(this.CatNameLbl);
            this.NewCatGrBox.Controls.Add(this.CatNameTxt);
            this.NewCatGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewCatGrBox.Location = new System.Drawing.Point(12, 12);
            this.NewCatGrBox.Name = "NewCatGrBox";
            this.NewCatGrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewCatGrBox.Size = new System.Drawing.Size(325, 85);
            this.NewCatGrBox.TabIndex = 0;
            this.NewCatGrBox.TabStop = false;
            this.NewCatGrBox.Text = "New Category";
            // 
            // CatNameLbl
            // 
            this.CatNameLbl.AutoSize = true;
            this.CatNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CatNameLbl.Location = new System.Drawing.Point(30, 14);
            this.CatNameLbl.Name = "CatNameLbl";
            this.CatNameLbl.Size = new System.Drawing.Size(41, 15);
            this.CatNameLbl.TabIndex = 53;
            this.CatNameLbl.Text = "Name";
            // 
            // CatNameTxt
            // 
            this.CatNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTxt.Location = new System.Drawing.Point(30, 34);
            this.CatNameTxt.Name = "CatNameTxt";
            this.CatNameTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CatNameTxt.Size = new System.Drawing.Size(265, 24);
            this.CatNameTxt.TabIndex = 1;
            // 
            // RemoveCatGrBox
            // 
            this.RemoveCatGrBox.Controls.Add(this.CatChckLstBox);
            this.RemoveCatGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveCatGrBox.Location = new System.Drawing.Point(12, 110);
            this.RemoveCatGrBox.Name = "RemoveCatGrBox";
            this.RemoveCatGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveCatGrBox.Size = new System.Drawing.Size(325, 197);
            this.RemoveCatGrBox.TabIndex = 55;
            this.RemoveCatGrBox.TabStop = false;
            this.RemoveCatGrBox.Text = "Remove Category";
            // 
            // CatChckLstBox
            // 
            this.CatChckLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatChckLstBox.FormattingEnabled = true;
            this.CatChckLstBox.Location = new System.Drawing.Point(30, 33);
            this.CatChckLstBox.Name = "CatChckLstBox";
            this.CatChckLstBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CatChckLstBox.ScrollAlwaysVisible = true;
            this.CatChckLstBox.Size = new System.Drawing.Size(265, 137);
            this.CatChckLstBox.TabIndex = 4;
            // 
            // UpdateCatGrBox
            // 
            this.UpdateCatGrBox.Controls.Add(this.NewNameCatLbl);
            this.UpdateCatGrBox.Controls.Add(this.NewNameCatTxt);
            this.UpdateCatGrBox.Controls.Add(this.CatListBox);
            this.UpdateCatGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCatGrBox.Location = new System.Drawing.Point(359, 12);
            this.UpdateCatGrBox.Name = "UpdateCatGrBox";
            this.UpdateCatGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateCatGrBox.Size = new System.Drawing.Size(325, 295);
            this.UpdateCatGrBox.TabIndex = 56;
            this.UpdateCatGrBox.TabStop = false;
            this.UpdateCatGrBox.Text = "Update Category";
            // 
            // NewNameCatLbl
            // 
            this.NewNameCatLbl.AutoSize = true;
            this.NewNameCatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameCatLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NewNameCatLbl.Location = new System.Drawing.Point(30, 222);
            this.NewNameCatLbl.Name = "NewNameCatLbl";
            this.NewNameCatLbl.Size = new System.Drawing.Size(41, 15);
            this.NewNameCatLbl.TabIndex = 46;
            this.NewNameCatLbl.Text = "Name";
            // 
            // NewNameCatTxt
            // 
            this.NewNameCatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewNameCatTxt.Location = new System.Drawing.Point(30, 242);
            this.NewNameCatTxt.Name = "NewNameCatTxt";
            this.NewNameCatTxt.Size = new System.Drawing.Size(265, 24);
            this.NewNameCatTxt.TabIndex = 3;
            // 
            // CatListBox
            // 
            this.CatListBox.AllowDrop = true;
            this.CatListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatListBox.FormattingEnabled = true;
            this.CatListBox.ItemHeight = 18;
            this.CatListBox.Location = new System.Drawing.Point(30, 34);
            this.CatListBox.Name = "CatListBox";
            this.CatListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CatListBox.ScrollAlwaysVisible = true;
            this.CatListBox.Size = new System.Drawing.Size(265, 130);
            this.CatListBox.TabIndex = 2;
            // 
            // SaveCatBtn
            // 
            this.SaveCatBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveCatBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveCatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCatBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveCatBtn.Location = new System.Drawing.Point(280, 326);
            this.SaveCatBtn.Name = "SaveCatBtn";
            this.SaveCatBtn.Size = new System.Drawing.Size(136, 29);
            this.SaveCatBtn.TabIndex = 57;
            this.SaveCatBtn.Text = "Save";
            this.SaveCatBtn.UseVisualStyleBackColor = false;
            // 
            // frmManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(696, 377);
            this.Controls.Add(this.SaveCatBtn);
            this.Controls.Add(this.UpdateCatGrBox);
            this.Controls.Add(this.RemoveCatGrBox);
            this.Controls.Add(this.NewCatGrBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Categories";
            this.NewCatGrBox.ResumeLayout(false);
            this.NewCatGrBox.PerformLayout();
            this.RemoveCatGrBox.ResumeLayout(false);
            this.UpdateCatGrBox.ResumeLayout(false);
            this.UpdateCatGrBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox NewCatGrBox;
        private System.Windows.Forms.Label CatNameLbl;
        private System.Windows.Forms.TextBox CatNameTxt;
        private System.Windows.Forms.GroupBox RemoveCatGrBox;
        private System.Windows.Forms.CheckedListBox CatChckLstBox;
        private System.Windows.Forms.GroupBox UpdateCatGrBox;
        private System.Windows.Forms.Label NewNameCatLbl;
        private System.Windows.Forms.TextBox NewNameCatTxt;
        private System.Windows.Forms.ListBox CatListBox;
        private System.Windows.Forms.Button SaveCatBtn;
    }
}