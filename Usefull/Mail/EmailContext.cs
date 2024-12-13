using PROJET_C__GESTIONRESTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJET_C__GESTIONRESTO.Usefull.Mail
{
    class EmailContext
    {
        public static String[] reset_password = ["Reset Password"];
        
        public static string resetPasswordMessage(Operateur user, string validateCode)
        {
            string body = "<body>" + 
                   "<div>" + 
                        "<div class>" +
                            "<h1>Reset password</h1><hr>"+
                        "</div><br>"+
                        "<div>" +
                            "<p>Bonjour a vous <strong>" + user.Name + "</strong> il semblerait que vous ne parvener pas retrouver votre mot de passe</p>"+
                           "<p>Entrer le code suivant pour pouvoir reinitialiser votre mot de passe</p>" +
                            "<h5>Code de verification: " + validateCode + " </h5>" +
                            "<p>merci de nous faire confiance</p>" +
                        "</div>" +
                    "</div>"+
                "</body>" +
                "</html>"
            ;
            return body;
        }
    }
}
