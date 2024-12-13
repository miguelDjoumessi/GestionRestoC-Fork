using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET_C__GESTIONRESTO.Orm;
using PROJET_C__GESTIONRESTO.Models;
using System.Security.Cryptography;
using PROJET_C__GESTIONRESTO.Services;
using PROJET_C__GESTIONRESTO.Usefull.Mail;

namespace PROJET_C__GESTIONRESTO.processor
{
    class OperatorProcessor
    {
        private readonly string connectionString;
        private readonly SendMailService sendMailService;
        public OperatorProcessor()
        {
            var configuration = ConfigurationHelper.GetConfiguration();
            connectionString = configuration.GetValue<string>("ConnectionString:MySqlConnection");
            sendMailService = new SendMailService();
        }
        public string resetPassword(string email)
        {
            bool isExist = false;
            Operateur user = null;
            var mailContext = EmailContext.resetPasswordMessage;
            using (var contextDb = new AppDbContext(connectionString))
            {
                user = contextDb.Operateurs.FirstOrDefault(o => o.Email == email);
                if (user != null) { 
                    isExist = true;
                }
            }

            if (isExist)
            {
                string code = this.generateRandomCode();
                string body = EmailContext.resetPasswordMessage(user, code);
                try
                {
                    sendMailService.send(user, EmailContext.reset_password[0], body, true);
                }
                catch (Exception ex) { 
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return code;
            }
            else throw new Exception("User not found");

            return "";
        }

        public string generateRandomCode()
        {
            string code = "";
            for (int i = 0; i < 5; i++)
            {
                code = code + RandomNumberGenerator.GetInt32(9);
            }

            return code;
        }
    }
}
