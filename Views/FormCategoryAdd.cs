using Guna.UI2.WinForms;
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

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class FormCategoryAdd : Add
    {
        private int? categoryId = 0;
        public FormCategoryAdd(int? id = 0)
        {
            InitializeComponent();
            txtName.Focus();
            this.categoryId = id;
        }

        public int id = 0;

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == null)
            {
                MessageBox.Show("Veuillez remplir le champs et reessayer", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtName.Focus();
                return;
            }
            if (categoryId == 0)
            {
                Category category = new()
                {
                    Intitule = txtName.Text
                };

                if (CategoryProcess.SaveCategory(category) > 0)
                {
                    MessageBox.Show("Categorie enregistrer avec succés", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Une erreur s'est produit lors de la sauvegarde du produit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Category newCategory = new Category();
                newCategory.Intitule = txtName.Text;

                if (CategoryProcess.UpdateCategory(categoryId, newCategory) > 0)
                {
                    MessageBox.Show("Categorie enregistrer avec succés", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("une erreur c'est produitent. Veuillez reessayer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
