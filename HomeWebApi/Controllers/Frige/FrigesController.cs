using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class FrigesController : Controller
    {
        private DeviceContext db = new DeviceContext();
        Frige frige;
       // Lamp lamp;
        List<Lamp> lampList;
        // GET: Friges
        public ActionResult FrigeView(Frige Frige)
        {
            int id = Frige.Id;
            frige = db.Friges.Find(id);
            lampList = frige.Lamps;
            frige = Frige;
            frige.Lamps = lampList;
            return View(frige);
        }
    }
}