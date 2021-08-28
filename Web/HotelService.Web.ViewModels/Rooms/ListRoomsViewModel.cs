namespace HotelService.Web.ViewModels.Rooms
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ListRoomsViewModel : PagingViewModel
    {
        [Display(Name = "Type")]
        public string Category { get; set; }

        public string Location { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LocationsItems { get; set; }

        public IEnumerable<RoomViewModel> Rooms { get; set; }
    }
}
