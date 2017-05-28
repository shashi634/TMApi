using System;

namespace ManagementTravel.Models
{
    public class LocationImage
    {
        public decimal Id { get; set; }
        public string ImageName { get; set; }
        public DateTime? UploadedDate { get; set; }
        public int? LocationId { get; set; }
        public virtual Location Location { get; set; }
    }
}
