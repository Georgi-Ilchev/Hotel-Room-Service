namespace HotelService.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using HotelService.Data.Common.Repositories;
    using HotelService.Data.Models;

    public class CategoryService : ICategoryService
    {
        private readonly IDeletableEntityRepository<Category> categories;

        public CategoryService(IDeletableEntityRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.categories.AllAsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                })
            .OrderBy(x => x.Name)
            .ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name));
        }
    }
}
