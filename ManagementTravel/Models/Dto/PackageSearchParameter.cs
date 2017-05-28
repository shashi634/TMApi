using System;

namespace ManagementTravel.Models.Dto
{
    public class PackageSearchParameter
    {
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
    }
    public class LocationSearch
    {
        public string Country { get; set; }
        public string City { get; set; }
    }
}