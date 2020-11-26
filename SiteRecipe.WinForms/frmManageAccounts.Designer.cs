namespace SiteRecipe.WinForms
{
    partial class frmManageAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageAccounts));
            this.ValidateGrBox = new System.Windows.Forms.GroupBox();
            this.GenderCbBox = new System.Windows.Forms.ComboBox();
            this.CountryTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.RemoveGrBox = new System.Windows.Forms.GroupBox();
            this.UserChckLstBox = new System.Windows.Forms.CheckedListBox();
            this.ValidateBtn = new System.Windows.Forms.Button();
            this.RemoveGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ValidateGrBox
            // 
            this.ValidateGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateGrBox.Location = new System.Drawing.Point(12, 12);
            this.ValidateGrBox.Name = "ValidateGrBox";
            this.ValidateGrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ValidateGrBox.Size = new System.Drawing.Size(628, 250);
            this.ValidateGrBox.TabIndex = 0;
            this.ValidateGrBox.TabStop = false;
            this.ValidateGrBox.Text = "Validate Account";
            // 
            // GenderCbBox
            // 
            this.GenderCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderCbBox.FormattingEnabled = true;
            this.GenderCbBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.GenderCbBox.Location = new System.Drawing.Point(40, 208);
            this.GenderCbBox.Name = "GenderCbBox";
            this.GenderCbBox.Size = new System.Drawing.Size(265, 26);
            this.GenderCbBox.TabIndex = 7;
            // 
            // CountryTxt
            // 
            this.CountryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryTxt.Location = new System.Drawing.Point(40, 154);
            this.CountryTxt.Name = "CountryTxt";
            this.CountryTxt.Size = new System.Drawing.Size(265, 24);
            this.CountryTxt.TabIndex = 5;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameLbl.Location = new System.Drawing.Point(40, 80);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(65, 15);
            this.UsernameLbl.TabIndex = 54;
            this.UsernameLbl.Text = "Username";
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenderLbl.Location = new System.Drawing.Point(40, 188);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(48, 15);
            this.GenderLbl.TabIndex = 53;
            this.GenderLbl.Text = "Gender";
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BirthDateLbl.Location = new System.Drawing.Point(348, 134);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(58, 15);
            this.BirthDateLbl.TabIndex = 52;
            this.BirthDateLbl.Text = "BirthDate";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(348, 154);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(265, 24);
            this.DateTimePicker.TabIndex = 6;
            this.DateTimePicker.Value = new System.DateTime(2020, 11, 16, 0, 0, 0, 0);
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CountryLbl.Location = new System.Drawing.Point(40, 134);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(48, 15);
            this.CountryLbl.TabIndex = 50;
            this.CountryLbl.Text = "Country";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(348, 100);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(265, 24);
            this.EmailTxt.TabIndex = 4;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailLbl.Location = new System.Drawing.Point(348, 80);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(39, 15);
            this.EmailLbl.TabIndex = 48;
            this.EmailLbl.Text = "Email";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(40, 100);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(265, 24);
            this.UsernameTxt.TabIndex = 3;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLbl.Location = new System.Drawing.Point(348, 26);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(67, 15);
            this.LastNameLbl.TabIndex = 47;
            this.LastNameLbl.Text = "Last Name";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxt.Location = new System.Drawing.Point(348, 46);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(265, 24);
            this.LastNameTxt.TabIndex = 2;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstNameLbl.Location = new System.Drawing.Point(40, 26);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(67, 15);
            this.FirstNameLbl.TabIndex = 46;
            this.FirstNameLbl.Text = "First Name";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxt.Location = new System.Drawing.Point(40, 46);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(265, 24);
            this.FirstNameTxt.TabIndex = 1;
            // 
            // RemoveGrBox
            // 
            this.RemoveGrBox.Controls.Add(this.UserChckLstBox);
            this.RemoveGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveGrBox.Location = new System.Drawing.Point(12, 268);
            this.RemoveGrBox.Name = "RemoveGrBox";
            this.RemoveGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveGrBox.Size = new System.Drawing.Size(628, 197);
            this.RemoveGrBox.TabIndex = 56;
            this.RemoveGrBox.TabStop = false;
            this.RemoveGrBox.Text = "Remove Account";
            // 
            // UserChckLstBox
            // 
            this.UserChckLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserChckLstBox.FormattingEnabled = true;
            this.UserChckLstBox.Location = new System.Drawing.Point(28, 33);
            this.UserChckLstBox.Name = "UserChckLstBox";
            this.UserChckLstBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserChckLstBox.ScrollAlwaysVisible = true;
            this.UserChckLstBox.Size = new System.Drawing.Size(265, 137);
            this.UserChckLstBox.TabIndex = 8;
            // 
            // ValidateBtn
            // 
            this.ValidateBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ValidateBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ValidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValidateBtn.Location = new System.Drawing.Point(258, 485);
            this.ValidateBtn.Name = "ValidateBtn";
            this.ValidateBtn.Size = new System.Drawing.Size(136, 29);
            this.ValidateBtn.TabIndex = 57;
            this.ValidateBtn.Text = "Validate";
            this.ValidateBtn.UseVisualStyleBackColor = false;
            this.ValidateBtn.Click += new System.EventHandler(this.ValidateBtn_Click);
            // 
            // frmManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(653, 536);
            this.Controls.Add(this.ValidateBtn);
            this.Controls.Add(this.RemoveGrBox);
            this.Controls.Add(this.GenderCbBox);
            this.Controls.Add(this.CountryTxt);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.FirstNameTxt);
            this.Controls.Add(this.ValidateGrBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageAccounts";
            this.Text = "Manage Account";
            this.RemoveGrBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ValidateGrBox;
        private System.Windows.Forms.ComboBox GenderCbBox;
        private System.Windows.Forms.TextBox CountryTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.GroupBox RemoveGrBox;
        private System.Windows.Forms.Button ValidateBtn;
        private System.Windows.Forms.CheckedListBox UserChckLstBox;
    }
}