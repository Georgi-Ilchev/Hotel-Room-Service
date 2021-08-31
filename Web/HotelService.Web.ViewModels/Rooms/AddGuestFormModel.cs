namespace HotelService.Web.ViewModels.Rooms
{
    using HotelService.Data.Models;
    using HotelService.Services.Mapping;

    using System.ComponentModel.DataAnnotations;

    public class AddGuestFormModel : IMapFrom<Room>
    {
        public int Id { get; set; }

        [Required]
        public string Settle { get; set; }

        [Required]
        public string Leave { get; set; }

        [Required]
        public string Family { get; set; }

        public int RoomId { get; set; }
    }
}
