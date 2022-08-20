using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Login
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }
    }
}
