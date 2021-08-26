namespace HotelService.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using HotelService.Data.Models;

    public class LocationSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Locations.Any())
            {
                return;
            }

            await dbContext.Locations.AddAsync(new Location { Name = "Hotel" });
            await dbContext.Locations.AddAsync(new Location { Name = "Bungalow" });

            await dbContext.SaveChangesAsync();
        }
    }
}
