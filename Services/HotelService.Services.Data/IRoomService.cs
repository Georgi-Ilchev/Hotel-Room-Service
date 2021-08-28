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

        Task<IEnumerable<RoomViewModel>> ListAllFreeInHotel<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllTakenInHotel<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllInBungalow<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllFreeInBungalow<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        Task<IEnumerable<RoomViewModel>> ListAllTakenInBungalow<TRoomViewModel>(int category, int page, int itemsPerPage = 8);

        int RoomsCount();

        int RoomsCountInHotel();

        int FreeRoomsCountInHotel();

        int TakenRoomsCountInHotel();

        int RoomsCountInBungalow();

        int FreeRoomsCountInBungalow();

        int TakenRoomsCountInBungalow();

        int RoomsCountByCategory(int categoryId);

        int RoomsCountByCategoryInHotel(int categoryId);

        int FreeRoomsCountByCategoryInHotel(int categoryId);

        int TakenRoomsCountByCategoryInHotel(int categoryId);

        int RoomsCountByCategoryInBungalow(int categoryId);

        int FreeRoomsCountByCategoryInBungalow(int categoryId);

        int TakenRoomsCountByCategoryInBungalow(int categoryId);
    }
}
