using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelFacilityMap : EntityTypeConfiguration<HotelFacility>
    {
        public HotelFacilityMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("HotelFacilities");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.HotelId).HasColumnName("HotelId");
            Property(t => t.FacilityId).HasColumnName("FacilityId");
        }
    }
}
