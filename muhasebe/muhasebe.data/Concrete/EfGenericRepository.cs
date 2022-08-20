using Microsoft.EntityFrameworkCore;
using muhasebe.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.data.Concrete
{
    public class EfGenericRepository<T, Context> : IGenericRepository<T>
        where T : class
       where Context : DbContext, new()

    {
        public void Create(T t)
        {
            using (var db = new Context())
            {
                db.Set<T>().Add(t);
            }
        }

        public List<T> GetAll()
        {
            using (var db = new Context())
            {
                return db.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var db = new Context())
            {
              return db.Set<T>().Find(id);
            }
        }

        public void Update(T T)
        {
            using (var db = new Context())
            {
                db.Entry(T).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public void Delete(T t)
        {
            using (var db = new Context())
            {
                db.Set<T>().Remove(t);
            }
        }
    }
}
