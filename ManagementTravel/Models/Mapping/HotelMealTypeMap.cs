using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelMealTypeMap : EntityTypeConfiguration<HotelMealType>
    {
        public HotelMealTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            ToTable("HotelMealTypes");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.HotelId).HasColumnName("HotelId");
            Property(t => t.MealTypeId).HasColumnName("MealTypeId");

            // Relationships
            HasOptional(t => t.Hotel)
                .WithMany(t => t.HotelMealTypes)
                .HasForeignKey(d => d.HotelId);

        }
    }
}
