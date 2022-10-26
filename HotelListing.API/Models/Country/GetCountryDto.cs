using System.Collections.Generic;
using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{

    public class GetCountryDto : BaseCountryDto 
    {
        public int Id { get; set; }
    }


    public class CountryDto: BaseCountryDto
    {
        public int Id { get; set; }
        public List<HotelDto> Hotels { get; set; }
    }

}
