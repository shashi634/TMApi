using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class OrganizationMap : EntityTypeConfiguration<Organization>
    {
        public OrganizationMap()
        {
            // Primary Key
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Name)
                .HasMaxLength(150);

            Property(t => t.pan)
                .HasMaxLength(50);

            Property(t => t.RegistrationNo)
                .HasMaxLength(50);

            Property(t => t.Address)
                .HasMaxLength(250);

            Property(t => t.City)
                .HasMaxLength(50);

            Property(t => t.State)
                .HasMaxLength(50);

            Property(t => t.Servicetaxno)
                .HasMaxLength(50);

            Property(t => t.Owner)
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Organization");
            Property(t => t.Id).HasColumnName("Id");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.pan).HasColumnName("pan");
            Property(t => t.RegistrationNo).HasColumnName("RegistrationNo");
            Property(t => t.Address).HasColumnName("Address");
            Property(t => t.City).HasColumnName("City");
            Property(t => t.State).HasColumnName("State");
            Property(t => t.PublicId).HasColumnName("PublicId");
            Property(t => t.Servicetaxno).HasColumnName("Servicetaxno");
            Property(t => t.Owner).HasColumnName("Owner");
        }
    }
}
