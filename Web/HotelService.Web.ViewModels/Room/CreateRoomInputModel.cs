namespace HotelService.Web.ViewModels.Room
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Http;

    using static HotelService.Data.Models.DataConstants.DataConstants;

    public class CreateRoomInputModel
    {
        [Required]
        [StringLength(
            RoomNameMaxLength,
            ErrorMessage = "Auction name must be between {2} and {1} characters long.",
            MinimumLength = RoomNameMinLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(
            DescriptionMaxLength,
            ErrorMessage = "Description must be between {2} and {1} characters long.",
            MinimumLength = DescriptionMinLength)]
        public string Description { get; set; }

        [Range(PriceMinValue, PriceMaxValue, ErrorMessage = "The field {0} must be greater than {1}.")]
        public decimal Price { get; set; }

        public bool IsFree { get; set; }

        [Display(Name = "Type")]
        public int CategoryId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }

        [Display(Name = "Location")]
        public int LocationId { get; set; }

        public IEnumerable<KeyValuePair<string, string>> LocationItems { get; set; }

        [Display(Name = "Images (1-10)")]
        public IEnumerable<IFormFile> Images { get; set; }
    }
}
