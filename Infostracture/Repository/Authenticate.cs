using Domain.IRepository;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.LibraryDB;

namespace Infosturcture.Repository
{
    public class Authenticate : IAuthenticate
    {
       
        
          protected LibraryDBContext dBContext;

        public Authenticate(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public User AuthenticateData(string username, string password)
        {
            var user = dBContext.Set<User>().SingleOrDefault(u => u.Name == username && u.Password == password);
            return user;
        }
    }
}
