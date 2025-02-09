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
    class ZoneProcess
    {
        public static string? connectionString;
        public ZoneProcess() {}

        public static List<Zone> FindZone(string? filter = null)
        {
            var products = new List<Zone>();
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    products = context.Zones.Where(z => z.Designation == filter || context.Covers.Any(c => c.Id == z.Cover && c.Designation == filter)).ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                return products;
            }
        }

        public static Zone? FindOneByOrNull(string filter)
        {
            using (var context = new AppDbContext(connectionString))
            {
                var zone = context.Zones.Where(z => z.Designation == filter).FirstOrDefault();
                return zone;
            }
        }

    }
}
