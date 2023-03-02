using Microsoft.EntityFrameworkCore;
using TODO.Model;

namespace TODO.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.UseSerialColumns();
        }
        public DbSet<Movie> Movies { get; set; }

    }
}
