namespace HotelService.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using HotelService.Data.Common.Repositories;
    using HotelService.Data.Models;

    public class LocationService : ILocationService
    {
        private readonly IDeletableEntityRepository<Location> locations;

        public LocationService(IDeletableEntityRepository<Location> locations)
        {
            this.locations = locations;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs()
        {
            return this.locations.AllAsNoTracking()
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
