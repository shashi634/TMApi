using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class MealTypeMap : EntityTypeConfiguration<MealType>
    {
        public MealTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Type)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("MealType");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.AddedDate).HasColumnName("AddedDate");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
