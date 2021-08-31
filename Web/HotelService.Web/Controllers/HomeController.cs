namespace HotelService.Web.Controllers
{
    using System.Diagnostics;

    using HotelService.Services.Data;
    using HotelService.Web.ViewModels;
    using HotelService.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IRoomService roomService;

        public HomeController(IRoomService roomService)
        {
            this.roomService = roomService;
        }

        public IActionResult Index()
        {
            var freeInHotel = this.roomService.FreeRoomsCountInHotel();
            var freeInBungalow = this.roomService.FreeRoomsCountInBungalow();

            var viewModel = new IndexViewModel
            {
                FreeRoomsCountInHotel = freeInHotel,
                FreeRoomsCountInBungalow = freeInBungalow,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
