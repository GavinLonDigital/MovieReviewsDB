using MovieReviews.Models;

namespace MovieReviews.Services
{
    public interface IMovieReviewService
    {
        Task<List<Movie>?> GetMovies();

        Task<Movie?> GetMovie(int id);

    }
}
