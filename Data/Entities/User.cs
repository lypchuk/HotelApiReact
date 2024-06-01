using Microsoft.AspNetCore.Identity;

namespace Data.Entities
{
        public enum ClientType { Node, Regular, Premium }
    public class User : IdentityUser
    {
        public DateTime? Birthdate { get; set; }
        public string Role { get; set; }
        //public ClientType? ClientType { get; set; }

        //public ICollection<Order>? Orders { get; set; }

        //public ICollection<RefreshToken>? RefreshTokens { get; set; }
    }
}
