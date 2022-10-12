using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }    
        public DbSet<Country> countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(new Country {
              Id=1,
              Name="India",
              CountryCode="IND",
              
            }, new Country
            {
                Id = 2,
                Name = "Canada",
                CountryCode = "CAN",

            },
            new Country
            {
                Id = 3,
                Name = "Cayman Island",
                CountryCode = "CAY",

            });
            modelBuilder.Entity<Hotel>().HasData(

                new Hotel 
                {Id = 1,
                Name= "Taj Hotel",
                Address= "GeorgeTown",
                CountryId = 1,
                Rating= 10
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "ITC Grand",
                     Address = "Madras",
                     CountryId = 2,
                     Rating = 7.5
                 },
                 new Hotel
                 {
                     Id = 3,
                     Name = "Hilton",
                     Address = "Timtok",
                     CountryId = 3,
                     Rating = 6.5
                 }
                );
        }
    }
}
