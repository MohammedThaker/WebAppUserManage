

using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class GetRepositoryById<T> : IGetRepositoryById<T> where T : class
    {
        protected LibraryDBContext dBContext;

        public GetRepositoryById(LibraryDBContext dBContext)
        {
            this.dBContext = dBContext;
        }




        public T GetByIdi(int entityId)
        {
             return dBContext.Set<T>().Find(entityId);
        }
    }
}
