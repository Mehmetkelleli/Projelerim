using Api.Core.interfaces;
using Api.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Infrastructure.Implements
{
    public class GenericRepository<T> : IGenericRepository<T>
            where T:class
            
    {
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            using (var db = new DataS1Context())
            {
                return await db.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            using (var db = new DataS1Context())
            {
                return await db.Set<T>().FindAsync(id);
            }
        }
    }
}
