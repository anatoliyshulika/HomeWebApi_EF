using HomeWebApi.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class BakesController : Controller
    {
        Bake bake;
        // GET: Bakes
        public ActionResult BakeView(Bake Bake)
        {
            using (DeviceContext db = new DeviceContext())
            {
                List<Bake> bk = db.Bakes.Include(b => b.Burners).ToList();
                bk = db.Bakes.Include(b => b.Ovens).ToList();
                List<Oven> ov = db.Ovens.Include(l => l.Lamps).ToList();
                int id = Bake.Id;
                bake = db.Bakes.Find(id);
                return View(bake);
            }
        }
    }
}