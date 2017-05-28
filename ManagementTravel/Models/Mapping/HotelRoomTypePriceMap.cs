using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelRoomTypePriceMap : EntityTypeConfiguration<HotelRoomTypePrice>
    {
        public HotelRoomTypePriceMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("HotelRoomTypePrice");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.HotelRoomTypeId).HasColumnName("HotelRoomTypeId");
            Property(t => t.Rate).HasColumnName("Rate");
            Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            Property(t => t.RoomNoAvailable).HasColumnName("RoomNoAvailable");
            // Relationships
            HasOptional(t => t.HotelRoomType)
                .WithMany(t => t.HotelRoomTypePrices)
                .HasForeignKey(d => d.HotelRoomTypeId);
        }
    }
}
