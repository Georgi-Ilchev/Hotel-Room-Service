using HotelService.Services.Data;
using HotelService.Web.ViewModels.Rooms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HotelService.Web.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService roomService;
        private readonly ICategoryService categoryService;
        private readonly ILocationService locationService;
        private readonly IWebHostEnvironment environment;

        public RoomController(
            IRoomService roomService,
            ICategoryService categoryService,
            ILocationService locationService,
            IWebHostEnvironment environment)
        {
            this.roomService = roomService;
            this.categoryService = categoryService;
            this.locationService = locationService;
            this.environment = environment;
        }

        [Authorize]
        public IActionResult Create()
        {
            var viewModel = new CreateRoomInputModel();
            viewModel.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();
            viewModel.LocationItems = this.locationService.GetAllAsKeyValuePairs();

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create(CreateRoomInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();
                input.LocationItems = this.locationService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            try
            {
                await this.roomService.CreateAsync(input, userId, $"{this.environment.WebRootPath}/images");
            }
            catch (Exception ex)
            {
                this.ModelState.AddModelError(string.Empty, ex.Message);

                input.CategoriesItems = this.categoryService.GetAllAsKeyValuePairs();
                input.LocationItems = this.locationService.GetAllAsKeyValuePairs();
                return this.View(input);
            }

            this.TempData["Message"] = "The room was successfully created.";

            return this.Redirect("/Room/All");
        }

        [Authorize]
        public async Task<IActionResult> All(int category, int id = 1, int searchId = 1)
        {
            const int ItemsPerPage = 8;

            if (id <= 0)
            {
                return this.NotFound();
            }

            var roomsCount = 0;
            var viewModel = new ListRoomsViewModel();

            if (category == 0)
            {
                roomsCount = this.roomService.RoomsCount();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllWithSearch<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            //else
            //{
            //    auctionsCount = this.roomService.GetAuctionsCountByCategory(category);
            //    viewModel = new ListRoomsViewModel
            //    {
            //        CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs(),
            //        ItemsPerPage = ItemsPerPage,
            //        PageNumber = searchId,
            //        Auctions = await this.auctionService.GetAllForSearch<ListAuctionViewModel>(category, searchId, ItemsPerPage),
            //        Count = auctionsCount,
            //    };
            //}

            //foreach (var auction in viewModel.Auctions)
            //{
            //    await this.auctionService.UpdateDbAuction(auction.Id);
            //}

            if (category != 0)
            {
                this.ViewBag.CurrentCategory = category;
            }

            return this.View(viewModel);
        }
    }
}
