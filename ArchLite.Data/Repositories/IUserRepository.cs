using System.Collections.Generic;

namespace ArchLite.Data.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<string> GetUsers();
    }
}
