using SiteRecipe.Model.Model;
using SiteRecipe.Services.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteRecipe.WinForms
{
    public partial class frmManageCategories : Form
    {
        private CategoryService _service;
        
        public frmManageCategories()
        {
            InitializeComponent();
            _service = new CategoryService();
        }

        private void frmManageCategories_Load(object sender, EventArgs e)
        {
            CategoriesDtGridVw.DataSource = _service.GetAll();
        }

        private void CategoriesDtGridVw_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CategoryNameTxt.Text = CategoriesDtGridVw.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string name = CategoryNameTxt.Text;

            Category category = new Category()
            {
                CategoryName = name
            };

            try
            {
                _service.Add(category);
                MessageBox.Show("Category saved successfully with the id: " + category.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string name = CategoryNameTxt.Text;

            Category category = new Category()
            {
                CategoryName = name
            };

            try
            {
                _service.Update(category);
                MessageBox.Show("Category updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(CategoryNameTxt.Text);

            Category category = new Category()
            {
                Id = id
            };
            
            try
            {
                _service.Remove(id);
                MessageBox.Show("Category removed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
