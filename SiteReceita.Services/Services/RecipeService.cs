using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class RecipeService
    {
        private RecipeRepository _repo;

        public RecipeService()
        {
            _repo = new RecipeRepository();
        }

        public List<Recipe> GetAll()
        {
            return _repo.GetAll();
        }

        public Recipe GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Recipe recipe)
        {
            _repo.Add(recipe);
        }

        public void Update(Recipe recipe)
        {
            _repo.Update(recipe);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
