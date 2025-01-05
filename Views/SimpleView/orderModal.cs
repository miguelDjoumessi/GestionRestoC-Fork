using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
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
    public partial class orderModal : Form
    {
        string connectionString;

        public orderModal()
        {
            InitializeComponent();
            this.Text = string.Empty;
            var config = ConfigurationHelper.GetConfiguration();
            this.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
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
            foreach (Control radioButton in gBType.Controls)
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
            this.Close();
        }
    }
}
