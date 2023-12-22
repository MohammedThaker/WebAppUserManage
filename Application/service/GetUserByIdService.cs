using Application.DTOs.ResponseDTO;
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
    public class GetUserByIdService : IGetUserByIdService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public GetUserByIdService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public User GetUser_ById(int userid)
        {


            var user = addUnitOfWork.GetUserById.GetByIdi(userid);


          
            return user;








        }
    }
}
