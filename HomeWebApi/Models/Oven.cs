using System.Collections.Generic;

namespace HomeWebApi
{
    public class Oven : Devices, ISwitchbl
    {
        public bool State { get; set; }
        public virtual List<Lamp> Lamps { get; set; }
        public int BakeId { get; set; }
        public void LampOnOff()
        {
            Lamps[0].OnOff();
        }
        public bool GetLampState()
        {
            return Lamps[0].State;
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