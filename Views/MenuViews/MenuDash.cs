using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
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
        public readonly MenuProcess menuProcess = new();
        public MenuDash()
        {
            InitializeComponent();
            lblListEmpty.Location = new Point(
                (LPanelMenu.ClientSize.Width - lblListEmpty.Width) / 2,
                (LPanelMenu.ClientSize.Height - lblListEmpty.Height) / 2
            );
        }
        private void MenuDash_Load(object sender, EventArgs e)
        {
            FillLayoutPanel();
        }

        private void LPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddMenuView modal = new AddMenuView();
            var resultat = modal.ShowDialog();
            if (resultat == DialogResult.OK)
            {
                MessageBox.Show("Le Menu a ete creer avec succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FillLayoutPanel();
        }

        private void FillLayoutPanel()
        {
            
            List<Menu> menus = menuProcess.FindAll(txtSearchbar.Text);
            LPanelMenu.Controls.Clear();
            if (menus.Count > 0)
            {
                if(!LPanelMenu.Visible) 
                    toggleVisibilityListMenu();
                foreach (var menu in menus)
                {
                    var card = new MenuController(menu);
                    if (menu.IsHoliday)
                        card.isSelected = true;

                    LPanelMenu.Controls.Add(card);
                }
                return;
            }
            toggleVisibilityListMenu();
        }

        private void LPanelMenu_Resize(object sender, EventArgs e)
        {
        }

        public void toggleVisibilityListMenu()
        {
            if (LPanelMenu.Visible)
            {MessageBox.Show("1");
                LPanelMenu.Visible = false;
                lblListEmpty.Visible = true;
            }
            else
            {MessageBox.Show("2");
                LPanelMenu.Visible = true;
                lblListEmpty.Visible = false;
            }
                
        }
    }
}
