using System.Web.Mvc;
using CalumGaleWeb.Models;

namespace CalumGaleWeb.Controllers
{
    public class CalumGaleController : Controller
    {
        private CalumGaleContext db = new CalumGaleContext();
        
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
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
