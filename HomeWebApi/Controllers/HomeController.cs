using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace HomeWebApi
{
    public class HomeController : Controller
    {
        private string lampViewPath = "~/Views/Lamps/LampView.cshtml";
        private string burnerViewPath = "~/Views/Burners/BurnerView.cshtml";
        private string ovenViewPath = "~/Views/Ovens/OvenView.cshtml";
        private string bakeViewPath = "~/Views/Bakes/BakeView.cshtml";
        private string frigeViewPath = "~/Views/Friges/FrigeView.cshtml";
        private string tvViewPath = "~/Views/TVs/TVView.cshtml";
        private string radioViewPath = "~/Views/Radios/RadioView.cshtml";
        private List<Devices> deviceList;
        private List<Devices> sortDeviceList;
        List<Burner> burnerList;
        private DeviceContext DeviceDb = new DeviceContext();
        public ActionResult Index()
        {
            deviceList = new List<Devices>();
            sortDeviceList = new List<Devices>();
            foreach (var l in DeviceDb.Lamps.ToList())
            {
                if ("no" != l.ViewPath)
                {
                    deviceList.Add(l);
                }
            }
            foreach (var b in DeviceDb.Bakes.ToList())
            {
                deviceList.Add(b);
            }
            foreach (var f in DeviceDb.Friges.ToList())
            {
                deviceList.Add(f);
            }
            foreach (var t in DeviceDb.TVs.ToList())
            {
                deviceList.Add(t);
            }
            foreach (var r in DeviceDb.Radios.ToList())
            {
                deviceList.Add(r);
            }
            var sortList = deviceList.OrderBy(d => d.CreateTime);
            foreach (Devices dev in sortList)
            {
                sortDeviceList.Add(dev);
            }
            ViewBag.DeviceList = sortDeviceList;
            return View();
        }
        [HttpPost]
        public ActionResult AddDevice(string modelName, string typeOfDevice)
        {
            string name = modelName;
            string parentName = modelName;
            if (modelName == string.Empty)
            {
                return null;
            }
            deviceList = new List<Devices>();
            foreach (var l in DeviceDb.Lamps.ToList())
            {
                deviceList.Add(l);
            }
            foreach (var b in DeviceDb.Bakes.ToList())
            {
                deviceList.Add(b);
            }
            foreach (var f in DeviceDb.Friges.ToList())
            {
                deviceList.Add(f);
            }
            foreach (var t in DeviceDb.TVs.ToList())
            {
                deviceList.Add(t);
            }
            foreach (var r in DeviceDb.Radios.ToList())
            {
                deviceList.Add(r);
            }
            foreach (Devices dev in deviceList)
            {
                if (name == dev.Name)
                {
                    return null;
                }
            }
            switch (typeOfDevice)
            {
                default:
                    break;
                case "Lamp":
                    Lamp lamp = new Lamp { ViewPath = lampViewPath, Name = name, State = false, CreateTime = DateTime.Now.ToLongDateString() };
                    DeviceDb.Entry(lamp).State = EntityState.Added;
                    DeviceDb.SaveChanges();
                    return RedirectToAction("LampView", "Lamps", lamp);
                case "Bake":
                    burnerList = new List<Burner>();
                    Lamp lampOven = new Lamp { ViewPath = "no", Name = "LampOven1", State = false };
                    Oven oven = new Oven { ViewPath = ovenViewPath, Name = parentName + "Oven1", State = false, Lamp = lampOven };
                    Burner burner1 = new Burner { ViewPath = burnerViewPath, Name = parentName + "1", BurnerLevel = SetLevel.Low, State = false };
                    Burner burner2 = new Burner { ViewPath = burnerViewPath, Name = parentName + "2", BurnerLevel = SetLevel.Low, State = false };
                    burnerList.Add(burner1);
                    burnerList.Add(burner2);
                    DeviceDb.Entry(lampOven).State = EntityState.Added;
                    DeviceDb.Entry(oven).State = EntityState.Added;
                    DeviceDb.Entry(burner1).State = EntityState.Added;
                    DeviceDb.Entry(burner2).State = EntityState.Added;
                    Bake bake = new Bake { ViewPath = bakeViewPath, Name = modelName, Burners = burnerList, Oven = oven, CreateTime = DateTime.Now.ToLongDateString() };
                    DeviceDb.Entry(bake).State = EntityState.Added;
                    DeviceDb.SaveChanges();
                    return RedirectToAction("BakeView", "Bakes", bake);
                case "Frige":
                    Lamp lampFrige = new Lamp { ViewPath = "no", Name = "LampFrige1", State = false };
                    DeviceDb.Entry(lampFrige).State = EntityState.Added;
                    Frige frige = new Frige { ViewPath = frigeViewPath, Name = modelName, State = false, FrigeLevel = SetLevel.Low, Lamp = lampFrige, CreateTime = DateTime.Now.ToLongDateString() };
                    DeviceDb.Entry(frige).State = EntityState.Added;
                    DeviceDb.SaveChanges();
                    return RedirectToAction("FrigeView", "Friges", frige);
                case "TV":
                    TV tv = new TV { ViewPath = tvViewPath, Name = modelName, State = false, Chennel = 1, Volume = SetLevel.Low, CreateTime = DateTime.Now.ToLongDateString() };
                    DeviceDb.Entry(tv).State = EntityState.Added;
                    DeviceDb.SaveChanges();
                    return RedirectToAction("TVView", "TVs", tv);
                case "Radio":
                    Radio radio = new Radio { ViewPath = radioViewPath, Name = modelName, State = false, Volume = SetLevel.Low, CreateTime = DateTime.Now.ToLongDateString() };
                    DeviceDb.Entry(radio).State = EntityState.Added;
                    DeviceDb.SaveChanges();
                    return RedirectToAction("RadioView", "Radios", radio);
            }
            return null;
        }
    }
}
