using Fashion.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fashion.Models
{
    public class RoleModel
    {
        [Required]
        public string Name { get; set; }
    }
    public class RoleDetails
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<User> NonMember { get; set; }
    }
}
