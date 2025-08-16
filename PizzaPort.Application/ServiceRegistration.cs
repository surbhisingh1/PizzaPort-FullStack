
using Microsoft.Extensions.DependencyInjection;
using PizzaPort.Application.Contracts;
using PizzaPort.Application.Implementation;
using PizzaPort.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaPort.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
           services.AddScoped<IItemService,ItemService>();
           services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            return services;
        }
    }
}
