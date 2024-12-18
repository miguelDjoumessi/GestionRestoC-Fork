using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class MenuItemProcess
    {
        public readonly string? connectionString;

        public MenuItemProcess()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            this.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
        }

        public int CreateProduct(Menuitem menuItem)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                context.Menuitems.Add(menuItem);
                lines = context.SaveChanges();
            }

            return lines;
        }

        public int UpdateMenuItem(Menuitem menuitem, int newproductId)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                var product = context.Products.FirstOrDefault(p => p.Id == newproductId);

                if (product != null)
                {
                    menuitem.Product = product;
                    context.Update(menuitem);
                    lines = context.SaveChanges();
                }

                return lines;
            }
        }

        public int DeleteMenuItem(int id)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                var menuitem = context.Menuitems.FirstOrDefault(mi => mi.Id == id);

                if (menuitem != null)
                {
                    context.Menuitems.Remove(menuitem);
                    lines = context.SaveChanges();
                }

                return lines;
            }
        }

        public int DeleteCollectionMenuItem(List<int> menuitems)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {

                foreach (var item in menuitems)
                {
                    var menuitem = context.Menuitems.FirstOrDefault(mi => mi.Id == item);

                    if (menuitem != null)
                    {
                        context.Menuitems.Remove(menuitem);
                    }
                }

                lines = context.SaveChanges();
                return lines;
            }
        }

        public List<Product> FilterMenuItems(string searchValue)
        {
            List<Product> list = new List<Product>();

            using (var context = new AppDbContext(connectionString))
            {
                var items = context.Products
                    .Where(p => context.Menuitems.Any(mi => mi.Product == p.Id) && p.Designation == searchValue)
                    .ToList();

                if (items != null)
                {
                    list = items;
                }


                return list;
            }
        }
    }
}
