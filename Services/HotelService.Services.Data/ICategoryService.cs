namespace HotelService.Services.Data
{
    using System.Collections.Generic;

    public interface ICategoryService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuePairs();
    }
}
