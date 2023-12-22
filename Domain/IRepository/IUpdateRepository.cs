using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IUpdateRepository <T> where T : class
    {
        public T Update(T entity);
    }
}
