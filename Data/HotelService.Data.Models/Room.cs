namespace HotelService.Data.Models
{
    using System;
    using System.Collections.Generic;

    using HotelService.Data.Common.Models;

    public class Room : BaseDeletableModel<int>
    {
        public Room()
        {
            this.Images = new HashSet<Image>();
            this.Extras = new HashSet<RoomExtra>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsFree { get; set; }

        public bool IsPaid { get; set; }

        public DateTime Settle { get; set; }

        public DateTime Leave { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public virtual ICollection<RoomExtra> Extras { get; set; }
    }
}
