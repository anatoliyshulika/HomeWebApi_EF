
namespace HomeWebApi
{
    public class Oven : Devices, ISwitchbl
    {
        public bool State { get; set; }
        public virtual Lamp Lamp { get; set; }
        public int? BakeId { get; set; }
        public void LampOnOff()
        {
            Lamp.OnOff();
        }
        public bool GetLampState()
        {
            return Lamp.State;
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