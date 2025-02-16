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
                    var clt = context.Clients.Where(cli =>  cli.Name == client.Name && cli.Prenom == client.Prenom && cli.Tel == client.Tel).FirstOrDefault();
                    if (clt != null) 
                        return clt;

                    context.Clients.Add(client);
                    var lines = context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.InnerException?.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                return client;
            }
        }

    }
}
