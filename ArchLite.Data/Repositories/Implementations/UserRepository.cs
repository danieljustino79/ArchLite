using System.Collections.Generic;

namespace ArchLite.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<string> GetUsers()
        {
            var list = new List<string>();
            list.Add("user 1");
            list.Add("user 2");
            return list;
        }
    }
}
