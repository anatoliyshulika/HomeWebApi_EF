using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HomeWebApi
{
    public class DeviceContextInitializer : DropCreateDatabaseIfModelChanges<DeviceContext>
    {
        private string viewPath = "~/Views/Lamps/LampView.cshtml";
        private string burnerViewPath = "~/Views/Burners/BurnerView.cshtml";
        private string ovenViewPath = "~/Views/Ovens/OvenView.cshtml";
        private string bakeViewPath = "~/Views/Bakes/BakeView.cshtml";
        private string frigeViewPath = "~/Views/Friges/FrigeView.cshtml";
        private string tvViewPath = "~/Views/TVs/TVView.cshtml";
        private string radioViewPath = "~/Views/Radios/RadioView.cshtml";
        protected override void Seed(DeviceContext context)
        {
            List<Burner> burnerList = new List<Burner>();
            context.Lamps.Add(new Lamp { ViewPath = viewPath, Name = "Lamp1", State = false, CreateTime = DateTime.Now.ToLongDateString() });
            Burner burner1 = new Burner { ViewPath = burnerViewPath, Name = "Bake1" + "1", BurnerLevel = SetLevel.Low, State = false };
            Burner burner2 = new Burner { ViewPath = burnerViewPath, Name = "Bake1" + "2", BurnerLevel = SetLevel.Low, State = false };
            burnerList.Add(burner1);
            burnerList.Add(burner2);
            Lamp lampOven = new Lamp { ViewPath = "no", Name = "LampOven1", State = false };
            Oven oven = new Oven { ViewPath = ovenViewPath, Name = "Bake1" + "Oven1", State = false, Lamp = lampOven };
            context.Lamps.Add(lampOven);
            context.Burners.Add(burner1);
            context.Burners.Add(burner2);
            context.Ovens.Add(oven);
            context.Bakes.Add(new Bake { ViewPath = bakeViewPath, Name = "Bake1", Burners = burnerList, Oven = oven, CreateTime = DateTime.Now.ToLongDateString() });
            Lamp lampFrige = new Lamp { ViewPath = "no", Name = "LampFrige", State = false };
            context.Lamps.Add(lampFrige);
            context.Friges.Add(new Frige { ViewPath = frigeViewPath, Name = "Frige1", State = false, FrigeLevel = SetLevel.Low, Lamp = lampFrige, CreateTime = DateTime.Now.ToLongDateString() });
            context.TVs.Add(new TV { ViewPath = tvViewPath, Name = "TV1", State = false, Chennel = 1, Volume = SetLevel.Low, CreateTime = DateTime.Now.ToLongDateString() });
            context.Radios.Add(new Radio { ViewPath = radioViewPath, Name = "Radio1", State = false, Volume = SetLevel.Low, CreateTime = DateTime.Now.ToLongDateString() });
            context.SaveChanges();
        }
    }
}