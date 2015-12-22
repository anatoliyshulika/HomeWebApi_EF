using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWebApi
{
    public class Oven : Devices, ISwitchbl
    {
        public bool State { get; set; }
        public virtual List<Lamp> Lamps { get; set; }
        public virtual Bake Bake { get; set; }
        public int? BakeId { get; set; }
        public void LampOnOff(int id)
        {
            Lamps[id].OnOff();
        }
        public bool GetLampState(int id)
        {
            return Lamps[id].State;
        }
        public void OnOff()
        {
            if (State)
            {
                State = false;
                return;
            }
            if (!State)
            {
                State = true;
                return;
            }
        }
    }
}