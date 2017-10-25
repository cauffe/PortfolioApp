using System.Threading.Tasks;
using PortfolioApp.Models;
using PortfolioApp.Repository;
using PortfolioApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PortfolioApp.Controllers
{
    public class LoggedInController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProfileRepository _profileRepository;

        public LoggedInController(UserManager<ApplicationUser> userManager, IProfileRepository profileRepository)
        {
            _userManager = userManager;
            _profileRepository = profileRepository;
        }

        public async Task<IActionResult> Index()
        {
            var userId = await _userManager.GetUserAsync(HttpContext.User);

            var hobbies = _profileRepository.GetHobbyList(userId.Id);

            var individual = _profileRepository.GetIndividualList(userId.Id);

            var organization = _profileRepository.GetOrganizationList(userId.Id);

            var model = new DashboardViewModel
            {
                Individuals = individual,
                Organization = organization,
                Hobby = hobbies

            };

            return View(model);
        }

    }
}
