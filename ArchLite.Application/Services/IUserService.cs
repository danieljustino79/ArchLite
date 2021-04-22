using System.Collections.Generic;

namespace ArchLite.Application.Services
{
    public interface IUserService
    {
        public string GetUser();
        public IEnumerable<string> GetUsers();
    }
}
