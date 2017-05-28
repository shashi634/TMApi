using System;
using System.Collections.Generic;

namespace ManagementTravel.Models.Dto
{
    public class DtoCreatePackage
    {
        public DtoCreatePackage() {
            DtoPackageDetails = new List<DtoPackageDetails>();
        }
        public decimal HotelId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DefaultMember { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfNights { get; set; }
        public string Description { get; set; }
        public string Inclusion { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<DtoPackageDetails> DtoPackageDetails { get; set; }
    }

    public class DtoPackageDetails
    {
        public string MealType { get; set; }
        public string RoomType { get; set; }
        public double RoomPriceNormal { get; set; }
        public string RoomPriceNormalType { get; set; }
        public double ExtraChildPrice { get; set; }
        public string ExtraChildPriceType { get; set; }
        public double ExtraAdultPrice { get; set; }
        public string ExtraAdultPriceType { get; set; }
        public double Tac { get; set; }
        public string TacType { get; set; }
    }
}