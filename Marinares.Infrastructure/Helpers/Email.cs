using System.Net.Mail;
using Marinares.Data.Shared;

namespace Marinares.Infrastructure.Helpers
{
    public static class Email
    {
        public static void Send(EmailData email)
        {
            var mailFrom = new MailAddress(email.From, email.DisplayName);

            var smtpClient = new SmtpClient(email.Host, email.Port)
            {
                Credentials = new System.Net.NetworkCredential(email.Credentiales.UserName, email.Credentiales.Password),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = mailFrom,
                Subject = email.Subcaject,
                Body = email.Body,
                IsBodyHtml = true
            };

            foreach (var to in email.To)
            {
                mailMessage.To.Add(to);
            }

            smtpClient.Send(mailMessage);
        }
    }
}