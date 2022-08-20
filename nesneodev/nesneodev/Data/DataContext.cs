using Microsoft.EntityFrameworkCore;
using nesneodev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nesneodev.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-3DP2PDF;Database=DataDb1;Integrated Security=True");
        }

    }
}
