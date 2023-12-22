using System;


namespace Domain.IRepository
{
    public interface  IGetRepositoryById<T> where T : class
    {
        public T GetByIdi(int entityId);

   

    }
}
