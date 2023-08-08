using Microsoft.EntityFrameworkCore;
using MovieReviews.Models;

namespace MovieReviews.Data
{
    public static class SeedData
    {
        public static void AddMovies(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Title = "Highlander",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/Highlander.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });
            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 2,
                Title = "Godfather",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/Godfather.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });
            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 3,
                Title = "Last of the Mohicans",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/LastOfTheMohicans.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });
           
            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 4,
                Title = "Rear Window",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/RearWindow.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });

            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 5,
                Title = "Road House",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/RoadHouse.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });

            modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 6,
                Title = "Star Trek IV",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                ImageUrl = "/images/movies/StarTreck4.png",
                Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

            });



        }
    }
}
