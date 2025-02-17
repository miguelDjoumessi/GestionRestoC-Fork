using Microsoft.EntityFrameworkCore;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Usefull;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class BookingProcess
    {
        public static string? connectionString;

        public BookingProcess() { }

        public static Booking SaveBook(Booking book)
        {
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    context.Booking.Add(book);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return book;
            }
        }

        public static PaginationContext<Booking> FindAll(int page,string? filter = null)
        {
            PaginationContext<Booking>? bookInfos = null;
            using(var context = new AppDbContext(connectionString))
            {
                try
                {
                    if (!string.IsNullOrEmpty(filter))
                        bookInfos = context.Booking
                            .Where(b => context.Clients.Any(clt => b.Client == clt.Id && (clt.Name.Contains(filter) || clt.Tel.Contains(filter))))
                            .Include(b => b.ClientNavigation)
                            .Include(b => b.TableNavigation)
                            .GetPaginedItems(page);
                    else
                        bookInfos = context.Booking
                            .Include(b => b.ClientNavigation)
                            .Include(b => b.TableNavigation)
                            .GetPaginedItems(page);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
                }

                return bookInfos;
            }
        }

        public static PaginationContext<Booking> Filter(int page, string filter = "all")
        {
            PaginationContext<Booking>? bookInfos = null;
            using (var context = new AppDbContext(connectionString))
            {
                try
                {
                    if (filter != "all")
                        bookInfos = context.Booking
                            .Where(b => b.RequestState.Equals(filter) || b.State.Equals(filter) || b.Period.Equals(filter))
                            .Include(b => b.ClientNavigation)
                            .Include(b => b.TableNavigation)
                            .GetPaginedItems(page);
                    else
                        bookInfos = context.Booking
                            .Include(b => b.ClientNavigation)
                            .Include(b => b.TableNavigation)
                            .GetPaginedItems(page);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message);
                }

                return bookInfos;
            }
        }
    }
}
