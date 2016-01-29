using HomeWebApi.Models;
using System;
using System.Data.Entity;
using System.Web.Http;

namespace HomeWebApi
{
    public class FrigesApiController : ApiController
    {
        // PUT: api/FrigesApi/5
        public int PutOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
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
        }
        // PUT: api/FrigesApi/FrigesApi/{5}
        [Route("api/FrigesApi/PutLampFrigeOnOff/{id}")]
        public int PutLampFrigeOnOff(string Id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int id = Convert.ToInt32(Id);
                Frige frige = db.Friges.Find(id);
                if (frige != null)
                {
                    frige.LampOnOff();
                    db.Entry(frige).State = EntityState.Modified;
                    db.SaveChanges();
                    if (frige.GetLampState())
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
        // PUT: api/FrigesApi/PutLevelDown/{id}
        [Route("api/FrigesApi/PutLevelDown/{id}")]
        public int PutLevelDown(string Id)
        {
            using (DeviceContext db = new DeviceContext())
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
        }
        // PUT: api/FrigesApi/PutLevelUp/{id}
        [Route("api/FrigesApi/PutLevelUp/{id}")]
        public int PutLevelUp(string Id)
        {
            using (DeviceContext db = new DeviceContext())
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
        }
        // DELETE: api/FrigesApi/5
        public int DeleteFrige(string id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int frigeId = Convert.ToInt32(id);
                Frige frige = db.Friges.Find(frigeId);
                int lampId = frige.Lamps[0].Id;         // Здесь стоят везде нули потому что в данных коллекциях может быть только по одному
                Lamp lamp = db.Lamps.Find(lampId);      // устройству. Сделано так для того чтобы объяснить EF взаимосвязи между сущностями.
                if (frige != null && lamp != null)
                {
                    db.Lamps.Remove(lamp);        // Здесь лампа удаляется в ручную, потому что экземпляры одного класса могут быть в разных
                    db.Friges.Remove(frige);      // устройствах, и могут быть самостоятельны. Но один конкретный экземпляр относится,
                    db.SaveChanges();             // только к одному конкретному устройству, или же сам по себе. То есть здесь не получается
                    return 1;                     // ни один ко многим, ни многий ко многим, навигационные свойство должны иметь возможность
                }                                 // быть null, иначе будут возникать конфликты. При такой расскладке все работает, но при удалении
                return 0;                         // возникает ошибка что EF не может определить связи, либо если сделать немножко по другому
            }                                     // то при удалении к приперу печки, лампа относящаяся к ней из таблицы не удаляется.
        }                                         // Получается засорение базы, что очень плохо. В данной ситуации я решил что удалить
    }                                             // лампу в ручную это меньшее из зол.
}
