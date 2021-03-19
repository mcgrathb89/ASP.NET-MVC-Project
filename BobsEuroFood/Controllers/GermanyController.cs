using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class GermanyController : Controller
    {
        // GET: Germany
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GermanStarters()
        {
            return View();
        }

        public ActionResult GermanMains()
        {
            return View();
        }

        public ActionResult GermanDesserts()
        {
            return View();
        }
    }
}