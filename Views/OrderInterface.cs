using PROJET_C__GESTIONRESTO.Models;
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
    public partial class OrderInterface : Form
    {
        public OrderInterface()
        {
            InitializeComponent();
        }

        private void OrderInterface_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            orderModal form = new orderModal();
            form.pnHeader.Tag = pnContainer.Tag;
            form.ShowDialog();
            //if(form.DialogResult.OK)
        }
    }
}
