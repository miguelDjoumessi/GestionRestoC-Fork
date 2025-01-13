using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class ProductProcess
    {
        public static string? connectionString;

        public ProductProcess()
        {
        }

        public int SaveProduct(Product product)
        {
            int lines = 0;
            using (var context = new AppDbContext(connectionString))
            {
                context.Products.Add(product);
                lines = context.SaveChanges();
            }

            return lines;
        }

        public int UpdateProduct(int id, Product newProduct)
        {
            using (var context = new AppDbContext(connectionString))
            {
                int lines = 0;
                var product = context.Products.FirstOrDefault(x => x.Id == id);

                if (product != null)
                {
                    newProduct.Id = id;
                    product = newProduct;
                    context.Products.Update(product);
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
                var product = context.Products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    context.Products.Remove(product);
                    lines = context.SaveChanges();
                }

                return lines;
            }
        }

        public static PaginationContext<Product> GetProduct(int page, string? filter = null)
        {
            var products = new List<Product>();
            PaginationContext<Product> paginationResult = null;
            using (var context = new AppDbContext(connectionString))
            {
                if (filter != null)
                {
                    paginationResult = context.Products.Where(p => p.Designation.Contains(filter) || context.Categories.Any(c => c.Id == p.Category && c.Intitule.Contains(filter)))
                             .GetPaginedItems(page);
                }
                else
                {
                    try
                    {
                        paginationResult = context.Products.GetPaginedItems(page);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return paginationResult;
            }
        }

        public List<object> FilterProduct(string searchValue)
        {
            List<object>? filteredItems = new List<object>();

            using (var context = new AppDbContext(connectionString))
            {
                if (searchValue.GetType() == typeof(string))
                {
                    var items = context.Products
                            .Where("designation.Contains(@0) or description.Contains(@0)", searchValue)
                            .Where(p => p.UnityPrice.ToString() ==  searchValue)
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
