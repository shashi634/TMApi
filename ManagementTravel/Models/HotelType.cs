using System;
using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public sealed class HotelType
    {
        public HotelType()
        {
            Hotels = new List<Hotel>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public Guid? PublicId { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsDeleted { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }
}
