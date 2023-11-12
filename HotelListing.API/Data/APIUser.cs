﻿using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Data
{
    public class APIUser: IdentityUser
    {
        public string Password { get; set; }
    }
}
