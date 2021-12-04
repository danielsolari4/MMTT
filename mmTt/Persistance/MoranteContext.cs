using mmTt.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mmTt.Persistance
{
    public class MoranteContext : DbContext
    {
        public MoranteContext() : base("MoranteConnection")
        {

        }

        public DbSet<Producto> Productos {get;set;}

    }
}