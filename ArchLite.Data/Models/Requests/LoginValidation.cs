using ArchLite.Data.Models.Validation;
using System.Collections.Generic;

namespace ArchLite.Data.Models.Requests
{
    public static class LoginValidation
    {
        public static readonly short PASSWORD_LENGTH_MIN = 4;

        public static IEnumerable<ErrorValidation> Email(string email)
        {
            var list = new List<ErrorValidation>();
            if (string.IsNullOrWhiteSpace(email))
            {
                list.Add(ErrorValidation.Create("Email", "E-mail required."));
            }

            return list;
        }

        public static IEnumerable<ErrorValidation> Password(string password)
        {
            var list = new List<ErrorValidation>();
            if (string.IsNullOrWhiteSpace(password))
            {
                list.Add(ErrorValidation.Create("Password", "Password required."));
            }
            else if (password.Length < PASSWORD_LENGTH_MIN)
            {
                list.Add(ErrorValidation.Create("Password", $"Password minimum length is {PASSWORD_LENGTH_MIN}."));
            }

            return list;
        }
    }
}
