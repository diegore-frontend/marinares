
using System.Configuration;
using System.Web.Mvc;
using PayPal.Api;
using PayPal.Util;

namespace Marinares.Web.Controllers
{
	public class PayPalController : Controller
	{
		// GET: PayPal
		public ActionResult Index()
		{
			return View();
		}
	}
}