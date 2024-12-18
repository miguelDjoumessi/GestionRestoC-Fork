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
    class MenuProcess
    {
        public readonly string? connectionString;

        public MenuProcess()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            this.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
        }

        public int CreateProduct(Menu menu)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                context.Menus.Add(menu);
                lines = context.SaveChanges();
            }

            return lines;
        }

        public int UpdateProduct(int id, Menu newMenu)
        {
            using (var context = new AppDbContext(connectionString))
            {
                int lines = 0;
                var menu = context.Menus.FirstOrDefault(x => x.Id == id);

                if (menu != null)
                {
                    newMenu.Id = id;
                    menu = newMenu;
                    context.Menus.Update(newMenu);
                    lines = context.SaveChanges();
                }

                return lines;
            }
        }

        public int DeleteProduct(int id)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                var menu = context.Menus.FirstOrDefault(m => m.Id == id);
                if (menu != null)
                {
                    foreach (Menuitem menuitem in menu.Menuitems)
                    {
                        context.Menuitems.Remove(menuitem);
                    }
                    context.Menus.Remove(menu);
                    lines = context.SaveChanges();
                }

                return lines;
            }
        }



        public List<Product> GetProductItem(int menuid)
        {
            List<Product>? products = new List<Product>();

            using (var context = new AppDbContext(connectionString))
            {
                var items = context.Products
                    .Where(p => context.Menuitems.Any(mi => mi.ProductId == p.Id && mi.MenuId == menuid))
                    .ToList();

                if (items.Count > 0)
                {
                    products = items;
                }
            }

            return products;
        }

        public List<object> FilterMenu(string searchValue)
        {
            List<object>? filteredItems = new List<object>();

            using (var context = new AppDbContext(connectionString))
            {
                if (searchValue.GetType() == typeof(string))
                {
                    var items = context.Menus
                            .Where("theme.Contains(@0)", searchValue)
                            .ToList();

                    if (items.Any())
                    {
                        filteredItems.Add(items);
                    }
                }

                return filteredItems;
            }
        }
    }
}
