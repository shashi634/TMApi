using System;

namespace ManagementTravel.Models.Dto
{
    public class SearchHotelParameters
    {
        public string City { get; set; }
        public DateTime? startdate { get; set; }
        public DateTime? enddate { get; set; }
    }
}