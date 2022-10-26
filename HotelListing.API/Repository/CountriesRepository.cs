﻿using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {
        private readonly HotelListingDbContext _context;

        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            var country = await _context.countries.Include(x => x.Hotels)
                         .FirstOrDefaultAsync(x => x.Id == id);

            return country;
        }
    }
}
