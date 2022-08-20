using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface IService<t>
    {
        void create(t t);
        void update(t t);
        t GetById(int id);
        List<t> GetList();
        void delete(int id);

    }
}
