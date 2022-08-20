using Application.Repositories;
using Domain;
using Persistence.Context;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadrepository
    {
        public ProductReadRepository(DataContext db) : base(db)
        {
        }
    }
}
