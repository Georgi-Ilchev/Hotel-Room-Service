namespace HotelService.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using HotelService.Web.ViewModels.Rooms;

    public interface IRoomService
    {
        Task CreateAsync(CreateRoomInputModel input, string userId, string imagePath);

        Task<IEnumerable<RoomViewModel>> ListAllWithSearch<TListAuctionViewModel>(int category, int page, int itemsPerPage = 8);

        int RoomsCount();

        int RoomsCountByCategory(int categoryId);
    }
}
