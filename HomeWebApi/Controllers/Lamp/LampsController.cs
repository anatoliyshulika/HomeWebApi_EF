using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class LampsController : Controller
    {
        // GET: Lamps
        public ActionResult LampView(Lamp lamp)
        {
            return View(lamp);
        }
    }
}