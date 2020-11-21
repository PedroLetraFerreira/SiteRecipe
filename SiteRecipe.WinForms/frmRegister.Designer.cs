namespace SiteRecipe.WinForms
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.BirthDateLbl = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RepeatPLbl = new System.Windows.Forms.Label();
            this.CountryLbl = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.UsernameTxt = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.LastNameTxt = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTxt = new System.Windows.Forms.TextBox();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.TextBox();
            this.RepeatPasswordTxt = new System.Windows.Forms.TextBox();
            this.GenderCbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegisterBtn.Location = new System.Drawing.Point(271, 316);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(136, 29);
            this.RegisterBtn.TabIndex = 35;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GenderLbl.Location = new System.Drawing.Point(42, 242);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(48, 15);
            this.GenderLbl.TabIndex = 32;
            this.GenderLbl.Text = "Gender";
            // 
            // BirthDateLbl
            // 
            this.BirthDateLbl.AutoSize = true;
            this.BirthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDateLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BirthDateLbl.Location = new System.Drawing.Point(350, 188);
            this.BirthDateLbl.Name = "BirthDateLbl";
            this.BirthDateLbl.Size = new System.Drawing.Size(58, 15);
            this.BirthDateLbl.TabIndex = 31;
            this.BirthDateLbl.Text = "BirthDate";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlLight;
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(350, 208);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(265, 24);
            this.DateTimePicker.TabIndex = 8;
            this.DateTimePicker.Value = new System.DateTime(2020, 11, 1, 15, 17, 17, 0);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // RepeatPLbl
            // 
            this.RepeatPLbl.AutoSize = true;
            this.RepeatPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RepeatPLbl.Location = new System.Drawing.Point(350, 134);
            this.RepeatPLbl.Name = "RepeatPLbl";
            this.RepeatPLbl.Size = new System.Drawing.Size(104, 15);
            this.RepeatPLbl.TabIndex = 29;
            this.RepeatPLbl.Text = "Repeat Password";
            // 
            // CountryLbl
            // 
            this.CountryLbl.AutoSize = true;
            this.CountryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountryLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CountryLbl.Location = new System.Drawing.Point(42, 188);
            this.CountryLbl.Name = "CountryLbl";
            this.CountryLbl.Size = new System.Drawing.Size(48, 15);
            this.CountryLbl.TabIndex = 28;
            this.CountryLbl.Text = "Country";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTxt.Location = new System.Drawing.Point(42, 154);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.Size = new System.Drawing.Size(265, 24);
            this.PasswordTxt.TabIndex = 5;
            this.PasswordTxt.WordWrap = false;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordLbl.Location = new System.Drawing.Point(42, 134);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(61, 15);
            this.PasswordLbl.TabIndex = 27;
            this.PasswordLbl.Text = "Password";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTxt.Location = new System.Drawing.Point(350, 100);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(265, 24);
            this.EmailTxt.TabIndex = 4;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailLbl.Location = new System.Drawing.Point(350, 80);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(39, 15);
            this.EmailLbl.TabIndex = 25;
            this.EmailLbl.Text = "Email";
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTxt.Location = new System.Drawing.Point(42, 100);
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.Size = new System.Drawing.Size(265, 24);
            this.UsernameTxt.TabIndex = 3;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLbl.Location = new System.Drawing.Point(350, 26);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(67, 15);
            this.LastNameLbl.TabIndex = 22;
            this.LastNameLbl.Text = "Last Name";
            // 
            // LastNameTxt
            // 
            this.LastNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTxt.Location = new System.Drawing.Point(350, 46);
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.Size = new System.Drawing.Size(265, 24);
            this.LastNameTxt.TabIndex = 2;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstNameLbl.Location = new System.Drawing.Point(42, 26);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(67, 15);
            this.FirstNameLbl.TabIndex = 20;
            this.FirstNameLbl.Text = "First Name";
            // 
            // FirstNameTxt
            // 
            this.FirstNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTxt.Location = new System.Drawing.Point(42, 46);
            this.FirstNameTxt.Name = "FirstNameTxt";
            this.FirstNameTxt.Size = new System.Drawing.Size(265, 24);
            this.FirstNameTxt.TabIndex = 1;
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameLbl.Location = new System.Drawing.Point(42, 80);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(65, 15);
            this.UsernameLbl.TabIndex = 36;
            this.UsernameLbl.Text = "Username";
            // 
            // Country
            // 
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Country.Location = new System.Drawing.Point(42, 208);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(265, 24);
            this.Country.TabIndex = 7;
            // 
            // RepeatPasswordTxt
            // 
            this.RepeatPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPasswordTxt.Location = new System.Drawing.Point(350, 154);
            this.RepeatPasswordTxt.Name = "RepeatPasswordTxt";
            this.RepeatPasswordTxt.Size = new System.Drawing.Size(265, 24);
            this.RepeatPasswordTxt.TabIndex = 6;
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
            this.GenderCbBox.Location = new System.Drawing.Point(42, 262);
            this.GenderCbBox.Name = "GenderCbBox";
            this.GenderCbBox.Size = new System.Drawing.Size(265, 26);
            this.GenderCbBox.TabIndex = 37;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(653, 376);
            this.Controls.Add(this.GenderCbBox);
            this.Controls.Add(this.RepeatPasswordTxt);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.GenderLbl);
            this.Controls.Add(this.BirthDateLbl);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.RepeatPLbl);
            this.Controls.Add(this.CountryLbl);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.UsernameTxt);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.FirstNameLbl);
            this.Controls.Add(this.FirstNameTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.Label BirthDateLbl;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label RepeatPLbl;
        private System.Windows.Forms.Label CountryLbl;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox UsernameTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox LastNameTxt;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.TextBox FirstNameTxt;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox RepeatPasswordTxt;
        private System.Windows.Forms.ComboBox GenderCbBox;
    }
}