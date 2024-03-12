using System.ComponentModel.DataAnnotations.Schema;

namespace PedroMoreira.Domain.Authentication.Entity
{
    [NotMapped]
    public class Token
    {
        public string? JwtToken { get; set; }
        public DateTime? JwtTokenExpitre { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpire { get; set; }
    }
}
