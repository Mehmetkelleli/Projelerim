namespace GenericWeb.Entity
{
    public class SiteConfig
    {
        public int Id { get; set; }
        public string LogoUrl { get; set; }
        public string Author { get; set; }
        public string MetaDescription { get; set; }
        public string MetaTags { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPassword { get; set; }
        public int ClickDay { get; set; }
        public string Date { get; set; }
    }
}
