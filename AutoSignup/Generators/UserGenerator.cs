using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSignup.Generators
{
    public static class UserGenerator
    {
        public static User LastGeneratedUser;

        public static void Initialize()
        {
            LastGeneratedUser = null;
        }

        public static User Generate()
        {
            var user = new User
            {
                EmailAddress = Email.Generate(),
                Password = Password.Generate(),
                PhoneNumber= Phone.Generate(),
                FirstName=FirstName.Generate(),
                LastName=LastName.Generate()

            };

            LastGeneratedUser = user;
            return user;
        }
    }

    public class User
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get;  set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
