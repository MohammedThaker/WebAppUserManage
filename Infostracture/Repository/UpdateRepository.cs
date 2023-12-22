
using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class UpdateRepository<T> : IUpdateRepository<T> where T : class
    {
       
        protected LibraryDBContext _dBContext;

        public UpdateRepository(LibraryDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public T Update(T entity)
        {
            _dBContext.Set<T>().Update(entity);
            return entity;
        }
    }
}
