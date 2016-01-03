using System.Web.Mvc;

namespace HomeWebApi
{
    public class LampsController : Controller
    {
        // GET: Lamps
        public ActionResult LampView(Lamp lamp)
        {
            return View(lamp);
        }
    }
}