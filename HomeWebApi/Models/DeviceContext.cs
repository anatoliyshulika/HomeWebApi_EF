using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HomeWebApi.Models
{
    public class DeviceContext : DbContext
    {
        public DbSet<Lamp> Lamps { get; set; }
        public DbSet<Burner> Burners { get; set; }
        public DbSet<Bake> Bakes { get; set; }
        public DbSet<Oven> Ovens { get; set; }
        public DbSet<Frige> Friges { get; set; }
        public DbSet<TV> TVs { get; set; }
        public DbSet<Radio> Radios { get; set; }
    }
}