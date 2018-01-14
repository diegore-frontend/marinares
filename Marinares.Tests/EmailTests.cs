using NUnit.Framework;
using System.Net.Mail;

namespace Marinares.Tests
{
    [TestFixture]
    public class EmailTests
    {
        [Test]
        public void Send()
        {
            var mailFrom = new MailAddress("sistemasguzman@gmail.com", "data");

            var smtpClient = new SmtpClient("50.62.160.107", 25)
            {
                UseDefaultCredentials = true
                // Credentials = new System.Net.NetworkCredential(ConfigData.NotifyUserName, ConfigData.NotifyPassword)
            };

            var mailMessage = new MailMessage
            {
                From = mailFrom,
                Subject = "esteban",
                Body = "daaa",
                IsBodyHtml = true
            };

            mailMessage.To.Add("sistemasguzman@gmail.com");

            smtpClient.Send(mailMessage);
        }

    }
}
