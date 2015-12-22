using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWebApi
{
    public class Burner : Devices, ISwitchbl, ISetLevel
    {
        public bool State { get; set; }
        public SetLevel BurnerLevel { get; set; }
        public virtual Bake Bake { get; set; }
        public int? BakeId { get; set; }
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
            if (BurnerLevel == SetLevel.Medium && State)
            {
                BurnerLevel = SetLevel.Height;
                return;
            }
            else if (BurnerLevel == SetLevel.Low && State)
            {
                BurnerLevel = SetLevel.Medium;
                return;
            }
        }
        public void LevelDown()
        {
            if (BurnerLevel == SetLevel.Medium && State)
            {
                BurnerLevel = SetLevel.Low;
                return;
            }
            else if (BurnerLevel == SetLevel.Height && State)
            {
                BurnerLevel = SetLevel.Medium;
                return;
            }
        }
    }
}