using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Views.MenuViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    public partial class GetProductView : Form
    {
        public List<int> products = new List<int>();
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

        private void btnValide_Click(object sender, EventArgs e)
        {
            var list = LpProducts.Controls;
            foreach(var product in list)
            {
                if(product is ProductController mi && mi.isSelected)
                {
                    products.Add(mi.product);
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillPanelList()
        {
            LpProducts.Controls.Clear();
            var products = ProductProcess.FindAll(txtSearchbar.Text);
            if (products.Count > 0)
            {
                if (!LpProducts.Visible)
                {
                    toggleVisibilityListMenu();
                }

                foreach (var product in products)
                {
                    ProductController np = new(product.Id);
                    np.lblName.Text = product.Designation;
                    np.lblDescription.Text = product.Description;
                    np.lblPrice.Text = product.UnityPrice.ToString();

                    LpProducts.Controls.Add(np);
                }
            }
            else { toggleVisibilityListMenu(); }
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

        private void txtSearchbar_Leave(object sender, EventArgs e)
        {
            FillPanelList();
        }

        // afficher un ombre derriere le form
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

    }

}
