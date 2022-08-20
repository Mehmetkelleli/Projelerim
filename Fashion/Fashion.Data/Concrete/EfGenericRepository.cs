using Fashion.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Concrete
{
    public class EfGenericRepository<T, Context> : IGenericRepository<T>
        where T:class
        where Context:DbContext,new()
    {
        public void Create(T T)
        {
            using(var db = new Context())
            {
                db.Set<T>().Add(T);
                db.SaveChanges();
            }
        }

        public void Delete(T T)
        {
            using (var db = new Context())
            {
                db.Set<T>().Remove(T);
                db.SaveChanges();
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

        public virtual void Update(T T)
        {
            using (var db = new Context())
            {
                db.Entry(T).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
