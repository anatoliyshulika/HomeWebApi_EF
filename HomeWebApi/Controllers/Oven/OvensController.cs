using System.Web.Mvc;

namespace HomeWebApi
{
    public class OvensController : Controller
    {
        // GET: Ovens
        public ActionResult OvenView()
        {
            return View();
        }
    }
}