using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWebApi
{
    public class Radio : Devices, ISwitchbl, ISetVolume
    {
        public SetLevel Volume { get; set; }
        public bool State { get; set; }
        public void OnOff()
        {
            if (State)
            {
                State = false;
                Volume = SetLevel.Low;
                return;
            }
            if (!State)
            {
                State = true;
                return;
            }
        }
        public void VolumeUp()
        {
            if (Volume == SetLevel.Medium && State)
            {
                Volume = SetLevel.Height;
                return;
            }
            else if (Volume == SetLevel.Low && State)
            {
                Volume = SetLevel.Medium;
                return;
            }
        }
        public void VolumeDown()
        {
            if (Volume == SetLevel.Medium && State)
            {
                Volume = SetLevel.Low;
                return;
            }
            else if (Volume == SetLevel.Height && State)
            {
                Volume = SetLevel.Medium;
                return;
            }
        }
    }
}