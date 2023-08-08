using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;
namespace MovieReviews.Data
{
    public class MovieReviewDBContext:DbContext
    {
        public MovieReviewDBContext(DbContextOptions<MovieReviewDBContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData.AddMovies(modelBuilder);
        }
       public DbSet<Movie> Movies { get; set; }


    }
}
