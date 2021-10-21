using Microsoft.AspNetCore.Identity;

namespace ByteBank.Forum.Models
{
    public class UserApplication : IdentityUser
    {
        public string FullName { get; set; }
    }
}
