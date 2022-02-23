using GroupsUsers.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupsUsers
{
    public class ExchangeDbContext : DbContext
    {
        public ExchangeDbContext(DbContextOptions<ExchangeDbContext> options)
           : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Users>()
               .HasKey(x => x.Id);
            modelBuilder.Entity<Groups>()
                .HasKey(x => x.Id);
             

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Groups> Groups { get; set; }
    }
}
