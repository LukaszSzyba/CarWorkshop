using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Persistence
{
    public class CarWorkshopDbContext : DbContext
    {
        public CarWorkshopDbContext(DbContextOptions<CarWorkshopDbContext> options) : base(options)
        {
            CarWorkshops = Set<Domain.Entities.CarWorkshop>();
        }

        public DbSet<Domain.Entities.CarWorkshop> CarWorkshops { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle("User Id=DEV_DEV;Password=test123;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=150.150.222.13)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=LGORCL)));");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.CarWorkshop>()
                .OwnsOne(c => c.ContactDetails);
        }
    }
}
