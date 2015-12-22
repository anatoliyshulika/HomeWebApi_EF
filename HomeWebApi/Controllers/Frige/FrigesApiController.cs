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
    public class FrigesApiController : ApiController
    {
        private DeviceContext db = new DeviceContext();
        // PUT: api/FrigesApi/5
        public int PutOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            Frige frige = db.Friges.Find(id);
            if (frige != null)
            {
                frige.OnOff();
                db.Entry(frige).State = EntityState.Modified;
                db.SaveChanges();
                if (frige.State && frige.FrigeLevel == SetLevel.Low)
                {
                    return 1;
                }
                else if (frige.State && frige.FrigeLevel == SetLevel.Medium)
                {
                    return 2;
                }
                else if (frige.State && frige.FrigeLevel == SetLevel.Height)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
            return 4;
        }
        // PUT: api/FrigesApi/FrigesApi/{5}
        [Route("api/FrigesApi/PutLampFrigeOnOff/{id}")]
        public int PutLampFrigeOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            Frige frige = db.Friges.Find(id);
            if (frige != null)
            {
                frige.LampOnOff(0);
                db.Entry(frige).State = EntityState.Modified;
                db.SaveChanges();
                if (frige.GetLampState(0))
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
        // PUT: api/FrigesApi/PutLevelDown/{id}
        [Route("api/FrigesApi/PutLevelDown/{id}")]
        public int PutLevelDown(string Id)
        {
            int id = Convert.ToInt32(Id);
            Frige frige = db.Friges.Find(id);
            if (frige != null)
            {
                if (frige.State)
                {
                    frige.LevelDown();
                    db.Entry(frige).State = EntityState.Modified;
                    db.SaveChanges();
                    if (frige.State && frige.FrigeLevel == SetLevel.Low)
                    {
                        return 1;
                    }
                    else if (frige.State && frige.FrigeLevel == SetLevel.Medium)
                    {
                        return 2;
                    }
                    else if (frige.State && frige.FrigeLevel == SetLevel.Height)
                    {
                        return 3;
                    }
                }
            }
            return 4;
        }
        // PUT: api/FrigesApi/PutLevelUp/{id}
        [Route("api/FrigesApi/PutLevelUp/{id}")]
        public int PutLevelUp(string Id)
        {
            int id = Convert.ToInt32(Id);
            Frige frige = db.Friges.Find(id);
            if (frige != null)
            {
                if (frige.State)
                {
                    frige.LevelUp();
                    db.Entry(frige).State = EntityState.Modified;
                    db.SaveChanges();
                    if (frige.State && frige.FrigeLevel == SetLevel.Low)
                    {
                        return 1;
                    }
                    else if (frige.State && frige.FrigeLevel == SetLevel.Medium)
                    {
                        return 2;
                    }
                    else if (frige.State && frige.FrigeLevel == SetLevel.Height)
                    {
                        return 3;
                    }
                }
            }
            return 4;
        }
        // DELETE: api/FrigesApi/5
        public int DeleteFrige(string Id)
        {
            int id = Convert.ToInt32(Id);
            Frige frige = db.Friges.Find(id);
            if (frige != null)
            {
                List<Lamp> ll = new List<Lamp>();
                ll = frige.Lamps.ToList();
                db.Lamps.Remove(ll[0]);
                db.SaveChanges();
                db.Friges.Remove(frige);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}
