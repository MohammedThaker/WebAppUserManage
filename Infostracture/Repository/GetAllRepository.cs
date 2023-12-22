
using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class GetAllRepository<T> : IGetRepository<T> where T : class
    {
        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
