using ArchLite.Data.Models;
using System.Collections.Generic;

namespace ArchLite.Data.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}
