using System;
using System.Linq;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Validators
{
    internal static class ReviewValidator
    {
        public static (bool IsValid, string ErrorMessage) ValidateReview(Movie movie, string userEmail, double rating, string comment)
        {
            if (movie.Reviews.Any(r => r.UserEmail.Equals(userEmail, StringComparison.OrdinalIgnoreCase)))
                return (false, "You have already reviewed this movie.");

            if (string.IsNullOrWhiteSpace(comment))
                return (false, "Review comment cannot be empty.");

            if (rating < 1 || rating > 10)
                return (false, "Rating must be from 1 to 10.");

            return (true, "");
        }
    }
}