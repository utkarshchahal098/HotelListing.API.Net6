using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace HotelListing.API.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<APIUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthManager(IMapper mapper, UserManager<APIUser> userManager, IConfiguration configuration)
        {
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<AuthResponseDto> Login(UserLoginDto userLoginDto)
        {
            bool isValidUser = false;
            
            var user = await _userManager.FindByNameAsync(userLoginDto.UserName);
            isValidUser = await _userManager.CheckPasswordAsync(user, userLoginDto.Password);

            if (user == null || isValidUser == false)
                return null;
          

            var token = await GenerateJWTToken(user);

            AuthResponseDto authresponse = new AuthResponseDto()
            {
                UserId = user.UserName,
                Token = token
            };

            return authresponse;
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<APIUser>(userDto);

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }

        public async Task<string> GenerateJWTToken(APIUser user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWTSettings:Key"]));

            var roles = await _userManager.GetRolesAsync(user);
            

            var roleCliam = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();

            var claim = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())

            }.Union(roleCliam);

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            //var tokendesc = new SecurityTokenDescriptor()
            //{
            //    Subject = new ClaimsIdentity(claim),
            //    Expires = DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["JWTSettings:Duration"])),
            //    SigningCredentials = creds
            //};

            var token = new JwtSecurityToken(
                issuer: _configuration["JWTSettings:Issuer"],
                audience: _configuration["JWTSettings:Audience"],
                claims: claim,  
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_configuration["JWTSettings:Duration"])),
                signingCredentials: creds
                );

            var tokenHandler = new JwtSecurityTokenHandler();
            
            return tokenHandler.WriteToken(token);
        }
    }
}