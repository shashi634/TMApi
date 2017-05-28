using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class ContactPersonMap : EntityTypeConfiguration<ContactPerson>
    {
        public ContactPersonMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.PresonName)
                .HasMaxLength(150);

            Property(t => t.MobileNo)
                .HasMaxLength(20);

            Property(t => t.EmailId)
                .HasMaxLength(150);

            Property(t => t.Address)
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("ContactPersons");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.PresonName).HasColumnName("PresonName");
            Property(t => t.MobileNo).HasColumnName("MobileNo");
            Property(t => t.EmailId).HasColumnName("EmailId");
            Property(t => t.Address).HasColumnName("Address");
        }
    }
}
