using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PROJET_C__GESTIONRESTO.Usefull
{
    class MainClass
    {
        private static string? connectionString;
        public MainClass() 
        { 
            var configuration = ConfigurationHelper.GetConfiguration();
            connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");

            if (connectionString == null)
            {
                MessageBox.Show("Aucune chaine de connection trouvée", connectionString, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        public static string user;

        public static string USER {
            get { return user; }
            private set { user = value; }
        }

        public static bool IsValidUser(string username, string password)
        {
            bool isValid = false;

            using (AppDbContext context = new AppDbContext(connectionString))
            {
                Employee? operateur = context.Employees.FirstOrDefault(o => o.Email == username && o.Password == password);

                if (operateur == null)
                {
                    return isValid;
                }

                USER = username;
                return isValid = true;
            }
        }

        // Method for crud operation
        public static void LoadData<T>(DataGridView gv, ListBox lb, List<T> datas)
        {
            gv.Rows.Clear();

            for (int i = 0; i < lb.Items.Count; i++)
            {
                string colName = ((DataGridViewColumn)lb.Items[i]).ToString();
                gv.Columns[colName].DataPropertyName = datas[i].ToString();
            }

            gv.DataSource = datas;
        }

    }
}
