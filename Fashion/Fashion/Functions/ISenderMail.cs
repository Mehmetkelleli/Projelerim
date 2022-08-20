using System.Threading.Tasks;

namespace Fashion.Functions
{
    public interface ISenderMail
    {
        Task SendMail(string EMail, string Subject, string HtmlContent); 
    }
}
