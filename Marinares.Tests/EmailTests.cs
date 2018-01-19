using System.Collections.Generic;
using Marinares.Data.Shared;
using Marinares.Infrastructure.Helpers;
using NUnit.Framework;

namespace Marinares.Tests
{
	[TestFixture]
	public class EmailTests
	{
		[Test]
		public void Send()
		{
			Email.Send(new EmailData()
			{
				Subcaject = "Confirmación de pago",
				Body = "test",
				To = new List<string>()
				{
					"sistemasguzman@gmail.com"
				},
				Credentiales = new Credentiales()
				{
					UserName = AppSettings.UserName,
					Password = AppSettings.Password
				},
				DisplayName = AppSettings.Display,
				Host = AppSettings.Host,
				Port = AppSettings.Port,
				From = AppSettings.From
			});
		}
	}
}
