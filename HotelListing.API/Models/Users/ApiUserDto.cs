
using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users
{
    public class ApiUserDto: UserLoginDto
    {
       
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
    }
}
