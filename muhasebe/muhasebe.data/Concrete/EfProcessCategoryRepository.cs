using muhasebe.data.Abstract;
using muhasebe.entity.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.data.Concrete
{
    public class EfProcessCategoryRepository
        :EfGenericRepository<ProcessCategory,SqlContext>,IProcessCategoryRepoistory
    {
    }
}
