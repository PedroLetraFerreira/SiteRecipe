using SiteRecipe.Model.Model.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiteRecipe.Model.Model
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Country { get; set; }

        public Gender Gender { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsAdministrator { get; set; }

        public Account Account { get; set; }

        public List<Recipe> OwnRecipes { get; set; }

        public List<Recipe> FavouriteRecipes { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, string country, Gender gender, string email, DateTime birthDate, bool isAdministrator)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
            Gender = gender;
            Email = email;
            BirthDate = birthDate;
            IsAdministrator = isAdministrator;
        }
    }
}
