namespace HotelService.Data.Models
{
    public class RoomExtra
    {
        public int Id { get; set; }

        public int RoomId { get; set; }

        public Room Room { get; set; }

        public int ExtraId { get; set; }

        public Extra Extra { get; set; }

        //public decimal Price { get; set; }
    }
}
