using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class BakesController : Controller
    {
        private DeviceContext db = new DeviceContext();
        // GET: Bakes
        public ActionResult BakeView()
        {
            List<Bake> lb = new List<Bake>();
            lb = db.Bakes.ToList();
            int id = lb.Count;
            Bake bake = db.Bakes.Find(id);
            return View(bake);
        }
    }
}