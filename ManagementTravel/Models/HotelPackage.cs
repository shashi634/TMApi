using System;

namespace ManagementTravel.Models
{
    public class HotelPackage
    {
        public decimal Id { get; set; }
        public decimal? hotelId { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public int? noofdays { get; set; }
        public int? noofnight { get; set; }
        public decimal? extraadultcharge { get; set; }
        public decimal? extrachildcharge { get; set; }
        public string tac { get; set; }
        public int? defaultnoofmembers { get; set; }
        public Guid? publicId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
