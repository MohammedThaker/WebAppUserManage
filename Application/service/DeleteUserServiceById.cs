using Application.Interfaces;
using Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.service
{
    public class DeleteUserServiceById : IDeleteUserServiceById
    {
        public readonly IBaseUnitOftWork addUnitOfWork;


        public DeleteUserServiceById(IBaseUnitOftWork addUnitOfWork)
        {
            this.addUnitOfWork = addUnitOfWork;

        }
        public bool RemoveById(int UserId)
        {
            try
            {



                var createorder = addUnitOfWork.DeleteUser.RemoveById(UserId);

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
