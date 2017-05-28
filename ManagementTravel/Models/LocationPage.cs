using System;

namespace ManagementTravel.Models
{
    public class LocationPage
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? AverageRate { get; set; }
        public int? LocationId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? PublicId { get; set; }
        public virtual Location Location { get; set; }
    }
}
