using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(100);

            Property(t => t.CountryName)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Location");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.AddedDate).HasColumnName("AddedDate");
            Property(t => t.CountryName).HasColumnName("CountryName");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
