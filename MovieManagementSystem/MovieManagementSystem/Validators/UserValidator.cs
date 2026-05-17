using System;
using System.Text.RegularExpressions;

namespace MovieManagementSystem.Validators
{
    public static class UserValidator
    {
        public static ValidationResult ValidateRegistration(string firstName, string email, string password)
        {
            // 1. Check for empty fields
            if (string.IsNullOrWhiteSpace(firstName))
            {
                return new ValidationResult { IsValid = false, ErrorMessage = "First name cannot be empty." };
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                return new ValidationResult { IsValid = false, ErrorMessage = "Email address cannot be empty." };
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return new ValidationResult { IsValid = false, ErrorMessage = "Password cannot be empty." };
            }

            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase))
            {
                return new ValidationResult { IsValid = false, ErrorMessage = "The email address entered is incorrectly formatted (e.g., name@example.com)." };
            }

            if (password.Length < 6)
            {
                return new ValidationResult { IsValid = false, ErrorMessage = "Password must be at least 6 characters long." };
            }

            return new ValidationResult { IsValid = true };
        }
    }

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}