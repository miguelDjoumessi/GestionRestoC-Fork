using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.ReservationView
{
    public partial class ReservationDash : Form
    {
        protected int page = 1;
        protected int pageFilter = 1;
        protected int totalPage = 1;
        public ReservationDash()
        {
            InitializeComponent();
            lbPage.Text = page.ToString();
            var config = ConfigurationHelper.GetConfiguration();
            BookingProcess.connectionString = config.GetValue<string>("ConnectionString:MySqlConnection");
            FillDataGridView();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            FormAddBooking modal = new FormAddBooking();
            var result = modal.ShowDialog();
            if(result == DialogResult.OK)
                FillDataGridView();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (page > 1 && string.IsNullOrEmpty(cbFilter.Text))
            {
                page -= page;
                lbPage.Text = page.ToString();
                FillDataGridView();
            }
            else if (!string.IsNullOrEmpty(cbFilter.Text) && pageFilter > 1)
            {
                pageFilter--;
                lbPage.Text = pageFilter.ToString();
                FilterList();
            }
            else
                MessageBox.Show("Limite atteinte", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            if (page < totalPage && string.IsNullOrEmpty(cbFilter.Text))
            {
                page += page;
                lbPage.Text = page.ToString();
                FillDataGridView();
            }
            else if (pageFilter < totalPage && !string.IsNullOrEmpty(cbFilter.Text))
            {
                pageFilter++;
                lbPage.Text = pageFilter.ToString();
                FilterList();
            }
            else
                MessageBox.Show("Limite atteinte", "warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void txtSearchbar_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbFilter.Text))
                FillDataGridView();
            else
                FilterList();
        }
        private void FillDataGridView()
        {
            pageFilter = 1; 
            dgvListBook.Rows.Clear();
            PaginationContext<Booking> paginator;
            paginator = BookingProcess.FindAll(page, txtSearchbar.Text);
            var books = paginator.items;
            totalPage = paginator.TotalPages;
            ListBox fields = new ListBox();
            fields.Items.Add(clt_Name);
            fields.Items.Add(clt_Tel);
            fields.Items.Add(clt_Persons);
            fields.Items.Add(clt_Position);
            fields.Items.Add(clt_RequestState);
            fields.Items.Add(clt_State);

            MainClass.LoadData(dgvListBook, fields, books);
        }

        private void FilterList()
        {
            page = 1;
            dgvListBook.Rows.Clear();
            var paginator = BookingProcess.Filter(pageFilter, cbFilter.Text);
            var books = paginator.items;
            totalPage = paginator.TotalPages;
            ListBox fields = new ListBox();
            fields.Items.Add(clt_Name);
            fields.Items.Add(clt_Tel);
            fields.Items.Add(clt_Persons);
            fields.Items.Add(clt_Position);
            fields.Items.Add(clt_RequestState);
            fields.Items.Add(clt_State);

            MainClass.LoadData(dgvListBook, fields, books);
        }

    }
}
