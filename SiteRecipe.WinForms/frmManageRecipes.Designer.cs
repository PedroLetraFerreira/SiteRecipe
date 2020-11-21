namespace SiteRecipe.WinForms
{
    partial class frmManageRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageRecipes));
            this.AddRecipeGrBox = new System.Windows.Forms.GroupBox();
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
            this.RecipeNameLbl = new System.Windows.Forms.Label();
            this.RecipeNameTxt = new System.Windows.Forms.TextBox();
            this.RecipesrChckLstBox = new System.Windows.Forms.CheckedListBox();
            this.RemoveRecipeGrBox = new System.Windows.Forms.GroupBox();
            this.ValidateRecipeBtn = new System.Windows.Forms.Button();
            this.AddRecipeGrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDpwn)).BeginInit();
            this.RemoveRecipeGrBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddRecipeGrBox
            // 
            this.AddRecipeGrBox.Controls.Add(this.DescriptionRchTxtBox);
            this.AddRecipeGrBox.Controls.Add(this.DescriptionLbl);
            this.AddRecipeGrBox.Controls.Add(this.IngRchTxtBox);
            this.AddRecipeGrBox.Controls.Add(this.IngredientsLbl);
            this.AddRecipeGrBox.Controls.Add(this.HoursLbl);
            this.AddRecipeGrBox.Controls.Add(this.HoursNumUpDown);
            this.AddRecipeGrBox.Controls.Add(this.MinutesLbl);
            this.AddRecipeGrBox.Controls.Add(this.TimeNumUpDpwn);
            this.AddRecipeGrBox.Controls.Add(this.TimeLbl);
            this.AddRecipeGrBox.Controls.Add(this.DifficultyCbBox);
            this.AddRecipeGrBox.Controls.Add(this.DifficultyLbl);
            this.AddRecipeGrBox.Controls.Add(this.CategoryCbBox);
            this.AddRecipeGrBox.Controls.Add(this.CategoryLbl);
            this.AddRecipeGrBox.Controls.Add(this.LastNameLbl);
            this.AddRecipeGrBox.Controls.Add(this.AuthorTxt);
            this.AddRecipeGrBox.Controls.Add(this.RecipeNameLbl);
            this.AddRecipeGrBox.Controls.Add(this.RecipeNameTxt);
            this.AddRecipeGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecipeGrBox.Location = new System.Drawing.Point(12, 12);
            this.AddRecipeGrBox.Name = "AddRecipeGrBox";
            this.AddRecipeGrBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddRecipeGrBox.Size = new System.Drawing.Size(628, 410);
            this.AddRecipeGrBox.TabIndex = 1;
            this.AddRecipeGrBox.TabStop = false;
            this.AddRecipeGrBox.Text = "New Recipe";
            // 
            // DescriptionRchTxtBox
            // 
            this.DescriptionRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionRchTxtBox.Location = new System.Drawing.Point(28, 250);
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
            this.DescriptionLbl.Location = new System.Drawing.Point(28, 230);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescriptionLbl.TabIndex = 66;
            this.DescriptionLbl.Text = "Description";
            // 
            // IngRchTxtBox
            // 
            this.IngRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngRchTxtBox.Location = new System.Drawing.Point(28, 88);
            this.IngRchTxtBox.Name = "IngRchTxtBox";
            this.IngRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IngRchTxtBox.Size = new System.Drawing.Size(265, 132);
            this.IngRchTxtBox.TabIndex = 3;
            this.IngRchTxtBox.Text = "";
            // 
            // IngredientsLbl
            // 
            this.IngredientsLbl.AutoSize = true;
            this.IngredientsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngredientsLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IngredientsLbl.Location = new System.Drawing.Point(28, 68);
            this.IngredientsLbl.Name = "IngredientsLbl";
            this.IngredientsLbl.Size = new System.Drawing.Size(68, 15);
            this.IngredientsLbl.TabIndex = 64;
            this.IngredientsLbl.Text = "Ingredients";
            // 
            // HoursLbl
            // 
            this.HoursLbl.AutoSize = true;
            this.HoursLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HoursLbl.Location = new System.Drawing.Point(408, 200);
            this.HoursLbl.Name = "HoursLbl";
            this.HoursLbl.Size = new System.Drawing.Size(40, 15);
            this.HoursLbl.TabIndex = 62;
            this.HoursLbl.Text = "Hours";
            // 
            // HoursNumUpDown
            // 
            this.HoursNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursNumUpDown.Location = new System.Drawing.Point(336, 196);
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
            this.MinutesLbl.Location = new System.Drawing.Point(553, 200);
            this.MinutesLbl.Name = "MinutesLbl";
            this.MinutesLbl.Size = new System.Drawing.Size(51, 15);
            this.MinutesLbl.TabIndex = 60;
            this.MinutesLbl.Text = "Minutes";
            // 
            // TimeNumUpDpwn
            // 
            this.TimeNumUpDpwn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeNumUpDpwn.Location = new System.Drawing.Point(481, 196);
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
            this.TimeLbl.Location = new System.Drawing.Point(336, 176);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(83, 15);
            this.TimeLbl.TabIndex = 56;
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
            this.DifficultyCbBox.Location = new System.Drawing.Point(336, 142);
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
            this.DifficultyLbl.Location = new System.Drawing.Point(336, 122);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(52, 15);
            this.DifficultyLbl.TabIndex = 54;
            this.DifficultyLbl.Text = "Difficulty";
            // 
            // CategoryCbBox
            // 
            this.CategoryCbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCbBox.FormattingEnabled = true;
            this.CategoryCbBox.Location = new System.Drawing.Point(336, 88);
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
            this.CategoryLbl.Location = new System.Drawing.Point(336, 68);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(55, 15);
            this.CategoryLbl.TabIndex = 52;
            this.CategoryLbl.Text = "Category";
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLbl.Location = new System.Drawing.Point(336, 14);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(42, 15);
            this.LastNameLbl.TabIndex = 50;
            this.LastNameLbl.Text = "Author";
            // 
            // AuthorTxt
            // 
            this.AuthorTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorTxt.Location = new System.Drawing.Point(336, 34);
            this.AuthorTxt.Name = "AuthorTxt";
            this.AuthorTxt.Size = new System.Drawing.Size(265, 24);
            this.AuthorTxt.TabIndex = 2;
            // 
            // RecipeNameLbl
            // 
            this.RecipeNameLbl.AutoSize = true;
            this.RecipeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RecipeNameLbl.Location = new System.Drawing.Point(28, 14);
            this.RecipeNameLbl.Name = "RecipeNameLbl";
            this.RecipeNameLbl.Size = new System.Drawing.Size(83, 15);
            this.RecipeNameLbl.TabIndex = 48;
            this.RecipeNameLbl.Text = "Recipe Name";
            // 
            // RecipeNameTxt
            // 
            this.RecipeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameTxt.Location = new System.Drawing.Point(28, 34);
            this.RecipeNameTxt.Name = "RecipeNameTxt";
            this.RecipeNameTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecipeNameTxt.Size = new System.Drawing.Size(265, 24);
            this.RecipeNameTxt.TabIndex = 1;
            // 
            // RecipesrChckLstBox
            // 
            this.RecipesrChckLstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipesrChckLstBox.FormattingEnabled = true;
            this.RecipesrChckLstBox.Location = new System.Drawing.Point(28, 33);
            this.RecipesrChckLstBox.Name = "RecipesrChckLstBox";
            this.RecipesrChckLstBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RecipesrChckLstBox.ScrollAlwaysVisible = true;
            this.RecipesrChckLstBox.Size = new System.Drawing.Size(265, 137);
            this.RecipesrChckLstBox.TabIndex = 8;
            // 
            // RemoveRecipeGrBox
            // 
            this.RemoveRecipeGrBox.Controls.Add(this.RecipesrChckLstBox);
            this.RemoveRecipeGrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveRecipeGrBox.Location = new System.Drawing.Point(12, 428);
            this.RemoveRecipeGrBox.Name = "RemoveRecipeGrBox";
            this.RemoveRecipeGrBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemoveRecipeGrBox.Size = new System.Drawing.Size(628, 197);
            this.RemoveRecipeGrBox.TabIndex = 57;
            this.RemoveRecipeGrBox.TabStop = false;
            this.RemoveRecipeGrBox.Text = "Remove Recipe";
            // 
            // ValidateRecipeBtn
            // 
            this.ValidateRecipeBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ValidateRecipeBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ValidateRecipeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidateRecipeBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ValidateRecipeBtn.Location = new System.Drawing.Point(258, 646);
            this.ValidateRecipeBtn.Name = "ValidateRecipeBtn";
            this.ValidateRecipeBtn.Size = new System.Drawing.Size(136, 29);
            this.ValidateRecipeBtn.TabIndex = 58;
            this.ValidateRecipeBtn.Text = "Validate";
            this.ValidateRecipeBtn.UseVisualStyleBackColor = false;
            // 
            // frmManageRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(653, 697);
            this.Controls.Add(this.ValidateRecipeBtn);
            this.Controls.Add(this.RemoveRecipeGrBox);
            this.Controls.Add(this.AddRecipeGrBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManageRecipes";
            this.Text = "Manage Recipes";
            this.AddRecipeGrBox.ResumeLayout(false);
            this.AddRecipeGrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HoursNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNumUpDpwn)).EndInit();
            this.RemoveRecipeGrBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddRecipeGrBox;
        private System.Windows.Forms.Label RecipeNameLbl;
        private System.Windows.Forms.TextBox RecipeNameTxt;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox AuthorTxt;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.ComboBox CategoryCbBox;
        private System.Windows.Forms.ComboBox DifficultyCbBox;
        private System.Windows.Forms.Label DifficultyLbl;
        private System.Windows.Forms.Label MinutesLbl;
        private System.Windows.Forms.NumericUpDown TimeNumUpDpwn;
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label HoursLbl;
        private System.Windows.Forms.NumericUpDown HoursNumUpDown;
        private System.Windows.Forms.RichTextBox DescriptionRchTxtBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.RichTextBox IngRchTxtBox;
        private System.Windows.Forms.Label IngredientsLbl;
        private System.Windows.Forms.CheckedListBox RecipesrChckLstBox;
        private System.Windows.Forms.GroupBox RemoveRecipeGrBox;
        private System.Windows.Forms.Button ValidateRecipeBtn;
    }
}