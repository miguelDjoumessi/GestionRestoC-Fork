using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    public class MenuProcess
    {
        public readonly string? connectionString;

        public MenuProcess()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            this.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
        }

        public int SavedMenu(Menu menu)
        {
            int lines = 0;
            try
            {
                using (var context = new AppDbContext(connectionString))
                {
                    var m = context.Menus.Where(o => o.Theme == menu.Theme).FirstOrDefault();
                    if (m != null)
                    {
                        throw new Exception("Err23000: Ce menu existe deja");
                    }
                    context.Menus.Add(menu);
                    lines = context.SaveChanges();
                }
                
            }catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.InnerException?.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lines;

        }

        public int UpdateProduct(int id, Menu newMenu)
        {

            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    var menu = context.Menus.FirstOrDefault(x => x.Id == id);

                    if (menu != null)
                    {
                        menu.Theme = newMenu.Theme;
                        menu.Description = newMenu.Description;
                        context.Menus.Update(menu);
                        lines = context.SaveChanges();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

                return lines;
            }
        }

        public  void SelectedMenu(int menuId)
        {   
            using(var context = new AppDbContext(connectionString))
            {
                try
                {
                    var menu = context.Menus.Where(m => m.IsHoliday == true).FirstOrDefault();
                    if (menu != null)
                    {
                        menu.IsHoliday = false;
                        context.Menus.Update(menu);
                        context.SaveChanges();
                    }
                    menu = context.Menus.Where(m => m.Id == menuId).FirstOrDefault();
                    menu.IsHoliday = true;
                    context.Menus.Update(menu);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.InnerException?.Message);
                }
            }
        }

        public int DeleteMenu(int id)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                try
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

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
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
                    .Where(p => context.Menuitems.Any(mi => mi.Product == p.Id && mi.Menu == menuid))
                    .ToList();

                if (items.Count > 0)
                {
                    products = items;
                }
            }

            return products;
        }

        public List<Menu> FindAll(string? filter = null)
        {
            List<Menu>? menus = new List<Menu>();

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        menus = context.Menus
                                .Where(m => m.Theme.Contains(filter))
                                .ToList();
                    }
                    else
                        menus = context.Menus.ToList();

                }catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
                }

                return menus;
            }
        }
    }
}
