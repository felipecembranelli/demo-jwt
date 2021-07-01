using System;
using Xunit;
using AuthenticationService.Models;
using AuthenticationService.Managers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;


namespace JWTSample.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Create_Token_with_Valid_Claims()
        {
            // arrange
            string name = "Felipe Cembranelli";
            string email = "felipecembranelli@live.com";
            string country = "US";
            string postalCode = "07901";

            IAuthContainerModel model = JWTContainerModel.GetJWTContainerModel(name,
                                                           email,
                                                           country,
                                                           postalCode);

            IAuthService authService = new JWTService(model.SecretKey);

            // act
            string token = authService.GenerateToken(model);

            List<Claim> claims = authService.GetTokenClaims(token).ToList();

            Assert.Equal(name, claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Name)).Value);
            Assert.Equal(email, claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Email)).Value);
            Assert.Equal(country, claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.Country)).Value);
            Assert.Equal(postalCode, claims.FirstOrDefault(e => e.Type.Equals(ClaimTypes.PostalCode)).Value);
        }

        [Fact]
        public void Expired_Token_Should_Not_Be_Valid()
        {
            // arrange
            string name = "Felipe Cembranelli";
            string email = "felipecembranelli@live.com";
            string country = "US";
            string postalCode = "07901";

            IAuthContainerModel model = JWTExpiredContainerModel.GetJWTContainerModel(name,
                                                           email,
                                                           country,
                                                           postalCode);

            IAuthService authService = new JWTService(model.SecretKey);

            // act
            string token = authService.GenerateToken(model);

            var ret = authService.IsTokenValid(token);

            Assert.True(ret);
        }
    }
}
