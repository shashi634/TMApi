using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class LocationImageMap : EntityTypeConfiguration<LocationImage>
    {
        public LocationImageMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.ImageName)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("LocationImages");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.ImageName).HasColumnName("ImageName");
            Property(t => t.UploadedDate).HasColumnName("UploadedDate");
            Property(t => t.LocationId).HasColumnName("LocationId");
            // Relationships
            HasOptional(t => t.Location)
                .WithMany(t => t.LocationImagess)
                .HasForeignKey(d => d.LocationId);
        }
    }
}
