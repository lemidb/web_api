using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions Options) : base(Options)
        {
            
        }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Stock> Stocks { get; set; }

       
    }
}
