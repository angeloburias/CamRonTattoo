using System.Web.Mvc;

namespace IdentitySample.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Home()
        {
            return View();
        }

        [HttpGet]
  
        public ActionResult About()

        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Works()
        {
            ViewBag.Message = "Collection of Works";

            return View();
        }

        [HttpGet]
        public ActionResult Categories()
        {
            ViewBag.Message = "Different Categories";

            return View();
        }
    }
}
