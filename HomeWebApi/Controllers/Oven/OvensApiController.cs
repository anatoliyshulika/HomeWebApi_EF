using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeWebApi
{
    public class OvensApiController : ApiController
    {
        private DeviceContext db = new DeviceContext();
        // PUT: api/OvensApi
        public int PutOvenOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            Oven oven = db.Ovens.Find(id);
            if (oven != null)
            {
                oven.OnOff();
                db.Entry(oven).State = EntityState.Modified;
                db.SaveChanges();
                if (oven.State)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 2;
        }
        // PUT: api/OvensApi
        [Route("api/OvensApi/PutLampOvenOnOff/{id}")]
        public int PutLampOvenOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            Oven oven = db.Ovens.Find(id);
            if (oven != null)
            {
                oven.LampOnOff(0);
                db.Entry(oven).State = EntityState.Modified;
                db.SaveChanges();
                if (oven.GetLampState(0))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            return 2;
        }
    }
}
