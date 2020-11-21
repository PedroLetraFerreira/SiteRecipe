using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteRecipe.WinForms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmCadastro());
            //Application.Run(new frmLogin());
            //Application.Run(new frmSearch());
            //Application.Run(new frmManageIngredients());
            //Application.Run(new frmManageAccounts());
            //Application.Run(new frmManageUsers());
            //Application.Run(new frmManageCategories());
            //Application.Run(new frmManageRecipes());
            Application.Run(new frmUpdateRecipe());
            //Application.Run(new frmSearchRecipe());
            //Application.Run(new frmSearchUser());
            //Application.Run(new frmPrincipal());
        }
    }
}
