using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace HomeWebApi
{
    public class DeviceContextInitializer : DropCreateDatabaseAlways<DeviceContext>
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
            List<Oven> ovenList = new List<Oven>();
            List<Lamp> lampOvenList = new List<Lamp>();
            List<Lamp> lampFrigeList = new List<Lamp>();
            context.Lamps.Add(new Lamp { ViewPath = viewPath, Name = "Lamp1", State = false, CreateTime = DateTime.Now });
            Burner burner1 = new Burner { ViewPath = burnerViewPath, Name = "Bake1" + "1", BurnerLevel = SetLevel.Low, State = false };
            Burner burner2 = new Burner { ViewPath = burnerViewPath, Name = "Bake1" + "2", BurnerLevel = SetLevel.Low, State = false };
            burnerList.Add(burner1);
            burnerList.Add(burner2);
            Lamp lampOven = new Lamp { ViewPath = "no", Name = "LampOven1", State = false };
            lampOvenList.Add(lampOven);
            Oven oven = new Oven { ViewPath = ovenViewPath, Name = "Bake1" + "Oven1", State = false, Lamps = lampOvenList };
            ovenList.Add(oven);
            context.Lamps.Add(lampOven);
            context.Burners.Add(burner1);
            context.Burners.Add(burner2);
            context.Ovens.Add(oven);
            context.Bakes.Add(new Bake { ViewPath = bakeViewPath, Name = "Bake1", Burners = burnerList, Ovens = ovenList, CreateTime = DateTime.Now });
            Lamp lampFrige = new Lamp { ViewPath = "no", Name = "LampFrige", State = false };
            lampFrigeList.Add(lampFrige);
            context.Lamps.Add(lampFrige);
            context.Friges.Add(new Frige { ViewPath = frigeViewPath, Name = "Frige1", State = false, FrigeLevel = SetLevel.Low, Lamps = lampFrigeList, CreateTime = DateTime.Now });
            context.TVs.Add(new TV { ViewPath = tvViewPath, Name = "TV1", State = false, Chennel = 1, Volume = SetLevel.Low, CreateTime = DateTime.Now });
            context.Radios.Add(new Radio { ViewPath = radioViewPath, Name = "Radio1", State = false, Volume = SetLevel.Low, CreateTime = DateTime.Now });
            context.SaveChanges();
        }
    }
}