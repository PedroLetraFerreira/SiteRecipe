namespace SiteRecipe.WinForms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.PasswordOneLbl = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.PasswordOneTxt = new System.Windows.Forms.TextBox();
            this.UsernameOneLbl = new System.Windows.Forms.Label();
            this.UsernameOneTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordOneLbl
            // 
            this.PasswordOneLbl.AutoSize = true;
            this.PasswordOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PasswordOneLbl.Location = new System.Drawing.Point(42, 80);
            this.PasswordOneLbl.Name = "PasswordOneLbl";
            this.PasswordOneLbl.Size = new System.Drawing.Size(61, 15);
            this.PasswordOneLbl.TabIndex = 41;
            this.PasswordOneLbl.Text = "Password";
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LoginBtn.Location = new System.Drawing.Point(109, 154);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(136, 29);
            this.LoginBtn.TabIndex = 40;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = false;
            // 
            // PasswordOneTxt
            // 
            this.PasswordOneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordOneTxt.Location = new System.Drawing.Point(42, 100);
            this.PasswordOneTxt.Name = "PasswordOneTxt";
            this.PasswordOneTxt.Size = new System.Drawing.Size(265, 24);
            this.PasswordOneTxt.TabIndex = 2;
            // 
            // UsernameOneLbl
            // 
            this.UsernameOneLbl.AutoSize = true;
            this.UsernameOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UsernameOneLbl.Location = new System.Drawing.Point(42, 26);
            this.UsernameOneLbl.Name = "UsernameOneLbl";
            this.UsernameOneLbl.Size = new System.Drawing.Size(65, 15);
            this.UsernameOneLbl.TabIndex = 39;
            this.UsernameOneLbl.Text = "Username";
            // 
            // UsernameOneTxt
            // 
            this.UsernameOneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameOneTxt.Location = new System.Drawing.Point(42, 46);
            this.UsernameOneTxt.Name = "UsernameOneTxt";
            this.UsernameOneTxt.Size = new System.Drawing.Size(265, 24);
            this.UsernameOneTxt.TabIndex = 1;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(350, 211);
            this.Controls.Add(this.PasswordOneLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordOneTxt);
            this.Controls.Add(this.UsernameOneLbl);
            this.Controls.Add(this.UsernameOneTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PasswordOneLbl;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox PasswordOneTxt;
        private System.Windows.Forms.Label UsernameOneLbl;
        private System.Windows.Forms.TextBox UsernameOneTxt;
    }
}