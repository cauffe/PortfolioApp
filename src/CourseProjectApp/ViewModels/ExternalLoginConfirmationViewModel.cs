using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
