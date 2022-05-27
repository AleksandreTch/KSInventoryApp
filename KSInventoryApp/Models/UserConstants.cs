using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSInventoryApp.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {UserName = "jason_admin", EmailAddress = "jason.admin@email.com", 
                Password = "MyPass_w0rd", FirstName = "Jason", 
                LastName = "Bryant", Position = "Administrator"},
            new UserModel() {UserName ="elyse_seller", EmailAddress ="elyse.seller@email.com", 
                Password = "MyPass_w0rd", FirstName = "Elyse", 
                LastName = "Lambert", Position = "Seller"}
        };
    }
}
