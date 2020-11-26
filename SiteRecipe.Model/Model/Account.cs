using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Model.Model
{
    public class Account 
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
