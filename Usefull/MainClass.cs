using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PROJET_C__GESTIONRESTO.Usefull
{
    class MainClass
    {
        public static string? connectionString;
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

        public static string USER
        {
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
            if (datas == null || !datas.Any())
            {
                MessageBox.Show("La liste des données est vide.");
                return;
            }

            if (lb.Items.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner au moins une colonne à afficher dans le ListBox.");
                return;
            }

            gv.Rows.Clear();

            List<string> SelectedColumns = new List<string>();

            foreach (DataGridViewColumn col in lb.Items)
            {
                SelectedColumns.Add(col.Name);
            }

            var properties = typeof(T).GetProperties();

            foreach (var data in datas)
            {
                var row = new List<object>();

                foreach (var column in SelectedColumns)
                {

                    var nameProp = column.Split('_')[1];
                    var props = typeof(T).GetProperty(nameProp, BindingFlags.Public | BindingFlags.Instance);

                    if (props != null)
                    {
                        var value = props.GetValue(data);
                        row.Add(value ?? "");
                    }
                    else
                    {

                        var type = data.GetType();
                        foreach (var property in type.GetProperties())
                        {
                            // Vérifier si la propriété est une classe et non une primitive ou une collection
                            if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                            {   
                                try
                                {
                                    var dataProperty = property.GetValue(data);
                                    var prop = dataProperty.GetType().GetProperty(nameProp);

                                    if (prop == null)
                                        continue;

                                    var propValue = prop.GetValue(dataProperty);
                                    row.Add((string)propValue);
                                    break;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Une erreur est survenu lors de l'affichage de la colonne categorie: " + ex.Message);
                                }
                            }
                        }
                    }

                }
                gv.Rows.Add(row.ToArray());
            }
        }

        public static bool IsPropertyAnInstanceOfClass<T>(T obj, string propertyName)
        {
            MessageBox.Show(propertyName);

            if (obj == null || string.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException("L'objet et le nom de la propriété doivent être spécifiés.");

            // Récupérer les informations sur la propriété
            var propertyInfo = obj.GetType().GetProperty(propertyName);

            if (propertyInfo == null)
                throw new ArgumentException($"La propriété '{propertyName}' n'existe pas sur le type '{obj.GetType().Name}'.");

            // Vérifier si le type de la propriété est une classe
            return propertyInfo.PropertyType.IsClass && propertyInfo.PropertyType != typeof(string);
        }

        public static object? GetValueOfProperty<T>(T instance, string propertyName)
        {
            if (instance == null || string.IsNullOrEmpty(propertyName))
                throw new ArgumentNullException("L'objet et le nom de la propriété doivent être spécifiés.");

            var property = instance.GetType().GetProperty(propertyName);

            if (property == null)
                throw new ArgumentNullException("the property is not exist");

            var value = property.GetValue(instance);

            return value;

        }
    }
}


//foreach (var property in properties)
//{
//    for (int j = 0; j < SelectedColumns.Count; j++)
//    {
//        if (SelectedColumns[j].Contains(property.Name))
//        {
//            var value = property.GetValue(data);
//            //var cell = new DataGridViewTextBoxCell
//            //{
//            //    Tag = SelectedColumns[j],
//            //};
//            //cell.Value = value;
//            row.Cells[j].Value = value;
//        }
//    }
//}

//var nameProp = column.Split('_')[1];

//// Utiliser la réflexion pour récupérer les valeurs des propriétés correspondant aux colonnes sélectionnées.
//var property = typeof(T).GetProperty(nameProp, BindingFlags.Public | BindingFlags.Instance);

//if (property != null)
//{
//    var value = property.GetValue(data);
//    if (IsPropertyAnInstanceOfClass(value, property.Name))
//    {

//    }
//    row.Add(value ?? "");
//}