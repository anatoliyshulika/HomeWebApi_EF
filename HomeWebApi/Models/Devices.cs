using System;

namespace HomeWebApi
{
    public abstract class Devices
    {
        public string ViewPath { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreateTime { get; set; }
    }
}