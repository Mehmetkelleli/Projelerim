using muhasebe.entity.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.business.Abstract
{
    public interface IProcessCategoryService
    {
        void Create(ProcessCategory t);
        void Delete(ProcessCategory t);
        void Update(ProcessCategory t);
        List<ProcessCategory> GetAll();
        ProcessCategory GetById(int id);
    }
}
