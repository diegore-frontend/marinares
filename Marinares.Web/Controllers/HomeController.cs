using System.Collections.Generic;
using Marinares.Data.ViewModel;
using System.Web.Mvc;
using Marinares.Data.Shared;
using Marinares.Infrastructure.Helpers;
using Resources;
using System.Net;

namespace Marinares.Web.Controllers
{
    public class HomeController : JsonController
    {
        public ActionResult Index()
        {
            return View();
        }

        [Route("donde-hospedarse")]
        public ActionResult Hospedaje()
        {
            return View();
        }

        [Route("donde")]
        public ActionResult Donde()
        {
            return View();
        }

        [Route("como-vestir")]
        public ActionResult Wear()
        {
            return View();
        }

        [Route("itinerario")]
        public ActionResult Itinerario()
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
                    Subcaject = "Confirmación de asistencia",
                    Body = ReplaceValues(model),
                    To = new List<string>()
                    {
                         AppSettings.From
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

        private string GetHtml()
        {
            var client = new WebClient();
            return client.DownloadString(AppSettings.RouteMailConfirmation);
        }

        private string ReplaceValues(ContactViewModel model)
        {
            var html = GetHtml()
                .Replace("{{email}}", model.Email)
                .Replace("{(Nombre:)}", model.Name).
                Replace("{(telefono:)}", model.Phone)
                .Replace("{(mensaje:)}", model.Message);
            return html;
        }

    }
}
