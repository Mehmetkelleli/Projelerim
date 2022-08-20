using System.ComponentModel.DataAnnotations;

namespace Fashion.Models
{
    public class Register
    {
        [Required]
        [MinLength(5),MaxLength(25)]
        public string Name { get; set; }
        [Required]
        [MinLength(5), MaxLength(25)]
        public string UserName { get; set; }
        [Required]
        [MinLength(5),MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string EPosta { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        public string Password { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [MinLength(10)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
