using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class FranceController : Controller
    {
        // GET: France
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FrenchStarters()
        {
            return View();
        }

        public ActionResult FrenchMains()
        {
            return View();
        }

        public ActionResult FrenchDesserts()
        {
            return View();
        }
    }
}