using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET_C__GESTIONRESTO.Models;
using PROJET_C__GESTIONRESTO.Orm;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class ClientProcess
    {
        public static string? connecctionString;
        public ClientProcess() { }

        public static Client SaveClient(Client client)
        {
            using(var context = new AppDbContext(connecctionString))
            {
                try
                {
                    context.Clients.Add(client);
                    var lines = context.SaveChanges();
                    return client;
                }
                catch (Exception ex)
                {
                    throw new Exception("Found Exception: " + ex.InnerException, ex);
                }
                
            }
        }

    }
}
