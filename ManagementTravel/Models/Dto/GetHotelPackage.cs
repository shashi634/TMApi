using System;
using System.Collections.Generic;

namespace ManagementTravel.Models.Dto
{
    public class GetHotelPackage
    {
        public string HotelName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
        public int? noofdays { get; set; }
        public int? noofnight { get; set; }
        public decimal? extraadultcharge { get; set; }
        public decimal? extrachildcharge { get; set; }
        public string tac { get; set; }
        public int? defaultnoofmembers { get; set; }
        public Guid? publicId { get; set; }
        public Guid? HotelPublicId { get; set; }
        public List<string> Images { get; set; }
    }
}