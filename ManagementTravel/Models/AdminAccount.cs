using System;

namespace ManagementTravel.Models
{
    public class AdminAccount
    {
        public int Id { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public int? UserType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
        public string Name { get; set; }
        public decimal? MobileNo { get; set; }
        public string Address { get; set; }
        public string LandLineNo { get; set; }
        public Guid? PublicId { get; set; }
        public bool? IsDeleted { get; set; }
        public virtual UserType UserType1 { get; set; }
    }
}
