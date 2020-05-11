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
           
            senderMail = "jessicabautista1698@gmail.com";
            password = "silenthill1698";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmptClient();
        }
    }
}
