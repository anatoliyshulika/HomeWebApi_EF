using HomeWebApi.Models;
using System;
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
                db.Bakes.Remove(bake);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }
    }
}
