﻿namespace HotelService.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using HotelService.Data.Common.Models;

    public class Location : BaseDeletableModel<int>
    {
        public Location()
        {
            this.Rooms = new HashSet<Room>();
        }

        [Required]
        public string Name { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
