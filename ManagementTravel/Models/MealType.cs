using System;

namespace ManagementTravel.Models
{
    public class MealType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Guid? PublicId { get; set; }
        public DateTime? AddedDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
