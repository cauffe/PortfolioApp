using System.Collections.Generic;
using PortfolioApp.Models;

namespace PortfolioApp.ViewModels
{
    public class DashboardViewModel
    {
        public List<Individual> Individuals { get; set; }

        public List<Organization> Organization { get; set; }

        public List<Hobbies> Hobby { get; set; }
    }
}
