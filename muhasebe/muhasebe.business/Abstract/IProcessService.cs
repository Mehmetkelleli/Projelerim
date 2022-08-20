using muhasebe.entity.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.business.Abstract
{
    public interface IProcessService
    {
        void Create(Process t);
        void Delete(Process t);
        void Update(Process t);
        List<Process> GetAll();
        Process GetById(int id);
    }
}
