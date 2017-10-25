using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.ViewComponents
{
    public class LoginViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
