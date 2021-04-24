using ArchLite.Data.Models.Dto;
using ArchLite.Data.Models.Requests;
using ArchLite.Data.Models.Responses;

namespace ArchLite.Application.Services
{
    public interface IUserService
    {
        string GetUser();
        ResponseDto GetUsers();
        UserViewModel GetUserByEmailPassword(string email, string password);
        ResponseDto Login(Login login);
    }
}
