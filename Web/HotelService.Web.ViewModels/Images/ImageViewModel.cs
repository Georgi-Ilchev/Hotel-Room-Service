namespace HotelService.Web.ViewModels.Images
{
    using System.ComponentModel.DataAnnotations;

    using HotelService.Data.Models;
    using HotelService.Services.Mapping;

    public class ImageViewModel : IMapFrom<Image>
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Extension { get; set; }
    }
}
