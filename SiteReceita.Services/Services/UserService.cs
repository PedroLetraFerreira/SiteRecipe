using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class UserService
    {
        private UserRepository _repo;

        public UserService()
        {
            _repo = new UserRepository();
        }

        public List<User> GetAll()
        {
            return _repo.GetAll();
        }

        public User GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(User user)
        {
            _repo.Add(user);
        }

        public void Update(User user)
        {
            _repo.Update(user);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
