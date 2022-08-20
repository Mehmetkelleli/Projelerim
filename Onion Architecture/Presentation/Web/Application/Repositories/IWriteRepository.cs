using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T:class
    {
        bool Update(T T);
        Task<bool> Create(T T);
        Task<bool> CreateRange(List<T> T);
        bool Delete(T T);
        Task<bool> Delete(int Id);
        Task<int> SaveAsync();

    }
}
