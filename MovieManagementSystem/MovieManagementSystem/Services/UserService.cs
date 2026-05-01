using MovieManagementSystem.Models;

namespace MovieManagementSystem.Services
{ 

internal class UserService
{
    public void UpdateProfile(User user, string newFirstName, string newLastName)
    {
        user.FirstName = newFirstName;
        user.LastName = newLastName;
    }

        public void LeaveReview(User user, Movie movie, double score, string comment)
        {
            var review = new Review
            {
                UserEmail = user.Email,
                Rating = score,
                Comment = comment,
                DatePosted = DateTime.Now
            };

            // Just add the review. 
            // The Movie model's "AverageRating" will update automatically!
            movie.Reviews.Add(review);
        }

        public List<Movie> SortMovies(List<Movie> movies, string criterion)
        {
            return criterion switch
            {
                "1" => movies.OrderBy(m => m.Title).ToList(),
                "2" => movies.OrderByDescending(m => m.ReleaseYear).ToList(),
                "3" => movies.OrderBy(m => m.ReleaseYear).ToList(),
                "4" => movies.OrderByDescending(m => m.AverageRating).ToList(),
                "5" => movies.OrderBy(m => m.Duration).ToList(),
                "6" => movies.OrderByDescending(m => m.Actors.Count).ToList(),
                _ => movies
            };
        }
        public void VerifyUser(User user, string inputCode, string sentCode)
        {
            if (user.IsVerified)
            {
                Console.WriteLine($"User {user.Email} is already verified.");
                return;
            }

            if (inputCode == sentCode)
            {
                user.IsVerified = true;
                Console.WriteLine($"[SUCCESS] User {user.Email} has been verified!");
            }
            else
            {
                Console.WriteLine("[ERROR] Invalid verification code. Access restricted.");
            }
        }
    
}
}