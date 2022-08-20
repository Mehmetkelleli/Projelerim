using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Identity.EMailSender
{
    public class EFMailSender : IEMailSender
    {

            public static string Smtp = "smtp-mail.outlook.com";
            public static int Port = 587;
            public static bool  enableSsl = true;
            public static string  Username = "kelleli_mehmet@hotmail.com";
            public static string Password = "Aslanlar123";

        public Task Send(string Mail, string subject, string HtmlDescription)
        {
            var client = new SmtpClient(Smtp, Port)
            {
                Credentials = new NetworkCredential(Username, Password),
                EnableSsl = enableSsl
            };
            return client.SendMailAsync(
                new MailMessage(Username, Mail, subject, HtmlDescription)
                {
                    IsBodyHtml = true

                }
                );
        }
    }
}
