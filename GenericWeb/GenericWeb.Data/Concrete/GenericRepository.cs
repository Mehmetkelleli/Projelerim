using GenericWeb.Data.Abstract;
using GenericWeb.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GenericWeb.Data.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : class
        
    {
        private DataContext _Data;
        public GenericRepository(DataContext Data)
        {
            _Data = Data;
        }
        public void Create(T T)
        {

                _Data.Set<T>().Add(T);
                _Data.SaveChanges();

        }

        public List<T> GetAll()
        {
              return _Data.Set<T>().ToList();

        }

        public T GetById(int id)
        {
            
                return _Data.Set<T>().Find(id);

        }

        public void Remove(T T)
        {
            
                _Data.Set<T>().Remove(T);
                _Data.SaveChanges();
            
        }

        public void Update(T T)
        {
            
                _Data.Entry(T).State = EntityState.Modified;
                _Data.SaveChanges();
            
        }
    }
}
