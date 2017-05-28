using System;

namespace ManagementTravel.Models
{
    public class HotelRoomTypePrice
    {
        public decimal Id { get; set; }
        public decimal? HotelRoomTypeId { get; set; }
        public decimal? Rate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? RoomNoAvailable { get; set; }
        public virtual HotelRoomType HotelRoomType { get; set; }
    }
}
