using System.Threading.Tasks;

namespace GenericWebUi.Functions
{
    public interface IMailSender
    {
        Task Send(string EMail, string subject, string DetailsHtml);
    }
}
