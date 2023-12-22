using Application.DTOs.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IGetAllUserSerivce
    {
        public List<UserResponseDTOs> GetUser_All();

    }
}
