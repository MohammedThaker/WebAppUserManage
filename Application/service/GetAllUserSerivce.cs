using Application.DTOs.ResponseDTO;
using Application.Interfaces;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service
{
    public class GetAllUserSerivce : IGetAllUserSerivce
    {

        public readonly IBaseUnitOftWork addUnitOfWork;


        public GetAllUserSerivce(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }

        public List<UserResponseDTOs> GetUser_All()
        {

            var user = addUnitOfWork.GetAllUser.GetAll().ToList();


            
            var UserDTOs = new List<UserResponseDTOs>();

            foreach(var UserDTO in user)
                UserDTOs.Add(new UserResponseDTOs
            {
                UserId = UserDTO.UserId,
                Name =UserDTO.Name ,
                Phone = UserDTO.Phone,
                Email = UserDTO.Email,
            });
            return UserDTOs;


        }
    }
}
