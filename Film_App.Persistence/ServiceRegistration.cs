using Film_App.Application.Absractions;
using Film_App.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Film_App.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<Film_AppDbCoıtext>(options => options.UseSqlServer("data source=DESKTOP-T58A0DS; initial catalog=FilmDb; integrated security=True "));

        }
    }
}
