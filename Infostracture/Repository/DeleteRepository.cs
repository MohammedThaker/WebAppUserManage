

using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class
    {
      

        protected LibraryDBContext _dBContext;

        public DeleteRepository(LibraryDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public T RemoveById(int id)
        {
            var RemoveEntity= _dBContext.Set<T>().Find(id);
            if(RemoveEntity != null)
                _dBContext.Set<T>().Remove(RemoveEntity);
                 return RemoveEntity;
            return null;
            
        }


    }
}
