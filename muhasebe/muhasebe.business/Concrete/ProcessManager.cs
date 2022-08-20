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
    public class ProcessManager : IProcessService
    {
        private IProcessRepoistory _Process;
        public ProcessManager(IProcessRepoistory Process)
        {
            _Process = Process;
        }
        public void Create(Process t)
        {
            _Process.Create(t);
        }

        public void Delete(Process t)
        {
            _Process.Delete(t);
        }

        public List<Process> GetAll()
        {
            return _Process.GetAll();
        }

        public Process GetById(int id)
        {
            return _Process.GetById(id);
        }

        public void Update(Process t)
        {
            _Process.Update(t);
        }
    }
}
