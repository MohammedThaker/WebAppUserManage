using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IDeleteRepository< T> where T : class

    {

        public T RemoveById(int id);
    }
}
