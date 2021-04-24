using System;

namespace ArchLite.Data.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreateAt { get; set; }
        public bool IsAdmin { get; set; }
    }
}
