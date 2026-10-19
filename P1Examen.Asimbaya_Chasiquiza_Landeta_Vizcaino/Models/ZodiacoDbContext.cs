using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Hierarchy;
using System.Linq;
using System.Web;

namespace ExamenP1.Asimbaya_Chasiquiza_Landeta_Vizcaino.Models
{
    public class ZodiacoDbContext : DbContext
    {
        public ZodiacoDbContext() : base("name=ZodiacoDbContext") { }

        public DbSet<Caballero> Caballeros { get; set; }
        public DbSet<Armadura> Armaduras { get; set; }

    }
}