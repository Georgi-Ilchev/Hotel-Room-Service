using HotelService.Services.Data;
using HotelService.Web.ViewModels.Room;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelService.Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;
        private readonly ICategoryService categoryService;
        private readonly ILocationService locationService;

        public RoomController(
            IRoomService roomService,
            ICategoryService categoryService,
            ILocationService locationService)
        {
            this.roomService = roomService;
            this.categoryService = categoryService;
            this.locationService = locationService;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateRoomInputModel();
            viewModel.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();
            viewModel.LocationItems = this.locationService.GetAllAsKeyValuePairs();

            return this.View(viewModel);
        }
    }
}
