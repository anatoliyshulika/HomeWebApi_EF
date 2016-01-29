using HomeWebApi.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace HomeWebApi
{
    public class TVsApiController : ApiController
    {
        // PUT: api/TVsApi
        public byte PutOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    tv.OnOff();
                    db.Entry(tv).State = EntityState.Modified;
                    db.SaveChanges();
                    if (tv.State)
                    {
                        return tv.Chennel;
                    }
                    else
                    {
                        return 0;
                    }
                }
                return 11;
            }
        }
        // PUT: api/TVApi/PutChennelDown/{id}
        [Route("api/TVsApi/PutChennelDown/{id}")]
        public int PutChennelDown(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    if (tv.State)
                    {
                        tv.ChannelDown();
                        db.Entry(tv).State = EntityState.Modified;
                        db.SaveChanges();
                        return tv.Chennel;
                    }
                }
                return 0;
            }
        }
        // PUT: api/TVApi/PutChennelUp/{id}
        [Route("api/TVsApi/PutChennelUp/{id}")]
        public int PutChennelUp(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    if (tv.State)
                    {
                        tv.ChannelUp();
                        db.Entry(tv).State = EntityState.Modified;
                        db.SaveChanges();
                        return tv.Chennel;
                    }
                }
                return 0;
            }
        }
        // PUT: api/TVsApi/PutVolumeDown/{id}
        [Route("api/TVsApi/PutVolumeDown/{id}")]
        public int PutVolumeDown(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    if (tv.State)
                    {
                        tv.VolumeDown();
                        db.Entry(tv).State = EntityState.Modified;
                        db.SaveChanges();
                        if (tv.State && tv.Volume == SetLevel.Low)
                        {
                            return 1;
                        }
                        else if (tv.State && tv.Volume == SetLevel.Medium)
                        {
                            return 2;
                        }
                        else if (tv.State && tv.Volume == SetLevel.Height)
                        {
                            return 3;
                        }
                    }
                }
                return 4;
            }
        }
        // PUT: api/TVsApi/PutVolumeUp/{id}
        [Route("api/TVsApi/PutVolumeUp/{id}")]
        public int PutVolumeUp(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    if (tv.State)
                    {
                        tv.VolumeUp();
                        db.Entry(tv).State = EntityState.Modified;
                        db.SaveChanges();
                        if (tv.State && tv.Volume == SetLevel.Low)
                        {
                            return 1;
                        }
                        else if (tv.State && tv.Volume == SetLevel.Medium)
                        {
                            return 2;
                        }
                        else if (tv.State && tv.Volume == SetLevel.Height)
                        {
                            return 3;
                        }
                    }
                }
                return 4;
            }
        }
        // DELETE: api/TVsApi/5
        public int DeleteTV(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                TV tv = db.TVs.Find(id);
                if (tv != null)
                {
                    db.TVs.Remove(tv);
                    db.SaveChanges();
                    return 1;
                }
                return 0;
            }
        }
    }
}
