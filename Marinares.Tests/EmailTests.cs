using NUnit.Framework;
using System.Net.Mail;
using Marinares.Data.Shared;
using Marinares.Infrastructure.Helpers;

namespace Marinares.Tests
{
    [TestFixture]
    public class EmailTests
    {
        [Test]
        public void Send()
        {
            Email.Send(new EmailData());
        }
    }
}
