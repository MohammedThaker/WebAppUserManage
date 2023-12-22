using Domain.Entities;
namespace Domain.IRepository
{
    public interface IBaseUnitOftWork : IDisposable
    {
        //add
        IAddRepository<User> AddUsers { get; }
        IAddRepository<Role> AddRole { get; }



        //Show ALL
        IGetRepository<User> GetAllUser { get; }
        IGetRepository<Role> GetAllRole { get; }

        //show By Id
        IGetRepositoryById<User> GetUserById { get; }
        IGetRepositoryById<Role> GetRoleById { get; }

        //update
        IUpdateRepository<User> UpdateUser { get; }
        IUpdateRepository<Role> UpdateRole { get; }

        
        //Delete
        IDeleteRepository<User> DeleteUser { get; }
        IDeleteRepository<Role> DeleteRole { get; }

        //IAuthenticate
        IAuthenticate authenticate { get; }

        int Complete();
     
      
    }
    
}
