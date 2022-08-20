using Fashion.Data.Abstract;
using Fashion.Data.Context;
using Fashion.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Data.Concrete
{
    public class EfSiteConfigRepository:EfGenericRepository<SiteConfig,ShopDataContext>,ISiteConfigRepository
    {
    }
}
