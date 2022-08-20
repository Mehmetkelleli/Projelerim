using Fashion.Business.Abstract;
using Fashion.entity;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Fashion.Functions
{
    public class SenderMail : ISenderMail
    {
        private ISiteConfigService _Setting;
        public SenderMail(ISiteConfigService Setting)
        {
            _Setting = Setting;
        }
        public Task SendMail(string EMail, string Subject, string HtmlContent)
        {
            var _Set = _Setting.GetById(3);
            var client = new SmtpClient(_Set.Smtp, _Set.SmtpPort)
            {
                Credentials = new NetworkCredential(_Set.SmtpUser,_Set.SmtpPassword),
                EnableSsl = true
            };
            return client.SendMailAsync(
                new MailMessage(_Set.SmtpUser,EMail, Subject, HtmlContent)
                {
                    IsBodyHtml = true

                }
                );
        }
    }
}
