using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class LocationPageMap : EntityTypeConfiguration<LocationPage>
    {
        public LocationPageMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Title)
                .HasMaxLength(350);

            // Table & Column Mappings
            ToTable("LocationPage");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Title).HasColumnName("Title");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.LocationId).HasColumnName("LocationId");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.AverageRate).HasColumnName("AverageRate");
            // Relationships
            HasOptional(t => t.Location)
                .WithMany(t => t.LocationPages)
                .HasForeignKey(d => d.LocationId);

        }
    }
}
