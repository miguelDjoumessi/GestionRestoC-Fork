using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class OrderItemProcess
    {
        public static string? connectionString;
        public OrderItemProcess() { }

        public static int SaveOrderItem(Orderitem orderitem)
        {
            int lines = 0;

            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    var entity = context.Orderitems.Add(orderitem);
                    lines = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return lines;
            }
        }
    }
}
