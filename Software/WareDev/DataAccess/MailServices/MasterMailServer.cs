using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

//encargado de enviar cualquier correo electrónico a uno o varios destinarios.
namespace DataAccess.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient;
        protected string sendEmail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmptClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(sendEmail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl; 

        }
        public void sendMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(sendEmail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage); //enviar mensaje
            }
            catch(Exception ex){ }
            finally
            {
                mailMessage.Dispose();
                smtpClient.Dispose();
            }

        }


    }
}
