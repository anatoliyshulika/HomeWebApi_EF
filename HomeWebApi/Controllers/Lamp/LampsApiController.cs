using HomeWebApi.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace HomeWebApi
{
    public class LampsApiController : ApiController
    {
        // PUT: api/LampsApi
        public int PutOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Lamp lamp = db.Lamps.Find(id);
                if (lamp != null)
                {
                    lamp.OnOff();
                    db.Entry(lamp).State = EntityState.Modified;
                    db.SaveChanges();
                    if (lamp.State)
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

        // DELETE: api/LampsApi/5
        public int DeleteLamp(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Lamp lamp = db.Lamps.Find(id);
                if (lamp != null)
                {
                    db.Lamps.Remove(lamp);
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }
    }
}
