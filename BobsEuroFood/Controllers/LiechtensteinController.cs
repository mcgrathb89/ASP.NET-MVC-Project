using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class LiechtensteinController : Controller
    {
        // GET: Liechtenstein
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LiechtensteinerStarters()
        {
            return View();
        }

        public ActionResult LiechtensteinerMains()
        {
            return View();
        }

        public ActionResult LiechtensteinerDesserts()
        {
            return View();
        }
    }
}