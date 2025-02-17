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
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    public partial class orderModal : Form
    {
        string connectionString;
        int currentPage = 1;
        int totalPage = 1;
        public List<PROJET_C__GESTIONRESTO.Models.Product> list1;
        public List<PROJET_C__GESTIONRESTO.Models.Product> SelectedProducts = new List<PROJET_C__GESTIONRESTO.Models.Product>();

        public orderModal()
        {
            InitializeComponent();
            this.Text = string.Empty;
            RadbtnHere.Checked = true;
            var config = ConfigurationHelper.GetConfiguration();
            ProductProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            OrderProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            TableProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            OrderItemProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            ZoneProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            ClientProcess.connecctionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            CoverProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
        }

        private void orderModal_Load(object sender, EventArgs e)
        {
            LoadDgv1();
            LoadTableItem();
            lblCurrentPage.Text = currentPage.ToString();
            lblTotalPage.Text = totalPage.ToString();
            LoadSectorItem();
            LoadQuaterItem(cbSecteur.Items[0].ToString());
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
                product.Quantity = modal.quantity;
                SelectedProducts.Add(product);

                LoadDgv2();
                LoadDgv1();
            }
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
            if (currentPage > 1)
            {
                currentPage--;
                lblCurrentPage.Text = currentPage.ToString();
                LoadDgv1(txtSearch.Text);
            }
            else
            {
                MessageBox.Show("limit atteint", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPage)
            {
                currentPage++;
                lblCurrentPage.Text = currentPage.ToString();
                LoadDgv1(txtSearch.Text);
            }
            else
            {
                MessageBox.Show("limit atteint", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RadbtnHere_CheckedChanged(object sender, EventArgs e)
        {
            if (RadbtnHere.Checked)
                cbTable.Enabled = true;
            else
            {
                cbTable.Text = string.Empty;
                cbTable.Enabled = false;
            }
        }


        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadDgv1(txtSearch.Text);
        }

        private void RadbtnDeliver_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBtnDeliver.Checked)
                gbZone.Enabled = true;
            else
                gbZone.Enabled = false;
        }

        private void cbSecteur_SelectedValueChanged(object sender, EventArgs e)
        {
            cbQuatier.Items.Clear();
            LoadQuaterItem(cbSecteur.SelectedItem.ToString());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Order order = new();

            if (SelectedProducts.Count <= 0)
            {
                MessageBox.Show("Veuillez choisir un element du menu avant de commander", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (RadbtnHere.Checked)
            {
                if (string.IsNullOrEmpty(cbTable.Text))
                {
                    MessageBox.Show("Veuillez selectionner un table", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var table = TableProcess.GetTable(1, cbTable.SelectedItem.ToString()).items;
                order.Table = table[0].Id;
                order.Type = RadbtnHere.Text;
                order.Status = "paid";
                OrderProcess.SaveOrder(order);

                JoinOrderItemToOrder(SelectedProducts, order);
            }
            else if (RadBtnOut.Checked)
            {
                order.Type = RadBtnOut.Text;
                order.Status = "paid";
                OrderProcess.SaveOrder(order);
                JoinOrderItemToOrder(SelectedProducts, order);
            }
            else if (RadBtnDeliver.Checked)
            {
                foreach (var control in gBClient.Controls)
                {
                    if (control is TextBox tb && string.IsNullOrEmpty(tb.Text))
                    {
                        MessageBox.Show("Veuillez entrer tout les information sur le client", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                if (cbSecteur.SelectedItem == null || cbQuatier.SelectedItem == null)
                {
                    MessageBox.Show("Il semblerait que vous n'avait fournir toute les information sur la zone de livraison", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                order.Type = RadBtnDeliver.Text;
                Client client = new()
                {
                    Name = txtName.Text,
                    Prenom = txtSurname.Text,
                    Tel = txtPhone.Text
                };
                client = ClientProcess.SaveClient(client);
                Zone zone = ZoneProcess.FindOneByOrNull(cbQuatier.Text);
                order.Client = client.Id;
                order.Zone = zone.Id;
                order.Status = "pending";
                OrderProcess.SaveOrder(order);
            }
            MessageBox.Show("Your order have saved with successfuly", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        // Methods no event

        public void LoadTableItem()
        {
            var paginator = TableProcess.GetTable(1);
            List<Table> tables = paginator.items;

            foreach (var table in tables)
            {
                cbTable.Items.Add(table.Position);
            }
        }

        public void LoadSectorItem()
        {
            List<Cover> covers = CoverProcess.Find();

            foreach (var cover in covers)
            {
                cbSecteur.Items.Add(cover.Designation);
            }
        }
        public void LoadQuaterItem(string? cover = null)
        {
            List<Zone> zones = ZoneProcess.FindZone(cover); ;

            foreach (var zone in zones)
            {
                cbQuatier.Items.Add(zone.Designation);
            }
        }

        public void JoinOrderItemToOrder(List<PROJET_C__GESTIONRESTO.Models.Product> products, Order order)
        {
            foreach (PROJET_C__GESTIONRESTO.Models.Product product in products)
            {
                Orderitem orderitem = new()
                {
                    Product = product.Id,
                    Order = order.Id,
                    Quantity = (int)product.Quantity
                };
                OrderItemProcess.SaveOrderItem(orderitem);
            }
        }

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

        public void LoadDgv1(string? wordSearch = null)
        {
            var paginationResult = ProductProcess.GetProduct(currentPage, wordSearch);
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
            lb.Items.Add(ps_Id);
            lb.Items.Add(ps_Designation);
            lb.Items.Add(ps_UnityPrice);
            lb.Items.Add(ps_Intitule);
            lb.Items.Add(ps_Quantity);

            if (SelectedProducts.Count > 0)
                MainClass.LoadData(dgvSelectedProduct, lb, SelectedProducts);
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
