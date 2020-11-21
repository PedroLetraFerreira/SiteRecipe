namespace SiteRecipe.WinForms
{
    partial class frmUpdateRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateRecipe));
            this.RecipeCbBox = new System.Windows.Forms.ComboBox();
            this.RecipeNameLbl = new System.Windows.Forms.Label();
            this.DescriptionRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.IngRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.IngredientsLbl = new System.Windows.Forms.Label();
            this.HoursLbl = new System.Windows.Forms.Label();
            this.HoursNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinutesLbl = new System.Windows.Forms.Label();
            this.TimeNumUpDpwn = new System.Windows.Forms.NumericUpDown();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.DifficultyCbBox = new System.Windows.Forms.ComboBox();
            this.DifficultyLbl = new System.Windows.Forms.Label();
            this.CategoryCbBox = new System.Windows.Forms.ComboBox();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.AuthorTxt = new System.Windows.Forms.TextBox();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.UpdateRecipeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDpwn)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipeCbBox
            // 
            this.RecipeCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCbBox.FormattingEnabled = true;
            this.RecipeCbBox.Location = new System.Drawing.Point(40, 46);
            this.RecipeCbBox.Name = "RecipeCbBox";
            this.RecipeCbBox.Size = new System.Drawing.Size(265, 26);
            this.RecipeCbBox.TabIndex = 1;
            // 
            // RecipeNameLbl
            // 
            this.RecipeNameLbl.AutoSize = true;
            this.RecipeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RecipeNameLbl.Location = new System.Drawing.Point(40, 26);
            this.RecipeNameLbl.Name = "RecipeNameLbl";
            this.RecipeNameLbl.Size = new System.Drawing.Size(86, 15);
            this.RecipeNameLbl.TabIndex = 67;
            this.RecipeNameLbl.Text = "Recipe Name ";
            // 
            // DescriptionRchTxtBox
            // 
            this.DescriptionRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionRchTxtBox.Location = new System.Drawing.Point(38, 262);
            this.DescriptionRchTxtBox.Name = "DescriptionRchTxtBox";
            this.DescriptionRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionRchTxtBox.Size = new System.Drawing.Size(573, 132);
            this.DescriptionRchTxtBox.TabIndex = 8;
            this.DescriptionRchTxtBox.Text = "";
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DescriptionLbl.Location = new System.Drawing.Point(38, 242);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescriptionLbl.TabIndex = 82;
            this.DescriptionLbl.Text = "Description";
            // 
            // IngRchTxtBox
            // 
            this.IngRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngRchTxtBox.Location = new System.Drawing.Point(40, 100);
            this.IngRchTxtBox.Name = "IngRchTxtBox";
            this.IngRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IngRchTxtBox.Size = new System.Drawing.Size(265, 132);
            this.IngRchTxtBox.TabIndex = 2;
            this.IngRchTxtBox.Text = "";
            // 
            // IngredientsLbl
            // 
            this.IngredientsLbl.AutoSize = true;
            this.IngredientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngredientsLbl.Location = new System.Drawing.Point(38, 80);
            this.IngredientsLbl.Name = "IngredientsLbl";
            this.IngredientsLbl.Size = new System.Drawing.Size(68, 15);
            this.IngredientsLbl.TabIndex = 81;
            this.IngredientsLbl.Text = "Ingredients";
            // 
            // HoursLbl
            // 
            this.HoursLbl.AutoSize = true;
            this.HoursLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HoursLbl.Location = new System.Drawing.Point(418, 212);
            this.HoursLbl.Name = "HoursLbl";
            this.HoursLbl.Size = new System.Drawing.Size(40, 15);
            this.HoursLbl.TabIndex = 80;
            this.HoursLbl.Text = "Hours";
            // 
            // HoursNumUpDown
            // 
            this.HoursNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursNumUpDown.Location = new System.Drawing.Point(346, 208);
            this.HoursNumUpDown.Name = "HoursNumUpDown";
            this.HoursNumUpDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HoursNumUpDown.Size = new System.Drawing.Size(66, 24);
            this.HoursNumUpDown.TabIndex = 6;
            // 
            // MinutesLbl
            // 
            this.MinutesLbl.AutoSize = true;
            this.MinutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinutesLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinutesLbl.Location = new System.Drawing.Point(563, 212);
            this.MinutesLbl.Name = "MinutesLbl";
            this.MinutesLbl.Size = new System.Drawing.Size(51, 15);
            this.MinutesLbl.TabIndex = 79;
            this.MinutesLbl.Text = "Minutes";
            // 
            // TimeNumUpDpwn
            // 
            this.TimeNumUpDpwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNumUpDpwn.Location = new System.Drawing.Point(491, 208);
            this.TimeNumUpDpwn.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.TimeNumUpDpwn.Name = "TimeNumUpDpwn";
            this.TimeNumUpDpwn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeNumUpDpwn.Size = new System.Drawing.Size(66, 24);
            this.TimeNumUpDpwn.TabIndex = 7;
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeLbl.Location = new System.Drawing.Point(346, 188);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(83, 15);
            this.TimeLbl.TabIndex = 78;
            this.TimeLbl.Text = "Cooking Time";
            // 
            // DifficultyCbBox
            // 
            this.DifficultyCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifficultyCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyCbBox.FormattingEnabled = true;
            this.DifficultyCbBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.DifficultyCbBox.Location = new System.Drawing.Point(346, 154);
            this.DifficultyCbBox.MaxDropDownItems = 5;
            this.DifficultyCbBox.Name = "DifficultyCbBox";
            this.DifficultyCbBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DifficultyCbBox.Size = new System.Drawing.Size(265, 26);
            this.DifficultyCbBox.TabIndex = 5;
            // 
            // DifficultyLbl
            // 
            this.DifficultyLbl.AutoSize = true;
            this.DifficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DifficultyLbl.Location = new System.Drawing.Point(346, 134);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(52, 15);
            this.DifficultyLbl.TabIndex = 77;
            this.DifficultyLbl.Text = "Difficulty";
            // 
            // CategoryCbBox
            // 
            this.CategoryCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCbBox.FormattingEnabled = true;
            this.CategoryCbBox.Location = new System.Drawing.Point(346, 100);
            this.CategoryCbBox.MaxDropDownItems = 20;
            this.CategoryCbBox.Name = "CategoryCbBox";
            this.CategoryCbBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CategoryCbBox.Size = new System.Drawing.Size(265, 26);
            this.CategoryCbBox.TabIndex = 4;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CategoryLbl.Location = new System.Drawing.Point(346, 80);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(55, 15);
            this.CategoryLbl.TabIndex = 76;
            this.CategoryLbl.Text = "Category";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLbl.Location = new System.Drawing.Point(346, 26);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(42, 15);
            this.LastNameLbl.TabIndex = 75;
            this.LastNameLbl.Text = "Author";
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTxt.Location = new System.Drawing.Point(346, 46);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(265, 24);
            this.AuthorTxt.TabIndex = 3;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CommentsLbl.Location = new System.Drawing.Point(38, 404);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(67, 15);
            this.CommentsLbl.TabIndex = 83;
            this.CommentsLbl.Text = "Comments";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 424);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(573, 132);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // UpdateRecipeBtn
            // 
            this.UpdateRecipeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.UpdateRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRecipeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateRecipeBtn.Location = new System.Drawing.Point(258, 580);
            this.UpdateRecipeBtn.Name = "UpdateRecipeBtn";
            this.UpdateRecipeBtn.Size = new System.Drawing.Size(136, 29);
            this.UpdateRecipeBtn.TabIndex = 85;
            this.UpdateRecipeBtn.Text = "Update";
            this.UpdateRecipeBtn.UseVisualStyleBackColor = false;
            // 
            // frmUpdateRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(653, 631);
            this.Controls.Add(this.UpdateRecipeBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CommentsLbl);
            this.Controls.Add(this.DescriptionRchTxtBox);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.IngRchTxtBox);
            this.Controls.Add(this.IngredientsLbl);
            this.Controls.Add(this.HoursLbl);
            this.Controls.Add(this.HoursNumUpDown);
            this.Controls.Add(this.MinutesLbl);
            this.Controls.Add(this.TimeNumUpDpwn);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.DifficultyCbBox);
            this.Controls.Add(this.DifficultyLbl);
            this.Controls.Add(this.CategoryCbBox);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.LastNameLbl);
            this.Controls.Add(this.AuthorTxt);
            this.Controls.Add(this.RecipeCbBox);
            this.Controls.Add(this.RecipeNameLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUpdateRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Recipe";
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDpwn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RecipeCbBox;
        private System.Windows.Forms.Label RecipeNameLbl;
        private System.Windows.Forms.RichTextBox DescriptionRchTxtBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.RichTextBox IngRchTxtBox;
        private System.Windows.Forms.Label IngredientsLbl;
        private System.Windows.Forms.Label HoursLbl;
        private System.Windows.Forms.NumericUpDown HoursNumUpDown;
        private System.Windows.Forms.Label MinutesLbl;
        private System.Windows.Forms.NumericUpDown TimeNumUpDpwn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.ComboBox DifficultyCbBox;
        private System.Windows.Forms.Label DifficultyLbl;
        private System.Windows.Forms.ComboBox CategoryCbBox;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button UpdateRecipeBtn;
    }
}