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
    public class OrderWriteRepository : WriteRepository<Orders>, IOrderWriteRepository
    {
        public OrderWriteRepository(DataContext Data) : base(Data)
        {
        }
    }
}
