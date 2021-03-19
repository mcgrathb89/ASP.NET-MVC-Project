using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class UkraineController : Controller
    {
        // GET: Ukraine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UkrainianStarters()
        {
            return View();
        }

        public ActionResult UkrainianMains()
        {
            return View();
        }

        public ActionResult UkrainianDesserts()
        {
            return View();
        }
    }
}