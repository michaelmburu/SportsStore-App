using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Context
{
    public class SportsStoreDbContext : DbContext
    {
        public SportsStoreDbContext(DbContextOptions<SportsStoreDbContext> sportsStoreDbContextOptions) : base(sportsStoreDbContextOptions)
        {
           
        }

        public DbSet<Product> Products { get; set; }
    }
}
