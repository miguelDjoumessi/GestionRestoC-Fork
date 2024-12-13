using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.Services
{
    class SendMailService
    {
        private const string Host = "localhost";
        public SendMailService() { }

        public void send(Operateur to, string subject, string bodyMessage, bool isBodyHtml)
        {
            string fromMail = "Resto@noname.com";
            string fromPassword = "";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(to.Email));
            message.Body = bodyMessage;
            message.IsBodyHtml = isBodyHtml;

            SmtpClient smtpClient = new(Host)
            {
                Port = 1025,
                //Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = false
            };

            smtpClient.Send(message);
        }
    }
}
