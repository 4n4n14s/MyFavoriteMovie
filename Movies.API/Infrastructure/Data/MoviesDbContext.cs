using Microsoft.EntityFrameworkCore;
using Movies.API.Domain.Entities;

namespace Movies.API.Infrastructure.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext( DbContextOptions<MoviesDbContext> opt) : base(opt)
        {
        }

        public DbSet<Domain.Entities.Movies> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(MoviesDbContext).Assembly);
        }
       
    }
}
