using System;
using System.Linq;
using System.Security.Claims;
using System.Collections.Generic;
using AuthenticationService.Models;
using AuthenticationService.Managers;


namespace poc_jwt
{
    class JWT
    {
        static void Main()
        {
            // IAuthContainerModel model = GetJWTContainerModel("Felipe Cembranelli", 
            //                                                 "felipecembranelli@live.com",
            //                                                 "US",
            //                                                 "07901");

            // IAuthService authService = new JWTService(model.SecretKey);

            // string token = authService.GenerateToken(model);

            // if (!authService.IsTokenValid(token))
            //     throw new UnauthorizedAccessException();
            // else
            // {
            //     List<Claim> claims = authService.GetTokenClaims(token).ToList();

            //     Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Name)).Value);
            //     Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Email)).Value);
            //     Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Country)).Value);
            //     Console.WriteLine(claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.PostalCode)).Value);
            // }
        }

    }
}