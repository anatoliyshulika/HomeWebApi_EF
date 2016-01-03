using System.Collections.Generic;

namespace HomeWebApi
{
    public class Bake : Devices
    {
        public virtual List<Burner> Burners { get; set; }
        public virtual Oven Oven { get; set; }
    }
}