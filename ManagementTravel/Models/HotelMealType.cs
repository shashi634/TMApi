namespace ManagementTravel.Models
{
    public class HotelMealType
    {
        public decimal Id { get; set; }
        public decimal? HotelId { get; set; }
        public int? MealTypeId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
