
using Application.DTOs.RequestDTO;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICreateUserSerivce
    {
   public bool CreateUser(User user);
 
    }
}
