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
        public int page = 1;
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void GetData(string? word = null)
        {
            var listCategories = CategoryProcess.GetCategories(page, word);
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
    }
}
