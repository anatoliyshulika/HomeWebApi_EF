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
        Bake bake;
        List<Burner> burnerList;
        List<Oven> ovenList;
        // GET: Bakes
        public ActionResult BakeView(Bake Bake)
        {
            int id = Bake.Id;
            bake = db.Bakes.Find(id);
            ovenList = bake.Ovens;
            burnerList = bake.Burners;
            bake = Bake;
            bake.Ovens = ovenList;
            bake.Burners = burnerList;
            return View(bake);
        }
    }
}