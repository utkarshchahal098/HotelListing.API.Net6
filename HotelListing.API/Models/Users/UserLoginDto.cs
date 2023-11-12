using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users
{
    public class UserLoginDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
