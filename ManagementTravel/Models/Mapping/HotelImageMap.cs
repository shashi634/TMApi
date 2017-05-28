using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelImageMap : EntityTypeConfiguration<HotelImage>
    {
        public HotelImageMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.ImageName)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("HotelImages");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.ImageName).HasColumnName("ImageName");
            Property(t => t.UploadedDate).HasColumnName("UploadedDate");
            Property(t => t.HotelId).HasColumnName("HotelId");

            // Relationships
            HasOptional(t => t.Hotel)
                .WithMany(t => t.HotelImages)
                .HasForeignKey(d => d.HotelId);

        }
    }
}
