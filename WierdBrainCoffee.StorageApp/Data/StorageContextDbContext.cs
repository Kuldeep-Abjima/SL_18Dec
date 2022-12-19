using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WierdBrainCoffee.StorageApp.Entities;

namespace WierdBrainCoffee.StorageApp.Data
{
    class StorageContextDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Organisation> Organisation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDB");
        }
    }
}
