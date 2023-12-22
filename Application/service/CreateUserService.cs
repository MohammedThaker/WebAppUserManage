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

        public bool CreateUser(UserDTOs userDTOs)

        {
            try
            {


            if (String.IsNullOrEmpty(userDTOs.UserName))
                {
               return false;
                }
                if (String.IsNullOrEmpty(userDTOs.UserEmail))
                {
                    return false;
                }
                if (String.IsNullOrEmpty(userDTOs.Phone))
                {
                    return false;
                }
                var User= new User

                {Phone = userDTOs.Phone,
                    Email=userDTOs.UserEmail,
                    Name=userDTOs.UserName,
                   };

                  
                var createorder= addUnitOfWork.AddUsers.Add(User);
         
                addUnitOfWork.Complete();
                return true;
            }
            catch (Exception ex)
            {
               
                throw new ApplicationException();
            }
        }

   
    }
}
