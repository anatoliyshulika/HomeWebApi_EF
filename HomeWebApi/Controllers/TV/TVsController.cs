using System.Web.Mvc;

namespace HomeWebApi
{
    public class TVsController : Controller
    {
        // GET: TVs
        public ActionResult TVView(TV tv)
        {
            return View(tv);
        }
    }
}