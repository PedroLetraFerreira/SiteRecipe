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
    public partial class frmPrincipal : Form
    {
        private bool closeSentinel = false;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region Forms

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            form.MdiParent = this;
            form.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchUser form = new frmSearchUser();
            form.MdiParent = this;
            form.Show();
        }

        private void recipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchRecipe form = new frmSearchRecipe();
            form.MdiParent = this;
            form.Show();
        }

        private void validateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageAccounts form = new frmManageAccounts();
            form.MdiParent = this;
            form.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageAccounts form = new frmManageAccounts();
            form.MdiParent = this;
            form.Show();
        }

        private void validateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageIngredients form = new frmManageIngredients();
            form.MdiParent = this;
            form.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageIngredients form = new frmManageIngredients();
            form.MdiParent = this;
            form.Show();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmManageIngredients form = new frmManageIngredients();
            form.MdiParent = this;
            form.Show();
        }

        private void validateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmManageRecipes form = new frmManageRecipes();
            form.MdiParent = this;
            form.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdateRecipe form = new frmUpdateRecipe();
            form.MdiParent = this;
            form.Show();
        }

        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmManageRecipes form = new frmManageRecipes();
            form.MdiParent = this;
            form.Show();
        }

        #endregion

        #region Options

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SairMessage())
            {
                closeSentinel = true;
                Application.Exit();
            }
        }

        private bool SairMessage()
        {
            DialogResult result = MessageBox.Show("Do you want to exit the application?", "Closing...", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (!closeSentinel)
            {
                if (SairMessage())
                {
                    Dispose(true);
                    Application.Exit();
                }
                e.Cancel = true;
            }
        }

        #endregion

    }
}
