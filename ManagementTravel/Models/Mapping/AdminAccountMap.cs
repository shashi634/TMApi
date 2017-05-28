using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class AdminAccountMap : EntityTypeConfiguration<AdminAccount>
    {
        public AdminAccountMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.EmailId)
                .IsRequired()
                .HasMaxLength(150);

            Property(t => t.Password)
                .HasMaxLength(150);

            Property(t => t.Name)
                .HasMaxLength(150);

            Property(t => t.Address)
                .HasMaxLength(150);

            Property(t => t.LandLineNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AdminAccount");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.EmailId).HasColumnName("EmailId");
            Property(t => t.Password).HasColumnName("Password");
            Property(t => t.UserType).HasColumnName("UserType");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.LastLogin).HasColumnName("LastLogin");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.MobileNo).HasColumnName("MobileNo");
            Property(t => t.Address).HasColumnName("Address");
            Property(t => t.LandLineNo).HasColumnName("LandLineNo");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.IsDeleted).HasColumnName("IsDeleted");

            // Relationships
            HasOptional(t => t.UserType1)
                .WithMany(t => t.AdminAccounts)
                .HasForeignKey(d => d.UserType);

        }
    }
}
