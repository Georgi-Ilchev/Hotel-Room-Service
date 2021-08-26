namespace HotelService.Services.Data
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using HotelService.Data.Common.Repositories;
    using HotelService.Data.Models;
    using HotelService.Web.ViewModels.Room;

    using static HotelService.Data.Models.DataConstants.DataConstants;

    public class RoomService : IRoomService
    {
        private readonly IDeletableEntityRepository<Room> roomRepository;
        private readonly IDeletableEntityRepository<Category> categoryRepository;
        private readonly IDeletableEntityRepository<Location> locationRepository;

        private readonly string[] allowedExtensionsForImage = new[] { "jpg", "png", "JPG", "PNG" };

        public RoomService(
            IDeletableEntityRepository<Room> roomRepository,
            IDeletableEntityRepository<Category> categoryRepository,
            IDeletableEntityRepository<Location> locationRepository)
        {
            this.roomRepository = roomRepository;
            this.categoryRepository = categoryRepository;
            this.locationRepository = locationRepository;
        }

        public async Task CreateAsync(CreateRoomInputModel input, string userId, string imagePath)
        {
            var room = new Room()
            {
                Name = input.Name,
                Description = input.Description,
                Price = input.Price,
                CreatedOn = DateTime.UtcNow.ToLocalTime(),
                CategoryId = input.CategoryId,
                LocationId = input.LocationId,
                UserId = userId,
                IsFree = true,
                IsPaid = false,
            };

            if (!this.categoryRepository.All().Any(c => c.Id == input.CategoryId))
            {
                throw new Exception($"Invalid category.");
            }

            if (!this.locationRepository.All().Any(c => c.Id == input.LocationId))
            {
                throw new Exception($"Invalid location.");
            }

            Directory.CreateDirectory($"{imagePath}/rooms/");

            if (input.Images.Count() <= ImagesMaxCount && input.Images.Count() >= ImagesMinCount)
            {
                foreach (var image in input.Images)
                {
                    var extension = Path.GetExtension(image.FileName).TrimStart('.');

                    if (!this.allowedExtensionsForImage.Any(x => extension.EndsWith(x)))
                    {
                        throw new Exception($"Invalid image extension {extension}.");
                    }

                    var dataImage = new Image
                    {
                        UserId = userId,
                        Extension = extension,
                    };
                    room.Images.Add(dataImage);

                    var path = $"{imagePath}/rooms/{dataImage.Id}.{extension}";

                    using (Stream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await image.CopyToAsync(fileStream);
                    }
                }
            }
            else
            {
                throw new Exception($"Maximum {ImagesMaxCount} images.");
            }

            await this.roomRepository.AddAsync(room);
            await this.roomRepository.SaveChangesAsync();
        }
    }
}
