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
        public readonly string? connectionString;

        public ProductProcess()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            this.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
        }

        public int CreateProduct(Product product)
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

        public List<Product> GetDistinctProduct()
        {
            List<Product> result = null;

            using (var context = new AppDbContext(connectionString))
            {
                var items = context.Products
                    .Where(p => context.Menuitems.Any(m => m.ProductId != p.Id))
                    .ToList();

                if (items != null)
                {
                    result = items;
                }

            }

            return result;
        }

        public List<object> FilterProduct<T>(T searchValue)
        {
            List<object>? filteredItems = new List<object>();

            using (var context = new AppDbContext(connectionString))
            {
                if (searchValue.GetType() == typeof(string))
                {
                    var items = context.Products
                            .Where("designation.Contains(@0) or description.Contains(@0)", searchValue)
                            .ToList();

                    if (items.Any())
                    {
                        filteredItems.Add(items);
                    }
                }

                if (searchValue.GetType() == typeof(float))
                {
                    var items = context.Products
                            .Where(p => p.Id.Equals(searchValue))
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
