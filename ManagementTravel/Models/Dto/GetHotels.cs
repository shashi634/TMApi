using System;
using System.Collections.Generic;

namespace ManagementTravel.Models.Dto
{
    public class GetHotels
    {
        public GetHotels() {
           Facilities = new List<GetFacility>();
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public string Rate { get; set; }
        public List<GetFacility> Facilities
        {
            get;
            set;
        }
    }
    public class GetHotelsHomePage
    {
        public Guid? PublicId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Image { get; set; }
        public decimal? Rate { get; set; }
        public int? Rating { get; set; }
        public int? RoonAvailable { get; set; }
    }
}