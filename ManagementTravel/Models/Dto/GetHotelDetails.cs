using System.Collections.Generic;

namespace ManagementTravel.Models.Dto
{
    public class GetHotelDetails
    {
        public GetHotelDetails()
        {
            Facilities = new List<GetFacility>();
            RoomTypes = new List<GetRoomType>();
            MealTypes = new List<GetMealType>();
        }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public List<string> Image { get; set; }
        public string Description { get; set; }
        public string Rate { get; set; }
        public List<GetFacility> Facilities
        {
            get;
            set;
        }
        public List<GetRoomType> RoomTypes
        {
            get;
            set;
        }
        public string HotelTypes
        {
            get;
            set;
        }
        public List<GetMealType> MealTypes
        {
            get;
            set;
        }
    }
}