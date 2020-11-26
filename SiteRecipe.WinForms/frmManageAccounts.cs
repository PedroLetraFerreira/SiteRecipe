using SiteRecipe.Model.Model;
using SiteRecipe.Model.Model.Util;
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
    public partial class frmManageAccounts : Form
    {
        private UserService _service;
        
        public frmManageAccounts()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void ValidateBtn_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTxt.Text;
            string lastName = LastNameTxt.Text;
            string country = CountryTxt.Text;
            Gender gender = (Gender)Enum.Parse(typeof(Gender), GenderCbBox.SelectedItem.ToString());
            string email = EmailTxt.Text;
            DateTime birthDate = DateTimePicker.Value;
            bool isAdministrator = false;

            User user = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Country = country,
                Gender = gender,
                Email = email,
                BirthDate = birthDate,
                IsAdministrator = isAdministrator 
            };

            try
            {
                _service.Add(user);
                MessageBox.Show("User saved with the id: " + user.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
