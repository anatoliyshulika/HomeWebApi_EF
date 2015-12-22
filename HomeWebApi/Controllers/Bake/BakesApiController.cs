using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeWebApi
{
    public class BakesApiController : ApiController
    {
        private DeviceContext db = new DeviceContext();
        // DELETE: api/BakesApi/5
        public int DeleteBake(string Id)
        {
            int id = Convert.ToInt32(Id);
            Bake bake = db.Bakes.Find(id);
            if (bake != null)
            {
                List<Lamp> lampList = new List<Lamp>();
                List<Oven> ovenList = new List<Oven>();
                List<Burner> burnerList = new List<Burner>();
                burnerList = bake.Burners.ToList();
                ovenList = bake.Ovens.ToList();
                lampList = ovenList[0].Lamps.ToList();
                db.Lamps.Remove(lampList[0]);
                db.SaveChanges();
                db.Ovens.Remove(ovenList[0]);
                db.Burners.Remove(burnerList[0]);
                db.Burners.Remove(burnerList[1]);
                db.SaveChanges();
                db.Bakes.Remove(bake);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}
