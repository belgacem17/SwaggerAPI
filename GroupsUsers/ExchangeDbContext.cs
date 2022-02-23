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
        public DbSet<Users> Users { get; set; }
        public DbSet<Groups> Groups { get; set; }
    }
}
