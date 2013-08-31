using System.Web.Mvc;
using CalumGayleWeb.Models;

namespace CalumGayleWeb.Controllers
{
    public class CalumGayleController : Controller
    {
        private CalumGayleContext db = new CalumGayleContext();
        
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accommodation()
        {
            return View("Accommodation");
        }

        [HttpPost]
        public ViewResult Submitted(Rsvp rsvp)
        {
            if (string.IsNullOrEmpty(rsvp.Names) || string.IsNullOrEmpty(rsvp.Email))
                return View("Index");

            db.Rsvps.Add(rsvp);
            db.SaveChanges();

            return View("Submitted");
        }

        public ActionResult Submitted()
        {
            return View();
        }
    }
}
