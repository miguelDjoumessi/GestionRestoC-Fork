using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJET_C__GESTIONRESTO.Views.SimpleView
{
    public partial class ProductController : UserControl
    {
        public int product;
        public bool isSelected = false;
        public ProductController(int productId)
        {
            InitializeComponent();
            product = productId;
        }

        private void guna2Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!chkbSelection.Checked)
            {
                chkbSelection.Checked = true;
                toggleIsSelected();
            }
            else
            {
                chkbSelection.Checked = false;
                toggleIsSelected();
            }
        }

        private void toggleIsSelected()
        {
            isSelected = chkbSelection.Checked;
        }

        private void chkbSelection_CheckedChanged(object sender, EventArgs e)
        {
            toggleIsSelected();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }
    }
}
