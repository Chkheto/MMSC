using FluentValidation;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Validators
{
internal class MovieValidator : AbstractValidator<Movie>
{
    public MovieValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Title is required.");
        RuleFor(x => x.ReleaseYear).InclusiveBetween(1888, DateTime.Now.Year + 5);
        RuleFor(x => x.Genre).NotEmpty();
    }
}
}