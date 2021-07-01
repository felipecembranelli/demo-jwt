using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationService.Models
{
    public class JWTContainerModel : IAuthContainerModel
    {
        #region Public Methods
        public int ExpireMinutes { get; set; } = 10080; // 7 days.
        public string SecretKey { get; set; } = "qlemopTW9zaGVFcmV6UHJpdmF0ZUtleQ"; // This secret key should be moved to some configurations outter server.
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { get; set; }

        public static JWTContainerModel GetJWTContainerModel(string name,
                                                         string email,
                                                         string country,
                                                         string postalCode)
        {
            return new JWTContainerModel()
            {
                Claims = new Claim[]
                {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Country, country),
                new Claim(ClaimTypes.PostalCode, postalCode)
                }
            };
        }

        #endregion
    }

    public class JWTExpiredContainerModel : IAuthContainerModel
    {
        #region Public Methods
        public int ExpireMinutes { get; set; } = 0; // 7 days.
        public string SecretKey { get; set; } = "qlemopTW9zaGVFcmV6UHJpdmF0ZUtleQ"; // This secret key should be moved to some configurations outter server.
        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha256Signature;

        public Claim[] Claims { get; set; }

        public static JWTContainerModel GetJWTContainerModel(string name,
                                                         string email,
                                                         string country,
                                                         string postalCode)
        {
            return new JWTContainerModel()
            {
                Claims = new Claim[]
                {
                new Claim(ClaimTypes.Name, name),
                new Claim(ClaimTypes.Email, email),
                new Claim(ClaimTypes.Country, country),
                new Claim(ClaimTypes.PostalCode, postalCode)
                }
            };
        }

        #endregion
    }
}