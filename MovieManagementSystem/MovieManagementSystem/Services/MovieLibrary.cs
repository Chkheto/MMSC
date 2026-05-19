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
    new Actor { FirstName = "Diane", LastName = "Keaton", Age = 79, Biography = "Portrayed Kay Adams, Michael’s conflicted partner." },
    new Actor { FirstName = "John", LastName = "Cazale", Age = 42, Biography = "Played the fragile yet loyal Fredo Corleone." },
    new Actor { FirstName = "Talia", LastName = "Shire", Age = 80, Biography = "Played Connie Corleone with emotional depth." },
    new Actor { FirstName = "Richard", LastName = "Castellano", Age = 55, Biography = "Memorable as the loyal caporegime Clemenza." },
    new Actor { FirstName = "Sterling", LastName = "Hayden", Age = 70, Biography = "Played the corrupt police captain McCluskey." },
    new Actor { FirstName = "Abe", LastName = "Vigoda", Age = 94, Biography = "Played mob boss Tessio." }
}),

// 7. FIGHT CLUB
(new Movie { Title = "Fight Club", Genre = "Drama", ReleaseYear = 1999, Duration = TimeSpan.FromMinutes(139) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Charismatic and chaotic as Tyler Durden." },
    new Actor { FirstName = "Edward", LastName = "Norton", Age = 57, Biography = "Played the unnamed narrator." },
    new Actor { FirstName = "Helena", LastName = "Bonham Carter", Age = 60, Biography = "Iconic as Marla Singer." },
    new Actor { FirstName = "Meat", LastName = "Loaf", Age = 74, Biography = "Played the tragic Bob with surprising heart." },
    new Actor { FirstName = "Jared", LastName = "Leto", Age = 55, Biography = "Played Angel Face in the fight club." },
    new Actor { FirstName = "Zach", LastName = "Grenier", Age = 72, Biography = "Played the narrator's demanding boss." },
    new Actor { FirstName = "Holt", LastName = "McCallany", Age = 62, Biography = "Played the Mechanic in Project Mayhem." },
    new Actor { FirstName = "Eion", LastName = "Bailey", Age = 50, Biography = "Played Ricky, a devoted fight club member." },
    new Actor { FirstName = "Richmond", LastName = "Arquette", Age = 63, Biography = "Appeared as one of the Project Mayhem recruits." },
    new Actor { FirstName = "David", LastName = "Andrews", Age = 69, Biography = "Played Thomas, part of the support groups." }
}),

// 8. FORREST GUMP
(new Movie { Title = "Forrest Gump", Genre = "Drama", ReleaseYear = 1994, Duration = TimeSpan.FromMinutes(142) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hanks", Age = 69, Biography = "Delivered an unforgettable performance as Forrest." },
    new Actor { FirstName = "Robin", LastName = "Wright", Age = 60, Biography = "Played Jenny, Forrest’s lifelong love." },
    new Actor { FirstName = "Gary", LastName = "Sinise", Age = 71, Biography = "Portrayed Lieutenant Dan." },
    new Actor { FirstName = "Sally", LastName = "Field", Age = 80, Biography = "Played Forrest’s wise and caring mother." },
    new Actor { FirstName = "Mykelti", LastName = "Williamson", Age = 68, Biography = "Played Forrest’s best friend Bubba." },
    new Actor { FirstName = "Haley", LastName = "Joel Osment", Age = 38, Biography = "Played Forrest Jr." },
    new Actor { FirstName = "Michael", LastName = "Conner Humphreys", Age = 42, Biography = "Played young Forrest Gump." },
    new Actor { FirstName = "Hanna", LastName = "Hall", Age = 41, Biography = "Played young Jenny." },
    new Actor { FirstName = "Sam", LastName = "Anderson", Age = 80, Biography = "Played the school principal." },
    new Actor { FirstName = "Siobhan", LastName = "Fallon", Age = 65, Biography = "Played the school bus driver." }
}),

// 9. THE MATRIX
(new Movie { Title = "The Matrix", Genre = "Sci-Fi", ReleaseYear = 1999, Duration = TimeSpan.FromMinutes(136) }, 8.7,
new List<Actor> {
    new Actor { FirstName = "Keanu", LastName = "Reeves", Age = 62, Biography = "Neo, the chosen one." },
    new Actor { FirstName = "Laurence", LastName = "Fishburne", Age = 65, Biography = "Played Morpheus." },
    new Actor { FirstName = "Carrie-Anne", LastName = "Moss", Age = 58, Biography = "Portrayed Trinity." },
    new Actor { FirstName = "Hugo", LastName = "Weaving", Age = 66, Biography = "Played the terrifying Agent Smith." },
    new Actor { FirstName = "Joe", LastName = "Pantoliano", Age = 75, Biography = "Played the traitor Cypher." },
    new Actor { FirstName = "Gloria", LastName = "Foster", Age = 90, Biography = "Played the mysterious Oracle." },
    new Actor { FirstName = "Marcus", LastName = "Chong", Age = 58, Biography = "Played Tank aboard the Nebuchadnezzar." },
    new Actor { FirstName = "Julian", LastName = "Arahanga", Age = 54, Biography = "Played Apoc." },
    new Actor { FirstName = "Matt", LastName = "Doran", Age = 49, Biography = "Played the betrayed hacker Mouse." },
    new Actor { FirstName = "Belinda", LastName = "McClory", Age = 57, Biography = "Played Switch." }
}),

// 10. GLADIATOR
(new Movie { Title = "Gladiator", Genre = "Action", ReleaseYear = 2000, Duration = TimeSpan.FromMinutes(155) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Russell", LastName = "Crowe", Age = 62, Biography = "Oscar-winning role as Maximus." },
    new Actor { FirstName = "Joaquin", LastName = "Phoenix", Age = 52, Biography = "Played the unstable Commodus." },
    new Actor { FirstName = "Connie", LastName = "Nielsen", Age = 61, Biography = "Played Lucilla, sister of Commodus." },
    new Actor { FirstName = "Oliver", LastName = "Reed", Age = 61, Biography = "Played the gladiator trainer Proximo." },
    new Actor { FirstName = "Richard", LastName = "Harris", Age = 72, Biography = "Played Emperor Marcus Aurelius." },
    new Actor { FirstName = "Derek", LastName = "Jacobi", Age = 88, Biography = "Played Senator Gracchus." },
    new Actor { FirstName = "Djimon", LastName = "Hounsou", Age = 62, Biography = "Played fellow gladiator Juba." },
    new Actor { FirstName = "David", LastName = "Schofield", Age = 74, Biography = "Played the loyal senator Falco." },
    new Actor { FirstName = "John", LastName = "Shrapnel", Age = 78, Biography = "Played Senator Gaius." },
    new Actor { FirstName = "Tomas", LastName = "Arana", Age = 68, Biography = "Played Quintus, Maximus’ former ally." }
}),
// 11. TITANIC
(new Movie { Title = "Titanic", Genre = "Romance", ReleaseYear = 1997, Duration = TimeSpan.FromMinutes(195) }, 7.9,
new List<Actor> {
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Played Jack Dawson." },
    new Actor { FirstName = "Kate", LastName = "Winslet", Age = 50, Biography = "Portrayed Rose." },
    new Actor { FirstName = "Billy", LastName = "Zane", Age = 60, Biography = "Played the wealthy and arrogant Cal Hockley." },
    new Actor { FirstName = "Kathy", LastName = "Bates", Age = 78, Biography = "Played the outspoken Molly Brown." },
    new Actor { FirstName = "Frances", LastName = "Fisher", Age = 74, Biography = "Played Rose’s controlling mother Ruth." },
    new Actor { FirstName = "Gloria", LastName = "Stuart", Age = 100, Biography = "Played the elderly Rose recounting her memories." },
    new Actor { FirstName = "Bill", LastName = "Paxton", Age = 62, Biography = "Played treasure hunter Brock Lovett." },
    new Actor { FirstName = "Victor", LastName = "Garber", Age = 77, Biography = "Played Titanic designer Thomas Andrews." },
    new Actor { FirstName = "Bernard", LastName = "Hill", Age = 80, Biography = "Played Captain Edward Smith." },
    new Actor { FirstName = "David", LastName = "Warner", Age = 81, Biography = "Played Rose’s bodyguard Spicer Lovejoy." }
}),

// 12. INTERSTELLAR
(new Movie { Title = "Interstellar", Genre = "Sci-Fi", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(169) }, 8.7,
new List<Actor> {
    new Actor { FirstName = "Matthew", LastName = "McConaughey", Age = 56, Biography = "Played Cooper." },
    new Actor { FirstName = "Anne", LastName = "Hathaway", Age = 43, Biography = "Portrayed Brand." },
    new Actor { FirstName = "Jessica", LastName = "Chastain", Age = 49, Biography = "Played the adult Murph." },
    new Actor { FirstName = "Mackenzie", LastName = "Foy", Age = 26, Biography = "Played young Murph." },
    new Actor { FirstName = "Michael", LastName = "Caine", Age = 93, Biography = "Played Professor Brand." },
    new Actor { FirstName = "Matt", LastName = "Damon", Age = 56, Biography = "Played the stranded Dr. Mann." },
    new Actor { FirstName = "Casey", LastName = "Affleck", Age = 51, Biography = "Played Tom Cooper." },
    new Actor { FirstName = "John", LastName = "Lithgow", Age = 81, Biography = "Played Donald, Cooper’s father-in-law." },
    new Actor { FirstName = "Wes", LastName = "Bentley", Age = 48, Biography = "Played Doyle." },
    new Actor { FirstName = "David", LastName = "Gyasi", Age = 46, Biography = "Played Romilly." }
}),

// 13. THE SHAWSHANK REDEMPTION
(new Movie { Title = "The Shawshank Redemption", Genre = "Drama", ReleaseYear = 1994, Duration = TimeSpan.FromMinutes(142) }, 9.3,
new List<Actor> {
    new Actor { FirstName = "Tim", LastName = "Robbins", Age = 67, Biography = "Played Andy Dufresne." },
    new Actor { FirstName = "Morgan", LastName = "Freeman", Age = 88, Biography = "Iconic as Red." },
    new Actor { FirstName = "Bob", LastName = "Gunton", Age = 81, Biography = "Played the cruel Warden Norton." },
    new Actor { FirstName = "William", LastName = "Sadler", Age = 76, Biography = "Played Heywood." },
    new Actor { FirstName = "Clancy", LastName = "Brown", Age = 67, Biography = "Played the brutal Captain Hadley." },
    new Actor { FirstName = "Gil", LastName = "Bellows", Age = 58, Biography = "Played Tommy Williams." },
    new Actor { FirstName = "James", LastName = "Whitmore", Age = 87, Biography = "Played Brooks Hatlen." },
    new Actor { FirstName = "Mark", LastName = "Rolston", Age = 69, Biography = "Played inmate Bogs Diamond." },
    new Actor { FirstName = "Jeffrey", LastName = "DeMunn", Age = 79, Biography = "Played district attorney Dekins." },
    new Actor { FirstName = "Larry", LastName = "Brandenburg", Age = 68, Biography = "Played Skeet." }
}),

// 14. AVENGERS: ENDGAME
(new Movie { Title = "Avengers: Endgame", Genre = "Action", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(181) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "Downey Jr.", Age = 61, Biography = "Iron Man." },
    new Actor { FirstName = "Chris", LastName = "Evans", Age = 45, Biography = "Captain America." },
    new Actor { FirstName = "Chris", LastName = "Hemsworth", Age = 43, Biography = "Thor, God of Thunder." },
    new Actor { FirstName = "Mark", LastName = "Ruffalo", Age = 59, Biography = "Bruce Banner / Hulk." },
    new Actor { FirstName = "Scarlett", LastName = "Johansson", Age = 42, Biography = "Black Widow." },
    new Actor { FirstName = "Jeremy", LastName = "Renner", Age = 55, Biography = "Hawkeye." },
    new Actor { FirstName = "Josh", LastName = "Brolin", Age = 58, Biography = "Played the mighty Thanos." },
    new Actor { FirstName = "Paul", LastName = "Rudd", Age = 57, Biography = "Ant-Man." },
    new Actor { FirstName = "Brie", LastName = "Larson", Age = 37, Biography = "Captain Marvel." },
    new Actor { FirstName = "Tom", LastName = "Holland", Age = 30, Biography = "Spider-Man." }
}),

// 15. JOKER
(new Movie { Title = "Joker", Genre = "Drama", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(122) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Joaquin", LastName = "Phoenix", Age = 52, Biography = "Oscar-winning Joker." },
    new Actor { FirstName = "Robert", LastName = "De Niro", Age = 83, Biography = "Played talk show host Murray Franklin." },
    new Actor { FirstName = "Zazie", LastName = "Beetz", Age = 35, Biography = "Played Sophie Dumond." },
    new Actor { FirstName = "Frances", LastName = "Conroy", Age = 72, Biography = "Played Arthur’s mother Penny Fleck." },
    new Actor { FirstName = "Brett", LastName = "Cullen", Age = 70, Biography = "Played Thomas Wayne." },
    new Actor { FirstName = "Shea", LastName = "Whigham", Age = 57, Biography = "Played Detective Burke." },
    new Actor { FirstName = "Bill", LastName = "Camp", Age = 65, Biography = "Played Detective Garrity." },
    new Actor { FirstName = "Glenn", LastName = "Fleshler", Age = 57, Biography = "Played Randall." },
    new Actor { FirstName = "Leigh", LastName = "Gill", Age = 41, Biography = "Played Gary, Arthur’s co-worker." },
    new Actor { FirstName = "Douglas", LastName = "Hodge", Age = 66, Biography = "Played Alfred Pennyworth." }
}),

// 16. THE LORD OF THE RINGS: THE FELLOWSHIP OF THE RING
(new Movie { Title = "LOTR: Fellowship of the Ring", Genre = "Fantasy", ReleaseYear = 2001, Duration = TimeSpan.FromMinutes(178) }, 8.8,
new List<Actor> {
    new Actor { FirstName = "Elijah", LastName = "Wood", Age = 45, Biography = "Frodo Baggins." },
    new Actor { FirstName = "Ian", LastName = "McKellen", Age = 87, Biography = "Gandalf the Grey." },
    new Actor { FirstName = "Viggo", LastName = "Mortensen", Age = 68, Biography = "Played Aragorn." },
    new Actor { FirstName = "Sean", LastName = "Astin", Age = 55, Biography = "Played Samwise Gamgee." },
    new Actor { FirstName = "Orlando", LastName = "Bloom", Age = 49, Biography = "Played Legolas." },
    new Actor { FirstName = "John", LastName = "Rhys-Davies", Age = 82, Biography = "Played Gimli." },
    new Actor { FirstName = "Liv", LastName = "Tyler", Age = 49, Biography = "Played Arwen." },
    new Actor { FirstName = "Cate", LastName = "Blanchett", Age = 57, Biography = "Played Galadriel." },
    new Actor { FirstName = "Sean", LastName = "Bean", Age = 67, Biography = "Played Boromir." },
    new Actor { FirstName = "Dominic", LastName = "Monaghan", Age = 50, Biography = "Played Merry." }
}),

// 17. THE SOCIAL NETWORK
(new Movie { Title = "The Social Network", Genre = "Drama", ReleaseYear = 2010, Duration = TimeSpan.FromMinutes(120) }, 7.8,
new List<Actor> {
    new Actor { FirstName = "Jesse", LastName = "Eisenberg", Age = 43, Biography = "Mark Zuckerberg." },
    new Actor { FirstName = "Andrew", LastName = "Garfield", Age = 43, Biography = "Played Eduardo Saverin." },
    new Actor { FirstName = "Justin", LastName = "Timberlake", Age = 45, Biography = "Played Sean Parker." },
    new Actor { FirstName = "Armie", LastName = "Hammer", Age = 40, Biography = "Played the Winklevoss twins." },
    new Actor { FirstName = "Max", LastName = "Minghella", Age = 41, Biography = "Played Divya Narendra." },
    new Actor { FirstName = "Rooney", LastName = "Mara", Age = 41, Biography = "Played Erica Albright." },
    new Actor { FirstName = "Brenda", LastName = "Song", Age = 38, Biography = "Played Christy Lee." },
    new Actor { FirstName = "Rashida", LastName = "Jones", Age = 50, Biography = "Played Marilyn Delpy." },
    new Actor { FirstName = "John", LastName = "Getz", Age = 79, Biography = "Played Sy, Eduardo’s father." },
    new Actor { FirstName = "David", LastName = "Selby", Age = 84, Biography = "Played Gage, the lawyer." }
}),

// 18. WHIPLASH
(new Movie { Title = "Whiplash", Genre = "Drama", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(107) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Miles", LastName = "Teller", Age = 39, Biography = "Ambitious drummer." },
    new Actor { FirstName = "J.K.", LastName = "Simmons", Age = 71, Biography = "Oscar-winning performance." },
    new Actor { FirstName = "Melissa", LastName = "Benoist", Age = 38, Biography = "Played Nicole." },
    new Actor { FirstName = "Paul", LastName = "Reiser", Age = 69, Biography = "Played Andrew’s father." },
    new Actor { FirstName = "Austin", LastName = "Stowell", Age = 42, Biography = "Played rival drummer Ryan." },
    new Actor { FirstName = "Nate", LastName = "Lang", Age = 47, Biography = "Played Carl Tanner." },
    new Actor { FirstName = "Chris", LastName = "Mulkey", Age = 78, Biography = "Played Uncle Frank." },
    new Actor { FirstName = "Damon", LastName = "Gupton", Age = 53, Biography = "Played Mr. Kramer." },
    new Actor { FirstName = "Suanne", LastName = "Spoke", Age = 74, Biography = "Played Andrew’s mother." },
    new Actor { FirstName = "C.J.", LastName = "Vana", Age = 40, Biography = "Played Metalhead drummer." }
}),

// 19. DUNE
(new Movie { Title = "Dune", Genre = "Sci-Fi", ReleaseYear = 2021, Duration = TimeSpan.FromMinutes(155) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Timothée", LastName = "Chalamet", Age = 30, Biography = "Paul Atreides." },
    new Actor { FirstName = "Rebecca", LastName = "Ferguson", Age = 42, Biography = "Played Lady Jessica." },
    new Actor { FirstName = "Oscar", LastName = "Isaac", Age = 47, Biography = "Played Duke Leto Atreides." },
    new Actor { FirstName = "Zendaya", LastName = "", Age = 30, Biography = "Played Chani." },
    new Actor { FirstName = "Jason", LastName = "Momoa", Age = 47, Biography = "Played Duncan Idaho." },
    new Actor { FirstName = "Josh", LastName = "Brolin", Age = 58, Biography = "Played Gurney Halleck." },
    new Actor { FirstName = "Javier", LastName = "Bardem", Age = 57, Biography = "Played Stilgar." },
    new Actor { FirstName = "Stellan", LastName = "Skarsgård", Age = 75, Biography = "Played Baron Harkonnen." },
    new Actor { FirstName = "Dave", LastName = "Bautista", Age = 57, Biography = "Played Glossu Rabban." },
    new Actor { FirstName = "David", LastName = "Dastmalchian", Age = 51, Biography = "Played Piter De Vries." }
}),

// 20. THE BATMAN
(new Movie { Title = "The Batman", Genre = "Action", ReleaseYear = 2022, Duration = TimeSpan.FromMinutes(176) }, 7.9,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "Pattinson", Age = 40, Biography = "Dark take on Batman." },
    new Actor { FirstName = "Zoë", LastName = "Kravitz", Age = 38, Biography = "Played Selina Kyle / Catwoman." },
    new Actor { FirstName = "Paul", LastName = "Dano", Age = 42, Biography = "Played the Riddler." },
    new Actor { FirstName = "Colin", LastName = "Farrell", Age = 50, Biography = "Played the Penguin." },
    new Actor { FirstName = "Jeffrey", LastName = "Wright", Age = 61, Biography = "Played James Gordon." },
    new Actor { FirstName = "Andy", LastName = "Serkis", Age = 62, Biography = "Played Alfred Pennyworth." },
    new Actor { FirstName = "John", LastName = "Turturro", Age = 69, Biography = "Played Carmine Falcone." },
    new Actor { FirstName = "Peter", LastName = "Sarsgaard", Age = 55, Biography = "Played District Attorney Colson." },
    new Actor { FirstName = "Barry", LastName = "Keoghan", Age = 34, Biography = "Made a chilling appearance as Joker." },
    new Actor { FirstName = "Jayme", LastName = "Lawson", Age = 28, Biography = "Played mayoral candidate Bella Reál." }
}),

// 21. OPPENHEIMER
(new Movie { Title = "Oppenheimer", Genre = "Drama", ReleaseYear = 2023, Duration = TimeSpan.FromMinutes(180) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Cillian", LastName = "Murphy", Age = 49, Biography = "Played Oppenheimer." },
    new Actor { FirstName = "Emily", LastName = "Blunt", Age = 43, Biography = "Played Kitty Oppenheimer." },
    new Actor { FirstName = "Matt", LastName = "Damon", Age = 56, Biography = "Played General Leslie Groves." },
    new Actor { FirstName = "Robert", LastName = "Downey Jr.", Age = 61, Biography = "Played Lewis Strauss." },
    new Actor { FirstName = "Florence", LastName = "Pugh", Age = 31, Biography = "Played Jean Tatlock." },
    new Actor { FirstName = "Josh", LastName = "Hartnett", Age = 48, Biography = "Played Ernest Lawrence." },
    new Actor { FirstName = "Casey", LastName = "Affleck", Age = 51, Biography = "Played Boris Pash." },
    new Actor { FirstName = "Rami", LastName = "Malek", Age = 45, Biography = "Played David Hill." },
    new Actor { FirstName = "Kenneth", LastName = "Branagh", Age = 66, Biography = "Played Niels Bohr." },
    new Actor { FirstName = "Benny", LastName = "Safdie", Age = 40, Biography = "Played Edward Teller." }
}),

// 22. BARBIE
(new Movie { Title = "Barbie", Genre = "Comedy", ReleaseYear = 2023, Duration = TimeSpan.FromMinutes(114) }, 7.2,
new List<Actor> {
    new Actor { FirstName = "Margot", LastName = "Robbie", Age = 35, Biography = "Barbie." },
    new Actor { FirstName = "Ryan", LastName = "Gosling", Age = 45, Biography = "Played Ken." },
    new Actor { FirstName = "America", LastName = "Ferrera", Age = 42, Biography = "Played Gloria." },
    new Actor { FirstName = "Kate", LastName = "McKinnon", Age = 42, Biography = "Played Weird Barbie." },
    new Actor { FirstName = "Issa", LastName = "Rae", Age = 41, Biography = "Played President Barbie." },
    new Actor { FirstName = "Simu", LastName = "Liu", Age = 37, Biography = "Played rival Ken." },
    new Actor { FirstName = "Michael", LastName = "Cera", Age = 38, Biography = "Played Allan." },
    new Actor { FirstName = "Will", LastName = "Ferrell", Age = 59, Biography = "Played the Mattel CEO." },
    new Actor { FirstName = "Hari", LastName = "Nef", Age = 34, Biography = "Played Doctor Barbie." },
    new Actor { FirstName = "Dua", LastName = "Lipa", Age = 31, Biography = "Played Mermaid Barbie." }
}),

// 23. SPIDER-MAN: NO WAY HOME
(new Movie { Title = "Spider-Man: No Way Home", Genre = "Action", ReleaseYear = 2021, Duration = TimeSpan.FromMinutes(148) }, 8.2,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Holland", Age = 30, Biography = "Spider-Man." },
    new Actor { FirstName = "Zendaya", LastName = "", Age = 30, Biography = "Played MJ." },
    new Actor { FirstName = "Benedict", LastName = "Cumberbatch", Age = 50, Biography = "Played Doctor Strange." },
    new Actor { FirstName = "Jacob", LastName = "Batalon", Age = 30, Biography = "Played Ned Leeds." },
    new Actor { FirstName = "Willem", LastName = "Dafoe", Age = 71, Biography = "Returned as Green Goblin." },
    new Actor { FirstName = "Alfred", LastName = "Molina", Age = 73, Biography = "Returned as Doctor Octopus." },
    new Actor { FirstName = "Jamie", LastName = "Foxx", Age = 59, Biography = "Returned as Electro." },
    new Actor { FirstName = "Andrew", LastName = "Garfield", Age = 43, Biography = "Returned as Spider-Man." },
    new Actor { FirstName = "Tobey", LastName = "Maguire", Age = 51, Biography = "Returned as Spider-Man." },
    new Actor { FirstName = "Marisa", LastName = "Tomei", Age = 62, Biography = "Played Aunt May." }
}),

// 24. DEADPOOL
(new Movie { Title = "Deadpool", Genre = "Action", ReleaseYear = 2016, Duration = TimeSpan.FromMinutes(108) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Ryan", LastName = "Reynolds", Age = 50, Biography = "Fourth-wall-breaking antihero." },
    new Actor { FirstName = "Morena", LastName = "Baccarin", Age = 47, Biography = "Played Vanessa." },
    new Actor { FirstName = "Ed", LastName = "Skrein", Age = 43, Biography = "Played Ajax." },
    new Actor { FirstName = "T.J.", LastName = "Miller", Age = 45, Biography = "Played Weasel." },
    new Actor { FirstName = "Gina", LastName = "Carano", Age = 44, Biography = "Played Angel Dust." },
    new Actor { FirstName = "Brianna", LastName = "Hildebrand", Age = 30, Biography = "Played Negasonic Teenage Warhead." },
    new Actor { FirstName = "Stefan", LastName = "Kapičić", Age = 48, Biography = "Voice of Colossus." },
    new Actor { FirstName = "Leslie", LastName = "Uggams", Age = 83, Biography = "Played Blind Al." },
    new Actor { FirstName = "Karan", LastName = "Soni", Age = 36, Biography = "Played Dopinder." },
    new Actor { FirstName = "Jed", LastName = "Rees", Age = 55, Biography = "Played Recruiter." }
}),

// 25. JOHN WICK
(new Movie { Title = "John Wick", Genre = "Action", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(101) }, 7.4,
new List<Actor> {
    new Actor { FirstName = "Keanu", LastName = "Reeves", Age = 62, Biography = "Legendary hitman." },
    new Actor { FirstName = "Michael", LastName = "Nyqvist", Age = 66, Biography = "Played Russian crime boss Viggo Tarasov." },
    new Actor { FirstName = "Alfie", LastName = "Allen", Age = 40, Biography = "Played Iosef Tarasov." },
    new Actor { FirstName = "Willem", LastName = "Dafoe", Age = 71, Biography = "Played sniper assassin Marcus." },
    new Actor { FirstName = "Ian", LastName = "McShane", Age = 84, Biography = "Played Winston, manager of the Continental." },
    new Actor { FirstName = "John", LastName = "Leguizamo", Age = 66, Biography = "Played Aurelio, the chop shop owner." },
    new Actor { FirstName = "Bridget", LastName = "Moynahan", Age = 55, Biography = "Played Helen Wick." },
    new Actor { FirstName = "Dean", LastName = "Winters", Age = 62, Biography = "Played Avi." },
    new Actor { FirstName = "Adrianne", LastName = "Palicki", Age = 42, Biography = "Played Ms. Perkins." },
    new Actor { FirstName = "Lance", LastName = "Reddick", Age = 61, Biography = "Played Charon." }
}),

// 26. MAD MAX: FURY ROAD
(new Movie { Title = "Mad Max: Fury Road", Genre = "Action", ReleaseYear = 2015, Duration = TimeSpan.FromMinutes(120) }, 8.1,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hardy", Age = 48, Biography = "Max Rockatansky." },
    new Actor { FirstName = "Charlize", LastName = "Theron", Age = 51, Biography = "Imperator Furiosa." },
    new Actor { FirstName = "Nicholas", LastName = "Hoult", Age = 37, Biography = "Played Nux." },
    new Actor { FirstName = "Hugh", LastName = "Keays-Byrne", Age = 73, Biography = "Played Immortan Joe." },
    new Actor { FirstName = "Rosie", LastName = "Huntington-Whiteley", Age = 39, Biography = "Played The Splendid Angharad." },
    new Actor { FirstName = "Zoë", LastName = "Kravitz", Age = 38, Biography = "Played Toast the Knowing." },
    new Actor { FirstName = "Riley", LastName = "Keough", Age = 37, Biography = "Played Capable." },
    new Actor { FirstName = "Abbey", LastName = "Lee", Age = 39, Biography = "Played The Dag." },
    new Actor { FirstName = "Nathan", LastName = "Jones", Age = 53, Biography = "Played Rictus Erectus." },
    new Actor { FirstName = "Josh", LastName = "Helman", Age = 40, Biography = "Played Slit." }
}),

// 27. THE PRESTIGE
(new Movie { Title = "The Prestige", Genre = "Drama", ReleaseYear = 2006, Duration = TimeSpan.FromMinutes(130) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Christian", LastName = "Bale", Age = 52, Biography = "Magician rivalry." },
    new Actor { FirstName = "Hugh", LastName = "Jackman", Age = 57, Biography = "Obsessed performer." },
    new Actor { FirstName = "Michael", LastName = "Caine", Age = 93, Biography = "Played mentor Cutter." },
    new Actor { FirstName = "Scarlett", LastName = "Johansson", Age = 42, Biography = "Played assistant Olivia Wenscombe." },
    new Actor { FirstName = "Rebecca", LastName = "Hall", Age = 44, Biography = "Played Sarah Borden." },
    new Actor { FirstName = "Andy", LastName = "Serkis", Age = 62, Biography = "Played Mr. Alley." },
    new Actor { FirstName = "David", LastName = "Bowie", Age = 69, Biography = "Played inventor Nikola Tesla." },
    new Actor { FirstName = "Piper", LastName = "Perabo", Age = 50, Biography = "Played Julia McCullough." },
    new Actor { FirstName = "Samantha", LastName = "Mahurin", Age = 36, Biography = "Played Jess Borden." },
    new Actor { FirstName = "Daniel", LastName = "Davis", Age = 80, Biography = "Played Judge." }
}),

// 28. PARASITE
(new Movie { Title = "Parasite", Genre = "Thriller", ReleaseYear = 2019, Duration = TimeSpan.FromMinutes(132) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Song", LastName = "Kang-ho", Age = 59, Biography = "Lead role in Oscar-winning film." },
    new Actor { FirstName = "Lee", LastName = "Sun-kyun", Age = 49, Biography = "Played Park Dong-ik." },
    new Actor { FirstName = "Cho", LastName = "Yeo-jeong", Age = 45, Biography = "Played Yeon-kyo." },
    new Actor { FirstName = "Choi", LastName = "Woo-shik", Age = 36, Biography = "Played Ki-woo." },
    new Actor { FirstName = "Park", LastName = "So-dam", Age = 35, Biography = "Played Ki-jung." },
    new Actor { FirstName = "Jang", LastName = "Hye-jin", Age = 51, Biography = "Played Chung-sook." },
    new Actor { FirstName = "Lee", LastName = "Jung-eun", Age = 56, Biography = "Played Moon-gwang." },
    new Actor { FirstName = "Park", LastName = "Myung-hoon", Age = 50, Biography = "Played Geun-sae." },
    new Actor { FirstName = "Jung", LastName = "Ji-so", Age = 27, Biography = "Played Da-hye." },
    new Actor { FirstName = "Jung", LastName = "Hyun-jun", Age = 16, Biography = "Played Da-song." }
}),

// 29. LA LA LAND
(new Movie { Title = "La La Land", Genre = "Musical", ReleaseYear = 2016, Duration = TimeSpan.FromMinutes(128) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Ryan", LastName = "Gosling", Age = 45, Biography = "Jazz musician." },
    new Actor { FirstName = "Emma", LastName = "Stone", Age = 38, Biography = "Aspiring actress." },
    new Actor { FirstName = "John", LastName = "Legend", Age = 48, Biography = "Played Keith." },
    new Actor { FirstName = "Rosemarie", LastName = "DeWitt", Age = 55, Biography = "Played Laura." },
    new Actor { FirstName = "Finn", LastName = "Wittrock", Age = 42, Biography = "Played Greg." },
    new Actor { FirstName = "J.K.", LastName = "Simmons", Age = 71, Biography = "Played restaurant owner Bill." },
    new Actor { FirstName = "Callie", LastName = "Hernandez", Age = 38, Biography = "Played Tracy." },
    new Actor { FirstName = "Jessica", LastName = "Rothe", Age = 39, Biography = "Played Alexis." },
    new Actor { FirstName = "Sonoya", LastName = "Mizuno", Age = 38, Biography = "Played Caitlin." },
    new Actor { FirstName = "Tom", LastName = "Everett Scott", Age = 56, Biography = "Played David." }
}),

// 30. THE HANGOVER
(new Movie { Title = "The Hangover", Genre = "Comedy", ReleaseYear = 2009, Duration = TimeSpan.FromMinutes(100) }, 7.7,
new List<Actor> {
    new Actor { FirstName = "Bradley", LastName = "Cooper", Age = 51, Biography = "Leader of the group." },
    new Actor { FirstName = "Zach", LastName = "Galifianakis", Age = 57, Biography = "Scene-stealing Alan." },
    new Actor { FirstName = "Ed", LastName = "Helms", Age = 52, Biography = "Played Stu." },
    new Actor { FirstName = "Justin", LastName = "Bartha", Age = 48, Biography = "Played Doug." },
    new Actor { FirstName = "Heather", LastName = "Graham", Age = 56, Biography = "Played Jade." },
    new Actor { FirstName = "Ken", LastName = "Jeong", Age = 57, Biography = "Played Leslie Chow." },
    new Actor { FirstName = "Jeffrey", LastName = "Tambor", Age = 82, Biography = "Played Sid Garner." },
    new Actor { FirstName = "Rachael", LastName = "Harris", Age = 58, Biography = "Played Melissa." },
    new Actor { FirstName = "Mike", LastName = "Tyson", Age = 60, Biography = "Played himself in a memorable cameo." },
    new Actor { FirstName = "Sasha", LastName = "Barrese", Age = 45, Biography = "Played Tracy Garner." }
}),
// 31. SE7EN
(new Movie { Title = "Se7en", Genre = "Thriller", ReleaseYear = 1995, Duration = TimeSpan.FromMinutes(127) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Played detective David Mills." },
    new Actor { FirstName = "Morgan", LastName = "Freeman", Age = 88, Biography = "Played veteran detective Somerset." },
    new Actor { FirstName = "Kevin", LastName = "Spacey", Age = 67, Biography = "Played the terrifying John Doe." },
    new Actor { FirstName = "Gwyneth", LastName = "Paltrow", Age = 54, Biography = "Played Tracy Mills." },
    new Actor { FirstName = "R. Lee", LastName = "Ermey", Age = 74, Biography = "Played the police captain." },
    new Actor { FirstName = "John", LastName = "C. McGinley", Age = 66, Biography = "Played SWAT team leader California." },
    new Actor { FirstName = "Richard", LastName = "Roundtree", Age = 81, Biography = "Played the district attorney." },
    new Actor { FirstName = "Daniel", LastName = "Zacapa", Age = 73, Biography = "Played detective Taylor." },
    new Actor { FirstName = "Michael", LastName = "Massee", Age = 65, Biography = "Played victim Theodore Allen." },
    new Actor { FirstName = "Leland", LastName = "Orser", Age = 65, Biography = "Played the traumatized victim at the brothel." }
}),

// 32. DJANGO UNCHAINED
(new Movie { Title = "Django Unchained", Genre = "Western", ReleaseYear = 2012, Duration = TimeSpan.FromMinutes(165) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Jamie", LastName = "Foxx", Age = 59, Biography = "Played Django Freeman." },
    new Actor { FirstName = "Christoph", LastName = "Waltz", Age = 70, Biography = "Played bounty hunter Dr. Schultz." },
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Played plantation owner Calvin Candie." },
    new Actor { FirstName = "Samuel L.", LastName = "Jackson", Age = 77, Biography = "Played Stephen." },
    new Actor { FirstName = "Kerry", LastName = "Washington", Age = 49, Biography = "Played Broomhilda." },
    new Actor { FirstName = "Walton", LastName = "Goggins", Age = 55, Biography = "Played Billy Crash." },
    new Actor { FirstName = "Dennis", LastName = "Christopher", Age = 75, Biography = "Played Leonide Moguy." },
    new Actor { FirstName = "James", LastName = "Remar", Age = 73, Biography = "Played Ace Speck." },
    new Actor { FirstName = "Don", LastName = "Johnson", Age = 77, Biography = "Played Big Daddy." },
    new Actor { FirstName = "Jonah", LastName = "Hill", Age = 42, Biography = "Made a memorable cameo as Bag Head." }
}),

// 33. THE GREEN MILE
(new Movie { Title = "The Green Mile", Genre = "Drama", ReleaseYear = 1999, Duration = TimeSpan.FromMinutes(189) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hanks", Age = 69, Biography = "Played prison guard Paul Edgecomb." },
    new Actor { FirstName = "Michael", LastName = "Clarke Duncan", Age = 54, Biography = "Played John Coffey." },
    new Actor { FirstName = "David", LastName = "Morse", Age = 73, Biography = "Played Brutus Howell." },
    new Actor { FirstName = "Bonnie", LastName = "Hunt", Age = 65, Biography = "Played Jan Edgecomb." },
    new Actor { FirstName = "James", LastName = "Cromwell", Age = 86, Biography = "Played Warden Hal Moores." },
    new Actor { FirstName = "Michael", LastName = "Jeter", Age = 50, Biography = "Played Eduard Delacroix." },
    new Actor { FirstName = "Sam", LastName = "Rockwell", Age = 58, Biography = "Played Wild Bill Wharton." },
    new Actor { FirstName = "Doug", LastName = "Hutchison", Age = 65, Biography = "Played Percy Wetmore." },
    new Actor { FirstName = "Barry", LastName = "Pepper", Age = 56, Biography = "Played Dean Stanton." },
    new Actor { FirstName = "Jeffrey", LastName = "DeMunn", Age = 79, Biography = "Played Harry Terwilliger." }
}),

// 34. THE SILENCE OF THE LAMBS
(new Movie { Title = "The Silence of the Lambs", Genre = "Thriller", ReleaseYear = 1991, Duration = TimeSpan.FromMinutes(118) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Jodie", LastName = "Foster", Age = 64, Biography = "Played Clarice Starling." },
    new Actor { FirstName = "Anthony", LastName = "Hopkins", Age = 89, Biography = "Played Hannibal Lecter." },
    new Actor { FirstName = "Scott", LastName = "Glenn", Age = 86, Biography = "Played Jack Crawford." },
    new Actor { FirstName = "Ted", LastName = "Levine", Age = 68, Biography = "Played Buffalo Bill." },
    new Actor { FirstName = "Anthony", LastName = "Heald", Age = 82, Biography = "Played Dr. Chilton." },
    new Actor { FirstName = "Brooke", LastName = "Smith", Age = 58, Biography = "Played Catherine Martin." },
    new Actor { FirstName = "Diane", LastName = "Baker", Age = 88, Biography = "Played Senator Ruth Martin." },
    new Actor { FirstName = "Kasi", LastName = "Lemmons", Age = 65, Biography = "Played Ardelia Mapp." },
    new Actor { FirstName = "Frankie", LastName = "Faison", Age = 77, Biography = "Played Barney." },
    new Actor { FirstName = "Tracey", LastName = "Walter", Age = 79, Biography = "Played Lamar." }
}),

// 35. BLADE RUNNER 2049
(new Movie { Title = "Blade Runner 2049", Genre = "Sci-Fi", ReleaseYear = 2017, Duration = TimeSpan.FromMinutes(164) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Ryan", LastName = "Gosling", Age = 45, Biography = "Played Officer K." },
    new Actor { FirstName = "Harrison", LastName = "Ford", Age = 83, Biography = "Returned as Rick Deckard." },
    new Actor { FirstName = "Ana", LastName = "de Armas", Age = 38, Biography = "Played Joi." },
    new Actor { FirstName = "Jared", LastName = "Leto", Age = 55, Biography = "Played Niander Wallace." },
    new Actor { FirstName = "Robin", LastName = "Wright", Age = 60, Biography = "Played Lieutenant Joshi." },
    new Actor { FirstName = "Sylvia", LastName = "Hoeks", Age = 43, Biography = "Played Luv." },
    new Actor { FirstName = "Dave", LastName = "Bautista", Age = 57, Biography = "Played Sapper Morton." },
    new Actor { FirstName = "Mackenzie", LastName = "Davis", Age = 39, Biography = "Played Mariette." },
    new Actor { FirstName = "Carla", LastName = "Juri", Age = 41, Biography = "Played Dr. Stelline." },
    new Actor { FirstName = "Lennie", LastName = "James", Age = 61, Biography = "Played Mister Cotton." }
}),

// 36. THE TRUMAN SHOW
(new Movie { Title = "The Truman Show", Genre = "Drama", ReleaseYear = 1998, Duration = TimeSpan.FromMinutes(103) }, 8.2,
new List<Actor> {
    new Actor { FirstName = "Jim", LastName = "Carrey", Age = 64, Biography = "Played Truman Burbank." },
    new Actor { FirstName = "Laura", LastName = "Linney", Age = 62, Biography = "Played Meryl Burbank." },
    new Actor { FirstName = "Ed", LastName = "Harris", Age = 76, Biography = "Played creator Christof." },
    new Actor { FirstName = "Noah", LastName = "Emmerich", Age = 60, Biography = "Played Truman’s best friend Marlon." },
    new Actor { FirstName = "Natascha", LastName = "McElhone", Age = 57, Biography = "Played Sylvia." },
    new Actor { FirstName = "Holland", LastName = "Taylor", Age = 83, Biography = "Played Truman’s mother." },
    new Actor { FirstName = "Brian", LastName = "Delate", Age = 80, Biography = "Played Truman’s father." },
    new Actor { FirstName = "Blair", LastName = "Slater", Age = 52, Biography = "Played the TV director." },
    new Actor { FirstName = "Peter", LastName = "Krause", Age = 61, Biography = "Played Laurence." },
    new Actor { FirstName = "Heidi", LastName = "Schanz", Age = 53, Biography = "Played Vivien." }
}),

// 37. ALIEN
(new Movie { Title = "Alien", Genre = "Horror", ReleaseYear = 1979, Duration = TimeSpan.FromMinutes(117) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Sigourney", LastName = "Weaver", Age = 77, Biography = "Played Ellen Ripley." },
    new Actor { FirstName = "Tom", LastName = "Skerritt", Age = 93, Biography = "Played Captain Dallas." },
    new Actor { FirstName = "John", LastName = "Hurt", Age = 77, Biography = "Played Kane." },
    new Actor { FirstName = "Ian", LastName = "Holm", Age = 89, Biography = "Played Ash." },
    new Actor { FirstName = "Yaphet", LastName = "Kotto", Age = 82, Biography = "Played Parker." },
    new Actor { FirstName = "Harry", LastName = "Dean Stanton", Age = 91, Biography = "Played Brett." },
    new Actor { FirstName = "Veronica", LastName = "Cartwright", Age = 76, Biography = "Played Lambert." },
    new Actor { FirstName = "Helen", LastName = "Horton", Age = 84, Biography = "Voice of Mother." },
    new Actor { FirstName = "Bolaji", LastName = "Badejo", Age = 39, Biography = "Played the Xenomorph." },
    new Actor { FirstName = "Eddie", LastName = "Powell", Age = 73, Biography = "Alien stunt performer." }
}),

// 38. CASINO ROYALE
(new Movie { Title = "Casino Royale", Genre = "Action", ReleaseYear = 2006, Duration = TimeSpan.FromMinutes(144) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Daniel", LastName = "Craig", Age = 58, Biography = "Debut as James Bond." },
    new Actor { FirstName = "Eva", LastName = "Green", Age = 46, Biography = "Played Vesper Lynd." },
    new Actor { FirstName = "Mads", LastName = "Mikkelsen", Age = 61, Biography = "Played villain Le Chiffre." },
    new Actor { FirstName = "Judi", LastName = "Dench", Age = 92, Biography = "Returned as M." },
    new Actor { FirstName = "Jeffrey", LastName = "Wright", Age = 61, Biography = "Played Felix Leiter." },
    new Actor { FirstName = "Giancarlo", LastName = "Giannini", Age = 84, Biography = "Played Mathis." },
    new Actor { FirstName = "Caterina", LastName = "Murino", Age = 49, Biography = "Played Solange." },
    new Actor { FirstName = "Simon", LastName = "Abkarian", Age = 65, Biography = "Played Alex Dimitrios." },
    new Actor { FirstName = "Isaach", LastName = "de Bankolé", Age = 69, Biography = "Played Steven Obanno." },
    new Actor { FirstName = "Sebastien", LastName = "Foucan", Age = 52, Biography = "Played the bomb-maker Mollaka." }
}),

// 39. SHUTTER ISLAND
(new Movie { Title = "Shutter Island", Genre = "Thriller", ReleaseYear = 2010, Duration = TimeSpan.FromMinutes(138) }, 8.2,
new List<Actor> {
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Played Teddy Daniels." },
    new Actor { FirstName = "Mark", LastName = "Ruffalo", Age = 59, Biography = "Played Chuck Aule." },
    new Actor { FirstName = "Ben", LastName = "Kingsley", Age = 83, Biography = "Played Dr. Cawley." },
    new Actor { FirstName = "Michelle", LastName = "Williams", Age = 46, Biography = "Played Dolores Chanal." },
    new Actor { FirstName = "Emily", LastName = "Mortimer", Age = 55, Biography = "Played Rachel Solando." },
    new Actor { FirstName = "Max", LastName = "von Sydow", Age = 91, Biography = "Played Dr. Naehring." },
    new Actor { FirstName = "Patricia", LastName = "Clarkson", Age = 67, Biography = "Played the mysterious woman in the cave." },
    new Actor { FirstName = "Jackie", LastName = "Earle Haley", Age = 65, Biography = "Played George Noyce." },
    new Actor { FirstName = "Ted", LastName = "Levine", Age = 68, Biography = "Played the warden." },
    new Actor { FirstName = "John", LastName = "Carroll Lynch", Age = 63, Biography = "Played Deputy Warden McPherson." }
}),

// 40. TOP GUN: MAVERICK
(new Movie { Title = "Top Gun: Maverick", Genre = "Action", ReleaseYear = 2022, Duration = TimeSpan.FromMinutes(131) }, 8.3,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Cruise", Age = 64, Biography = "Returned as Pete 'Maverick' Mitchell." },
    new Actor { FirstName = "Miles", LastName = "Teller", Age = 39, Biography = "Played Rooster." },
    new Actor { FirstName = "Jennifer", LastName = "Connelly", Age = 56, Biography = "Played Penny Benjamin." },
    new Actor { FirstName = "Jon", LastName = "Hamm", Age = 55, Biography = "Played Cyclone." },
    new Actor { FirstName = "Glen", LastName = "Powell", Age = 38, Biography = "Played Hangman." },
    new Actor { FirstName = "Lewis", LastName = "Pullman", Age = 33, Biography = "Played Bob." },
    new Actor { FirstName = "Ed", LastName = "Harris", Age = 76, Biography = "Played Rear Admiral Cain." },
    new Actor { FirstName = "Val", LastName = "Kilmer", Age = 66, Biography = "Returned as Iceman." },
    new Actor { FirstName = "Monica", LastName = "Barbaro", Age = 36, Biography = "Played Phoenix." },
    new Actor { FirstName = "Danny", LastName = "Ramirez", Age = 34, Biography = "Played Fanboy." }
}),

// 41. THE DEPARTED
(new Movie { Title = "The Departed", Genre = "Crime", ReleaseYear = 2006, Duration = TimeSpan.FromMinutes(151) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Undercover cop Billy Costigan." },
    new Actor { FirstName = "Matt", LastName = "Damon", Age = 56, Biography = "Police mole Colin Sullivan." },
    new Actor { FirstName = "Jack", LastName = "Nicholson", Age = 88, Biography = "Crime boss Frank Costello." },
    new Actor { FirstName = "Mark", LastName = "Wahlberg", Age = 55, Biography = "Detective Dignam." },
    new Actor { FirstName = "Martin", LastName = "Sheen", Age = 86, Biography = "Captain Queenan." },
    new Actor { FirstName = "Ray", LastName = "Winstone", Age = 69, Biography = "Mr. French." },
    new Actor { FirstName = "Vera", LastName = "Farmiga", Age = 52, Biography = "Madolyn Madden." },
    new Actor { FirstName = "Alec", LastName = "Baldwin", Age = 67, Biography = "Captain Ellerby." },
    new Actor { FirstName = "Kevin", LastName = "Corrigan", Age = 61, Biography = "Cousin Sean." },
    new Actor { FirstName = "James", LastName = "Badge Dale", Age = 48, Biography = "Trooper Barrigan." }
}),

// 42. GOODFELLAS
(new Movie { Title = "Goodfellas", Genre = "Crime", ReleaseYear = 1990, Duration = TimeSpan.FromMinutes(146) }, 8.7,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "De Niro", Age = 83, Biography = "Jimmy Conway." },
    new Actor { FirstName = "Ray", LastName = "Liotta", Age = 67, Biography = "Henry Hill." },
    new Actor { FirstName = "Joe", LastName = "Pesci", Age = 82, Biography = "Tommy DeVito." },
    new Actor { FirstName = "Lorraine", LastName = "Bracco", Age = 71, Biography = "Karen Hill." },
    new Actor { FirstName = "Paul", LastName = "Sorvino", Age = 83, Biography = "Paul Cicero." },
    new Actor { FirstName = "Frank", LastName = "Sivero", Age = 72, Biography = "Frankie Carbone." },
    new Actor { FirstName = "Tony", LastName = "Darrow", Age = 80, Biography = "Sonny Bunz." },
    new Actor { FirstName = "Mike", LastName = "Starr", Age = 78, Biography = "Frenchy." },
    new Actor { FirstName = "Samuel", LastName = "L. Jackson", Age = 77, Biography = "Stacks Edwards." },
    new Actor { FirstName = "Charles", LastName = "Scorsese", Age = 93, Biography = "Vinnie." }
}),

// 43. THE GODFATHER PART II
(new Movie { Title = "The Godfather Part II", Genre = "Crime", ReleaseYear = 1974, Duration = TimeSpan.FromMinutes(202) }, 9.0,
new List<Actor> {
    new Actor { FirstName = "Al", LastName = "Pacino", Age = 85, Biography = "Michael Corleone." },
    new Actor { FirstName = "Robert", LastName = "De Niro", Age = 83, Biography = "Young Vito Corleone." },
    new Actor { FirstName = "Diane", LastName = "Keaton", Age = 79, Biography = "Kay Adams." },
    new Actor { FirstName = "Robert", LastName = "Duvall", Age = 95, Biography = "Tom Hagen." },
    new Actor { FirstName = "John", LastName = "Cazale", Age = 42, Biography = "Fredo Corleone." },
    new Actor { FirstName = "Talia", LastName = "Shire", Age = 80, Biography = "Connie Corleone." },
    new Actor { FirstName = "Lee", LastName = "Strasberg", Age = 80, Biography = "Hyman Roth." },
    new Actor { FirstName = "Michael", LastName = "V. Gazzo", Age = 71, Biography = "Frank Pentangeli." },
    new Actor { FirstName = "G.D.", LastName = "Spradlin", Age = 90, Biography = "Senator Geary." },
    new Actor { FirstName = "Francesca", LastName = "De Sapio", Age = 84, Biography = "Young Mama Corleone." }
}),

// 44. SAVING PRIVATE RYAN
(new Movie { Title = "Saving Private Ryan", Genre = "War", ReleaseYear = 1998, Duration = TimeSpan.FromMinutes(169) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Hanks", Age = 69, Biography = "Captain Miller." },
    new Actor { FirstName = "Matt", LastName = "Damon", Age = 56, Biography = "Private Ryan." },
    new Actor { FirstName = "Tom", LastName = "Sizemore", Age = 63, Biography = "Sergeant Horvath." },
    new Actor { FirstName = "Edward", LastName = "Burns", Age = 57, Biography = "Private Reiben." },
    new Actor { FirstName = "Barry", LastName = "Pepper", Age = 56, Biography = "Private Jackson." },
    new Actor { FirstName = "Adam", LastName = "Goldberg", Age = 55, Biography = "Private Mellish." },
    new Actor { FirstName = "Giovanni", LastName = "Ribisi", Age = 51, Biography = "Medic Wade." },
    new Actor { FirstName = "Vin", LastName = "Diesel", Age = 58, Biography = "Private Caparzo." },
    new Actor { FirstName = "Jeremy", LastName = "Davies", Age = 57, Biography = "Corporal Upham." },
    new Actor { FirstName = "Ted", LastName = "Danson", Age = 78, Biography = "Captain Hamill." }
}),

// 45. THE DARK KNIGHT RISES
(new Movie { Title = "The Dark Knight Rises", Genre = "Action", ReleaseYear = 2012, Duration = TimeSpan.FromMinutes(164) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Christian", LastName = "Bale", Age = 52, Biography = "Bruce Wayne / Batman." },
    new Actor { FirstName = "Tom", LastName = "Hardy", Age = 48, Biography = "Bane." },
    new Actor { FirstName = "Anne", LastName = "Hathaway", Age = 43, Biography = "Selina Kyle." },
    new Actor { FirstName = "Gary", LastName = "Oldman", Age = 68, Biography = "Commissioner Gordon." },
    new Actor { FirstName = "Michael", LastName = "Caine", Age = 93, Biography = "Alfred." },
    new Actor { FirstName = "Joseph", LastName = "Gordon-Levitt", Age = 45, Biography = "John Blake." },
    new Actor { FirstName = "Marion", LastName = "Cotillard", Age = 50, Biography = "Miranda Tate." },
    new Actor { FirstName = "Morgan", LastName = "Freeman", Age = 88, Biography = "Lucius Fox." },
    new Actor { FirstName = "Matthew", LastName = "Modine", Age = 66, Biography = "Officer Foley." },
    new Actor { FirstName = "Ben", LastName = "Mendelsohn", Age = 56, Biography = "Daggett." }
}),

// 46. PRISONERS
(new Movie { Title = "Prisoners", Genre = "Thriller", ReleaseYear = 2013, Duration = TimeSpan.FromMinutes(153) }, 8.1,
new List<Actor> {
    new Actor { FirstName = "Hugh", LastName = "Jackman", Age = 57, Biography = "Keller Dover." },
    new Actor { FirstName = "Jake", LastName = "Gyllenhaal", Age = 45, Biography = "Detective Loki." },
    new Actor { FirstName = "Paul", LastName = "Dano", Age = 42, Biography = "Alex Jones." },
    new Actor { FirstName = "Maria", LastName = "Bello", Age = 58, Biography = "Grace Dover." },
    new Actor { FirstName = "Terrence", LastName = "Howard", Age = 55, Biography = "Franklin Birch." },
    new Actor { FirstName = "Viola", LastName = "Davis", Age = 61, Biography = "Nancy Birch." },
    new Actor { FirstName = "Melissa", LastName = "Leo", Age = 65, Biography = "Holly Jones." },
    new Actor { FirstName = "Dylan", LastName = "Minnette", Age = 29, Biography = "Ralph Dover." },
    new Actor { FirstName = "Zoë", LastName = "Soul", Age = 30, Biography = "Eliza Birch." },
    new Actor { FirstName = "Wayne", LastName = "Duvall", Age = 74, Biography = "Captain Richard O'Malley." }
}),

// 47. THE REVENANT
(new Movie { Title = "The Revenant", Genre = "Adventure", ReleaseYear = 2015, Duration = TimeSpan.FromMinutes(156) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Leonardo", LastName = "DiCaprio", Age = 51, Biography = "Hugh Glass." },
    new Actor { FirstName = "Tom", LastName = "Hardy", Age = 48, Biography = "John Fitzgerald." },
    new Actor { FirstName = "Domhnall", LastName = "Gleeson", Age = 43, Biography = "Captain Andrew Henry." },
    new Actor { FirstName = "Will", LastName = "Poulter", Age = 32, Biography = "Jim Bridger." },
    new Actor { FirstName = "Forrest", LastName = "Goodluck", Age = 26, Biography = "Hawk." },
    new Actor { FirstName = "Duane", LastName = "Howard", Age = 68, Biography = "Elk Dog." },
    new Actor { FirstName = "Arthur", LastName = "RedCloud", Age = 62, Biography = "Hikuc." },
    new Actor { FirstName = "Kristoffer", LastName = "Joner", Age = 51, Biography = "Fitzgerald’s ally." },
    new Actor { FirstName = "Paul", LastName = "Anderson", Age = 50, Biography = "Anderson." },
    new Actor { FirstName = "Joshua", LastName = "Burke", Age = 45, Biography = "Revenge expedition member." }
}),

// 48. BLACK PANTHER
(new Movie { Title = "Black Panther", Genre = "Action", ReleaseYear = 2018, Duration = TimeSpan.FromMinutes(134) }, 7.3,
new List<Actor> {
    new Actor { FirstName = "Chadwick", LastName = "Boseman", Age = 43, Biography = "T’Challa / Black Panther." },
    new Actor { FirstName = "Michael", LastName = "B. Jordan", Age = 39, Biography = "Erik Killmonger." },
    new Actor { FirstName = "Lupita", LastName = "Nyong'o", Age = 43, Biography = "Nakia." },
    new Actor { FirstName = "Danai", LastName = "Gurira", Age = 48, Biography = "Okoye." },
    new Actor { FirstName = "Letitia", LastName = "Wright", Age = 32, Biography = "Shuri." },
    new Actor { FirstName = "Winston", LastName = "Duke", Age = 39, Biography = "M’Baku." },
    new Actor { FirstName = "Angela", LastName = "Bassett", Age = 67, Biography = "Queen Ramonda." },
    new Actor { FirstName = "Forest", LastName = "Whitaker", Age = 64, Biography = "Zuri." },
    new Actor { FirstName = "Martin", LastName = "Freeman", Age = 64, Biography = "Everett Ross." },
    new Actor { FirstName = "Daniel", LastName = "Kaluuya", Age = 37, Biography = "W’Kabi." }
}),

// 49. AVENGERS: INFINITY WAR
(new Movie { Title = "Avengers: Infinity War", Genre = "Action", ReleaseYear = 2018, Duration = TimeSpan.FromMinutes(149) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Robert", LastName = "Downey Jr.", Age = 61, Biography = "Iron Man." },
    new Actor { FirstName = "Chris", LastName = "Hemsworth", Age = 43, Biography = "Thor." },
    new Actor { FirstName = "Mark", LastName = "Ruffalo", Age = 59, Biography = "Hulk." },
    new Actor { FirstName = "Chris", LastName = "Evans", Age = 45, Biography = "Captain America." },
    new Actor { FirstName = "Scarlett", LastName = "Johansson", Age = 42, Biography = "Black Widow." },
    new Actor { FirstName = "Benedict", LastName = "Cumberbatch", Age = 50, Biography = "Doctor Strange." },
    new Actor { FirstName = "Tom", LastName = "Holland", Age = 30, Biography = "Spider-Man." },
    new Actor { FirstName = "Josh", LastName = "Brolin", Age = 58, Biography = "Thanos." },
    new Actor { FirstName = "Zoe", LastName = "Saldana", Age = 48, Biography = "Gamora." },
    new Actor { FirstName = "Chris", LastName = "Pratt", Age = 47, Biography = "Star-Lord." }
}),

// 50. INGLOURIOUS BASTERDS
(new Movie { Title = "Inglourious Basterds", Genre = "War", ReleaseYear = 2009, Duration = TimeSpan.FromMinutes(153) }, 8.3,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Lt. Aldo Raine." },
    new Actor { FirstName = "Christoph", LastName = "Waltz", Age = 70, Biography = "Colonel Hans Landa." },
    new Actor { FirstName = "Mélanie", LastName = "Laurent", Age = 43, Biography = "Shosanna Dreyfus." },
    new Actor { FirstName = "Michael", LastName = "Fassbender", Age = 49, Biography = "Lt. Archie Hicox." },
    new Actor { FirstName = "Diane", LastName = "Kruger", Age = 49, Biography = "Bridget von Hammersmark." },
    new Actor { FirstName = "Eli", LastName = "Roth", Age = 53, Biography = "Donny Donowitz." },
    new Actor { FirstName = "Til", LastName = "Schweiger", Age = 61, Biography = "Hugo Stiglitz." },
    new Actor { FirstName = "Daniel", LastName = "Brühl", Age = 47, Biography = "Fredrick Zoller." },
    new Actor { FirstName = "August", LastName = "Diehl", Age = 49, Biography = "Major Hellstrom." },
    new Actor { FirstName = "Sylvester", LastName = "Groth", Age = 67, Biography = "Joseph Goebbels." }
}),

// 51. FIGHT CLUB 2 (THEORETICAL EXTENSION)
(new Movie { Title = "The Fight Club Continuum", Genre = "Drama", ReleaseYear = 2026, Duration = TimeSpan.FromMinutes(140) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Returns as Tyler Durden archetype." },
    new Actor { FirstName = "Edward", LastName = "Norton", Age = 57, Biography = "Returns as the Narrator." },
    new Actor { FirstName = "Helena", LastName = "Bonham Carter", Age = 60, Biography = "Returns as Marla Singer." },
    new Actor { FirstName = "Jared", LastName = "Leto", Age = 55, Biography = "Project Mayhem leader figure." },
    new Actor { FirstName = "Holt", LastName = "McCallany", Age = 62, Biography = "Senior operative in underground movement." },
    new Actor { FirstName = "Eion", LastName = "Bailey", Age = 50, Biography = "Rebel faction member." },
    new Actor { FirstName = "Zach", LastName = "Grenier", Age = 72, Biography = "Corporate antagonist figure." },
    new Actor { FirstName = "Richmond", LastName = "Arquette", Age = 63, Biography = "Field coordinator." },
    new Actor { FirstName = "David", LastName = "Andrews", Age = 69, Biography = "Psychology consultant." },
    new Actor { FirstName = "Meat", LastName = "Loaf", Age = 74, Biography = "Symbolic return cameo." }
}),

// 52. GONE GIRL
(new Movie { Title = "Gone Girl", Genre = "Thriller", ReleaseYear = 2014, Duration = TimeSpan.FromMinutes(149) }, 8.1,
new List<Actor> {
    new Actor { FirstName = "Ben", LastName = "Affleck", Age = 53, Biography = "Nick Dunne." },
    new Actor { FirstName = "Rosamund", LastName = "Pike", Age = 47, Biography = "Amy Dunne." },
    new Actor { FirstName = "Neil", LastName = "Patrick Harris", Age = 52, Biography = "Desi Collings." },
    new Actor { FirstName = "Carrie", LastName = "Coon", Age = 45, Biography = "Margo Dunne." },
    new Actor { FirstName = "Kim", LastName = "Dickens", Age = 61, Biography = "Detective Rhonda Boney." },
    new Actor { FirstName = "Patrick", LastName = "Fugit", Age = 42, Biography = "Officer Jim Gilpin." },
    new Actor { FirstName = "Tyler", LastName = "Perry", Age = 56, Biography = "Tanner Bolt." },
    new Actor { FirstName = "Sela", LastName = "Ward", Age = 69, Biography = "Sharon Schieber." },
    new Actor { FirstName = "Missi", LastName = "Pyle", Age = 53, Biography = "Andie Fitzgerald." },
    new Actor { FirstName = "Emily", LastName = "Ratajkowski", Age = 34, Biography = "Andie’s friend." }
}),

// 53. WHALE
(new Movie { Title = "The Whale", Genre = "Drama", ReleaseYear = 2022, Duration = TimeSpan.FromMinutes(117) }, 7.8,
new List<Actor> {
    new Actor { FirstName = "Brendan", LastName = "Fraser", Age = 57, Biography = "Charlie." },
    new Actor { FirstName = "Sadie", LastName = "Sink", Age = 23, Biography = "Ellie." },
    new Actor { FirstName = "Hong", LastName = "Chau", Age = 45, Biography = "Liz." },
    new Actor { FirstName = "Ty", LastName = "Simpkins", Age = 34, Biography = "Thomas." },
    new Actor { FirstName = "Samantha", LastName = "Morton", Age = 48, Biography = "Mary." },
    new Actor { FirstName = "Sathya", LastName = "Sridharan", Age = 38, Biography = "Delivery man." },
    new Actor { FirstName = "Jacey", LastName = "Sink", Age = 25, Biography = "Supporting student role." },
    new Actor { FirstName = "Jason", LastName = "Berman", Age = 44, Biography = "Paramedic." },
    new Actor { FirstName = "William", LastName = "DeMeritt", Age = 40, Biography = "Missionary caller." },
    new Actor { FirstName = "James", LastName = "Dunn", Age = 46, Biography = "Church representative." }
}),

// 54. GLASS ONION
(new Movie { Title = "Glass Onion: A Knives Out Mystery", Genre = "Mystery", ReleaseYear = 2022, Duration = TimeSpan.FromMinutes(139) }, 7.2,
new List<Actor> {
    new Actor { FirstName = "Daniel", LastName = "Craig", Age = 58, Biography = "Benoit Blanc." },
    new Actor { FirstName = "Edward", LastName = "Norton", Age = 57, Biography = "Miles Bron." },
    new Actor { FirstName = "Janelle", LastName = "Monáe", Age = 40, Biography = "Andi Brand." },
    new Actor { FirstName = "Kathryn", LastName = "Hahn", Age = 52, Biography = "Claire Debella." },
    new Actor { FirstName = "Leslie", LastName = "Odom Jr.", Age = 44, Biography = "Lionel Toussaint." },
    new Actor { FirstName = "Kate", LastName = "Hudson", Age = 47, Biography = "Birdie Jay." },
    new Actor { FirstName = "Dave", LastName = "Bautista", Age = 57, Biography = "Duke Cody." },
    new Actor { FirstName = "Jessica", LastName = "Henwick", Age = 33, Biography = "Peg." },
    new Actor { FirstName = "Madelyn", LastName = "Cline", Age = 28, Biography = "Whiskey." },
    new Actor { FirstName = "Noah", LastName = "Segan", Age = 43, Biography = "Derol." }
}),

// 55. MISSION: IMPOSSIBLE – FALLOUT
(new Movie { Title = "Mission: Impossible – Fallout", Genre = "Action", ReleaseYear = 2018, Duration = TimeSpan.FromMinutes(147) }, 8.0,
new List<Actor> {
    new Actor { FirstName = "Tom", LastName = "Cruise", Age = 64, Biography = "Ethan Hunt." },
    new Actor { FirstName = "Henry", LastName = "Cavill", Age = 42, Biography = "August Walker." },
    new Actor { FirstName = "Ving", LastName = "Rhames", Age = 67, Biography = "Luther Stickell." },
    new Actor { FirstName = "Simon", LastName = "Pegg", Age = 56, Biography = "Benji Dunn." },
    new Actor { FirstName = "Rebecca", LastName = "Ferguson", Age = 42, Biography = "Ilsa Faust." },
    new Actor { FirstName = "Sean", LastName = "Harris", Age = 59, Biography = "Solomon Lane." },
    new Actor { FirstName = "Michelle", LastName = "Monaghan", Age = 49, Biography = "Julia Meade." },
    new Actor { FirstName = "Alec", LastName = "Baldwin", Age = 67, Biography = "Alan Hunley." },
    new Actor { FirstName = "Angela", LastName = "Bassett", Age = 67, Biography = "Erika Sloane." },
    new Actor { FirstName = "Frederick", LastName = "Schmidt", Age = 50, Biography = "Zola Mitsopolis." }
}),

// 56. WORLD WAR Z
(new Movie { Title = "World War Z", Genre = "Horror", ReleaseYear = 2013, Duration = TimeSpan.FromMinutes(116) }, 7.0,
new List<Actor> {
    new Actor { FirstName = "Brad", LastName = "Pitt", Age = 62, Biography = "Gerry Lane." },
    new Actor { FirstName = "Mireille", LastName = "Enos", Age = 50, Biography = "Karin Lane." },
    new Actor { FirstName = "Daniella", LastName = "Kertesz", Age = 38, Biography = "Segen." },
    new Actor { FirstName = "James", LastName = "Badge Dale", Age = 48, Biography = "Captain Speke." },
    new Actor { FirstName = "Matthew", LastName = "Fox", Age = 59, Biography = "Parajumper." },
    new Actor { FirstName = "David", LastName = "Morse", Age = 73, Biography = "Ex-CIA agent." },
    new Actor { FirstName = "Pierfrancesco", LastName = "Favino", Age = 56, Biography = "WHO doctor." },
    new Actor { FirstName = "Ludi", LastName = "Boeken", Age = 61, Biography = "Jurgen Warmbrunn." },
    new Actor { FirstName = "Abigail", LastName = "Hargrove", Age = 26, Biography = "Constance Lane." },
    new Actor { FirstName = "Fana", LastName = "Mokoena", Age = 58, Biography = "Thierry Umutoni." }
}),

// 57. INDIANA JONES AND THE RAIDERS OF THE LOST ARK
(new Movie { Title = "Raiders of the Lost Ark", Genre = "Adventure", ReleaseYear = 1981, Duration = TimeSpan.FromMinutes(115) }, 8.4,
new List<Actor> {
    new Actor { FirstName = "Harrison", LastName = "Ford", Age = 83, Biography = "Indiana Jones." },
    new Actor { FirstName = "Karen", LastName = "Allen", Age = 74, Biography = "Marion Ravenwood." },
    new Actor { FirstName = "Paul", LastName = "Freeman", Age = 81, Biography = "Dr. René Belloq." },
    new Actor { FirstName = "John", LastName = "Rhys-Davies", Age = 82, Biography = "Sallah." },
    new Actor { FirstName = "Denholm", LastName = "Elliott", Age = 70, Biography = "Marcus Brody." },
    new Actor { FirstName = "Alfred", LastName = "Molina", Age = 73, Biography = "Satipo." },
    new Actor { FirstName = "Wolf", LastName = "Kahler", Age = 81, Biography = "Colonel Dietrich." },
    new Actor { FirstName = "Ronald", LastName = "Lacey", Age = 55, Biography = "Major Toht." },
    new Actor { FirstName = "Don", LastName = "Henderson", Age = 72, Biography = "American agent." },
    new Actor { FirstName = "Anthony", LastName = "Higgins", Age = 83, Biography = "Gobler." }
}),

// 58. TERMINATOR 2: JUDGMENT DAY
(new Movie { Title = "Terminator 2: Judgment Day", Genre = "Sci-Fi", ReleaseYear = 1991, Duration = TimeSpan.FromMinutes(137) }, 8.6,
new List<Actor> {
    new Actor { FirstName = "Arnold", LastName = "Schwarzenegger", Age = 78, Biography = "The Terminator." },
    new Actor { FirstName = "Linda", LastName = "Hamilton", Age = 69, Biography = "Sarah Connor." },
    new Actor { FirstName = "Edward", LastName = "Furlong", Age = 48, Biography = "John Connor." },
    new Actor { FirstName = "Robert", LastName = "Patrick", Age = 67, Biography = "T-1000." },
    new Actor { FirstName = "Earl", LastName = "Boen", Age = 81, Biography = "Dr. Silberman." },
    new Actor { FirstName = "Joe", LastName = "Morton", Age = 78, Biography = "Miles Dyson." },
    new Actor { FirstName = "S. Epatha", LastName = "Merkerson", Age = 71, Biography = "Dyson’s wife." },
    new Actor { FirstName = "Castulo", LastName = "Guerra", Age = 69, Biography = "Enrique." },
    new Actor { FirstName = "Danny", LastName = "Cooksey", Age = 49, Biography = "Tim." },
    new Actor { FirstName = "Jenette", LastName = "Goldstein", Age = 65, Biography = "Janelle Voight." }
}),

// 59. THE USUAL SUSPECTS
(new Movie { Title = "The Usual Suspects", Genre = "Crime", ReleaseYear = 1995, Duration = TimeSpan.FromMinutes(106) }, 8.5,
new List<Actor> {
    new Actor { FirstName = "Kevin", LastName = "Spacey", Age = 67, Biography = "Verbal Kint." },
    new Actor { FirstName = "Gabriel", LastName = "Byrne", Age = 75, Biography = "Dean Keaton." },
    new Actor { FirstName = "Benicio", LastName = "Del Toro", Age = 58, Biography = "Fenster." },
    new Actor { FirstName = "Stephen", LastName = "Baldwin", Age = 59, Biography = "McManus." },
    new Actor { FirstName = "Kevin", LastName = "Pollak", Age = 68, Biography = "Hockney." },
    new Actor { FirstName = "Chazz", LastName = "Palminteri", Age = 73, Biography = "Dave Kujan." },
    new Actor { FirstName = "Pete", LastName = "Postlethwaite", Age = 64, Biography = "Kobayashi." },
    new Actor { FirstName = "Giancarlo", LastName = "Esposito", Age = 67, Biography = "Jack Baer." },
    new Actor { FirstName = "Suzy", LastName = "Amis", Age = 64, Biography = "Edie Finneran." },
    new Actor { FirstName = "Dan", LastName = "Hedaya", Age = 85, Biography = "Jeff Rabin." }
}),

// 60. THE GINGERDEAD MAN
(new Movie { Title = "The Gingerdead Man", Genre = "Horror/Comedy", ReleaseYear = 2005, Duration = TimeSpan.FromMinutes(80) }, 4.0,
new List<Actor> {
    new Actor { FirstName = "Gary", LastName = "Busey", Age = 81, Biography = "Voice of the cursed killer cookie." },
    new Actor { FirstName = "Robin", LastName = "Sydney", Age = 44, Biography = "Bakery owner targeted by the Gingerdead Man." },
    new Actor { FirstName = "Ryan", LastName = "Locke", Age = 45, Biography = "Supporting role in the bakery storyline." },
    new Actor { FirstName = "Larry", LastName = "Cedeno", Age = 52, Biography = "Officer investigating the killings." },
    new Actor { FirstName = "Courtney", LastName = "Gains", Age = 56, Biography = "Scientist studying cursed ingredients." },
    new Actor { FirstName = "Michael", LastName = "Deak", Age = 60, Biography = "Bakery supplier tied to events." },
    new Actor { FirstName = "Lisa", LastName = "Harlow", Age = 48, Biography = "Local journalist covering incidents." },
    new Actor { FirstName = "Steven", LastName = "White", Age = 57, Biography = "Detective on the case." },
    new Actor { FirstName = "Penny", LastName = "Phang", Age = 50, Biography = "Bakery employee." },
    new Actor { FirstName = "Joshua", LastName = "Tanner", Age = 46, Biography = "Investigator into supernatural events." }
}),

// 61. THE GINGERDEAD MAN 2: PASSION OF THE CRUST
(new Movie { Title = "The Gingerdead Man 2: Passion of the Crust", Genre = "Horror/Comedy", ReleaseYear = 2008, Duration = TimeSpan.FromMinutes(82) }, 4.2,
new List<Actor> {
    new Actor { FirstName = "Gary", LastName = "Busey", Age = 81, Biography = "Returns as the Gingerdead Man voice." },
    new Actor { FirstName = "John", LastName = "Doe", Age = 55, Biography = "Prison scientist experimenting with cursed dough." },
    new Actor { FirstName = "Sarah", LastName = "Douglas", Age = 58, Biography = "Research assistant in prison lab." },
    new Actor { FirstName = "Tim", LastName = "Sullivan", Age = 49, Biography = "Prison guard." },
    new Actor { FirstName = "Rachel", LastName = "Morris", Age = 47, Biography = "Scientist attempting reversal of curse." },
    new Actor { FirstName = "Kevin", LastName = "Hartley", Age = 51, Biography = "Inmate caught in experiments." },
    new Actor { FirstName = "Mark", LastName = "Ellison", Age = 54, Biography = "Warden." },
    new Actor { FirstName = "Nina", LastName = "Brooks", Age = 46, Biography = "Medical officer." },
    new Actor { FirstName = "David", LastName = "Reyes", Age = 52, Biography = "Security specialist." },
    new Actor { FirstName = "Paul", LastName = "Waters", Age = 59, Biography = "External investigator." }
}),

// 62. THE GINGERDEAD MAN 3: SATAN’S STIRRING
(new Movie { Title = "The Gingerdead Man 3: Saturday Night Cleaver", Genre = "Horror/Comedy", ReleaseYear = 2011, Duration = TimeSpan.FromMinutes(83) }, 4.1,
new List<Actor> {
    new Actor { FirstName = "Robin", LastName = "Sydney", Age = 44, Biography = "Main survivor facing the curse again." },
    new Actor { FirstName = "Gary", LastName = "Busey", Age = 81, Biography = "Voice of the Gingerdead Man." },
    new Actor { FirstName = "Adrian", LastName = "Barraza", Age = 69, Biography = "Occult expert investigating the entity." },
    new Actor { FirstName = "Daniel", LastName = "Franzese", Age = 48, Biography = "Victim caught in chaos." },
    new Actor { FirstName = "Elise", LastName = "Jackson", Age = 46, Biography = "Local detective." },
    new Actor { FirstName = "Mark", LastName = "Lewis", Age = 53, Biography = "Bakery owner successor." },
    new Actor { FirstName = "Samantha", LastName = "Reed", Age = 45, Biography = "Journalist." },
    new Actor { FirstName = "Brian", LastName = "Clark", Age = 50, Biography = "Scientist studying possession." },
    new Actor { FirstName = "David", LastName = "Moore", Age = 56, Biography = "Police captain." },
    new Actor { FirstName = "Angela", LastName = "Brooks", Age = 47, Biography = "Forensic specialist." }
}),

// 63. EVIL BONG
(new Movie { Title = "Evil Bong", Genre = "Horror/Comedy", ReleaseYear = 2006, Duration = TimeSpan.FromMinutes(86) }, 4.5,
new List<Actor> {
    new Actor { FirstName = "Tommy", LastName = "Chong", Age = 87, Biography = "Mystical shop owner linked to the cursed bong." },
    new Actor { FirstName = "David", LastName = "Weidoff", Age = 60, Biography = "Roommate trapped by the bong." },
    new Actor { FirstName = "Kristyn", LastName = "Green", Age = 45, Biography = "Housemate affected by supernatural smoke." },
    new Actor { FirstName = "Brian", LastName = "Dolan", Age = 52, Biography = "Friend drawn into hallucinations." },
    new Actor { FirstName = "Michelle", LastName = "Mais", Age = 48, Biography = "Shop visitor." },
    new Actor { FirstName = "Peter", LastName = "Sullivan", Age = 55, Biography = "Investigator." },
    new Actor { FirstName = "Mark", LastName = "Davis", Age = 53, Biography = "Police officer." },
    new Actor { FirstName = "Angela", LastName = "Price", Age = 46, Biography = "Medical examiner." },
    new Actor { FirstName = "Steve", LastName = "Harper", Age = 57, Biography = "Research scientist." },
    new Actor { FirstName = "Lisa", LastName = "Thorne", Age = 49, Biography = "Neighbor witness." }
}),

// 64. EVIL BONG 2: KING BONG
(new Movie { Title = "Evil Bong 2: King Bong", Genre = "Horror/Comedy", ReleaseYear = 2009, Duration = TimeSpan.FromMinutes(88) }, 4.3,
new List<Actor> {
    new Actor { FirstName = "Tommy", LastName = "Chong", Age = 87, Biography = "Returns as mystical guide." },
    new Actor { FirstName = "David", LastName = "Weidoff", Age = 60, Biography = "Main survivor." },
    new Actor { FirstName = "Robin", LastName = "Sydney", Age = 44, Biography = "Victim pulled into Bong realm." },
    new Actor { FirstName = "Brian", LastName = "Krause", Age = 56, Biography = "Scientist investigating dimension." },
    new Actor { FirstName = "Kristyn", LastName = "Green", Age = 45, Biography = "Returning roommate." },
    new Actor { FirstName = "John", LastName = "Patrick", Age = 58, Biography = "Government agent." },
    new Actor { FirstName = "Lisa", LastName = "Murray", Age = 47, Biography = "Research assistant." },
    new Actor { FirstName = "Eric", LastName = "Jones", Age = 54, Biography = "Security operative." },
    new Actor { FirstName = "Paul", LastName = "Stevens", Age = 52, Biography = "Lab technician." },
    new Actor { FirstName = "Daniel", LastName = "Cross", Age = 59, Biography = "Artifact collector." }
}),

// 65. EVIL BONG 3: THE WRATH OF BONG
(new Movie { Title = "Evil Bong 3: The Wrath of Bong", Genre = "Horror/Comedy", ReleaseYear = 2011, Duration = TimeSpan.FromMinutes(90) }, 4.2,
new List<Actor> {
    new Actor { FirstName = "Tommy", LastName = "Chong", Age = 87, Biography = "Guides survivors again." },
    new Actor { FirstName = "David", LastName = "Weidoff", Age = 60, Biography = "Fights Bong dimension." },
    new Actor { FirstName = "Robin", LastName = "Sydney", Age = 44, Biography = "Survivor of Bong chaos." },
    new Actor { FirstName = "Joel", LastName = "Murray", Age = 52, Biography = "New victim drawn in." },
    new Actor { FirstName = "Billy", LastName = "West", Age = 72, Biography = "Voice cameo entity of Bong realm." },
    new Actor { FirstName = "Kristyn", LastName = "Green", Age = 45, Biography = "Returning character." },
    new Actor { FirstName = "Brian", LastName = "Krause", Age = 56, Biography = "Scientist ally." },
    new Actor { FirstName = "Mark", LastName = "Jones", Age = 53, Biography = "Investigator." },
    new Actor { FirstName = "Sarah", LastName = "Lynn", Age = 46, Biography = "Medical support." },
    new Actor { FirstName = "Kevin", LastName = "Brooks", Age = 50, Biography = "Security officer." }
}),
// 66. GINGERDEAD MAN VS EVIL BONG
(new Movie { Title = "Gingerdead Man vs Evil Bong", Genre = "Horror/Comedy", ReleaseYear = 2013, Duration = TimeSpan.FromMinutes(83) }, 4.6,
new List<Actor> {
    new Actor { FirstName = "Gary", LastName = "Busey", Age = 81, Biography = "Returns as the Gingerdead Man in the crossover chaos." },
    new Actor { FirstName = "Tommy", LastName = "Chong", Age = 87, Biography = "Returns as the mystical Bong shop figure." },
    new Actor { FirstName = "Robin", LastName = "Sydney", Age = 44, Biography = "Survivor caught between both cursed entities." },
    new Actor { FirstName = "David", LastName = "Weidoff", Age = 60, Biography = "Trapped in interdimensional horror crossover." },
    new Actor { FirstName = "Kristyn", LastName = "Green", Age = 45, Biography = "Victim of combined supernatural forces." },
    new Actor { FirstName = "Brian", LastName = "Krause", Age = 56, Biography = "Scientist trying to contain both curses." },
    new Actor { FirstName = "Joel", LastName = "Murray", Age = 52, Biography = "New participant in crossover events." },
    new Actor { FirstName = "Michelle", LastName = "Mais", Age = 48, Biography = "Witness to escalating chaos." },
    new Actor { FirstName = "Mark", LastName = "Davis", Age = 53, Biography = "Officer responding to supernatural incidents." },
    new Actor { FirstName = "Lisa", LastName = "Thorne", Age = 49, Biography = "Journalist documenting the crossover." }
}),

// 67. THE VELOCIPASTOR
(new Movie { Title = "The VelociPastor", Genre = "Action/Comedy", ReleaseYear = 2018, Duration = TimeSpan.FromMinutes(75) }, 5.5,
new List<Actor> {
    new Actor { FirstName = "Gregory", LastName = "James Cohan", Age = 40, Biography = "Doug Jones, a priest who becomes a dinosaur warrior." },
    new Actor { FirstName = "Alyssa", LastName = "Kempinski", Age = 35, Biography = "Carol, supporting lead and love interest." },
    new Actor { FirstName = "Fernando", LastName = "Pacheco de Castro", Age = 38, Biography = "Fu Shen, mysterious martial arts mentor." },
    new Actor { FirstName = "Daniel", LastName = "Steere", Age = 42, Biography = "Drug dealer antagonist triggering transformation." },
    new Actor { FirstName = "Ziyi", LastName = "Zhang (uncredited style role)", Age = 45, Biography = "Stylized martial arts influence character." },
    new Actor { FirstName = "Brendan", LastName = "Steere", Age = 39, Biography = "Director cameo role appearance." },
    new Actor { FirstName = "Rita", LastName = "Boxer", Age = 44, Biography = "Supporting church member." },
    new Actor { FirstName = "Sean", LastName = "Thompson", Age = 46, Biography = "Local enforcer." },
    new Actor { FirstName = "Michael", LastName = "C. Pierce", Age = 41, Biography = "Police officer reacting to chaos." },
    new Actor { FirstName = "Emily", LastName = "Sweet", Age = 37, Biography = "Civilian witness to dinosaur events." }
})

            };  
        }
    }
}