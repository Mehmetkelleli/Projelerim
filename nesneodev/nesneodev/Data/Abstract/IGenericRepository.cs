using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nesneodev.Data.Abstract
{
    public interface IGenericRepository<T>
    {
        void Create(T T);
        void Delete(int T);
        List<T> GetAll();
        T GetById(int id);
        void Update(T T);
    }
}
