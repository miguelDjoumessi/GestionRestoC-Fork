using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class CategoryProcess
    {
        public static string connectionString;

        public CategoryProcess()
        {
            
        }

        public static List<Category> GetCategories(int page, string? name = null)
        {
            var categories = new List<Category>();
            PaginationContext<object> paginationResult = null;
            using (var context = new AppDbContext(connectionString))
            {
                if(name != null)
                {
                   var list = context.Categories.Where(c => c.Intitule.Contains(name))
                            .GetPaginedItems(page);
                    categories = list.items;
                }
                else
                {
                    try
                    {
                        categories = context.Categories.GetPaginedItems(page).items;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                return categories;
            }
        }
        public static int SaveCategory(Category category)
        {
            int line = 0;
            using(var context = new AppDbContext(connectionString))
            {
                context.Categories.Add(category);
                line = context.SaveChanges();

                return line;
            }
        }

        public static int UpdateCategory(int categoryId, Category newCategory)
        {
            int line = 0;
            using (var context = new AppDbContext(connectionString))
            {
                Category old = context.Categories.Where(c =>c.Id == categoryId).FirstOrDefault();

                if(old != null)
                {
                    newCategory.Id = old.Id;
                    newCategory.CreatedAt = old.CreatedAt;
                    context.Update(newCategory);
                    line = context.SaveChanges();
                }

                return line;
            }
        }

    }
}
