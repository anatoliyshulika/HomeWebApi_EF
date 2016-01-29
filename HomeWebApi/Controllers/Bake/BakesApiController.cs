using HomeWebApi.Models;
using System;
using System.Web.Http;

namespace HomeWebApi
{
    public class BakesApiController : ApiController
    {
        // DELETE: api/BakesApi/5
        public int DeleteBake(string id)
        {
            using (DeviceContext db = new DeviceContext())
            {
                int bakeId = Convert.ToInt32(id);
                Bake bake = db.Bakes.Find(bakeId);
                int lampId = bake.Ovens[0].Lamps[0].Id; // Здесь стоят везде нули потому что в данных коллекциях может быть только по одному
                Lamp lamp = db.Lamps.Find(lampId);      // устройству. Сделано так для того чтобы объяснить EF взаимосвязи между сущностями.
                if (bake != null && lamp != null)
                {
                    db.Lamps.Remove(lamp);         // Здесь лампа удаляется в ручную, потому что экземпляры одного класса могут быть в разных
                    db.Bakes.Remove(bake);         // устройствах, и могут быть самостоятельны. Но один конкретный экземпляр относится,
                    db.SaveChanges();              // только к одному конкретному устройству, или же сам по себе. То есть здесь не получается
                    return 1;                      // ни один ко многим, ни многий ко многим, навигационные свойство должны иметь возможность
                }                                  // быть null, иначе будут возникать конфликты. При такой расскладке все работает, но при удалении
                return 0;                          // возникает ошибка что EF не может определить связи, либо если сделать немножко по другому
            }                                      // то при удалении к приперу печки, лампа относящаяся к ней из таблицы не удаляется.
        }                                          // Получается засорение базы, что очень плохо. В данной ситуации я решил что удалить
    }                                              // лампу в ручную это меньшее из зол.
}
