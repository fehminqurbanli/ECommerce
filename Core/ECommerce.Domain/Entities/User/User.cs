using Microsoft.AspNetCore.Identity;

namespace ECommerce.Domain.Entities.User
{
    public class User: IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
    }
}
