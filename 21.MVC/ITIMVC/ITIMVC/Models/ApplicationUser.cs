using Microsoft.AspNetCore.Identity;

namespace ITIMVC.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string? Address { get; set; }
        public string DisplayName { get; set; }
    }
}
