namespace HotelService.Web.ViewModels.Rooms
{
    using System.Linq;

    using AutoMapper;
    using HotelService.Data.Models;
    using HotelService.Services.Mapping;

    public class RoomViewModel : IMapFrom<Room>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string UserUserName { get; set; }

        public decimal Price { get; set; }

        public bool IsFree { get; set; }

        public bool IsPaid { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Room, RoomViewModel>()
               .ForMember(x => x.ImageUrl, opt =>
                 opt.MapFrom(x =>
                 "/images/rooms/" + x.Images.FirstOrDefault().Id + "." + x.Images.FirstOrDefault().Extension));
        }
    }
}
