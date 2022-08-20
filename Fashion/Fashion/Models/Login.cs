using System.ComponentModel.DataAnnotations;

namespace Fashion.Models
{
    public class Login
    {
        [Required]
        public string EMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
