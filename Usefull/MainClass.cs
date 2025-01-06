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
            int i = 0;

            List<string> colonneSelected = new List<string>();
            foreach (DataGridViewColumn col in lb.Items)
            {
                colonneSelected.Add(col.Name);
                i++;
            }
            var properties = typeof(T).GetProperties();
            i = 0;

            foreach ( var data in datas )
            {
                var row = new DataGridViewRow();
                row.CreateCells(gv);
                foreach (var property in properties)
                {
                    for (int j = 0; j < colonneSelected.Count; j++)
                    {
                        if (colonneSelected[j].Contains(property.Name))
                        {
                            var value = property.GetValue(data);
                            //var cell = new DataGridViewTextBoxCell
                            //{
                            //    Tag = colonneSelected[j],
                            //};
                            //cell.Value = value;
                            row.Cells[j].Value = value;
                        }
                    }
                }
                gv.Rows.Add(row);
            }
        }

    }
}
