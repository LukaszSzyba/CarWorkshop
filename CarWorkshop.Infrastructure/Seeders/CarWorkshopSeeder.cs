using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Infrastructure.Persistence;

namespace CarWorkshop.Infrastructure.Seeders
{
    public class CarWorkshopSeeder
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopSeeder(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.CarWorkshops.Any())
                {
                    var mazdaAso = new Domain.Entities.CarWorkshop()
                    {
                        Name = "Mazda ASO",
                        Description = "Autoryzowany Serwis Mazda",
                        ContactDetails = new()
                        {
                            City = "Warszawa",
                            Street = "Powstanców 69",
                            PostalCode = "00-001",
                            PhoneNumber = "+48555666777"
                        }
                    };
                    mazdaAso.EncodeName();
                    
                    _dbContext.CarWorkshops.Add(mazdaAso);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
