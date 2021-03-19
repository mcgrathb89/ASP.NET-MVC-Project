using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class TurkeyController : Controller
    {
        // GET: Turkey
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TurkishStarters()
        {
            return View();
        }

        public ActionResult TurkishMains()
        {
            return View();
        }

        public ActionResult TurkishDesserts()
        {
            return View();
        }
    }
}