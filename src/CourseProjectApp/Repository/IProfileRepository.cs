using System.Collections.Generic;
using PortfolioApp.Models;

namespace PortfolioApp.Repository
{
   public interface IProfileRepository
    {
        List<Hobbies> GetHobbyList(string id);
        List<Organization> GetOrganizationList(string id);
        List<Individual> GetIndividualList(string id);
        void CreateHobby(Hobbies model);
        void CreateOrganization(Organization model);

        void CreateIndividual(Individual model);
    }
}
