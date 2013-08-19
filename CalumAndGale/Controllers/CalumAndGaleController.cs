using System.Web.Mvc;
using CalumAndGale.Models;

namespace CalumAndGale.Controllers
{
    public class CalumAndGaleController : Controller
    {
        private CalumAndGaleContext db = new CalumAndGaleContext();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Submitted(Rsvp rsvp)
        {
            if (string.IsNullOrEmpty(rsvp.Name) || string.IsNullOrEmpty(rsvp.Email))
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
