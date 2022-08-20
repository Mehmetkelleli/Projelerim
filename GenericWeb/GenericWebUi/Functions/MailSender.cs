using GenericWeb.Data.Abstract;
using GenericWeb.Entity;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GenericWebUi.Functions
{
    public class MailSender : IMailSender
    {
        private IGenericRepository<SiteConfig> _Setting;
        public MailSender(IGenericRepository<SiteConfig> Setting)
        {
            _Setting = Setting;
        }
        public Task Send(string EMail, string subject, string DetailsHtml)
        {
            var setting = _Setting.GetById(1);
            var client = new SmtpClient(setting.SmtpHost, setting.SmtpPort)
            {
                Credentials = new NetworkCredential(setting.SmtpUser, setting.SmtpPassword),
                EnableSsl = true
            };
            return client.SendMailAsync(
                new MailMessage(setting.SmtpUser,EMail, subject, DetailsHtml)
                {
                    IsBodyHtml = true
                }
                );
        }
    }
}
