using SiteRecipe.Data.Repositories;
using SiteRecipe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Services.Services
{
    public class AccountService
    {
        private AccountRepository _repo;

        public AccountService()
        {
            _repo = new AccountRepository();
        }

        public List<Account> GetAll()
        {
            return _repo.GetAll(); 
        }

        public Account GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Account account)
        {
            _repo.Add(account);
        }

        public void Update(Account account)
        {
            _repo.Update(account);
        }

        public void Remove(int id)
        {
            _repo.Remove(id);
        }
    }
}
