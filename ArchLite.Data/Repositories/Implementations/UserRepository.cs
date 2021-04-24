using ArchLite.Data.Models;
using System;
using System.Collections.Generic;

namespace ArchLite.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> GetUsers()
        {
            var list = new List<User>();
            list.Add(new User()
            {
                Id = 1,
                Email = "ana@g",
                Password = "",
                CreateAt = DateTime.Now,
                IsAdmin = false
            });
            list.Add(new User()
            {
                Id = 1,
                Email = "bet@g",
                Password = "",
                CreateAt = DateTime.Now,
                IsAdmin = false
            });
            list.Add(new User()
            {
                Id = 1,
                Email = "cel@g",
                Password = "1234",
                CreateAt = DateTime.Now,
                IsAdmin = false
            });
            list.Add(new User()
            {
                Id = 1,
                Email = "dan@g",
                Password = "1234",
                CreateAt = DateTime.Now,
                IsAdmin = true
            });
            return list;
        }
    }
}