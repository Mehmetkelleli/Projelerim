using Application.Repositories;
using Domain;
using Persistence.Context;
using Persistence.Repositories;

namespace Persistence
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(DataContext Data) : base(Data)
        {
        }
    }
}
