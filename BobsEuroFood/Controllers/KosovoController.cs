using System.Web.Mvc;

namespace BobsEuroFood.Controllers
{
    public class KosovoController : Controller
    {
        // GET: Kosovo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult KosovanStarters()
        {
            return View();
        }

        public ActionResult KosovanMains()
        {
            return View();
        }

        public ActionResult KosovanDesserts()
        {
            return View();
        }
    }
}