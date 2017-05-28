using System;
using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class Location
    {
        public Location()
        {
            Hotels = new List<Hotel>();
            LocationPages = new List<LocationPage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Guid? PublicId { get; set; }
        public DateTime? AddedDate { get; set; }
        public string CountryName { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual ICollection<Hotel> Hotels { get; set; }
        public virtual ICollection<LocationPage> LocationPages { get; set; }
        public virtual ICollection<LocationImage> LocationImagess { get; set; }
    }
}
