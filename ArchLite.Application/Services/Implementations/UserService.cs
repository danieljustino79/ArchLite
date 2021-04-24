using ArchLite.Data.Models;
using ArchLite.Data.Models.Requests;
using ArchLite.Data.Models.Responses;
using ArchLite.Data.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ArchLite.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public string GetUser()
        {
            return "user 1";
        }

        public IEnumerable<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public UserViewModel GetUserByEmailPassword(string email, string password)
        {
            var list = userRepository.GetUsers();
            var user = list
                .Where(x => x.Email == email && x.Password == password)
                .Select(o => new UserViewModel()
                {
                    Email = o.Email,
                    CreateAt = o.CreateAt,
                    IsAdmin = o.IsAdmin
                }).FirstOrDefault<UserViewModel>();
            return user;
        }

        public UserViewModel Login(Login login)
        {
            return GetUserByEmailPassword(login.Email, login.Password);
        }
    }
}
