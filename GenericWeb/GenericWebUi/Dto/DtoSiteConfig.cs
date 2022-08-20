using System.ComponentModel.DataAnnotations;

namespace GenericWebUi.Dto
{
    public class DtoSiteConfig
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string LogoUrl { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string MetaDescription { get; set; }
        [Required]
        public string MetaTags { get; set; }
        [Required]
        public string SmtpHost { get; set; }
        [Required]
        public int SmtpPort { get; set; }
        [Required]
        public string SmtpUser { get; set; }
        [Required]
        public string SmtpPassword { get; set; }
    }
}
