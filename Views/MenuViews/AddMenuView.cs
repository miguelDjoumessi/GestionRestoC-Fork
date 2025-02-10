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
    public partial class AddMenuView : Add
    {
        public readonly MenuProcess menuProcess = new();
        public AddMenuView()
        {
            InitializeComponent();
        }

        private void AddMenuView_Load(object sender, EventArgs e)
        {

        }

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDescription.Text) && string.IsNullOrEmpty(txtTheme.Text))
            {
                MessageBox.Show("Veuillez remplir correctement tout les champs et reessayer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Menu newMenu = new()
            {
                Theme = txtTheme.Text,
                Description = txtDescription.Text,
                IsHoliday = false
            };

            menuProcess.SavedMenu(newMenu);
            MessageBox.Show("Menu enregistrer avec succes", "successfuly", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
