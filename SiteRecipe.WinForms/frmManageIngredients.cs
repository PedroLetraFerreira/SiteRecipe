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
    public partial class frmManageIngredients : Form
    {
        private IngredientService _service;
        
        public frmManageIngredients()
        {
            InitializeComponent();
            _service = new IngredientService();
        }

        private void SaveIngBtn_Click(object sender, EventArgs e)
        {
            string name = IngNameTxt.Text;
            double quantity = double.Parse(QuantityTxt.Text);
            string measurementUnit = MeasurementUnitTxt.Text;

            Ingredient ingredient = new Ingredient()
            {
                Name = name,
                Quantity = quantity,
                MeasurementUnit = measurementUnit 
            };

            try
            {
                _service.Add(ingredient);
                MessageBox.Show("Ingredient saved with id: " + ingredient.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString()); 
            }
        }
    }
}
