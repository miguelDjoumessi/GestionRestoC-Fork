using Guna.UI2.WinForms;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.LogicApp;
using PROJET_C__GESTIONRESTO.Usefull;
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
    public partial class FormCategoryView : ListForm
    {
        public int currentPage = 1;
        public int totalPages = 1;
        public FormCategoryView()
        {
            InitializeComponent();
            var configuration = ConfigurationHelper.GetConfiguration();
            CategoryProcess.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
            
        }

        private void FormCategoryView_Load(object sender, EventArgs e)
        {

            try
            {
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            lblCounter.Text = Convert.ToString(currentPage);
            lblPages.Text = Convert.ToString(totalPages);
        }

        public void GetData(string? word = null)
        {
            var paginationResult = CategoryProcess.GetCategories(currentPage, word);
            var listCategories = paginationResult.items;
            this.totalPages = paginationResult.TotalPages;
            ListBox lb = new ListBox();
            lb.Items.Add(cId);
            lb.Items.Add(cIntitule);

            MainClass.LoadData(dgvCategory, lb, listCategories);
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData(txtSearch.Text);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            FormCategoryAdd modal = new FormCategoryAdd();
            modal.ShowDialog();
            GetData();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int categoryId = (int)dgvCategory.CurrentRow.Cells[0].Value;

            if (dgvCategory.CurrentCell.OwningColumn.Name == "cEdit")
            {
                FormCategoryAdd modal = new FormCategoryAdd(categoryId);
                modal.txtName.Text = (string)dgvCategory.CurrentRow.Cells[1].Value;
                modal.ShowDialog();


                GetData();
            }
            else if (dgvCategory.CurrentCell.OwningColumn.Name == "cDelete")
            {
                if (CategoryProcess.DeleteCategory(categoryId) > 0)
                {
                    MessageBox.Show("the Delete has been a success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                GetData();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                lblCounter.Text = currentPage.ToString();
                GetData();
            }
            else
            {
                MessageBox.Show("limit atteint", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                lblCounter.Text = currentPage.ToString();
                GetData();
            }
            else
            {
                MessageBox.Show("limit atteint", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
