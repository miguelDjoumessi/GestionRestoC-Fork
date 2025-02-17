using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.ReservationView
{
    public partial class FormAddBooking : Form
    {
        public FormAddBooking()
        {
            InitializeComponent();
            var config = ConfigurationHelper.GetConfiguration();
            ClientProcess.connecctionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            BookingProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            TableProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
        }

        private void FormAddBooking_Load(object sender, EventArgs e)
        {

            cbPeriod.SelectedIndex = 0;
            FillTable();
        }
        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkFull())
                return;

            var client = new Client();
            client.Name = txtName.Text;
            client.Prenom = txtPrenom.Text;
            client.Tel = txtTel.Text;
            client = ClientProcess.SaveClient(client);
            var book = new Booking();
            book.Client = client.Id;
            book.Period = cbPeriod.SelectedItem.ToString();
            book.Persons = (int)nudPersons.Value;
            book.Table = Convert.ToInt32(cbTable.SelectedItem.ToString());
            book.State = "active";
            book.RequestState = "accepted";
            book = BookingProcess.SaveBook(book);
            if (book != null)
            {
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkFields()
        {
            return cbPeriod.SelectedItem == null || cbTable.SelectedItem == null
                 || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrenom.Text);
        }
        private bool checkLengthField()
        {
            return txtName.Text.Length < 3 || txtPrenom.Text.Length < 3 || txtTel.Text.Length < 3;
        }

        private bool checkFull()
        {
            if (checkFields())
            {
                MessageBox.Show("Il semblerait que vous avez omis une information. Veuillez reverifier le formuaire", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (checkLengthField())
            {
                MessageBox.Show("la taille de chaque information concernant le client doit etre au minimum 03 caratères", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (cbTable.Text.EndsWith("reservé"))
            {
                MessageBox.Show("la table que vous avez selectionné est déja reservée", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            if (nudPersons.Value < 1)
            {
                MessageBox.Show("La reservation doit etre au moins pour une personne", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private void FillTable()
        {
            cbTable.Items.Clear();
            var tables = TableProcess.FindTableNotReservedBy(cbPeriod.Text);

            if (tables.Count > 0)
                foreach (var table in tables)
                    cbTable.Items.Add(table.Position);
        }
    }
}
