using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;
using Persistence;

namespace Persistence
{
    public class DataContext: DbContext
    {
        public DbSet<Value> Values {get; set;}

        public DataContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Value { Id = 1, Name = "Value1"},
                new Value { Id = 2, Name = "Value2" },
                new Value { Id = 3, Name = "Value3" }
            );
        }
    }
}