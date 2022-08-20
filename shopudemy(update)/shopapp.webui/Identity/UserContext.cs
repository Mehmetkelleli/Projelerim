using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace shopapp.webui.Identity
{
    public class UserContext:IdentityDbContext<User>
    {

        public UserContext(DbContextOptions<UserContext> options):base(options)
        {

        }
    }
}
