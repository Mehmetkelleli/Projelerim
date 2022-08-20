using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class Register
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        [Required]
        [MinLength(10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [MinLength(10)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
