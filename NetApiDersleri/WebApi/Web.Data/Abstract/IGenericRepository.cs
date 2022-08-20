using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Data.Abstract
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
    }
}
