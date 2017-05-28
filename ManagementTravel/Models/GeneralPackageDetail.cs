using System;

namespace ManagementTravel.Models
{
    public class GeneralPackageDetail
    {
        public decimal Id { get; set; }
        public string MealType { get; set; }
        public string RoomType { get; set; }
        public Nullable<double> RoomPriceNormal { get; set; }
        public string RoomPriceNormalType { get; set; }
        public Nullable<double> ExtraChildPrice { get; set; }
        public string ExtraChildPriceType { get; set; }
        public Nullable<double> ExtraAdultPrice { get; set; }
        public string ExtraAdultPriceType { get; set; }
        public Nullable<double> Tac { get; set; }
        public string TacType { get; set; }
        public Nullable<decimal> GeneralPackageId { get; set; }
        public Guid UniqueId { get; set; }
        public virtual GeneralPackage GeneralPackage { get; set; }

    }
}