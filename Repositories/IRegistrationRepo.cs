using Matchtickets1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Matchtickets1.Repositories
{
    public interface IRegistrationRepo
    {
        Registration Login(string email, string password);
        List<Registration>  GetAllRegistrations();
        Registration GetRegistrationById(int id);
        string AddnewRegistration(Registration registration);
        string UpdateRegistration(Registration registration);
        string DeleteRegistration(int id);
    }
}
