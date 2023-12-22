

using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class DeleteRepository<T> : IDeleteRepository<T> where T : class
    {
        public T RemoveById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
