using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Views.SimpleView;
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
    public partial class EditMenuView : Add
    {
        public Menu menu;
        public readonly MenuProcess menuProcess = new();
        public EditMenuView(Menu? menu)
        {
            InitializeComponent();
            this.menu = menu;
        }

        private void EditMenuView_Load(object sender, EventArgs e)
        {
            txtTheme.Text = menu.Theme;
            txtDescription.Text = menu.Description;
        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            bool isChanged = (txtTheme.Text.Equals(menu.Theme) && txtDescription.Text.Equals(menu.Description));

            if(!(string.IsNullOrEmpty(txtTheme.Text) || string.IsNullOrEmpty(txtDescription.Text)) && !isChanged)
            {
                Menu newMenu = new()
                {
                    Theme = txtTheme.Text,
                    Description = txtDescription.Text
                };
                menuProcess.UpdateProduct(menu.Id, newMenu);
                MessageBox.Show("Les modification ont ete enregistrer avec succes", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
                MessageBox.Show("Les champs ne doivent ni etre vide ni porter les infos initial", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
