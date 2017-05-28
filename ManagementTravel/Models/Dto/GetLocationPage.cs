using System;
using System.Collections.Generic;

namespace ManagementTravel.Models.Dto
{
    public class GetLocationPage 
    {
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Images { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Guid PublicId { get; set; }
        public string Description { get; set; }
        public string FrontImage { get; set; }
    }
    public class LocationPages
    {

        public string City { get; set; }
        public string Country { get; set; }
        public Guid PublicId { get; set; }
        public Guid LocationPublicId { get; set; }
        public string FrontImage { get; set; }
        public string Description { get; set; }
        public int TotalHotel { get; set; }
        public int AverageRate { get; set; }
    }
    public class GetLocationPages
    {
        public GetLocationPages() {
            GetHotelsHomePage = new List<GetHotelsHomePage>();
        }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<string> Images { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Guid PublicId { get; set; }
        public Guid LocationPublicId { get; set; }
        public string Description { get; set; }
        public string FrontImage { get; set; }
        public List<GetHotelsHomePage> GetHotelsHomePage { get; set; }
    }
}