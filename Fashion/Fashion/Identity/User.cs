using Microsoft.AspNetCore.Identity;

namespace Fashion.Identity
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }

    }
}
