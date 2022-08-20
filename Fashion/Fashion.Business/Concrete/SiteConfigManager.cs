using Fashion.Business.Abstract;
using Fashion.Data.Abstract;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Concrete
{
    public class SiteConfigManager : ISiteConfigService
    {
        private ISiteConfigRepository _SiteConfig;
        public SiteConfigManager(ISiteConfigRepository SiteConfig)
        {
            _SiteConfig = SiteConfig;
        }
        public void Create(SiteConfig T)
        {
            _SiteConfig.Create(T);
        }

        public void Delete(SiteConfig T)
        {
            _SiteConfig.Delete(T);
        }

        public List<SiteConfig> GetAll()
        {
            return _SiteConfig.GetAll();
        }

        public SiteConfig GetById(int id)
        {
            return _SiteConfig.GetById(id);
        }

        public void Update(SiteConfig T)
        {
            _SiteConfig.Update(T);
        }
    }
}
