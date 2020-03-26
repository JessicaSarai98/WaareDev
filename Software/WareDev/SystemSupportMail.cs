using System;
using System.Collections Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

class SystemSupportMail : MasterMailServer
{
    public SystemSupportMail()
    {
        senderMail = "jessicabautista1698@gmail.com";
        password = "admin4321";
        host = "smtp.gmail.com";
        port = 587;
        ssl = true;
        initializeSmtpClient();
    }

}