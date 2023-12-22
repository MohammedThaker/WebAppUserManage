

using Domain.IRepository;

namespace Infrastructure.Interfacies
{
    public class GetRepositoryById<T> : IGetRepositoryById<T> where T : class
    {
        public T GetByIdi(int entityId)
        {
            throw new NotImplementedException();
        }
    }
}
