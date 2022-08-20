using System.ComponentModel.DataAnnotations;

namespace Fashion.Models
{
    public class ResetPassword
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string UserToken { get; set; }
        [Required]
        [MinLength(10)]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
