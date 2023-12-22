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
        public UserResponseDTOs GetUser_ById(int userid)
        {


            var user = addUnitOfWork.GetUserById.GetByIdi(userid);


            var userRespons = new UserResponseDTOs
            {
                UserId = user.UserId,
                Name = user.Name,
                Email = user.Email,
                Phone = user.Phone,
                Created = user.Created,
            };

            return userRespons;








        }
    }
}
