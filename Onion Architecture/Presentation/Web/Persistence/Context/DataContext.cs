using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class DataContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DataContext(DbContextOptions options):base(options)
        {
        }
    }
}
