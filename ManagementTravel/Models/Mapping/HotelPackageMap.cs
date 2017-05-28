using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelPackageMap : EntityTypeConfiguration<HotelPackage>
    {
        public HotelPackageMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.tac)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("HotelPackage");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.hotelId).HasColumnName("hotelId");
            Property(t => t.startdate).HasColumnName("startdate");
            Property(t => t.enddate).HasColumnName("enddate");
            Property(t => t.noofdays).HasColumnName("noofdays");
            Property(t => t.noofnight).HasColumnName("noofnight");
            Property(t => t.extraadultcharge).HasColumnName("extraadultcharge");
            Property(t => t.extrachildcharge).HasColumnName("extrachildcharge");
            Property(t => t.tac).HasColumnName("tac");
            Property(t => t.defaultnoofmembers).HasColumnName("defaultnoofmembers");
            Property(t => t.publicId).HasColumnName("publicId");

            // Relationships
            HasOptional(t => t.Hotel)
                .WithMany(t => t.HotelPackages)
                .HasForeignKey(d => d.hotelId);

        }
    }
}
