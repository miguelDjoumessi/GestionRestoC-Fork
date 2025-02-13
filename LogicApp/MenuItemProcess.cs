using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Data;
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
                    menuitem.Product = product.Id;
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
                try
                {
                    var menuitem = context.Menuitems.FirstOrDefault(mi => mi.Id == id);

                    if (menuitem != null)
                    {
                        context.Menuitems.Remove(menuitem);
                        lines = context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
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
        public List<Menuitem>? FindMenuItemBy(int menuId, string? product = null)
        {
            List<Menuitem> items = new List<Menuitem>();
            using(var context = new AppDbContext(connectionString))
            {
                try
                {
                    if (!string.IsNullOrEmpty(product))
                        items = context.Menuitems
                            .Where(m => m.Menu == menuId && context.Products.Any(p => p.Id == m.Product && p.Designation.Contains(product)))
                            .Include(m => m.ProductNavigation)
                            .ToList();
                    else
                        items = context.Menuitems
                            .Where(mi => mi.Menu == menuId)
                            .Include(m => m.ProductNavigation)
                            .ToList();
                }catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
                }
            }

            return items;
        }
    }
}
