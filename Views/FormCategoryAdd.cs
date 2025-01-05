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
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        protected override void btnSave_Click(object sender, EventArgs e)
        {
            if(id == 0)
            {
                if (txtName.Text != null)
                {
                    Category category = new Category();
                    category.Intitule = txtName.Text;

                    if(CategoryProcess.SaveCategory(category) > 0)
                    {
                        Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
                        guna2MessageDialog.Icon = MessageDialogIcon.Information;
                        guna2MessageDialog.Caption = "Success";
                        guna2MessageDialog.Buttons = MessageDialogButtons.OK;
                        guna2MessageDialog.Text = "Category saving with success";

                        guna2MessageDialog.Show();
                    }
                    MessageBox.Show("une erreur c'est produitent. Veuillez reessayer");
                }

                MessageBox.Show("Veuillez entrez un mot de taille >3 dans le champs");

            }
            else
            {
                if(txtName.Text != null)
                {
                    Category newCategory = new Category();
                    newCategory.CreatedAt = null;

                    if(CategoryProcess.UpdateCategory(id, newCategory) > 0){
                        Guna2MessageDialog guna2MessageDialog = new Guna2MessageDialog();
                        guna2MessageDialog.Icon = MessageDialogIcon.Information;
                        guna2MessageDialog.Caption = "Success";
                        guna2MessageDialog.Buttons = MessageDialogButtons.OK;
                        guna2MessageDialog.Text = "Category update with success";

                        guna2MessageDialog.Show();

                    }
                    MessageBox.Show("une erreur c'est produitent. Veuillez reessayer");
                }

                MessageBox.Show("Veuillez entrez un mot de taille >3 dans le champs");
            }
            id = 0;
            txtName.Focus();
        }

        protected override void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
