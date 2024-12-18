using Microsoft.Extensions.Configuration;
using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.LogicApp
{
    class OrderProcess
    {
        public readonly string? connectionString;

        public OrderProcess()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            this.connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
        }

        //public int SaveOrder(Order menuItem)
        //{

        //}
    }
}
