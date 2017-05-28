using System;
using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class RoomType
    {
        public RoomType()
        {
            HotelRoomTypes = new List<HotelRoomType>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public Guid? PublicId { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual ICollection<HotelRoomType> HotelRoomTypes { get; set; }
    }
}
