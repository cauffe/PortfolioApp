using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public interface IEmailSend
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
