using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Jsopx.ClassLibrary
{

    /// <summary>
    /// Custom jSilvestri.com BETA v 2024 JSopX™ Web API Demo JWT Helper class used to handle all JWT Token processing, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Web API Demo 
    /// Collection projects.
    /// </summary>
    public static class JwtHelper
    {

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Web API Demo Enum used to handle all jSilvestri.com 2024
        /// User Role requirements, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Web API Demo 
        /// Collection projects.
        /// </summary>
        public static string GenerateJwtToken(string userId, string role, string key, string issuer, string audience, int expiresInMinutes)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userId),
                new Claim(ClaimTypes.Role, role),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: issuer,
                audience: audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(expiresInMinutes),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
