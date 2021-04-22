using ArchLite.Data.Repositories;
using System.Collections.Generic;

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
            return "user 2";
        }

        public IEnumerable<string> GetUsers()
        {
            return userRepository.GetUsers();
        }
    }
}
