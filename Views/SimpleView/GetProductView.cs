using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    public partial class GetProductView : Form
    {
        public GetProductView()
        {
            InitializeComponent();
            var config = ConfigurationHelper.GetConfiguration();
            ProductProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
        }

        private void GetProductView_Load(object sender, EventArgs e)
        {
            FillPanelList();
        }

        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            FillPanelList();
        }
        private void btnValide_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FillPanelList()
        {
            var products = ProductProcess.FindAll(txtSearchbar.Text);
            LpProducts.Controls.Clear();
            if (products.Count > 0)
            {
                if (!LpProducts.Visible)
                    toggleVisibilityListMenu();

                foreach (var product in products)
                {
                    ProductController np = new(product.Id);
                    np.lblName.Text = product.Designation;
                    np.lblDescription.Text = product.Description;
                    np.lblPrice.Text = product.UnityPrice.ToString();

                    LpProducts.Controls.Add(np);
                }
            }
            else
                toggleVisibilityListMenu();
        }

        protected void toggleVisibilityListMenu()
        {
            if (LpProducts.Visible)
            {
                LpProducts.Visible = false;
                lblListEmpty.Visible = true;
            }
            else
            {
                LpProducts.Visible = true;
                lblListEmpty.Visible = false;
            }

        }

    }
}
