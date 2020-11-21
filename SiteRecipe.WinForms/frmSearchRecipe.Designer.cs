namespace SiteRecipe.WinForms
{
    partial class frmSearchRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchRecipe));
            this.RecipeCbBox = new System.Windows.Forms.ComboBox();
            this.RecipeNameLbl = new System.Windows.Forms.Label();
            this.ratingOneLbl = new System.Windows.Forms.Label();
            this.cookingTimeOneLbl = new System.Windows.Forms.Label();
            this.difficultyOneLbl = new System.Windows.Forms.Label();
            this.categoryOneLbl = new System.Windows.Forms.Label();
            this.authorOneLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.IngLbl = new System.Windows.Forms.Label();
            this.RatingLbl = new System.Windows.Forms.Label();
            this.CookingTimeLbl = new System.Windows.Forms.Label();
            this.DifficultyLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.IngRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.CommentsRchTxtBox = new System.Windows.Forms.RichTextBox();
            this.CommentsLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RecipeCbBox
            // 
            this.RecipeCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeCbBox.FormattingEnabled = true;
            this.RecipeCbBox.Location = new System.Drawing.Point(40, 46);
            this.RecipeCbBox.Name = "RecipeCbBox";
            this.RecipeCbBox.Size = new System.Drawing.Size(265, 26);
            this.RecipeCbBox.TabIndex = 64;
            // 
            // RecipeNameLbl
            // 
            this.RecipeNameLbl.AutoSize = true;
            this.RecipeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecipeNameLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RecipeNameLbl.Location = new System.Drawing.Point(40, 26);
            this.RecipeNameLbl.Name = "RecipeNameLbl";
            this.RecipeNameLbl.Size = new System.Drawing.Size(86, 15);
            this.RecipeNameLbl.TabIndex = 65;
            this.RecipeNameLbl.Text = "Recipe Name ";
            // 
            // ratingOneLbl
            // 
            this.ratingOneLbl.AutoSize = true;
            this.ratingOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ratingOneLbl.Location = new System.Drawing.Point(140, 199);
            this.ratingOneLbl.Name = "ratingOneLbl";
            this.ratingOneLbl.Size = new System.Drawing.Size(44, 18);
            this.ratingOneLbl.TabIndex = 89;
            this.ratingOneLbl.Text = "rating";
            this.ratingOneLbl.Visible = false;
            this.ratingOneLbl.Click += new System.EventHandler(this.ratingOneLbl_Click);
            // 
            // cookingTimeOneLbl
            // 
            this.cookingTimeOneLbl.AutoSize = true;
            this.cookingTimeOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookingTimeOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cookingTimeOneLbl.Location = new System.Drawing.Point(140, 175);
            this.cookingTimeOneLbl.Name = "cookingTimeOneLbl";
            this.cookingTimeOneLbl.Size = new System.Drawing.Size(89, 18);
            this.cookingTimeOneLbl.TabIndex = 88;
            this.cookingTimeOneLbl.Text = "cookingTine";
            this.cookingTimeOneLbl.Visible = false;
            // 
            // difficultyOneLbl
            // 
            this.difficultyOneLbl.AutoSize = true;
            this.difficultyOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.difficultyOneLbl.Location = new System.Drawing.Point(140, 150);
            this.difficultyOneLbl.Name = "difficultyOneLbl";
            this.difficultyOneLbl.Size = new System.Drawing.Size(60, 18);
            this.difficultyOneLbl.TabIndex = 87;
            this.difficultyOneLbl.Text = "difficulty";
            this.difficultyOneLbl.Visible = false;
            // 
            // categoryOneLbl
            // 
            this.categoryOneLbl.AutoSize = true;
            this.categoryOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryOneLbl.Location = new System.Drawing.Point(140, 125);
            this.categoryOneLbl.Name = "categoryOneLbl";
            this.categoryOneLbl.Size = new System.Drawing.Size(65, 18);
            this.categoryOneLbl.TabIndex = 86;
            this.categoryOneLbl.Text = "category";
            this.categoryOneLbl.Visible = false;
            // 
            // authorOneLbl
            // 
            this.authorOneLbl.AutoSize = true;
            this.authorOneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authorOneLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.authorOneLbl.Location = new System.Drawing.Point(140, 100);
            this.authorOneLbl.Name = "authorOneLbl";
            this.authorOneLbl.Size = new System.Drawing.Size(50, 18);
            this.authorOneLbl.TabIndex = 85;
            this.authorOneLbl.Text = "author";
            this.authorOneLbl.Visible = false;
            this.authorOneLbl.Click += new System.EventHandler(this.authorOneLbl_Click);
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AuthorLbl.Location = new System.Drawing.Point(81, 102);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(45, 15);
            this.AuthorLbl.TabIndex = 84;
            this.AuthorLbl.Text = "Author:";
            this.AuthorLbl.Visible = false;
            // 
            // IngLbl
            // 
            this.IngLbl.AutoSize = true;
            this.IngLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IngLbl.Location = new System.Drawing.Point(348, 80);
            this.IngLbl.Name = "IngLbl";
            this.IngLbl.Size = new System.Drawing.Size(71, 15);
            this.IngLbl.TabIndex = 83;
            this.IngLbl.Text = "Ingredients:";
            this.IngLbl.Visible = false;
            // 
            // RatingLbl
            // 
            this.RatingLbl.AutoSize = true;
            this.RatingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatingLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.RatingLbl.Location = new System.Drawing.Point(80, 201);
            this.RatingLbl.Name = "RatingLbl";
            this.RatingLbl.Size = new System.Drawing.Size(46, 15);
            this.RatingLbl.TabIndex = 82;
            this.RatingLbl.Text = "Rating:";
            this.RatingLbl.Visible = false;
            // 
            // CookingTimeLbl
            // 
            this.CookingTimeLbl.AutoSize = true;
            this.CookingTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CookingTimeLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CookingTimeLbl.Location = new System.Drawing.Point(40, 177);
            this.CookingTimeLbl.Name = "CookingTimeLbl";
            this.CookingTimeLbl.Size = new System.Drawing.Size(86, 15);
            this.CookingTimeLbl.TabIndex = 81;
            this.CookingTimeLbl.Text = "Cooking Time:";
            this.CookingTimeLbl.Visible = false;
            // 
            // DifficultyLbl
            // 
            this.DifficultyLbl.AutoSize = true;
            this.DifficultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DifficultyLbl.Location = new System.Drawing.Point(71, 152);
            this.DifficultyLbl.Name = "DifficultyLbl";
            this.DifficultyLbl.Size = new System.Drawing.Size(55, 15);
            this.DifficultyLbl.TabIndex = 80;
            this.DifficultyLbl.Text = "Difficulty:";
            this.DifficultyLbl.Visible = false;
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CategoryLbl.Location = new System.Drawing.Point(68, 127);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(58, 15);
            this.CategoryLbl.TabIndex = 79;
            this.CategoryLbl.Text = "Category:";
            this.CategoryLbl.Visible = false;
            // 
            // IngRchTxtBox
            // 
            this.IngRchTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.IngRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngRchTxtBox.Location = new System.Drawing.Point(348, 100);
            this.IngRchTxtBox.Name = "IngRchTxtBox";
            this.IngRchTxtBox.ReadOnly = true;
            this.IngRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IngRchTxtBox.Size = new System.Drawing.Size(265, 117);
            this.IngRchTxtBox.TabIndex = 91;
            this.IngRchTxtBox.Text = "";
            this.IngRchTxtBox.Visible = false;
            // 
            // DescriptionRchTxtBox
            // 
            this.DescriptionRchTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionRchTxtBox.Location = new System.Drawing.Point(40, 245);
            this.DescriptionRchTxtBox.Name = "DescriptionRchTxtBox";
            this.DescriptionRchTxtBox.ReadOnly = true;
            this.DescriptionRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DescriptionRchTxtBox.Size = new System.Drawing.Size(573, 132);
            this.DescriptionRchTxtBox.TabIndex = 92;
            this.DescriptionRchTxtBox.Text = "";
            this.DescriptionRchTxtBox.Visible = false;
            this.DescriptionRchTxtBox.TextChanged += new System.EventHandler(this.DescriptionRchTxtBox_TextChanged);
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DescriptionLbl.Location = new System.Drawing.Point(54, 225);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(72, 15);
            this.DescriptionLbl.TabIndex = 93;
            this.DescriptionLbl.Text = "Description:";
            this.DescriptionLbl.Visible = false;
            // 
            // CommentsRchTxtBox
            // 
            this.CommentsRchTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.CommentsRchTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsRchTxtBox.Location = new System.Drawing.Point(40, 405);
            this.CommentsRchTxtBox.Name = "CommentsRchTxtBox";
            this.CommentsRchTxtBox.ReadOnly = true;
            this.CommentsRchTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommentsRchTxtBox.Size = new System.Drawing.Size(573, 132);
            this.CommentsRchTxtBox.TabIndex = 94;
            this.CommentsRchTxtBox.Text = "";
            this.CommentsRchTxtBox.Visible = false;
            // 
            // CommentsLbl
            // 
            this.CommentsLbl.AutoSize = true;
            this.CommentsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentsLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CommentsLbl.Location = new System.Drawing.Point(56, 385);
            this.CommentsLbl.Name = "CommentsLbl";
            this.CommentsLbl.Size = new System.Drawing.Size(70, 15);
            this.CommentsLbl.TabIndex = 95;
            this.CommentsLbl.Text = "Comments:";
            this.CommentsLbl.Visible = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SearchBtn.Location = new System.Drawing.Point(477, 45);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(136, 29);
            this.SearchBtn.TabIndex = 96;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = false;
            // 
            // frmSearchRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(653, 574);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CommentsRchTxtBox);
            this.Controls.Add(this.CommentsLbl);
            this.Controls.Add(this.DescriptionRchTxtBox);
            this.Controls.Add(this.DescriptionLbl);
            this.Controls.Add(this.IngRchTxtBox);
            this.Controls.Add(this.ratingOneLbl);
            this.Controls.Add(this.cookingTimeOneLbl);
            this.Controls.Add(this.difficultyOneLbl);
            this.Controls.Add(this.categoryOneLbl);
            this.Controls.Add(this.authorOneLbl);
            this.Controls.Add(this.AuthorLbl);
            this.Controls.Add(this.IngLbl);
            this.Controls.Add(this.RatingLbl);
            this.Controls.Add(this.CookingTimeLbl);
            this.Controls.Add(this.DifficultyLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.RecipeCbBox);
            this.Controls.Add(this.RecipeNameLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSearchRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RecipeCbBox;
        private System.Windows.Forms.Label RecipeNameLbl;
        private System.Windows.Forms.Label ratingOneLbl;
        private System.Windows.Forms.Label cookingTimeOneLbl;
        private System.Windows.Forms.Label difficultyOneLbl;
        private System.Windows.Forms.Label categoryOneLbl;
        private System.Windows.Forms.Label authorOneLbl;
        private System.Windows.Forms.Label AuthorLbl;
        private System.Windows.Forms.Label IngLbl;
        private System.Windows.Forms.Label RatingLbl;
        private System.Windows.Forms.Label CookingTimeLbl;
        private System.Windows.Forms.Label DifficultyLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.RichTextBox IngRchTxtBox;
        private System.Windows.Forms.RichTextBox DescriptionRchTxtBox;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.RichTextBox CommentsRchTxtBox;
        private System.Windows.Forms.Label CommentsLbl;
        private System.Windows.Forms.Button SearchBtn;
    }
}