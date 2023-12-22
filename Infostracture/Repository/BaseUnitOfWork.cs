
using Domain.Entities;
using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class BaseUnitOfWork : IBaseUnitOftWork
    {
        

      
        //add
        public IAddRepository<User> AddUsers { get; set; }

        public IAddRepository<Role> AddRole { get; set; }

      //gat
        public IGetRepository<User> GetAllUser { get; set; }

        public IGetRepository<Role> GetAllRole { get; set; }

        public IGetRepositoryById<User> GetUserById { get; set; }

        public IGetRepositoryById<Role> GetRoleById { get; set; }

     //update
        public IUpdateRepository<User> UpdateUser { get; set; }
        public IUpdateRepository<Role> UpdateRole { get; set; }

        public IDeleteRepository<User> DeleteUser { get; set; }
        public IDeleteRepository<Role> DeleteRole { get; set; }

        public BaseUnitOfWork()
        {


            //
            AddUsers = new AddRepository<User>();
            AddRole = new AddRepository<Role>();
            //
            GetUserById = new GetRepositoryById<User>();
            GetRoleById = new GetRepositoryById<Role>();
            //
            GetAllUser = new GetAllRepository<User>();
            GetAllRole = new GetAllRepository<Role>();

            //
            UpdateUser = new UpdateRepository<User>();
            UpdateRole = new UpdateRepository<Role>();

            //
            DeleteUser =new DeleteRepository<User>();
            DeleteRole=new DeleteRepository<Role>();


        }

        public int Complete()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}