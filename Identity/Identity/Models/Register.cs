using System.ComponentModel.DataAnnotations;

namespace Identity.Models
{
    public class Register
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(10, ErrorMessage = "Min 10"),MaxLength(30,ErrorMessage ="Max 30"),]
        public string  Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
    }
}
