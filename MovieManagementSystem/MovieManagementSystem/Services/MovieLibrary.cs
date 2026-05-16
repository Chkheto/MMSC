using MovieManagementSystem.Models;

namespace MovieManagementSystem.Services
{
    internal static class MovieLibrary
    {

                public static List<(Movie Movie, double Rating, List<Actor> Cast)> GetSeedData()
        {
            return new List<(Movie, double, List<Actor>)>
    {
        // 1. STAR WARS: A NEW HOPE
        (new Movie { Title = "Star Wars: A New Hope", Genre = "Sci-Fi", ReleaseYear = 1977, Duration = TimeSpan.FromMinutes(121) }, 8.6,
        new List<Actor> {
            new Actor { FirstName = "Mark", LastName = "Hamill", Age = 74, Biography = "Legendary Jedi who also became the definitive voice of the Joker." },
            new Actor { FirstName = "Harrison", LastName = "Ford", Age = 83, Biography = "The face of Han Solo and Indiana Jones; a true Hollywood titan." },
            new Actor { FirstName = "Carrie", LastName = "Fisher", Age = 60, Biography = "Iconic Princess Leia and a brilliant, sharp-witted script doctor." },
            new Actor { FirstName = "James Earl", LastName = "Jones", Age = 95, Biography = "The most recognizable voice in cinema, from Vader to Mufasa." },
            new Actor { FirstName = "Alec", LastName = "Guinness", Age = 86, Biography = "Classical Shakespearean actor who brought magic to Obi-Wan." },
            new Actor { FirstName = "Peter", LastName = "Cushing", Age = 81, Biography = "Legendary horror star who gave Tarkin his cold authority." },
            new Actor { FirstName = "Anthony", LastName = "Daniels", Age = 80, Biography = "The man inside the gold plating of C-3PO for over 40 years." },
            new Actor { FirstName = "Kenny", LastName = "Baker", Age = 81, Biography = "The heart of R2-D2; the small man who piloted the droid." },
            new Actor { FirstName = "Peter", LastName = "Mayhew", Age = 74, Biography = "The 7-foot-3 actor who made Chewbacca the world's favorite co-pilot." },
            new Actor { FirstName = "David", LastName = "Prowse", Age = 85, Biography = "Bodybuilder who provided the physical menace of Darth Vader." }
        }),

        // 2. THE DARK KNIGHT
        (new Movie { Title = "The Dark Knight", Genre = "Action", ReleaseYear = 2008, Duration = TimeSpan.FromMinutes(152) }, 9.0,
        new List<Actor> {
            new Actor { FirstName = "Christian", LastName = "Bale", Age = 52, Biography = "Master of physical transformation who redefined Batman." },
            new Actor { FirstName = "Heath", LastName = "Ledger", Age = 28, Biography = "Gave a haunting, Oscar-winning performance as the Joker." },
            new Actor { FirstName = "Gary", LastName = "Oldman", Age = 68, Biography = "Chameleon actor who played the grounded Jim Gordon." },
            new Actor { FirstName = "Aaron", LastName = "Eckhart", Age = 58, Biography = "Portrayed the tragic descent of Harvey Dent into Two-Face." },
            new Actor { FirstName = "Michael", LastName = "Caine", Age = 93, Biography = "The emotional anchor of the trilogy as Alfred Pennyworth." },
            new Actor { FirstName = "Morgan", LastName = "Freeman", Age = 88, Biography = "Provided the tech and the wisdom as Lucius Fox." },
            new Actor { FirstName = "Maggie", LastName = "Gyllenhaal", Age = 48, Biography = "Brought depth and intelligence to the role of Rachel Dawes." },
            new Actor { FirstName = "Cillian", LastName = "Murphy", Age = 49, Biography = "Nolan's lucky charm, appearing here as the Scarecrow." },
            new Actor { FirstName = "Eric", LastName = "Roberts", Age = 70, Biography = "Veteran actor who played the mob boss Sal Maroni." },
            new Actor { FirstName = "Chin", LastName = "Han", Age = 56, Biography = "Played Lau, the accountant who thought he could hide from Batman." }
        }),

        // 3. PULP FICTION
        (new Movie { Title = "Pulp Fiction", Genre = "Crime", ReleaseYear = 1994, Duration = TimeSpan.FromMinutes(154) }, 8.9,
        new List<Actor> {
            new Actor { FirstName = "John", LastName = "Travolta", Age = 72, Biography = "Revitalized his career with his cool turn as Vincent Vega." },
            new Actor { FirstName = "Samuel L.", LastName = "Jackson", Age = 77, Biography = "The king of cool, famous for his 'Ezekiel 25:17' speech." },
            new Actor { FirstName = "Uma", LastName = "Thurman", Age = 56, Biography = "Tarantino's muse and the heart of the film's iconic poster." },
            new Actor { FirstName = "Bruce", LastName = "Willis", Age = 71, Biography = "Action icon who showed his dramatic range as Butch the boxer." },
            new Actor { FirstName = "Harvey", LastName = "Keitel", Age = 87, Biography = "The professional 'cleaner' Winston Wolfe." },
            new Actor { FirstName = "Tim", LastName = "Roth", Age = 65, Biography = "British actor who played the diner robber 'Pumpkin'." },
            new Actor { FirstName = "Amanda", LastName = "Plummer", Age = 69, Biography = "Known for her high-intensity role as 'Honey Bunny'." },
            new Actor { FirstName = "Christopher", LastName = "Walken", Age = 83, Biography = "Delivered the most famous monologue about a gold watch." },
            new Actor { FirstName = "Ving", LastName = "Rhames", Age = 67, Biography = "The intimidating presence of boss Marsellus Wallace." },
            new Actor { FirstName = "Eric", LastName = "Stoltz", Age = 64, Biography = "Played the panicked drug dealer Lance." }
        }),

        // 4. INCEPTION
        (new Movie { Title = "Inception", Genre = "Sci-Fi", ReleaseYear = 2010, Duration = TimeSpan.FromMinutes(148) }, 8.8,
        new List<Actor> {
            new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "One of his generation's finest, playing the dream-thief Cobb." },
            new Actor { FirstName = "Joseph", LastName = "Gordon-Levitt", Age = 45, Biography = "Played the point man Arthur, famous for the hallway fight." },
            new Actor { FirstName = "Tom", LastName = "Hardy", Age = 48, Biography = "The charismatic identity-thief Eames." },
            new Actor { FirstName = "Ken", LastName = "Watanabe", Age = 66, Biography = "Japanese icon who played the powerful Mr. Saito." },
            new Actor { FirstName = "Marion", LastName = "Cotillard", Age = 50, Biography = "Oscar winner who played the haunting projection Mal." },
            new Actor { FirstName = "Elliot", LastName = "Page", Age = 39, Biography = "Played the architect Ariadne, the audience's guide to dreams." },
            new Actor { FirstName = "Cillian", LastName = "Murphy", Age = 49, Biography = "Played the target Fischer with quiet vulnerability." },
            new Actor { FirstName = "Michael", LastName = "Caine", Age = 93, Biography = "Appeared as the mentor and father-in-law." },
            new Actor { FirstName = "Tom", LastName = "Berenger", Age = 76, Biography = "Veteran actor playing Browning, the corporate advisor." },
            new Actor { FirstName = "Dileep", LastName = "Rao", Age = 52, Biography = "The chemist Yusuf who drove the van through the dreams." }
        }),

        // 5. THE WOLF OF WALL STREET
        (new Movie { Title = "The Wolf of Wall Street", Genre = "Comedy", ReleaseYear = 2013, Duration = TimeSpan.FromMinutes(180) }, 8.2,
        new List<Actor> {
            new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Gave a high-octane performance as Jordan Belfort." },
            new Actor { FirstName = "Jonah", LastName = "Hill", Age = 42, Biography = "Earned an Oscar nod for his wild role as Donnie Azoff." },
            new Actor { FirstName = "Margot", LastName = "Robbie", Age = 35, Biography = "Her breakout role as Naomi, the Duchess of Bay Ridge." },
            new Actor { FirstName = "Matthew", LastName = "McConaughey", Age = 56, Biography = "Stole the show with his chest-thumping scene." },
            new Actor { FirstName = "Kyle", LastName = "Chandler", Age = 60, Biography = "The straight-arrow FBI agent chasing the Wolf." },
            new Actor { FirstName = "Rob", LastName = "Reiner", Age = 79, Biography = "Director-turned-actor playing Jordan's hot-tempered father." },
            new Actor { FirstName = "Jon", LastName = "Bernthal", Age = 49, Biography = "The tough-guy money launderer Brad." },
            new Actor { FirstName = "Jon", LastName = "Favreau", Age = 59, Biography = "Iron Man director playing the firm's lawyer." },
            new Actor { FirstName = "Jean", LastName = "Dujardin", Age = 53, Biography = "French star playing the corrupt Swiss banker." },
            new Actor { FirstName = "Joanna", LastName = "Lumley", Age = 80, Biography = "British legend playing the sophisticated Aunt Emma." }
        }), 
// 6. THE GODFATHER
(new Movie { Title = "The Godfather", Genre = "Crime", ReleaseYear = 1972, Duration = TimeSpan.FromMinutes(175) }, 9.2,
new List<Actor> {
    new Actor { FirstName = "Marlon", LastName = "Brando", Age = 80, Biography = "Legendary actor who defined Don Vito Corleone." },
    new Actor { FirstName = "Al", LastName = "Pacino", Age = 85, Biography = "Masterful portrayal of Michael Corleone's transformation." },
    new Actor { FirstName = "James", LastName = "Caan", Age = 82, Biography = "Played the hot-headed Sonny Corleone." },
    new Actor { FirstName = "Robert", LastName = "Duvall", Age = 95, Biography = "The calm and calculating Tom Hagen." },
    new Actor { FirstName = "Diane", LastName = "Keaton", Age = 79, Biography = "Portrayed Kay Adams, Michael’s conflicted partner." }
}),

// 7. FIGHT CLUB
(new Movie { Title = "Fight Club", Genre = "Drama", ReleaseYear = 1999, Duration = TimeSpan.FromMinutes(139) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Charismatic and chaotic as Tyler Durden." },
    new Actor { FirstName = "Edward", LastName = "Norton", Age = 57, Biography = "Played the unnamed narrator." },
    new Actor { FirstName = "Helena", LastName = "Bonham Carter", Age = 60, Biography = "Iconic as Marla Singer." }
}),

// 8. FORREST GUMP
(new Movie { Title = "Forrest Gump", Genre = "Drama", ReleaseYear = 1994, Duration = TimeSpan.FromMinutes(142) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hanks", Age = 69, Biography = "Delivered an unforgettable performance as Forrest." },
    new Actor { FirstName = "Robin", LastName = "Wright", Age = 60, Biography = "Played Jenny, Forrest’s lifelong love." },
    new Actor { FirstName = "Gary", LastName = "Sinise", Age = 71, Biography = "Portrayed Lieutenant Dan." }
}),

// 9. THE MATRIX
(new Movie { Title = "The Matrix", Genre = "Sci-Fi", ReleaseYear = 1999, Duration = TimeSpan.FromMinutes(136) }, 8.7,
new List<Actor> {
    new Actor { FirstName = "Keanu", LastName = "Reeves", Age = 62, Biography = "Neo, the chosen one." },
    new Actor { FirstName = "Laurence", LastName = "Fishburne", Age = 65, Biography = "Played Morpheus." },
    new Actor { FirstName = "Carrie-Anne", LastName = "Moss", Age = 58, Biography = "Portrayed Trinity." }
}),

// 10. GLADIATOR
(new Movie { Title = "Gladiator", Genre = "Action", ReleaseYear = 2000, Duration = TimeSpan.FromMinutes(155) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Russell", LastName = "Crowe", Age = 62, Biography = "Oscar-winning role as Maximus." },
    new Actor { FirstName = "Joaquin", LastName = "Phoenix", Age = 52, Biography = "Played the unstable Commodus." }
}),

// 11. TITANIC
(new Movie { Title = "Titanic", Genre = "Romance", ReleaseYear = 1997, Duration = TimeSpan.FromMinutes(195) }, 7.9,
new List<Actor> {
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Played Jack Dawson." },
    new Actor { FirstName = "Kate", LastName = "Winslet", Age = 50, Biography = "Portrayed Rose." }
}),

// 12. INTERSTELLAR
(new Movie { Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(169) }, 8.7,
new List<Actor> {
    new Actor { FirstName = "Matthew", LastName = "McConaughey", Age = 56, Biography = "Played Cooper." },
    new Actor { FirstName = "Anne", LastName = "Hathaway", Age = 43, Biography = "Portrayed Brand." }
}),

// 13. THE SHAWSHANK REDEMPTION
(new Movie { Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994, Duration = TimeSpan.FromMinutes(142) }, 9.3,
new List<Actor> {
    new Actor { FirstName = "Tim", LastName = "Robbins", Age = 67, Biography = "Played Andy Dufresne." },
    new Actor { FirstName = "Morgan", LastName = "Freeman", Age = 88, Biography = "Iconic as Red." }
}),

// 14. AVENGERS: ENDGAME
(new Movie { Title = "Avengers: Endgame", Genre = "Action", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(181) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "Downey Jr.", Age = 61, Biography = "Iron Man." },
    new Actor { FirstName = "Chris", LastName = "Evans", Age = 45, Biography = "Captain America." }
}),

// 15. JOKER
(new Movie { Title = "Joker", Genre = "Drama", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(122) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Joaquin", LastName = "Phoenix", Age = 52, Biography = "Oscar-winning Joker." }
}),

// 16. THE LORD OF THE RINGS: THE FELLOWSHIP OF THE RING
(new Movie { Title = "LOTR: Fellowship of the Ring", Genre = "Fantasy", ReleaseYear = 2001, Duration = TimeSpan.FromMinutes(178) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Elijah", LastName = "Wood", Age = 45, Biography = "Frodo Baggins." },
    new Actor { FirstName = "Ian", LastName = "McKellen", Age = 87, Biography = "Gandalf the Grey." }
}),

// 17. THE SOCIAL NETWORK
(new Movie { Title = "The Social Network", Genre = "Drama", ReleaseYear = 2010, Duration = TimeSpan.FromMinutes(120) }, 7.8,
new List<Actor> {
    new Actor { FirstName = "Jesse", LastName = "Eisenberg", Age = 43, Biography = "Mark Zuckerberg." }
}),

// 18. WHIPLASH
(new Movie { Title = "Whiplash", Genre = "Drama", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(107) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Miles", LastName = "Teller", Age = 39, Biography = "Ambitious drummer." },
    new Actor { FirstName = "J.K.", LastName = "Simmons", Age = 71, Biography = "Oscar-winning performance." }
}),

// 19. DUNE
(new Movie { Title = "Dune", Genre = "Sci-Fi", ReleaseYear = 2021, Duration = TimeSpan.FromMinutes(155) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Timothée", LastName = "Chalamet", Age = 30, Biography = "Paul Atreides." }
}),

// 20. THE BATMAN
(new Movie { Title = "The Batman", Genre = "Action", ReleaseYear = 2022, Duration = TimeSpan.FromMinutes(176) }, 7.9,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "Pattinson", Age = 40, Biography = "Dark take on Batman." }
}),

// 21. OPPENHEIMER
(new Movie { Title = "Oppenheimer", Genre = "Drama", ReleaseYear = 2023, Duration = TimeSpan.FromMinutes(180) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Cillian", LastName = "Murphy", Age = 49, Biography = "Played Oppenheimer." }
}),

// 22. BARBIE
(new Movie { Title = "Barbie", Genre = "Comedy", ReleaseYear = 2023, Duration = TimeSpan.FromMinutes(114) }, 7.2,
new List<Actor> {
    new Actor { FirstName = "Margot", LastName = "Robbie", Age = 35, Biography = "Barbie." }
}),

// 23. SPIDER-MAN: NO WAY HOME
(new Movie { Title = "Spider-Man: No Way Home", Genre = "Action", ReleaseYear = 2021, Duration = TimeSpan.FromMinutes(148) }, 8.2,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Holland", Age = 30, Biography = "Spider-Man." }
}),

// 24. DEADPOOL
(new Movie { Title = "Deadpool", Genre = "Action", ReleaseYear = 2016, Duration = TimeSpan.FromMinutes(108) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Ryan", LastName = "Reynolds", Age = 50, Biography = "Fourth-wall-breaking antihero." }
}),

// 25. JOHN WICK
(new Movie { Title = "John Wick", Genre = "Action", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(101) }, 7.4,
new List<Actor> {
    new Actor { FirstName = "Keanu", LastName = "Reeves", Age = 62, Biography = "Legendary hitman." }
}),

// 26. MAD MAX: FURY ROAD
(new Movie { Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015, Duration = TimeSpan.FromMinutes(120) }, 8.1,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hardy", Age = 48, Biography = "Max Rockatansky." },
    new Actor { FirstName = "Charlize", LastName = "Theron", Age = 51, Biography = "Imperator Furiosa." }
}),

// 27. THE PRESTIGE
(new Movie { Title = "The Prestige", Genre = "Drama", ReleaseYear = 2006, Duration = TimeSpan.FromMinutes(130) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Christian", LastName = "Bale", Age = 52, Biography = "Magician rivalry." },
    new Actor { FirstName = "Hugh", LastName = "Jackman", Age = 57, Biography = "Obsessed performer." }
}),

// 28. PARASITE
(new Movie { Title = "Parasite", Genre = "Thriller", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(132) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Song", LastName = "Kang-ho", Age = 59, Biography = "Lead role in Oscar-winning film." }
}),

// 29. LA LA LAND
(new Movie { Title = "La La Land", Genre = "Musical", ReleaseYear = 2016, Duration = TimeSpan.FromMinutes(128) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Ryan", LastName = "Gosling", Age = 45, Biography = "Jazz musician." },
    new Actor { FirstName = "Emma", LastName = "Stone", Age = 38, Biography = "Aspiring actress." }
}),

// 30. THE HANGOVER
(new Movie { Title = "The Hangover", Genre = "Comedy", ReleaseYear = 2009, Duration = TimeSpan.FromMinutes(100) }, 7.7,
new List<Actor> {
    new Actor { FirstName = "Bradley", LastName = "Cooper", Age = 51, Biography = "Leader of the group." },
    new Actor { FirstName = "Zach", LastName = "Galifianakis", Age = 57, Biography = "Scene-stealing Alan." }
}),
            };
        }
    }
}