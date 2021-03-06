﻿using System.Collections.Generic;
namespace HomeWebApi
{
    public class Frige : Devices, ISwitchbl, ISetLevel
    {
        public bool State { get; set; }
        public virtual List<Lamp> Lamps { get; set; }
        public SetLevel FrigeLevel { get; set; }
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
        public void LevelUp()
        {
            if (FrigeLevel == SetLevel.Medium && State)
            {
                FrigeLevel = SetLevel.Height;
                return;
            }
            else if (FrigeLevel == SetLevel.Low && State)
            {
                FrigeLevel = SetLevel.Medium;
                return;
            }
        }
        public void LevelDown()
        {
            if (FrigeLevel == SetLevel.Medium && State)
            {
                FrigeLevel = SetLevel.Low;
                return;
            }
            else if (FrigeLevel == SetLevel.Height && State)
            {
                FrigeLevel = SetLevel.Medium;
                return;
            }
        }
    }
}