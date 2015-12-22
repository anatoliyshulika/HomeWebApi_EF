using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class OvensController : Controller
    {
        // GET: Ovens
        public ActionResult OvenView()
        {
            return View();
        }
    }
}