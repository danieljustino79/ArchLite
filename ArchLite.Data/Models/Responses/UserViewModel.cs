using System;

namespace ArchLite.Data.Models.Responses
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsAdmin { get; set; }
    }
}
