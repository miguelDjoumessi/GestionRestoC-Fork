using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
     class CoverProcess
    {
        public static string? connectionString;
         public CoverProcess() { }

        public static List<Cover> Find(string? filter = null)
        {
            var covers = new List<Cover>();
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    if (filter != null)
                    {
                        covers = context.Covers.Where(c => c.Designation == filter)
                                 .ToList();
                    }
                    else
                    {
                        covers = context.Covers.ToList();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return covers;
            }
        }
    }
}
