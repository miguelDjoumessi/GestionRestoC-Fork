using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.Internal;
using System.Runtime.CompilerServices;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class OrderProcess
    {
        public static string? connectionString;

        public OrderProcess()
        {
        }

        public static string? RandomOrderNumber(AppDbContext context) 
        {
            string numorder = "" + DateTime.Now.Year;

            for(int i=0; i < 8; i++)
            {
                numorder += new Random().Next(10);
            }

            var result = context.Orders.Where(o => o.NumCom == numorder).FirstOrDefault();
            if (result != null)
                numorder = RandomOrderNumber(context);
                
            return numorder;
        }

        public static int SaveOrder(Order order)
        {
            int lines = 0;

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    order.NumCom = RandomOrderNumber(context);
                    context.Orders.Add(order);
                    lines = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return lines;
            }
        }

        public static int UpdateOrder(int oldOrderId, Order newOrder)
        {
            int lines = 0;

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    var oldOrder = context.Orders.FirstOrDefault(o => o.Id == oldOrderId);
                    newOrder.Id = oldOrder.Id;
                    context.Orders.Update(newOrder);
                    lines = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return lines;
            }
        }
        public static int DeleteOrrder(int orderId)
        {
            int lines = 0;

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    var order = context.Orders.FirstOrDefault(o => o.Id == orderId);
                    foreach (var item in order.Orderitems)
                    {
                        context.Orderitems.Remove(item);
                    }
                    context.Orders.Remove(order);
                    lines = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return lines;
            }
        }

        public static List<Order> FilterItems(string searchValue)
        {
            List<Order> listOrder = new List<Order>();

            using(var context = new AppDbContext(connectionString))
            {
                try
                {
                    listOrder = context.Orders
                            .Where(o =>
                                    o.Status.Equals(searchValue) || o.NumCom.Contains(searchValue) || o.CreatedAt.ToString().Equals(searchValue)
                                    || context.Zones.Any(z => z.Id == o.Zone && z.Designation == searchValue) || context.Clients.Any(clt => clt.Id == o.Client && clt.Name == searchValue || clt.Prenom == searchValue)
                            )
                            .ToList();
                }catch(Exception ex) {  
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return listOrder;
            }
        }

        public static List<Product> GetProductForOrder(Order order)
        {
            List<Product> products = new List<Product>();

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    foreach (var item in order.Orderitems)
                    {
                        Product product = context.Products.FirstOrDefault(p => p.Id == item.Product);
                        products.Add(product);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return products;
            }
        }

        public static int CountOrderByCover(Cover cover)
        {
            int count = 0;

            using(var context =new AppDbContext(connectionString))
            {
                foreach (var item in cover.Zones)
                {
                    count += item.Orders.Count(); 
                }

                return count;
            }
        }

    }
}
