using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class HotelRoomType
    {
        public decimal Id { get; set; }
        public decimal? HotelId { get; set; }
        public int? RoomTypeId { get; set; }
        public virtual ICollection<HotelRoomTypePrice> HotelRoomTypePrices { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual RoomType RoomType { get; set; }
    }
}
