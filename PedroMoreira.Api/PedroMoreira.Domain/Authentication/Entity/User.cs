using Microsoft.AspNetCore.Identity;

namespace PedroMoreira.Domain.Authentication.Entity
{
    public class User : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpires { get; set; }
    }
}
