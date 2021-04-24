using ArchLite.Data.Models;
using ArchLite.Data.Models.Responses;
using System.Collections.Generic;

namespace ArchLite.Application.Adapters
{
    public class UserAdapter
    {
        public static UserViewModel UserToViewModel(User user)
        {
            var userViewModel = new UserViewModel();
            userViewModel.Id = user.Id;
            userViewModel.Email = user.Email;
            userViewModel.CreateAt = user.CreateAt;
            userViewModel.IsAdmin = user.IsAdmin;
            return userViewModel;
        }

        public static IEnumerable<UserViewModel> ListUserToViewModel(IEnumerable<User> users)
        {
            var list = new List<UserViewModel>();
            foreach(var item in users)
            {
                list.Add(UserToViewModel(item));
            }
            return list;
        }
    }
}
