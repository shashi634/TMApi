using System;
using System.Collections.Generic;

namespace ManagementTravel.Models
{
    public class GeneralPackage
    {
        public GeneralPackage()
        {
            GeneralPackageDetails = new List<GeneralPackageDetail>();
        }

        public decimal Id { get; set; }
        public Nullable<decimal> HotelId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> DefaultMember { get; set; }
        public Nullable<int> NoOfDays { get; set; }
        public Nullable<int> NoOdNights { get; set; }
        public string Description { get; set; }
        public string Inclusion { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Guid PublicKey { get; set; }
        public virtual ICollection<GeneralPackageDetail> GeneralPackageDetails { get; set; }
    }
}