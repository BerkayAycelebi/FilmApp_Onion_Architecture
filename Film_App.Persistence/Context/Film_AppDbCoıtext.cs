using Film_App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_App.Persistence.Context
{
    public class Film_AppDbCoıtext:DbContext
    {
        public Film_AppDbCoıtext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Saloon> Saloons { get; set; }

    }
}
