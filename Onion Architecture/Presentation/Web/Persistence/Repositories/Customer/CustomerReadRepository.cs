using Application.Repositories;
using Domain;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(DataContext db) : base(db)
        {
        }
    }
}
