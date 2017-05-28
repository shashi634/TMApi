using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class GeneralPackageMap : EntityTypeConfiguration<GeneralPackage>
    {
        public GeneralPackageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("GeneralPackage");
            this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
            this.Property(t => t.HotelId).HasColumnName("HotelId");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.DefaultMember).HasColumnName("DefaultMember");
            this.Property(t => t.NoOfDays).HasColumnName("NoOfDays");
            this.Property(t => t.NoOdNights).HasColumnName("NoOdNights");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Inclusion).HasColumnName("Inclusion");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.PublicKey).HasColumnName("PublicKey");
        }

    }
}