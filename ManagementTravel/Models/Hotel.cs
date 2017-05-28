using System;
using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class Hotel
    {
        public Hotel()
        {
            HotelImages = new List<HotelImage>();
            HotelMealTypes = new List<HotelMealType>();
            HotelPackages = new List<HotelPackage>();
            HotelRoomTypes = new List<HotelRoomType>();
        }

        public decimal Id { get; set; }
        public string Name { get; set; }
        public int? LocationId { get; set; }
        public int? HotelTypeId { get; set; }
        public string Description { get; set; }
        public int? AverageRating { get; set; }
        public Guid? PublicId { get; set; }
        public decimal? ContactPersonId { get; set; }
        public Guid? LoggingUserId { get; set; }
        public string Address { get; set; }
        public virtual ICollection<HotelImage> HotelImages { get; set; }
        public virtual ICollection<HotelMealType> HotelMealTypes { get; set; }
        public virtual ICollection<HotelPackage> HotelPackages { get; set; }
        public virtual ICollection<HotelRoomType> HotelRoomTypes { get; set; }
        public virtual HotelType HotelType { get; set; }
        public virtual Location Location { get; set; }
    }
}
