namespace MovieManagementSystem.Models
{
    internal class Movie
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }
        public TimeSpan Duration { get; set; }
        public List<Actor> Actors { get; set; } = new();
        public List<Review> Reviews { get; set; } = new();

        public double AverageRating { get; set; }
    }
}