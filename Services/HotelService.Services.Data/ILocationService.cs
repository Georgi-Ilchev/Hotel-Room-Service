namespace HotelService.Services.Data
{
    using System.Collections.Generic;

    public interface ILocationService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
