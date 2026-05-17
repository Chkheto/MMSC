using MovieManagementSystem.Models;
using MovieManagementSystem.Validators;

namespace MovieManagementSystem.Services

{ 
internal class AdminService
{
    private readonly List<Movie> _movieDb;
    private readonly List<Actor> _actorDb; 
    private readonly MovieValidator _movieValidator = new();


    public AdminService(List<Movie> movieDb, List<Actor> actorDb)
    {
        _movieDb = movieDb;
        _actorDb = actorDb;
    }

    public void AddMovie(User admin, Movie movie)
    {
        if (!admin.IsAdmin) throw new UnauthorizedAccessException("Admins only.");

        var validationResult = _movieValidator.Validate(movie);
        if (!validationResult.IsValid) return;

        _movieDb.Add(movie);
        Console.WriteLine($"[Admin] Added: {movie.Title}");
    }

  
    public void AddActor(User admin, Actor actor)
    {
        if (!admin.IsAdmin) throw new UnauthorizedAccessException();
        _actorDb.Add(actor);
    }
}
}