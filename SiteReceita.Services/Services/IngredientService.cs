using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class IngredientService
    {
        private IngredientRepository _repo;

        public IngredientService()
        {
            _repo = new IngredientRepository();
        }

        public List<Ingredient> GetAll()
        {
            return _repo.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Ingredient ingredient)
        {
            _repo.Add(ingredient);
        }

        public void Update(Ingredient ingredient)
        {
            _repo.Update(ingredient);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
