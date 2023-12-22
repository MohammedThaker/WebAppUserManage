using Application.DTOs.RequestDTO;
using Application.Interfaces;
using Domain.IRepository;

using Domain.Entities;


namespace Application.service
{
    public class CreateUserService : ICreateUserSerivce
    {
        public readonly IBaseUnitOftWork addUnitOfWork;
      

        public CreateUserService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;
        
        }

        public bool CreateUser(User user)

        {
            try
            {


            if (String.IsNullOrEmpty(user.Name))
                {
               return false;
                }
                if (String.IsNullOrEmpty(user.Email))
                {
                    return false;
                }
                if (String.IsNullOrEmpty(user.Phone))
                {
                    return false;
                }
                
                  
                var createorder= addUnitOfWork.AddUsers.Add(user);
         
                addUnitOfWork.Complete();
                return true;
            }
            catch (Exception )
            {
               
                throw new ApplicationException();
            }
        }

   
    }
}
