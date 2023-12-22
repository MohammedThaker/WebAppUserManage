using Application.DTOs.RequestDTO;
using Application.Interfaces;
using Domain.IRepository;

using Domain.Entities;
namespace Application.service
{
    public class UpdateUserService: IUpdateUserService
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public UpdateUserService(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public string Update_User(User userDTOs)
        {
            try
            {


                if (String.IsNullOrEmpty(userDTOs.Name))
                {
                    return "error to update";
                }
                if (String.IsNullOrEmpty(userDTOs.Email))
                {
                    return "error to update";
                }
                if (String.IsNullOrEmpty(userDTOs.Phone))
                {
                    return "error to  update";
                }
                var User = new User

                {
                    Phone = userDTOs.Phone,
                    Email = userDTOs.Email,
                    Name = userDTOs.Name,
                };


                var createorder = addUnitOfWork.UpdateUser.Update(User);

                addUnitOfWork.Complete();
                return   "Updated user";
            }
            catch (Exception )
            {

                throw new ApplicationException();
            }
        }
    }
}
