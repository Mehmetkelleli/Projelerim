using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Abstract
{
    public interface IGenericRepository<T>
    {
        void Create(T T);
        void Update(T T);
        void Delete(T T);
        List<T> GetAll();
        T GetById(int id);
    }
}
