using Microsoft.EntityFrameworkCore;
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

        public static PaginationContext<Category> GetCategories(int page, string? filterWord = null)
        {
            var categories = new List<Category>();
            PaginationContext<Category> paginationResult = null;
            using (var context = new AppDbContext(connectionString))
            {
                if(filterWord != null)
                {
                   paginationResult = context.Categories.Where(c => c.Intitule.Contains(filterWord))
                            .GetPaginedItems(page);
                }
                else
                {
                    try
                    {
                        paginationResult = context.Categories.GetPaginedItems(page);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                return paginationResult;
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

        public static int UpdateCategory(int? categoryId, Category newCategory)
        {
            int line = 0;
            using (var context = new AppDbContext(connectionString))
            {
                var old = context.Categories.Where(c =>c.Id == categoryId).FirstOrDefault();

                if(old != null)
                {
                    old.Intitule = newCategory.Intitule;
                    old.UpdatedAt = newCategory.UpdatedAt;
                    context.Categories.Update(old);
                    line = context.SaveChanges();
                }

                return line;
            }
        }

        public static int DeleteCategory(int? categoryId)
        {
            int line = 0;
            using( var context = new AppDbContext(connectionString))
            {
                var cat = context.Categories.FirstOrDefault(c => c.Id == categoryId);
                context.Remove(cat);
                line = context.SaveChanges();

                return line;
            }
        }

    }
}
