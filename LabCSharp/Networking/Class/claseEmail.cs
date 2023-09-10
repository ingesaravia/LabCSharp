using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LabCSharp.Networking.Class
{
    class claseEmail
    {
        public claseEmail()
        {

        }

        public void enviarMailSMTP(string To, string From, string smtpUsername, string smtpPassword, string Host, int Port, string subject, string body)
        {
            MailAddress to = new MailAddress(To);
            MailAddress from = new MailAddress(From);

            MailMessage email = new MailMessage(from, to);
            email.Subject = subject;
            email.Body = body;

            SmtpClient smtp = new SmtpClient();
            //Host, for example smtp.server.address
            smtp.Host = Host;
            smtp.Port = Port;
            smtp.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                /* Send method called below is what will send off our email 
                 * unless an exception is thrown.
                 */
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
