
using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class UpdateRepository<T> : IUpdateRepository<T> where T : class
    {
        public T Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
