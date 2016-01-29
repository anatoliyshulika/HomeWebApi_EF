using HomeWebApi.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;


namespace HomeWebApi
{
    public class FrigesController : Controller
    {
        Frige frige;
        // GET: Friges
        public ActionResult FrigeView(Frige Frige)
        {
            using (DeviceContext db = new DeviceContext())
            {
                List<Frige> fr = db.Friges.Include(l => l.Lamps).ToList();
                int id = Frige.Id;
                frige = db.Friges.Find(id);
                return View(frige);
            }
        }
    }
}