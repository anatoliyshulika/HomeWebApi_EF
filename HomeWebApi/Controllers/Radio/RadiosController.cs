using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class RadiosController : Controller
    {
        // GET: Radios
        public ActionResult RadioView(Radio radio)
        {
            return View(radio);
        }
    }
}