using Guna.UI2.WinForms;
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
    public partial class IgdForm : SimpleView.ListForm
    {
        public Guna2MessageDialog Dialog = new Guna2MessageDialog();

        public IgdForm()
        {
            InitializeComponent();
        }

        private void IgdForm_Load(object sender, EventArgs e)
        {
        }
        public void RefreshData()
        {
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
        }
    }
}
