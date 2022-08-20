using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data.Abstract
{
    public interface IGenericRepository<T>
    {
        T GetById(int i);
        List<T> GetList();
        void Update(T T);
        void Create(T T);
        void Delete(T T);    
    }
}
