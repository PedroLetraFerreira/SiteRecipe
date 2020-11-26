namespace SiteRecipe.WinForms
{
    partial class frmSearchUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchUser));
            this.UserCbBox = new System.Windows.Forms.ComboBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UserRecipesGrBox = new System.Windows.Forms.GroupBox();
            this.UserRecipesLstBox = new System.Windows.Forms.ListBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.firstNLbl = new System.Windows.Forms.Label();
            this.lastNLbl = new System.Windows.Forms.Label();
            this.emailOneLbl = new System.Windows.Forms.Label();
            this.countryOneLbl = new System.Windows.Forms.Label();
            this.birthDateOneLbl = new System.Windows.Forms.Label();
            this.GenderOneLbl = new System.Windows.Forms.Label();
            this.UserRecipesGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserCbBox
            // 
            this.UserCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserCbBox.FormattingEnabled = true;
            this.UserCbBox.Location = new System.Drawing.Point(40, 46);
            this.UserCbBox.Name = "UserCbBox";
            this.UserCbBox.Size = new System.Drawing.Size(265, 26);
            this.UserCbBox.TabIndex = 7;
            this.UserCbBox.SelectedIndexChanged += new System.EventHandler(this.UserCbBox_SelectedIndexChanged);
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FirstNameLbl.Location = new System.Drawing.Point(40, 157);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(70, 15);
            this.FirstNameLbl.TabIndex = 69;
            this.FirstNameLbl.Text = "First Name:";
            this.FirstNameLbl.Visible = false;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GenderLbl.Location = new System.Drawing.Point(59, 282);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(51, 15);
            this.GenderLbl.TabIndex = 68;
            this.GenderLbl.Text = "Gender:";
            this.GenderLbl.Visible = false;
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BirthDateLbl.Location = new System.Drawing.Point(49, 257);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(61, 15);
            this.BirthDateLbl.TabIndex = 67;
            this.BirthDateLbl.Text = "BirthDate:";
            this.BirthDateLbl.Visible = false;
            this.BirthDateLbl.Click += new System.EventHandler(this.BirthDateLbl_Click);
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CountryLbl.Location = new System.Drawing.Point(59, 232);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(51, 15);
            this.CountryLbl.TabIndex = 66;
            this.CountryLbl.Text = "Country:";
            this.CountryLbl.Visible = false;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EmailLbl.Location = new System.Drawing.Point(68, 207);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(42, 15);
            this.EmailLbl.TabIndex = 65;
            this.EmailLbl.Text = "Email:";
            this.EmailLbl.Visible = false;
            this.EmailLbl.Click += new System.EventHandler(this.EmailLbl_Click);
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LastNameLbl.Location = new System.Drawing.Point(40, 182);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(70, 15);
            this.LastNameLbl.TabIndex = 64;
            this.LastNameLbl.Text = "Last Name:";
            this.LastNameLbl.Visible = false;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameLbl.Location = new System.Drawing.Point(40, 26);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(68, 15);
            this.UsernameLbl.TabIndex = 63;
            this.UsernameLbl.Text = "Username ";
            // 
            // UserRecipesGrBox
            // 
            this.UserRecipesGrBox.AutoSize = true;
            this.UserRecipesGrBox.Controls.Add(this.UserRecipesLstBox);
            this.UserRecipesGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRecipesGrBox.Location = new System.Drawing.Point(12, 327);
            this.UserRecipesGrBox.Name = "UserRecipesGrBox";
            this.UserRecipesGrBox.Size = new System.Drawing.Size(309, 197);
            this.UserRecipesGrBox.TabIndex = 70;
            this.UserRecipesGrBox.TabStop = false;
            this.UserRecipesGrBox.Text = "User Recipes";
            this.UserRecipesGrBox.Visible = false;
            // 
            // UserRecipesLstBox
            // 
            this.UserRecipesLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserRecipesLstBox.FormattingEnabled = true;
            this.UserRecipesLstBox.ItemHeight = 18;
            this.UserRecipesLstBox.Location = new System.Drawing.Point(28, 33);
            this.UserRecipesLstBox.Name = "UserRecipesLstBox";
            this.UserRecipesLstBox.ScrollAlwaysVisible = true;
            this.UserRecipesLstBox.Size = new System.Drawing.Size(265, 130);
            this.UserRecipesLstBox.TabIndex = 0;
            this.UserRecipesLstBox.Visible = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBtn.Location = new System.Drawing.Point(108, 96);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(136, 29);
            this.SearchBtn.TabIndex = 72;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // firstNLbl
            // 
            this.firstNLbl.AutoSize = true;
            this.firstNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.firstNLbl.Location = new System.Drawing.Point(126, 154);
            this.firstNLbl.Name = "firstNLbl";
            this.firstNLbl.Size = new System.Drawing.Size(72, 18);
            this.firstNLbl.TabIndex = 73;
            this.firstNLbl.Text = "firstName";
            this.firstNLbl.Visible = false;
            // 
            // lastNLbl
            // 
            this.lastNLbl.AutoSize = true;
            this.lastNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lastNLbl.Location = new System.Drawing.Point(126, 179);
            this.lastNLbl.Name = "lastNLbl";
            this.lastNLbl.Size = new System.Drawing.Size(71, 18);
            this.lastNLbl.TabIndex = 74;
            this.lastNLbl.Text = "lastName";
            this.lastNLbl.Visible = false;
            this.lastNLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailOneLbl
            // 
            this.emailOneLbl.AutoSize = true;
            this.emailOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.emailOneLbl.Location = new System.Drawing.Point(126, 204);
            this.emailOneLbl.Name = "emailOneLbl";
            this.emailOneLbl.Size = new System.Drawing.Size(43, 18);
            this.emailOneLbl.TabIndex = 75;
            this.emailOneLbl.Text = "email";
            this.emailOneLbl.Visible = false;
            // 
            // countryOneLbl
            // 
            this.countryOneLbl.AutoSize = true;
            this.countryOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.countryOneLbl.Location = new System.Drawing.Point(126, 229);
            this.countryOneLbl.Name = "countryOneLbl";
            this.countryOneLbl.Size = new System.Drawing.Size(57, 18);
            this.countryOneLbl.TabIndex = 76;
            this.countryOneLbl.Text = "country";
            this.countryOneLbl.Visible = false;
            // 
            // birthDateOneLbl
            // 
            this.birthDateOneLbl.AutoSize = true;
            this.birthDateOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.birthDateOneLbl.Location = new System.Drawing.Point(126, 254);
            this.birthDateOneLbl.Name = "birthDateOneLbl";
            this.birthDateOneLbl.Size = new System.Drawing.Size(67, 18);
            this.birthDateOneLbl.TabIndex = 77;
            this.birthDateOneLbl.Text = "birthDate";
            this.birthDateOneLbl.Visible = false;
            // 
            // GenderOneLbl
            // 
            this.GenderOneLbl.AutoSize = true;
            this.GenderOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenderOneLbl.Location = new System.Drawing.Point(126, 280);
            this.GenderOneLbl.Name = "GenderOneLbl";
            this.GenderOneLbl.Size = new System.Drawing.Size(53, 18);
            this.GenderOneLbl.TabIndex = 78;
            this.GenderOneLbl.Text = "gender";
            this.GenderOneLbl.Visible = false;
            // 
            // frmSearchUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(346, 536);
            this.Controls.Add(this.GenderOneLbl);
            this.Controls.Add(this.birthDateOneLbl);
            this.Controls.Add(this.countryOneLbl);
            this.Controls.Add(this.emailOneLbl);
            this.Controls.Add(this.lastNLbl);
            this.Controls.Add(this.firstNLbl);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.UserRecipesGrBox);
            this.Controls.Add(this.UserCbBox);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.UsernameLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSearchUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage User";
            this.UserRecipesGrBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox UserCbBox;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.GroupBox UserRecipesGrBox;
        private System.Windows.Forms.ListBox UserRecipesLstBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label firstNLbl;
        private System.Windows.Forms.Label lastNLbl;
        private System.Windows.Forms.Label emailOneLbl;
        private System.Windows.Forms.Label countryOneLbl;
        private System.Windows.Forms.Label birthDateOneLbl;
        private System.Windows.Forms.Label GenderOneLbl;
    }
}