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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2TextBox2.PasswordChar = '\0'; // On efface le caractère de masquage
            }
            else
            {
                guna2TextBox2.PasswordChar = '*'; // On remet le caractère de masquage
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
