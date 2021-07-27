using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiNasaExample.Models;

namespace WebApiNasaExample.Data
{
    public class WebApiNasaExampleContext : DbContext
    {
        public WebApiNasaExampleContext (DbContextOptions<WebApiNasaExampleContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiNasaExample.Models.Database> Database { get; set; }
    }
}
