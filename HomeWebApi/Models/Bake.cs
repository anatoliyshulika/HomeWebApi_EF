using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWebApi
{
    public class Bake : Devices
    {
        public virtual List<Burner> Burners { get; set; }
        public virtual List<Oven> Ovens { get; set; }
    }
}