namespace ManagementTravel.Models.Dto
{
    public class GetFacility
    {
        public int Id { get; set; }
        public string Facility { get; set; }
    }
    public class GetRoomType
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
        public decimal? Price { get; set; }
        public int? Available { get; set; }
    }
    public class GetHotelType
    {
        public int Id { get; set; }
        public string HotelType { get; set; }
    }
    public class GetMealType
    {
        public int Id { get; set; }
        public string MealType { get; set; }
    }
    public class GetAllRoomType
    {
        public int Id { get; set; }
        public string RoomType { get; set; }
    }
}