using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Business.Abstract
{
    public interface ISiteConfigService
    {
        void Create(SiteConfig T);
        void Update(SiteConfig T);
        void Delete(SiteConfig T);
        List<SiteConfig> GetAll();
        SiteConfig GetById(int id);
    }
}
