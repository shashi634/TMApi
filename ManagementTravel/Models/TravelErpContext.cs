using System.Data.Entity;
using ManagementTravel.Models.Mapping;

namespace ManagementTravel.Models
{
    public class TravelErpContext : DbContext
    {
        static TravelErpContext()
        {
            Database.SetInitializer<TravelErpContext>(null);
        }

        public TravelErpContext()
            : base("Name=TravelErpContext")
        {
        }

        public DbSet<AdminAccount> AdminAccounts { get; set; }
        public DbSet<ContactPerson> ContactPersons { get; set; }
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<GeneralPackage> GeneralPackages { get; set; }
        public DbSet<GeneralPackageDetail> GeneralPackageDetails { get; set; }
        public DbSet<HotelFacility> HotelFacilities { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<HotelMealType> HotelMealTypes { get; set; }
        public DbSet<HotelPackage> HotelPackages { get; set; }
        public DbSet<HotelRoomTypePrice> HotelRoomTypePrices { get; set; }
        public DbSet<HotelRoomType> HotelRoomTypes { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelType> HotelTypes { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<LocationImage> LocationImages { get; set; }
        public DbSet<LocationPage> LocationPages { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminAccountMap());
            modelBuilder.Configurations.Add(new ContactPersonMap());
            modelBuilder.Configurations.Add(new FacilityMap());
            modelBuilder.Configurations.Add(new GeneralPackageMap());
            modelBuilder.Configurations.Add(new GeneralPackageDetailMap());
            modelBuilder.Configurations.Add(new HotelFacilityMap());
            modelBuilder.Configurations.Add(new HotelImageMap());
            modelBuilder.Configurations.Add(new HotelMealTypeMap());
            modelBuilder.Configurations.Add(new HotelPackageMap());
            modelBuilder.Configurations.Add(new HotelRoomTypePriceMap());
            modelBuilder.Configurations.Add(new HotelRoomTypeMap());
            modelBuilder.Configurations.Add(new HotelMap());
            modelBuilder.Configurations.Add(new HotelTypeMap());
            modelBuilder.Configurations.Add(new LocationMap());
            modelBuilder.Configurations.Add(new LocationImageMap());
            modelBuilder.Configurations.Add(new LocationPageMap());
            modelBuilder.Configurations.Add(new MealTypeMap());
            modelBuilder.Configurations.Add(new OrganizationMap());
            modelBuilder.Configurations.Add(new RoomTypeMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new UserTypeMap());
        }
    }
}
