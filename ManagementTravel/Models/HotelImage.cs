using System;

namespace ManagementTravel.Models
{
    public class HotelImage
    {
        public decimal Id { get; set; }
        public string ImageName { get; set; }
        public DateTime? UploadedDate { get; set; }
        public decimal? HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
