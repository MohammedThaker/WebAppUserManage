using Domain.IRepository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infosturcture.Repository
{
    public class Authenticate : IAuthenticate
    {
        private readonly List<User> _users = new List<User>
        {
            new User()
            {
                Email ="moh@gamil.com",
                Created = DateTime.Now,
                Name ="mohammed",
                Phone ="881818",
                UserId =12,
                Password="123456"
        

                
            },
        };
     public  User AuthenticateData(string username, string password)
        {
            var user = _users.SingleOrDefault(u => u.Name == username && u.Password == password);
            return user;
        }
    }
}
