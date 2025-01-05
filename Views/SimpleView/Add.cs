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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        protected virtual void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        protected virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
