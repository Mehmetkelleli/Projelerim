using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IReadRepository<T>:IRepository<T>
        where T :class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingle(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);
        Task<T> GetByIdAsync(int id);
    }
}
