using HomeWebApi.Models;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class BakesController : Controller
    {
        private DeviceContext db = new DeviceContext();
        Bake bake;
        // GET: Bakes
        public ActionResult BakeView(Bake Bake)
        {
            int id = Bake.Id;
            bake = db.Bakes.Find(id);
            return View(bake);
        }
    }
}