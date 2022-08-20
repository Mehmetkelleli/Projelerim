using blog.businnes.Abstract;
using blog.data.Abstract;
using blog.data.Concrete.EfCoreMysql;
using myblog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blog.businnes.Concrete
{
    public class SettingManager : ISettingService
    {
        private ISettingRepository _setting;
        public SettingManager(ISettingRepository setting)
        {
            _setting = setting;
        }
        public void create(Setting t)
        {
            _setting.create(t);
        }

        public Setting GetById(int id)
        {
            return _setting.GetById(id);
        }

        public List<Setting> GetList()
        {
            return _setting.GetList();
        }

        public void update(Setting t)
        {
            _setting.update(t);
        }
        public void delete(int id)
        {
            _setting.delete(id);
        }
    }
}
