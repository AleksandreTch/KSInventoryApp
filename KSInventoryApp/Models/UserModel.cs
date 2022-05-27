using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace KSInventoryApp.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public string Position { get; set; }

        public UserModel(string userName, string password, string emailAddress, string lastName, string firstName, string position)
        {
            UserName = userName;
            Password = password;
            EmailAddress = emailAddress;
            LastName = lastName;
            FirstName = firstName;
            Position = position;
        }

        public UserModel()
        {
            
        }
    }
}
