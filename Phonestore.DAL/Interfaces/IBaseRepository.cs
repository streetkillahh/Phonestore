using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonestore.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create (T entity);
        IQueryable<T> GetAll();
    }
}
