using Application.Repositories;
using Domain.Entities.Common;
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
        private DataContext _Data;
        public ReadRepository(DataContext Data)
        {
            _Data = Data;
        }

        public DbSet<T> Table => _Data.Set<T>();

        public IQueryable<T> GetAll() => Table;


        public async Task<T> GetByIdAsync(string id) => await Table.FindAsync(id);


        public async Task<T> GetByIdAsync(int id) => await Table.FindAsync(id);

        public async Task<T> GetSingle(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
    }
}
