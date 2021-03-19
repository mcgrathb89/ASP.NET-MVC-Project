using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class ItalyController : Controller
    {
        // GET: Italy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ItalianStarters()
        {
            return View();
        }

        public ActionResult ItalianMains()
        {
            return View();
        }

        public ActionResult ItalianDesserts()
        {
            return View();
        }
    }
}