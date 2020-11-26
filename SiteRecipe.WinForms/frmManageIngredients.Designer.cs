namespace SiteRecipe.WinForms
{
    partial class frmManageIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageIngredients));
            this.SaveIngBtn = new System.Windows.Forms.Button();
            this.IngQuantityLbl = new System.Windows.Forms.Label();
            this.MeasurementUnitTxt = new System.Windows.Forms.TextBox();
            this.IngUnitLbl = new System.Windows.Forms.Label();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.IngNameLbl = new System.Windows.Forms.Label();
            this.IngNameTxt = new System.Windows.Forms.TextBox();
            this.NewIngGrBox = new System.Windows.Forms.GroupBox();
            this.RemoveGrBox = new System.Windows.Forms.GroupBox();
            this.IngChckLstBox = new System.Windows.Forms.CheckedListBox();
            this.UpdateGrBox = new System.Windows.Forms.GroupBox();
            this.IngQuantityTwoLbl = new System.Windows.Forms.Label();
            this.IngUnitTwoLbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.IngNameTwoLbl = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IngListBox = new System.Windows.Forms.ListBox();
            this.RemoveGrBox.SuspendLayout();
            this.UpdateGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveIngBtn
            // 
            this.SaveIngBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SaveIngBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SaveIngBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveIngBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveIngBtn.Location = new System.Drawing.Point(282, 443);
            this.SaveIngBtn.Name = "SaveIngBtn";
            this.SaveIngBtn.Size = new System.Drawing.Size(136, 29);
            this.SaveIngBtn.TabIndex = 46;
            this.SaveIngBtn.Text = "Save";
            this.SaveIngBtn.UseVisualStyleBackColor = false;
            this.SaveIngBtn.Click += new System.EventHandler(this.SaveIngBtn_Click);
            // 
            // IngQuantityLbl
            // 
            this.IngQuantityLbl.AutoSize = true;
            this.IngQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngQuantityLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngQuantityLbl.Location = new System.Drawing.Point(42, 80);
            this.IngQuantityLbl.Name = "IngQuantityLbl";
            this.IngQuantityLbl.Size = new System.Drawing.Size(51, 15);
            this.IngQuantityLbl.TabIndex = 53;
            this.IngQuantityLbl.Text = "Quantity";
            // 
            // MeasurementUnitTxt
            // 
            this.MeasurementUnitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeasurementUnitTxt.Location = new System.Drawing.Point(42, 154);
            this.MeasurementUnitTxt.Name = "MeasurementUnitTxt";
            this.MeasurementUnitTxt.Size = new System.Drawing.Size(265, 24);
            this.MeasurementUnitTxt.TabIndex = 50;
            this.MeasurementUnitTxt.WordWrap = false;
            // 
            // IngUnitLbl
            // 
            this.IngUnitLbl.AutoSize = true;
            this.IngUnitLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngUnitLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngUnitLbl.Location = new System.Drawing.Point(42, 134);
            this.IngUnitLbl.Name = "IngUnitLbl";
            this.IngUnitLbl.Size = new System.Drawing.Size(29, 15);
            this.IngUnitLbl.TabIndex = 52;
            this.IngUnitLbl.Text = "Unit";
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxt.Location = new System.Drawing.Point(42, 100);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(265, 24);
            this.QuantityTxt.TabIndex = 49;
            // 
            // IngNameLbl
            // 
            this.IngNameLbl.AutoSize = true;
            this.IngNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngNameLbl.Location = new System.Drawing.Point(42, 26);
            this.IngNameLbl.Name = "IngNameLbl";
            this.IngNameLbl.Size = new System.Drawing.Size(41, 15);
            this.IngNameLbl.TabIndex = 51;
            this.IngNameLbl.Text = "Name";
            // 
            // IngNameTxt
            // 
            this.IngNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngNameTxt.Location = new System.Drawing.Point(42, 46);
            this.IngNameTxt.Name = "IngNameTxt";
            this.IngNameTxt.Size = new System.Drawing.Size(265, 24);
            this.IngNameTxt.TabIndex = 48;
            // 
            // NewIngGrBox
            // 
            this.NewIngGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewIngGrBox.Location = new System.Drawing.Point(12, 12);
            this.NewIngGrBox.Name = "NewIngGrBox";
            this.NewIngGrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewIngGrBox.Size = new System.Drawing.Size(325, 197);
            this.NewIngGrBox.TabIndex = 47;
            this.NewIngGrBox.TabStop = false;
            this.NewIngGrBox.Text = "New Ingredient";
            // 
            // RemoveGrBox
            // 
            this.RemoveGrBox.Controls.Add(this.IngChckLstBox);
            this.RemoveGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveGrBox.Location = new System.Drawing.Point(12, 221);
            this.RemoveGrBox.Name = "RemoveGrBox";
            this.RemoveGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveGrBox.Size = new System.Drawing.Size(325, 197);
            this.RemoveGrBox.TabIndex = 54;
            this.RemoveGrBox.TabStop = false;
            this.RemoveGrBox.Text = "Remove Ingredient";
            // 
            // IngChckLstBox
            // 
            this.IngChckLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngChckLstBox.FormattingEnabled = true;
            this.IngChckLstBox.Location = new System.Drawing.Point(30, 33);
            this.IngChckLstBox.Name = "IngChckLstBox";
            this.IngChckLstBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IngChckLstBox.ScrollAlwaysVisible = true;
            this.IngChckLstBox.Size = new System.Drawing.Size(265, 137);
            this.IngChckLstBox.TabIndex = 8;
            // 
            // UpdateGrBox
            // 
            this.UpdateGrBox.Controls.Add(this.IngQuantityTwoLbl);
            this.UpdateGrBox.Controls.Add(this.IngUnitTwoLbl);
            this.UpdateGrBox.Controls.Add(this.label2);
            this.UpdateGrBox.Controls.Add(this.textBox2);
            this.UpdateGrBox.Controls.Add(this.IngNameTwoLbl);
            this.UpdateGrBox.Controls.Add(this.textBox3);
            this.UpdateGrBox.Controls.Add(this.IngListBox);
            this.UpdateGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateGrBox.Location = new System.Drawing.Point(359, 12);
            this.UpdateGrBox.Name = "UpdateGrBox";
            this.UpdateGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UpdateGrBox.Size = new System.Drawing.Size(325, 406);
            this.UpdateGrBox.TabIndex = 55;
            this.UpdateGrBox.TabStop = false;
            this.UpdateGrBox.Text = "Update Ingredient";
            // 
            // IngQuantityTwoLbl
            // 
            this.IngQuantityTwoLbl.AutoSize = true;
            this.IngQuantityTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngQuantityTwoLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngQuantityTwoLbl.Location = new System.Drawing.Point(30, 276);
            this.IngQuantityTwoLbl.Name = "IngQuantityTwoLbl";
            this.IngQuantityTwoLbl.Size = new System.Drawing.Size(51, 15);
            this.IngQuantityTwoLbl.TabIndex = 48;
            this.IngQuantityTwoLbl.Text = "Quantity";
            // 
            // IngUnitTwoLbl
            // 
            this.IngUnitTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngUnitTwoLbl.Location = new System.Drawing.Point(30, 350);
            this.IngUnitTwoLbl.Name = "IngUnitTwoLbl";
            this.IngUnitTwoLbl.Size = new System.Drawing.Size(265, 24);
            this.IngUnitTwoLbl.TabIndex = 7;
            this.IngUnitTwoLbl.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(30, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Unit";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(30, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 24);
            this.textBox2.TabIndex = 6;
            // 
            // IngNameTwoLbl
            // 
            this.IngNameTwoLbl.AutoSize = true;
            this.IngNameTwoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngNameTwoLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngNameTwoLbl.Location = new System.Drawing.Point(30, 222);
            this.IngNameTwoLbl.Name = "IngNameTwoLbl";
            this.IngNameTwoLbl.Size = new System.Drawing.Size(41, 15);
            this.IngNameTwoLbl.TabIndex = 46;
            this.IngNameTwoLbl.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(30, 242);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(265, 24);
            this.textBox3.TabIndex = 5;
            // 
            // IngListBox
            // 
            this.IngListBox.AllowDrop = true;
            this.IngListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngListBox.FormattingEnabled = true;
            this.IngListBox.ItemHeight = 18;
            this.IngListBox.Location = new System.Drawing.Point(30, 34);
            this.IngListBox.Name = "IngListBox";
            this.IngListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IngListBox.ScrollAlwaysVisible = true;
            this.IngListBox.Size = new System.Drawing.Size(265, 130);
            this.IngListBox.TabIndex = 4;
            // 
            // frmManageIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(696, 496);
            this.Controls.Add(this.UpdateGrBox);
            this.Controls.Add(this.RemoveGrBox);
            this.Controls.Add(this.IngQuantityLbl);
            this.Controls.Add(this.MeasurementUnitTxt);
            this.Controls.Add(this.IngUnitLbl);
            this.Controls.Add(this.QuantityTxt);
            this.Controls.Add(this.IngNameLbl);
            this.Controls.Add(this.IngNameTxt);
            this.Controls.Add(this.NewIngGrBox);
            this.Controls.Add(this.SaveIngBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Ingredients";
            this.RemoveGrBox.ResumeLayout(false);
            this.UpdateGrBox.ResumeLayout(false);
            this.UpdateGrBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveIngBtn;
        private System.Windows.Forms.Label IngQuantityLbl;
        private System.Windows.Forms.TextBox MeasurementUnitTxt;
        private System.Windows.Forms.Label IngUnitLbl;
        private System.Windows.Forms.TextBox QuantityTxt;
        private System.Windows.Forms.Label IngNameLbl;
        private System.Windows.Forms.TextBox IngNameTxt;
        private System.Windows.Forms.GroupBox NewIngGrBox;
        private System.Windows.Forms.GroupBox RemoveGrBox;
        private System.Windows.Forms.CheckedListBox IngChckLstBox;
        private System.Windows.Forms.GroupBox UpdateGrBox;
        private System.Windows.Forms.Label IngQuantityTwoLbl;
        private System.Windows.Forms.TextBox IngUnitTwoLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label IngNameTwoLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox IngListBox;
    }
}