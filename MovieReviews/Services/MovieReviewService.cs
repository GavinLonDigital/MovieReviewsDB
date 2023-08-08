using Microsoft.EntityFrameworkCore;
using MovieReviews.Data;
using MovieReviews.Models;

namespace MovieReviews.Services
{
    //https://www.lipsum.com/

    public class MovieReviewService:IMovieReviewService
    {
        private readonly MovieReviewDBContext movieReviewDBContext;

        //  private static readonly List<Movie> Movies = new List<Movie>
        //    {
        // new Movie
        //{
        //    Id = 1,
        //    Title = "Highlander",
        //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //    ImageUrl = "/images/movies/Highlander.png",
        //    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        //},
        //new Movie
        //{
        //    Id = 2,
        //    Title = "Godfather",
        //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //    ImageUrl = "/images/movies/Godfather.png",
        //    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        //},
        //new Movie
        //{
        //     Id = 3,
        //     Title = "Last of the Mohicans",
        //     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //     ImageUrl = "/images/movies/LastOfTheMohicans.png",
        //    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        //},
        //new Movie
        //{
        //    Id = 4,
        //    Title = "Rear Window",
        //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //    ImageUrl = "/images/movies/RearWindow.png",
        //    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        //},
        // new Movie
        //{
        //    Id = 5,
        //    Title = "Road House",
        //    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //    ImageUrl = "/images/movies/RoadHouse.png",
        //    Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        //},                 
        // new Movie
        // {
        //     Id = 6,
        //     Title = "Star Treck IV",
        //     Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
        //     ImageUrl = "/images/movies/StarTreck4.png",
        //     Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam quam erat, gravida quis est vitae, tempus dignissim lorem. Vestibulum et aliquam est. Phasellus interdum diam ac faucibus condimentum. In malesuada scelerisque blandit."

        // }
        // };

        public MovieReviewService(MovieReviewDBContext movieReviewDBContext)
        {
            this.movieReviewDBContext = movieReviewDBContext;
        }

        public async Task<List<Movie>?> GetMovies()
        {
   
            return await this.movieReviewDBContext.Movies.ToListAsync<Movie>();

        }
        public async Task<Movie?> GetMovie(int id)
        {
            return await this.movieReviewDBContext.Movies.SingleOrDefaultAsync(m => m.Id == id);

        }

    }
}
