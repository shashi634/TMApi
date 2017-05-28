using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ManagementTravel.Models.Mapping
{
    public class GeneralPackageDetailMap  : EntityTypeConfiguration<GeneralPackageDetail>
    {
        public GeneralPackageDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.MealType)
                .HasMaxLength(50);

            this.Property(t => t.RoomType)
                .HasMaxLength(50);

            this.Property(t => t.RoomPriceNormalType)
                .HasMaxLength(50);

            this.Property(t => t.ExtraChildPriceType)
                .HasMaxLength(50);

            this.Property(t => t.ExtraAdultPriceType)
                .HasMaxLength(50);

            this.Property(t => t.TacType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GeneralPackageDetails");
            this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); ;
            this.Property(t => t.MealType).HasColumnName("MealType");
            this.Property(t => t.RoomType).HasColumnName("RoomType");
            this.Property(t => t.RoomPriceNormal).HasColumnName("RoomPriceNormal");
            this.Property(t => t.RoomPriceNormalType).HasColumnName("RoomPriceNormalType");
            this.Property(t => t.ExtraChildPrice).HasColumnName("ExtraChildPrice");
            this.Property(t => t.ExtraChildPriceType).HasColumnName("ExtraChildPriceType");
            this.Property(t => t.ExtraAdultPrice).HasColumnName("ExtraAdultPrice");
            this.Property(t => t.ExtraAdultPriceType).HasColumnName("ExtraAdultPriceType");
            this.Property(t => t.Tac).HasColumnName("Tac");
            this.Property(t => t.TacType).HasColumnName("TacType");
            this.Property(t => t.GeneralPackageId).HasColumnName("GeneralPackageId");
            this.Property(t => t.UniqueId).HasColumnName("UniqueId");

            // Relationships
            this.HasOptional(t => t.GeneralPackage)
                .WithMany(t => t.GeneralPackageDetails)
                .HasForeignKey(d => d.GeneralPackageId);

        }
    }
}