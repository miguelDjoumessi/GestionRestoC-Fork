using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.MenuViews
{
    public partial class MenuDash : Form
    {
        public MenuDash()
        {
            InitializeComponent();
            var menu = new MenuController();
            menu.isSelected = true;
            LPanelMenu.Controls.Add(new MenuController());
            LPanelMenu.Controls.Add(menu);
        }

        private void LPanelMenu_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMenuView modal = new AddMenuView();
            var resultat = modal.ShowDialog();
            if(resultat == DialogResult.OK)
            {
                MessageBox.Show("Le Menu a ete creer avec succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
