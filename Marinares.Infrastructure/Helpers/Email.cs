using System.Net.Mail;
using Marinares.Data.Shared;
using System.Net;

namespace Marinares.Infrastructure.Helpers
{
    public static class Email
    {
        public static void Send(EmailData email)
        {
            SmtpClient smtpClient = new SmtpClient(email.Host, email.Port);
            MailMessage mailMessage = new MailMessage()
            {
                From = new MailAddress(email.From, email.DisplayName)
            };

            foreach (var itemTo in email.To)
            {
                mailMessage.To.Add(itemTo);
            }

            mailMessage.Subject = email.Subcaject;
            mailMessage.Body = email.Body;
            mailMessage.IsBodyHtml = true;

            if (!string.IsNullOrEmpty(email.Credentiales.UserName) && !string.IsNullOrEmpty(email.Credentiales.Password))
            {
                smtpClient.Credentials = new NetworkCredential(email.Credentiales.UserName, email.Credentiales.Password);
                //smtpClient.EnableSsl = true;

            }
            else
            {
                smtpClient.UseDefaultCredentials = true;
            }
            smtpClient.Send(mailMessage);
        }
    }
}
