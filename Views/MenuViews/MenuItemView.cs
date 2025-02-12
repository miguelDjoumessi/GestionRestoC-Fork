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
    public partial class MenuItemView : UserControl
    {
        public int menuitemId;
        public Product product;
        private MenuItemProcess menuitemProcess = new();
        public MenuItemView(Product product, int menuitemId)
        {
            InitializeComponent();
            this.product = product;
            ShowMenuItem();
            this.menuitemId = menuitemId;
        }
        private void ShowMenuItem()
        {
            lblName.Text = product.Designation;
            lblDescription.Text = product.Description;
            lblPrice.Text = product.UnityPrice.ToString();
        }

        private void picDelete_Click(object sender, EventArgs e)
        {
            var result = menuitemProcess.DeleteMenuItem(menuitemId);
            if(result > 0 )
            {
                MessageBox.Show("Le Menu a ete creer avec succes", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
