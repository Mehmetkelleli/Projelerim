using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.data.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        void Create(TEntity t);
        void Delete(TEntity t);
        void Update(TEntity t);
        List<TEntity> GetAll();
        TEntity GetById(int id);
    }
}
