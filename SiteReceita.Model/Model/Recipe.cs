using SiteRecipe.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Model.Model
{
    public class Recipe
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Rating Rating { get; set; }

        public Difficulty Difficulty { get; set; }

        public string Description { get; set; }

        public TimeSpan CookingTime { get; set; }

        public bool IsValidated { get; set; }

        public User User { get; set; }

        public List<Ingredient> Ingredients { get; set; }

        public List<Category> Category { get; set; }

        public List<Comment> Comment { get; set; }

        public Recipe()
        {
        }

        public Recipe(string name, Rating rating, Difficulty difficulty, string description, TimeSpan cookingTime, bool isValidated)
        {
            Name = name;
            Rating = rating;
            Difficulty = difficulty;
            Description = description;
            CookingTime = cookingTime;
            IsValidated = isValidated;
        }
    }


}
