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
    public partial class FormOrderAdd : Add
    {
        public int quantity = 0;
        public FormOrderAdd()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtQty.Text == "")
                MessageBox.Show("Vous devez entrez un nombre entier avant de continuer", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if(Int32.TryParse(txtQty.Text, out quantity))
                MessageBox.Show("votre valeur: "  + quantity, "succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
