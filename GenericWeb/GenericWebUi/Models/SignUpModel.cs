using System.ComponentModel.DataAnnotations;

namespace GenericWebUi.Models
{
    public class SignUpModel
    {
        [Required]
        [MinLength(10)]
        public string UserName { get; set; }
        [Required]
        [MinLength(2)] 
        public string Name { get; set; }
        [Required]
        [MinLength(5)] 
        public string LastName { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]         
        public string EMail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string Repassword { get; set; }
    }
}
