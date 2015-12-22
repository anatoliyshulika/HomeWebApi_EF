using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWebApi
{
    public class Lamp : Devices, ISwitchbl
    {
        public bool State { get; set; }
        public virtual Oven Oven { get; set; }
        public int? OvenId { get; set; }
        public virtual Frige Frige { get; set; }
        public int? FrigeId { get; set; }
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