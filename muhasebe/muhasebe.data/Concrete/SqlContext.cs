using Microsoft.EntityFrameworkCore;
using muhasebe.entity.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muhasebe.data.Concrete
{
    public class SqlContext : DbContext
    {
        public DbSet<Process> Process { get; set; }
        public DbSet<ProcessCategory> ProcessCategories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=Muhasebe;Integrated Security=True");
        }
    }
}
