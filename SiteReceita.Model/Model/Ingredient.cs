using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Model.Model
{
    public class Ingredient
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public double Quantity { get; set; }
        
        public string MeasurementUnit { get; set; }

        public Ingredient()
        {
        }

        public Ingredient(string name, double quantity, string measurementUnit)
        {
            Name = name;
            Quantity = quantity;
            MeasurementUnit = measurementUnit;
        }
    }
}
