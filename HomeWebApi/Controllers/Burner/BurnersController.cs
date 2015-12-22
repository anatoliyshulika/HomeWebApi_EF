using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class BurnersController : Controller
    {
        // GET: Burners
        public ActionResult BurnerView()
        {
            return View();
        }
    }
}