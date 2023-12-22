using Application.Interfaces;
using Domain.Entities;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service
{
    public class AuthenticateSerivce: IAuthenticateSerivce
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public AuthenticateSerivce(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }

        public bool AuthenticateSerivces(string username, string password)
        {

            var UserAuth= addUnitOfWork.authenticate.AuthenticateData(username, password);

            if(UserAuth!=null)
            return true; 
            else return false;
        
        
        
        }
    }
}
