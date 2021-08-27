namespace HotelService.Web.ViewModels.Rooms
{
    using System.Collections.Generic;

    public class ListRoomsViewModel : PagingViewModel
    {
        public string Category { get; set; }

        public string Location { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LocationsItems { get; set; }

        public IEnumerable<RoomViewModel> Rooms { get; set; }
    }
}
