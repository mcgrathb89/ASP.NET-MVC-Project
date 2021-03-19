using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class SwitzerlandController : Controller
    {
        // GET: Switzerland
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SwissStarters()
        {
            return View();
        }

        public ActionResult SwissMains()
        {
            return View();
        }

        public ActionResult SwissDesserts()
        {
            return View();
        }
    }
}