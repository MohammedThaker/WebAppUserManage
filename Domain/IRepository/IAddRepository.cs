
using Domain.Entities;

namespace Domain.IRepository
{
    public interface IAddRepository<T> where T : class
    { 
       public T Add(T entity );

    }
}
