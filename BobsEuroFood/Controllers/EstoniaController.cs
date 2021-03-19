using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class EstoniaController : Controller
    {
        // GET: Estonia
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EstonianStarters()
        {
            return View();
        }

        public ActionResult EstonianMains()
        {
            return View();
        }

        public ActionResult EstonianDesserts()
        {
            return View();
        }
    }
}