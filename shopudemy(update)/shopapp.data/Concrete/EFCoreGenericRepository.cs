using Microsoft.EntityFrameworkCore;
using shopapp.data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data.Concrete
{
    public class EFCoreGenericRepository<T, Context> : IGenericRepository<T>
        where T: class
        where Context : DbContext,new()
    {
        public void Create(T T)
        {
            using (var db = new Context())
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

        public T GetById(int i)
        {
            using (var db = new Context())
            {
                return db.Set<T>().Find(i);
            }
        }

        public List<T> GetList()
        {
            using (var db = new Context())
            {
                return db.Set<T>().ToList();
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
    }
}
