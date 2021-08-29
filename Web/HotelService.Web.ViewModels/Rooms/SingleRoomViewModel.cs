namespace HotelService.Web.ViewModels.Rooms
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using HotelService.Data.Models;
    using HotelService.Services.Mapping;
    using HotelService.Web.ViewModels.Images;

    public class SingleRoomViewModel : IMapFrom<Room>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int LocationId { get; set; }

        public string LocationName { get; set; }

        public string UserUserName { get; set; }

        public decimal Price { get; set; }

        public bool IsFree { get; set; }

        public bool IsPaid { get; set; }

        public DateTime Settle { get; set; }

        public string SettleAsString
           => this.Settle.ToString("dd.MM.yyyy HH:mm", CultureInfo.GetCultureInfo("bg-BG"));

        public DateTime Leave { get; set; }

        public string LeavingAsString
          => this.Leave.ToString("dd.MM.yyyy HH:mm", CultureInfo.GetCultureInfo("bg-BG"));

        public IEnumerable<ImageViewModel> Images { get; set; }
    }
}
