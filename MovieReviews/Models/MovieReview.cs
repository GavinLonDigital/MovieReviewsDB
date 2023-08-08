namespace MovieReviews.Models
{
    public class MovieReview
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
 
    }
}
