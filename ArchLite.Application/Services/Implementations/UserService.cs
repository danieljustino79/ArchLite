using ArchLite.Application.Adapters;
using ArchLite.Data.Models.Dto;
using ArchLite.Data.Models.Requests;
using ArchLite.Data.Models.Responses;
using ArchLite.Data.Models.Validation;
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

        public ResponseDto GetUsers()
        {
            var list = userRepository.GetUsers();


            if(list.Count() == 0)
            {
            //    var errors = new List<ErrorValidation>();
            //    errors.Add(ErrorValidation.CreateSummary("User not found."));
                return ResponseDto.Create(new List<string>(), 404, true);
            }

            var listViewModel = UserAdapter.ListUserToViewModel(list);
            return ResponseDto.Create(listViewModel, 200, true);
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

        public ResponseDto Login(Login login)
        {
            var errors = new List<ErrorValidation>();
            errors.AddRange(LoginValidation.Email(login.Email));
            errors.AddRange(LoginValidation.Password(login.Password));

            if(errors.Count > 0)
            {
                return ResponseDto.Create(errors, 400, true);
            }

            var user = GetUserByEmailPassword(login.Email, login.Password);
            if(user == null)
            {
                errors.Add(ErrorValidation.CreateSummary("E-mail or Password does not match."));
                return ResponseDto.Create(errors, 404, true);
            }

            var list = new List<UserViewModel>();
            list.Add(user);
            return ResponseDto.Create(list, 200, true);
        }
    }
}
