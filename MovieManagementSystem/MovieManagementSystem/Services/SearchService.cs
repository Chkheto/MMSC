using System;
using System.Collections.Generic;
using System.Linq;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Services
{
    internal class SearchService
    {
        private readonly List<Movie> _movieDb;
        private readonly List<Actor> _actorDb;

        public SearchService(List<Movie> movieDb, List<Actor> actorDb)
        {
            _movieDb = movieDb;
            _actorDb = actorDb;
        }

        public (List<Movie> Movies, List<Actor> Actors) GlobalSearch(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return (new List<Movie>(), new List<Actor>());

            query = query.ToLower().Trim();

            var matchingMovies = _movieDb.Where(m =>
                m.Title.ToLower().Contains(query) ||
                m.ReleaseYear.ToString().Contains(query)
            ).ToList();

            var matchingActors = _actorDb.Where(a =>
                $"{a.FirstName} {a.LastName}".ToLower().Contains(query)
            ).ToList();

            var moviesWithMatchingActors = _movieDb.Where(m =>
                m.Actors.Any(a => $"{a.FirstName} {a.LastName}".ToLower().Contains(query))
            ).ToList();

            var finalMovies = matchingMovies.Union(moviesWithMatchingActors).ToList();

            return (finalMovies, matchingActors);
        }
    }
}