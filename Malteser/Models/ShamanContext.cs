using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Malteser.Models
{
    public class ShamanContext : DbContext
    {
        public ShamanContext()
            : base("name = cnnShaman")
        {
        }

        public DbSet<Incidente> Incidentes { get; set; }
    }
}