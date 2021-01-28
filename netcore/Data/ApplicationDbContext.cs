using Microsoft.EntityFrameworkCore;
using netcore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Category> Category { get; set; }

        public DbSet<Category> MyProperty { get; set; }
        public IEnumerable<Category> Category { get; internal set; }
    }
}
