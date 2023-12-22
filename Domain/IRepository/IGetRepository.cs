
namespace Domain.IRepository
{
    public  interface IGetRepository<T> where T : class
    {

        public IEnumerable<T> GetAll();

    }
}
