using Microsoft.EntityFrameworkCore;
using TodosWeb.Configuration;
using TodosWeb.Seeders;

namespace TodosWeb.Data
{
    public class TodosDbContext: DbContext
    {
        public TodosDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());

            modelBuilder.Seed();
        }
    }
}
