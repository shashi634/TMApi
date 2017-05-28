using System;

namespace ManagementTravel.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string pan { get; set; }
        public string RegistrationNo { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Guid? PublicId { get; set; }
        public string Servicetaxno { get; set; }
        public string Owner { get; set; }
    }
}
