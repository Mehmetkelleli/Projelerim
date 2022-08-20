using muhasebe.business.Abstract;
using muhasebe.data.Abstract;
using muhasebe.entity.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.business.Concrete
{
    public class ProcessCategoryManager : IProcessCategoryService
    {
        private IProcessCategoryRepoistory _ProcessCategory;
        public ProcessCategoryManager(IProcessCategoryRepoistory ProcessCategory)
        {
            _ProcessCategory = ProcessCategory;
        }
        public void Create(ProcessCategory t)
        {
            _ProcessCategory.Create(t);
        }

        public List<ProcessCategory> GetAll()
        {
            return _ProcessCategory.GetAll();
        }

        public ProcessCategory GetById(int id)
        {
            return _ProcessCategory.GetById(id);
        }

        public void Update(ProcessCategory t)
        {
            _ProcessCategory.Update(t);
        }

        public void Delete(ProcessCategory t)
        {
            _ProcessCategory.Delete(t);
        }
    }
}
