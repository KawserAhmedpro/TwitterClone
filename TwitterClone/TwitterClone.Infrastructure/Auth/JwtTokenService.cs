using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TwitterClone.Application.Dtos;
using TwitterClone.Application.Interfaces;

namespace TwitterClone.Infrastructure.Auth
{
    public class JwtTokenService : ITokenService
    {
        private readonly JwtSettings _JwtSettings;
        private readonly JsonWebTokenHandler _jwtHandler = new JsonWebTokenHandler();
        public JwtTokenService(
            JwtSettings jwtSettings)
        {
            _JwtSettings = jwtSettings;
        }

      

        public (string, DateTime) GetToken(UserDto user)
        {

            var claims = new List<Claim >
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim (JwtRegisteredClaimNames.Email, user.Email),

            };
            var signKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_JwtSettings.Key));
            var expireAt = DateTime.UtcNow.AddMinutes(_JwtSettings.ExpirationInMinutes);
            var discriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expireAt,
                SigningCredentials = new SigningCredentials(signKey, SecurityAlgorithms.HmacSha256),
                Issuer = _JwtSettings.Issuer,
                Audience = _JwtSettings.Audience
            };

            return (_jwtHandler.CreateToken(discriptor), expireAt);
        }
    }
}