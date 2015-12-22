﻿using HomeWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HomeWebApi
{
    public class TVsApiController : ApiController
    {
        private DeviceContext db = new DeviceContext();
        // PUT: api/TVsApi
        public int PutOnOff(string Id)
        {
            int id = Convert.ToInt32(Id);
            TV tv = db.TVs.Find(id);
            if (tv != null)
            {
                tv.OnOff();
                db.Entry(tv).State = EntityState.Modified;
                db.SaveChanges();
                if (tv.State && tv.Chennel == 1)
                {
                    return 1;
                }
                else if (tv.State && tv.Chennel == 2)
                {
                    return 2;
                }
                else if (tv.State && tv.Chennel == 3)
                {
                    return 3;
                }
                else if (tv.State && tv.Chennel == 4)
                {
                    return 4;
                }
                else if (tv.State && tv.Chennel == 5)
                {
                    return 5;
                }
                else if (tv.State && tv.Chennel == 6)
                {
                    return 6;
                }
                else if (tv.State && tv.Chennel == 7)
                {
                    return 7;
                }
                else if (tv.State && tv.Chennel == 8)
                {
                    return 8;
                }
                else if (tv.State && tv.Chennel == 9)
                {
                    return 9;
                }
                else if (tv.State && tv.Chennel == 10)
                {
                    return 10;
                }
                else
                {
                    return 0;
                }
            }
            return 11;
        }
        // PUT: api/TVApi/PutChennelDown/{id}
        [Route("api/TVsApi/PutChennelDown/{id}")]
        public int PutChennelDown(string Id)
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
        // PUT: api/TVApi/PutChennelUp/{id}
        [Route("api/TVsApi/PutChennelUp/{id}")]
        public int PutChennelUp(string Id)
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
        // PUT: api/TVsApi/PutVolumeDown/{id}
        [Route("api/TVsApi/PutVolumeDown/{id}")]
        public int PutVolumeDown(string Id)
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
        // PUT: api/TVsApi/PutVolumeUp/{id}
        [Route("api/TVsApi/PutVolumeUp/{id}")]
        public int PutVolumeUp(string Id)
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
        // DELETE: api/TVsApi/5
        public int DeleteTV(string Id)
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