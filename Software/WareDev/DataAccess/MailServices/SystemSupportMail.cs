using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
//para enviar correos 
namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer
    {
        public SystemSupportMail()
        {
           
            sendEmail = "jessicabautista1698@gmail.com";
            password = "****";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmptClient();
        }
    }
}
