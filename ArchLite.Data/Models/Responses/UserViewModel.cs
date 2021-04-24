using System;

namespace ArchLite.Data.Models.Responses
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsAdmin { get; set; }
    }
}
