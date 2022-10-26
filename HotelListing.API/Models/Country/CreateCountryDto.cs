using HotelListing.API.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Country
{
    public class CreateCountryDto
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$",ErrorMessage ="Only alphabets are allowed")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only alphabets are allowed")]
        [CustomCountryValidation]
        public string  CountryCode { get; set; }
    }
}
