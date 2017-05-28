using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class HotelTypeMap : EntityTypeConfiguration<HotelType>
    {
        public HotelTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Type)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("HotelType");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.AddedDate).HasColumnName("AddedDate");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
