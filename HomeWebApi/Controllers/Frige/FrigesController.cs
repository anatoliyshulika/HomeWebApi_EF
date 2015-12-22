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
        // GET: Friges
        public ActionResult FrigeView()
        {
            List<Frige> lf = new List<Frige>();
            lf = db.Friges.ToList();
            int id = lf.Count;
            frige = new Frige();
            frige = db.Friges.Find(id);
            return View(frige);
        }
    }
}