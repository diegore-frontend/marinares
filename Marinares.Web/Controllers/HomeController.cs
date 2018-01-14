using Marinares.Data.ViewModel;
using System.Web.Mvc;

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
                return Ok("");
            }
            catch (System.Exception exc)
            {
                return GenericError(exc);
            }
        }
    }
}
