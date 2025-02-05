using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using CarWorkshop.Infrastructure.Seeders;
using CarWorkshop.Domain.Intefaces;
using CarWorkshop.Infrastructure.Repositories;

namespace CarWorkshop.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var DBConnect = configuration.GetConnectionString("CarWorkshopORA");

            services.AddDbContext<CarWorkshopDbContext>(options => options.UseOracle(DBConnect));

            services.AddScoped<CarWorkshopSeeder>();

            services.AddScoped<ICarWorkshopRepository, CarWorkshopRepository>();
        }
    }
}
