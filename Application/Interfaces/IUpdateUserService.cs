using Application.DTOs.RequestDTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUpdateUserService
    {
        public string Update_User(User userDTOs);
    }
}
