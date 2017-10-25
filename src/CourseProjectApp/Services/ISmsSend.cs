using System.Threading.Tasks;

namespace PortfolioApp.Services
{
   public interface ISmsSend
   {
       Task SendSmsAsync(string number, string message);
   }
}
