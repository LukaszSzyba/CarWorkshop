using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Application.Mappings;
using CarWorkshop.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CarWorkshop.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddAplication(this IServiceCollection services)
        {
            services.AddScoped<ICarWorkshopService, CarWorkshopService>();

            services.AddAutoMapper(typeof(CarWorkshopMappingProfile));
        }
    }
}
