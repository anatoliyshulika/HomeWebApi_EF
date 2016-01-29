using HomeWebApi.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace HomeWebApi
{
    public class RadiosApiController : ApiController
    {
        // PUT: api/RadiosApi
        public int PutOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Radio radio = db.Radios.Find(id);
                if (radio != null)
                {
                    radio.OnOff();
                    db.Entry(radio).State = EntityState.Modified;
                    db.SaveChanges();
                    if (radio.State)
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
        // PUT: api/RadiosApi/PutVolumeDown/{id}
        [Route("api/RadiosApi/PutVolumeDown/{id}")]
        public int PutVolumeDown(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Radio radio = db.Radios.Find(id);
                if (radio != null)
                {
                    if (radio.State)
                    {
                        radio.VolumeDown();
                        db.Entry(radio).State = EntityState.Modified;
                        db.SaveChanges();
                        if (radio.State && radio.Volume == SetLevel.Low)
                        {
                            return 1;
                        }
                        else if (radio.State && radio.Volume == SetLevel.Medium)
                        {
                            return 2;
                        }
                        else if (radio.State && radio.Volume == SetLevel.Height)
                        {
                            return 3;
                        }
                    }
                }
                return 4;
            }
        }
        // PUT: api/RadiosApi/PutVolumeUp/{id}
        [Route("api/RadiosApi/PutVolumeUp/{id}")]
        public int PutVolumeUp(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Radio radio = db.Radios.Find(id);
                if (radio != null)
                {
                    if (radio.State)
                    {
                        radio.VolumeUp();
                        db.Entry(radio).State = EntityState.Modified;
                        db.SaveChanges();
                        if (radio.State && radio.Volume == SetLevel.Low)
                        {
                            return 1;
                        }
                        else if (radio.State && radio.Volume == SetLevel.Medium)
                        {
                            return 2;
                        }
                        else if (radio.State && radio.Volume == SetLevel.Height)
                        {
                            return 3;
                        }
                    }
                }
                return 4;
            }
        }
        // DELETE: api/RadiosApi/5
        public int DeleteRadio(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Radio radio = db.Radios.Find(id);
                if (radio != null)
                {
                    db.Radios.Remove(radio);
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }
    }
}
