using HomeWebApi.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace HomeWebApi
{
    public class OvensApiController : ApiController
    {
        // PUT: api/OvensApi
        public int PutOvenOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
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
        }
        // PUT: api/OvensApi
        [Route("api/OvensApi/PutLampOvenOnOff/{id}")]
        public int PutLampOvenOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Oven oven = db.Ovens.Find(id);
                if (oven != null)
                {
                    oven.LampOnOff();
                    db.Entry(oven).State = EntityState.Modified;
                    db.SaveChanges();
                    if (oven.GetLampState())
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
}
