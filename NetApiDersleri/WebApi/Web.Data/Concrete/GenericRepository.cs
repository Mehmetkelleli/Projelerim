using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Data.Abstract;
using Web.Data.Context;

namespace Web.Data.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T :class,new()
    {
        public async Task<List<T>> GetAll()
        {
            using(var db = new DataContext())
            {
                return await db.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetById(int id)
        {
            using (var db = new DataContext())
            {
                return await db.Set<T>().FindAsync(id);
            }
        }
    }
}
