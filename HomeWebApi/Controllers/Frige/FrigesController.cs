using HomeWebApi.Models;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class FrigesController : Controller
    {
        private DeviceContext db = new DeviceContext();
        Frige frige;
        // GET: Friges
        public ActionResult FrigeView(Frige Frige)
        {
            int id = Frige.Id;
            frige = db.Friges.Find(id);
            return View(frige);
        }
    }
}