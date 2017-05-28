using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelRoomTypeMap : EntityTypeConfiguration<HotelRoomType>
    {
        public HotelRoomTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("HotelRoomTypes");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.HotelId).HasColumnName("HotelId");
            Property(t => t.RoomTypeId).HasColumnName("RoomTypeId");

            // Relationships
            HasOptional(t => t.Hotel)
                .WithMany(t => t.HotelRoomTypes)
                .HasForeignKey(d => d.HotelId);
            HasOptional(t => t.RoomType)
                .WithMany(t => t.HotelRoomTypes)
                .HasForeignKey(d => d.RoomTypeId);

        }
    }
}
