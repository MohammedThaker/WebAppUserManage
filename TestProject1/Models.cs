using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs.RequestDTO;
namespace Test_UserManagement
{
    public class Models
    {
      public  UserDTOs userDTOs = new UserDTOs
        {

            UserEmail = "m@m.com",
            UserName = "Mohammed",
            Phone = "771159921",
        };
      public  User user = new User
        {
            UserId = 2,
            Email = "m@m.com",
            Name = "Mohammed",
            Phone = "771159921",
            Password ="1234"

        };
        public static List<User> GetTestRegistrations()
        {
            var registrations = new List<User>();
            registrations.Add(new User()
            {
                UserId = 1,
                Name = "Tester1",
                Phone = "77110"
            });
            registrations.Add(new User()
            {
                UserId = 2,
                Name = "Tester2",
                Phone = "77111"
            });
            registrations.Add(new User()
            {
                UserId = 3,
                Name = "Tester3",
                Phone = "77112"
            });
            return registrations;
        }


    }
}
