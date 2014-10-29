using System.Web.Mvc;

namespace PhoneWebApp.Web.Controllers
{
    public class HomeController : PhoneWebAppControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}