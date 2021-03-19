using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class MaltaController : Controller
    {
        // GET: Malta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MalteseStarters()
        {
            return View();
        }

        public ActionResult MalteseMains()
        {
            return View();
        }

        public ActionResult MalteseDesserts()
        {
            return View();
        }
    }
}