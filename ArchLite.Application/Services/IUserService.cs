using ArchLite.Data.Models;
using ArchLite.Data.Models.Requests;
using ArchLite.Data.Models.Responses;
using System.Collections.Generic;

namespace ArchLite.Application.Services
{
    public interface IUserService
    {
        string GetUser();
        IEnumerable<User> GetUsers();
        UserViewModel GetUserByEmailPassword(string email, string password);
        UserViewModel Login(Login login);
    }
}
