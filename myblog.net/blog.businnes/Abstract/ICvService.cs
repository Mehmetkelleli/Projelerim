using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface ICvService
    {
        void create(Cv t);
        void update(Cv t);
        Cv GetById(int id);
        List<Cv> GetList();
        void delete(int id);

    }
}
