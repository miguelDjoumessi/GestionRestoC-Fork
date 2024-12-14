using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Services;
using PROJET_C__GESTIONRESTO.Usefull.Mail;
using PROJET_C__GESTIONRESTO.Usefull;

namespace PROJET_C__GESTIONRESTO.Views
{
    public partial class LoginForm : Form
    {
        private string? connectionString;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");

            if (connectionString == null)
            {
                MessageBox.Show("Aucune chaine de connection trouvée", connectionString, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
            string name = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;

            if (name.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("les deux champs sont obligatoire");
                return;
            }

            using (var context = new AppDbContext(connectionString))
            {
                Operateur? operateur = context.Operateurs.FirstOrDefault(o => o.Email == name && o.Password == password);
                context.Operateurs.PaginedData(1);

                if (operateur == null)
                {
                    MessageBox.Show("Ses information sont incorrect", "Security Violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Connexion reussie");
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var result = guna2MessageDialog1.Show();
            if (result == DialogResult.Yes)
            {

                Application.Exit(); // Utilisez Application.Exit() pour fermer complètement l'application
            }

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
