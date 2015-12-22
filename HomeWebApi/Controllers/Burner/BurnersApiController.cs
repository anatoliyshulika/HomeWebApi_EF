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
    public class BurnersApiController : ApiController
    {
        private DeviceContext db = new DeviceContext();
        // PUT: api/BurnersApi
        public int PutOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            Burner burner = db.Burners.Find(id);
            if (burner != null)
            {
                burner.OnOff();
                db.Entry(burner).State = EntityState.Modified;
                db.SaveChanges();
                if (burner.State && burner.BurnerLevel == SetLevel.Low)
                {
                    return 1;
                }
                else if (burner.State && burner.BurnerLevel == SetLevel.Medium)
                {
                    return 2;
                }
                else if (burner.State && burner.BurnerLevel == SetLevel.Height)
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
        // PUT: api/BurnersApi/PutLevelDown/{id}
        [Route("api/BurnersApi/PutLevelDown/{id}")]
        public int PutLevelDown(string Id)
        {
            int id = Convert.ToInt32(Id);
            Burner burner = db.Burners.Find(id);
            if (burner != null)
            {
                if (burner.State)
                {
                    burner.LevelDown();
                    db.Entry(burner).State = EntityState.Modified;
                    db.SaveChanges();
                    if (burner.State && burner.BurnerLevel == SetLevel.Low)
                    {
                        return 1;
                    }
                    else if (burner.State && burner.BurnerLevel == SetLevel.Medium)
                    {
                        return 2;
                    }
                    else if (burner.State && burner.BurnerLevel == SetLevel.Height)
                    {
                        return 3;
                    }
                }
            }
            return 4;
        }
        // PUT: api/BurnersApi/PutLevelUp/{id}
        [Route("api/BurnersApi/PutLevelUp/{id}")]
        public int PutLevelUp(string Id)
        {
            int id = Convert.ToInt32(Id);
            Burner burner = db.Burners.Find(id);
            if (burner != null)
            {
                if (burner.State)
                {
                    burner.LevelUp();
                    db.Entry(burner).State = EntityState.Modified;
                    db.SaveChanges();
                    if (burner.State && burner.BurnerLevel == SetLevel.Low)
                    {
                        return 1;
                    }
                    else if (burner.State && burner.BurnerLevel == SetLevel.Medium)
                    {
                        return 2;
                    }
                    else if (burner.State && burner.BurnerLevel == SetLevel.Height)
                    {
                        return 3;
                    }
                }
            }
            return 4;
        }
    }
}
