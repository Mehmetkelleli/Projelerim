using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Abstract
{
    public interface ISettingService
    {
        void create(Setting t);
        void update(Setting t);
        Setting GetById(int id);
        List<Setting> GetList();
        void delete(int id);

    }
}
