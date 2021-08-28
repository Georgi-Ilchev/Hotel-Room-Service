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
            else
            {
                roomsCount = this.roomService.RoomsCountByCategory(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllWithSearch<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> AllInHotel(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.RoomsCountInHotel();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllInHotel<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.RoomsCountByCategoryInHotel(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllInHotel<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> FreeInHotel(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.FreeRoomsCountInHotel();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllFreeInHotel<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.FreeRoomsCountByCategoryInHotel(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllFreeInHotel<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> TakenInHotel(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.TakenRoomsCountInHotel();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllTakenInHotel<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.TakenRoomsCountByCategoryInHotel(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllTakenInHotel<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> AllInBungalow(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.RoomsCountInBungalow();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllInBungalow<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.RoomsCountByCategoryInBungalow(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllInBungalow<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> FreeInBungalow(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.FreeRoomsCountInBungalow();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllFreeInBungalow<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.FreeRoomsCountByCategoryInBungalow(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllFreeInBungalow<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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

        [Authorize]
        public async Task<IActionResult> TakenInBungalow(int category, int id = 1, int searchId = 1)
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
                roomsCount = this.roomService.TakenRoomsCountInBungalow();
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    LocationsItems = this.locationService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = id,
                    Rooms = await this.roomService.ListAllTakenInBungalow<RoomViewModel>(category, id, ItemsPerPage),
                    Count = roomsCount,
                };
            }
            else
            {
                roomsCount = this.roomService.TakenRoomsCountByCategoryInBungalow(category);
                viewModel = new ListRoomsViewModel
                {
                    CategoriesItems = this.categoryService.GetAllAsKeyValuePairs(),
                    ItemsPerPage = ItemsPerPage,
                    PageNumber = searchId,
                    Rooms = await this.roomService.ListAllTakenInBungalow<RoomViewModel>(category, searchId, ItemsPerPage),
                    Count = roomsCount,
                };
            }

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
