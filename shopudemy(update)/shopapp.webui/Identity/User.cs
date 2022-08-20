using Microsoft.AspNetCore.Identity;

namespace shopapp.webui.Identity
{
    public class User:IdentityUser
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
