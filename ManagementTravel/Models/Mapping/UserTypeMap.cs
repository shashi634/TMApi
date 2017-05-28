using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class UserTypeMap : EntityTypeConfiguration<UserType>
    {
        public UserTypeMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.UserType1)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("UserType");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.UserType1).HasColumnName("UserType");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");
        }
    }
}
