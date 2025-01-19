using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
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
using System.Xml.Linq;

namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    public partial class orderModal : Form
    {
        string connectionString;
        int page = 1;
        int totalPage = 0;
        public List<PROJET_C__GESTIONRESTO.Models.Product> list1;
        public List<PROJET_C__GESTIONRESTO.Models.Orderitem> SelectedProducts = new List<PROJET_C__GESTIONRESTO.Models.Orderitem>();

        public orderModal()
        {
            InitializeComponent();
            this.Text = string.Empty;
            var config = ConfigurationHelper.GetConfiguration();
            ProductProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
        }

        private void orderModal_Load(object sender, EventArgs e)
        {
            LoadDgv1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                CheckTextBIfNotEmpty();
            }
            catch (Exception ex) { }

            Client client = CheckIfClientExist(txtName.Text, txtSurname.Text, txtPhone.Text);
            if (client == null)
            {
                client.Name = txtName.Text;
                client.Prenom = txtSurname.Text;
                client.Tel = txtPhone.Text;
                client.Employee = (int)pnHeader.Tag;
            }

            Order newOrder = new Order();
            foreach (Control radioButton in GBType.Controls)
            {
                if (radioButton is RadioButton rb && rb.Checked)
                {
                    newOrder.Type = radioButton.Text;
                }
            }
        }

        private void CheckTextBIfNotEmpty()
        {
            foreach (Control control in gBClient.Controls)
            {
                if (control is TextBox txt && string.IsNullOrEmpty(txt.Text))
                {
                    MessageBox.Show("Veuillez verifier que tout les champs sont correctement remplis avant de valider", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw new Exception("the field cannot be empty");
                }
            }
        }
        private Client CheckIfClientExist(string name, string surname, string phone)
        {
            using (var context = new AppDbContext(connectionString))
            {
                var client = context.Clients.FirstOrDefault(clt => clt.Name == name && clt.Prenom == surname && clt.Tel == phone);
                return client;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (this.DialogResult == DialogResult.None)
            {
                this.Close();
            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListProduct.CurrentCell.OwningColumn.Name == "p_Add")
            {
                int id = (int)dgvListProduct.CurrentRow.Cells[0].Value;
                var product = list1.FirstOrDefault(p => p.Id == id);
                FormOrderAdd modal = new();
                modal.ShowDialog();
                Orderitem oi = new Orderitem();
                if(modal.DialogResult == DialogResult.OK) 
                    oi.Quantity = modal.quantity;
                oi.ProductNavigation = product;
                SelectedProducts.Add(oi);       

                LoadDgv2();
                LoadDgv1();
            }
        }

        public void LoadDgv1(string? wordSearch = null)
        {
            var paginationResult = ProductProcess.GetProduct(page, wordSearch);
            list1 = paginationResult.items;
            totalPage = paginationResult.TotalPages;
            ListBox lb = new ListBox();
            lb.Items.Clear();
            lb.Items.Add(p_Id);
            lb.Items.Add(p_Designation);
            lb.Items.Add(p_UnityPrice);
            lb.Items.Add(p_Intitule);

            if (SelectedProducts.Count > 0)
            {
                foreach (var product in SelectedProducts)
                {
                    list1 = list1.FindAll(p => p.Id != product.Id);
                }
            }

            MainClass.LoadData(dgvListProduct, lb, list1);
        }

        public void LoadDgv2(string? wordSearch = null)
        {
            ListBox lb = new ListBox();
            lb.Items.Clear();
            lb.Items.Add(p_Id);
            lb.Items.Add(p_Designation);
            lb.Items.Add(p_UnityPrice);
            lb.Items.Add(p_Intitule);
            lb.Items.Add(ps_Qty);

            if(SelectedProducts.Count > 0) 
                MainClass.LoadData(dgvSelectedProduct, lb, SelectedProducts);
        }

        private void dgvSelectedProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSelectedProduct.CurrentCell.OwningColumn.Name == "ps_Delete")
            {
                int id = (int)dgvSelectedProduct.CurrentRow.Cells[0].Value;
                SelectedProducts = SelectedProducts.FindAll(p => p.Id != id);
                dgvSelectedProduct.CurrentRow.Visible = false;

                LoadDgv1();
            }
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }


        // Methods no event

        public object? GetValueOfProperty<T>(T intent, string propertyName)
        {
            var properties = intent.GetType().GetProperties();
            var property = properties.FirstOrDefault(p => p.Name == propertyName);

            if (property != null)
            {
                var value = property.GetValue(intent);
                return value;
            }

            return null;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
