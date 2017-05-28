using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class FacilityMap : EntityTypeConfiguration<Facility>
    {
        public FacilityMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Facility1)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("Facilities");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Facility1).HasColumnName("Facility");
            Property(t => t.AddedDate).HasColumnName("AddedDate");
        }
    }
}
