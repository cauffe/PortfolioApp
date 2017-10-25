using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
