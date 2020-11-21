using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class CategoryService
    {
        private CategoryRepository _repo;

        public CategoryService()
        {
            _repo = new CategoryRepository();
        }

        public List<Category> GetAll()
        {
            return _repo.GetAll();
        }

        public Category GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Category category)
        {
            _repo.Add(category);
        }

        public void Update(Category category)
        {
            _repo.Update(category);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
