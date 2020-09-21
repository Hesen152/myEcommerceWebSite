using System.Threading.Tasks;

namespace clicker.webui.EmaiLService
{
    public interface IEmail
    {

        Task SendEmailAsync(string  email,string subject,string messagehtml);
        
    }
}