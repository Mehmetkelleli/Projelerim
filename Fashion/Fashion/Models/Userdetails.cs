using Fashion.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;

namespace Fashion.Models
{
    public class Userdetails
    {
        public User User { get; set; }
 
        public IEnumerable<string> UserRoles { get; set; }
    }
}
