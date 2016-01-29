
namespace HomeWebApi
{
    public class Lamp : Devices, ISwitchbl
    {
        public bool State { get; set; }
        public int? OvenId { get; set; }
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