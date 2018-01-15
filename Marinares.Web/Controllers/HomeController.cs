using System.Collections.Generic;
using Marinares.Data.ViewModel;
using System.Web.Mvc;
using Marinares.Data.Shared;
using Marinares.Infrastructure.Helpers;
using Resources;

namespace Marinares.Web.Controllers
{
	public class HomeController : JsonController
	{
		public ActionResult Index()
		{
			return View();
		}

		[Route("confirmar")]
		public ActionResult Contact()
		{
			return View();
		}

		[HttpPost, Route("SendMessage")]
		public JsonResult SendMessage(ContactViewModel model)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					return InvalidData();
				}
				Email.Send(new EmailData()
				{
					Subcaject = "Confirmación",
					Body = string.Concat(model.Name, model.FirstName, model.Phone),
					To = new List<string>()
					{
						 model.Email
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

				return Ok(Messages.SendMessageSuccess);
			}
			catch (System.Exception exc)
			{
				return GenericError(exc);
			}
		}
	}
}
