using Microsoft.EntityFrameworkCore;
using nesneodev.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nesneodev.Data.Concrete
{
    public class GenericRepoistory<T, Data> : IGenericRepository<T>
        where T:class
        where Data:DbContext,new()
    {
        public void Create(T T)
        {
            using (var db = new Data())
            {
                db.Set<T>().Add(T);
                db.SaveChanges();
            }
        }

        public void Delete(int T)
        {
            using (var db = new Data())
            {
                var a = db.Set<T>().Find(T);
                db.Set<T>().Remove(a);
                db.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var db = new Data())
            {
                return db.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var db = new Data())
            {
                return db.Set<T>().Find(id);
            }
        }

        public void Update(T T)
        {
            using (var db = new Data())
            {
                db.Entry(T).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
