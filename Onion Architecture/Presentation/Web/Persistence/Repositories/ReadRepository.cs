using Application.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
            private readonly DataContext _db;
            public ReadRepository(DataContext db)
            {
                _db = db;
            }
        public DbSet<T> Table => _db.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var get = Table.AsQueryable();
            if (!tracking)
            {
                get = get.AsNoTracking();
            }
            return get;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var get = Table.AsQueryable();
            if (!tracking)
            {
                get = get.AsNoTracking();
            }
            return await Table.FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var get = Table.AsQueryable();
            if (!tracking)
            {
                get = get.AsNoTracking();
            }
            return await Table.FirstOrDefaultAsync(method);

        }
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var get = Table.AsQueryable();
            if (!tracking)
            {
                get = get.AsNoTracking();
            }
            return Table.Where(method);
        }
        
    }
}
