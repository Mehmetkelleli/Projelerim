using System.Threading.Tasks;

namespace Identity.EMailSender
{
    public interface IEMailSender
    {
        Task Send(string Mail, string subject, string HtmlDescription);
    }
}
