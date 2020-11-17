using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Entities;

namespace Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AppUser> Users { get; set; } 

    }
}