using HotelListing.API.Controllers;
using HotelListing.API.Data;
using HotelListing.API.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelListingTest
{
    
    public class CoutriesControllerTesting
    {
        [Fact]
        public void GetCountriesTest()
        {

            var options = new DbContextOptionsBuilder<HotelListingDbContext>()
                          .UseInMemoryDatabase(databaseName: "HotelListingDb").Options;

            using (var context = new HotelListingDbContext(options))
            {
                context.countries.Add(new Country() { Id = 1, Name = "India", CountryCode = "IND", Hotels = null });
                context.countries.Add(new Country() { Id = 2, Name = "Canada", CountryCode = "CAN", Hotels = null });
                context.countries.Add(new Country() { Id = 3, Name = "Singapore", CountryCode = "SIN", Hotels = null });
            }

            using (var context = new HotelListingDbContext(options))
            {
                var obj = new CountriesController(context);
                List<Country> countries = obj.Getcountries();
                Assert.NotNull(countries);
            }

            
            

            //Assert

           
        }

    }
}
