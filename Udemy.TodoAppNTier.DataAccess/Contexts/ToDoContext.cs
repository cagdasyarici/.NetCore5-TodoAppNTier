using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.TodoAppNTier.DataAccess.Configurations;
using Udemy.TodoAppNTier.Entities.Domains;

namespace Udemy.TodoAppNTier.DataAccess.Contexts
{
    public class ToDoContext : DbContext
    {

        public ToDoContext(DbContextOptions<ToDoContext> options): base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration (new WorkConfiguration());
        }
        public DbSet<Work> Works { get; set; }
    }
}
