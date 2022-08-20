using Application.Repositories;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private DataContext _Data;
        public WriteRepository(DataContext Data)
        {
            _Data = Data;
        }
        public DbSet<T> Table => _Data.Set<T>();


        public async Task<bool> Create(T T)
        {
            T.CreatedTime = DateTime.Now;
            var result = await Table.AddAsync(T);
            return result.State == EntityState.Added;
        }

        public async Task<bool> CreateRange(List<T> T)
        {
            await Table.AddRangeAsync(T);
            return true;
        }

        public bool Delete(T T)
        {
           EntityEntry<T> result =  Table.Remove(T);
           return result.State == EntityState.Deleted;
        }

        public async Task<bool> Delete(int Id)
        {
            var item = await Table.FirstAsync(i => i.Id == Id);
            return Delete(item);
        }

        public Task<int> SaveAsync()
        {
            var result  = _Data.SaveChangesAsync();
            return result;
        }

        public virtual bool Update(T T)
        {
            T.UpdateTime = DateTime.Now;
            var result = Table.Update(T);
            return result.State == EntityState.Modified;
        }
    }
}
