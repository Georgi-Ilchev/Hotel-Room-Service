namespace HotelService.Services.Data
{
    using System.Threading.Tasks;

    using HotelService.Web.ViewModels.Room;

    public interface IRoomService
    {
        Task CreateAsync(CreateRoomInputModel input, string userId, string imagePath);
    }
}
