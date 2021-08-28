namespace HotelService.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using HotelService.Web.ViewModels.Rooms;

    public interface IRoomService
    {
        Task CreateAsync(CreateRoomInputModel input, string userId, string imagePath);

        Task<IEnumerable<RoomViewModel>> ListAllWithSearch<TListAuctionViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllInHotel<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllInBungalow<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        int RoomsCount();

        int RoomsCountInHotel();

        int RoomsCountInBungalow();

        int RoomsCountByCategory(int categoryId);

        int RoomsCountByCategoryInHotel(int categoryId);

        int RoomsCountByCategoryInBungalow(int categoryId);
    }
}
