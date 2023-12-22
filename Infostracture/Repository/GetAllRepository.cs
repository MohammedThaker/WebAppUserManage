
using Domain.IRepository;
using Infrastructure.LibraryDB;

namespace Infrastructure.Interfacies
{
    public class GetAllRepository<T> : IGetRepository<T> where T : class
    {

        protected LibraryDBContext _dBContext;

        public GetAllRepository(LibraryDBContext dBContext)
        {
            _dBContext = dBContext;
        }



        public IEnumerable<T> GetAll()
        {
            return _dBContext.Set<T>().ToList();
        }
    }
}
