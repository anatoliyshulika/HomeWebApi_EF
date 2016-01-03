using System.Web.Mvc;

namespace HomeWebApi
{
    public class RadiosController : Controller
    {
        // GET: Radios
        public ActionResult RadioView(Radio radio)
        {
            return View(radio);
        }
    }
}