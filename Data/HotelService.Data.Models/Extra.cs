namespace HotelService.Data.Models
{
    using System.Collections.Generic;

    using HotelService.Data.Common.Models;

    public class Extra : BaseDeletableModel<int>
    {
        public Extra()
        {
            this.Rooms = new HashSet<RoomExtra>();
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<RoomExtra> Rooms { get; set; }
    }
}
