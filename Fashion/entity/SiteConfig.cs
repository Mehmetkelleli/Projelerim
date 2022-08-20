using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.entity
{
    public class SiteConfig
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public int SiteClick { get; set; }
        public string Author { get; set; }
        public string  Meta { get; set; }
        public string MetaDescription { get; set; }
        public string Facebook { get; set; }
        public string PhoneNumber { get; set; }
        public string Instagram { get; set; }
        public string Wp { get; set; }
        public DateTime Date { get; set; }
        public string Smtp { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
    }
}
