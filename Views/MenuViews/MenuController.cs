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
    public partial class MenuController : UserControl
    {
        public static MenuController menuSelected = null;
        public bool isSelected = false;
        public Menu menu;
        public readonly MenuProcess menuProcess = new();

        public MenuController(Menu menu)
        {
            InitializeComponent();
            picMenu.FillColor = Color.FromArgb(100, 3, 3, 3);
            this.menu = menu;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MenuController_Load(object sender, EventArgs e)
        {
            if (isSelected)
                SelectedMenu();
            initComponent();
            lblDescription.Location = new Point(
                (picMenu.ClientSize.Width - lblDescription.Width) / 2,
                (picMenu.ClientSize.Height - lblDescription.Height) / 2
            );
        }

        private void RbDefMenu_CheckedChanged(object sender, EventArgs e)
        {
        }

        public void DeselectCard()
        {
            RbDefMenu.Checked = false;
            pnHeader.FillColor = Color.Black;
            pnFooter.FillColor = Color.Black;
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            menuProcess.SelectedMenu(menu.Id);
            SelectedMenu();
            MessageBox.Show("Vous venez de definir ce menu comme menu du jour", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectedMenu()
        {
            if (menuSelected != null && menuSelected != this)
            {
                menuSelected.DeselectCard(); // Désélectionne l'ancienne carte
            }

            menuSelected = this;
            RbDefMenu.Checked = true;
            pnHeader.FillColor = Color.OrangeRed;
            pnFooter.FillColor = Color.OrangeRed;

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            // Afficher le menu et le placer pret de l'element appelant
            ContextMenu.Show(btnMenu, new Point(10, btnMenu.Height));
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            Menu m = new()
            {
                Id = 1,
                Theme = "Mediévale",
                Description = "Decouvrir les mets deguster a l'epoque medieval"

            };
            new EditMenuView(m).Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            var resultat = MessageBox.Show("Etes-vous vraiment sur de vouloir supprimer l'element", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resultat == DialogResult.Yes)
            {
                int result = menuProcess.DeleteMenu(menu.Id);
                if(result > 0)
                {
                    this.Parent.Controls.Remove(this);
                    MessageBox.Show("the element have been delete with successufuly", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void initComponent()
        {
            lblTheme.Text = menu.Theme;
            lblDescription.Text = menu.Description;
        }
    }
}
