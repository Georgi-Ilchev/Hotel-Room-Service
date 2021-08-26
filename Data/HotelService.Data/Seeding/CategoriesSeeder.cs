namespace HotelService.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using HotelService.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Double" });
            await dbContext.Categories.AddAsync(new Category { Name = "Triple " });
            await dbContext.Categories.AddAsync(new Category { Name = "Apartment" });

            await dbContext.SaveChangesAsync();
        }
    }
}
