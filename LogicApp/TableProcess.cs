using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET_C__GESTIONRESTO.Models;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class TableProcess
    {
        public static string? connectionString;

        public TableProcess()
        {
        }

        public static PaginationContext<Table> GetTable(int page, string? filter = null)
        {
            var products = new List<Table>();
            PaginationContext<Table> paginationResult = null;
            using (var context = new AppDbContext(connectionString))
            {
                if (filter != null)
                {
                    paginationResult = context.Tables.Where(t => t.Position.Contains(filter))
                             .GetPaginedItems(page);
                }
                else
                {
                    try
                    {
                        paginationResult = context.Tables.GetPaginedItems(page);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return paginationResult;
            }
        }

        public static List<Table> FindTableNotReservedBy(string period)
        {
            List<Table> tables = new List<Table>();
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    tables = context.Tables.Where(t => 
                                 !(context.Booking.Any(b => b.Table == t.Id && 
                                    b.Period == period &&
                                    b.State == "active" &&
                                    b.CreatedAt.Date == DateTime.Today
                                 ))
                            )
                            .ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return tables;
            }
        }

        public static List<Table> GetAll()
        {
            List<Table> tables = new List<Table>();
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    tables = context.Tables.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return tables;
            }
        }
    }
}
