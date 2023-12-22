
using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class AddRepository<T> : IAddRepository<T> where T : class
    {
        public T Add(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
