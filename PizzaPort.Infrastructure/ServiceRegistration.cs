using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PizzaPort.Domain;
using PizzaPort.Domain.Interfaces;
using PizzaPort.Infrastructure.Entities;
using PizzaPort.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Infrastructure
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,string connectionstring)
        {
            services.AddDbContext<PizzaPortDBContext>(Options => Options.UseSqlServer(connectionstring));
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
