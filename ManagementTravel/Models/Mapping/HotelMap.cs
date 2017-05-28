using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelMap : EntityTypeConfiguration<Hotel>
    {
        public HotelMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(250);

            Property(t => t.Address)
                .HasMaxLength(250);

            // Table & Column Mappings
            ToTable("Hotels");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.LocationId).HasColumnName("LocationId");
            Property(t => t.HotelTypeId).HasColumnName("HotelTypeId");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.AverageRating).HasColumnName("AverageRating");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.ContactPersonId).HasColumnName("ContactPersonId");
            Property(t => t.LoggingUserId).HasColumnName("LoggingUserId");
            Property(t => t.Address).HasColumnName("Address");

            // Relationships
            HasOptional(t => t.HotelType)
                .WithMany(t => t.Hotels)
                .HasForeignKey(d => d.HotelTypeId);
            HasOptional(t => t.Location)
                .WithMany(t => t.Hotels)
                .HasForeignKey(d => d.LocationId);

        }
    }
}
