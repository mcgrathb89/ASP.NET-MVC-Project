using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class GreeceController : Controller
    {
        // GET: Greece
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GreekStarters()
        {
            return View();
        }

        public ActionResult GreekMains()
        {
            return View();
        }

        public ActionResult GreekDesserts()
        {
            return View();
        }
    }
}