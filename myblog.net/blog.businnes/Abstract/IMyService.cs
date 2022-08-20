using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface IMyService
    {
        void create(My t);
        void update(My t);
        My GetById(int id);
        List<My> GetList();
        void delete(int id);

    }
}
