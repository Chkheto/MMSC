using MovieManagementSystem.Models;
using MovieManagementSystem.Services;
using System.Text;

// 1. Initializations
var movieDb = new List<Movie>();
var actorDb = new List<Actor>();
var userService = new UserService();
var adminService = new AdminService(movieDb, actorDb);
var searchService = new SearchService(movieDb, actorDb);
var emailService = new EmailService();
var authService = new AuthService();
User? currentUser = null;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("=================================");
Console.WriteLine("=== Movie Management System ===");
Console.WriteLine("=================================");
Console.ResetColor();

Console.WriteLine("1: Login");
Console.WriteLine("2: Create Account");
Console.Write("Selection: ");
string authChoice = Console.ReadLine() ?? "";

// 2. Authentication Flow
if (authChoice == "2")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n--- Register New Account ---");
    Console.ResetColor();
    Console.Write("Enter First Name: ");
    string fName = Console.ReadLine() ?? "User";
    Console.Write("Enter Email: ");
    string newEmail = Console.ReadLine() ?? "";
    Console.Write("Enter Password: ");
    string newPassword = Console.ReadLine() ?? "";

    if (authService.Register(newEmail, newPassword, fName))
    {
        bool verified = false;
        while (!verified)
        {
            string verificationCode = new Random().Next(1000, 9999).ToString();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\n[System] Sending verification code to {newEmail}...");
            Console.ResetColor();
            emailService.SendVerificationEmail(newEmail, fName, verificationCode);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- Verification Required ---");
            Console.ResetColor();
            Console.WriteLine("Enter the 4-digit code OR type 'RESEND' to get a new one.");
            Console.Write("Input: ");
            string input = Console.ReadLine() ?? "";

            if (input.Equals("RESEND", StringComparison.OrdinalIgnoreCase)) continue;

            if (input == verificationCode)
            {
                verified = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[SUCCESS] Account verified! You may now login.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] Invalid code. 1: Try Again | 2: Resend | 3: Cancel");
                Console.ResetColor();
                string failChoice = Console.ReadLine() ?? "";
                if (failChoice == "2") continue;
                if (failChoice == "3") return;
            }
        }
    }
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- Login ---");
Console.ResetColor();
Console.Write("Email: ");
string inputEmail = Console.ReadLine() ?? "";
Console.Write("Password: ");
string inputPassword = Console.ReadLine() ?? "";

if (authService.ValidateLogin(inputEmail, inputPassword))
{
    var authorizedAdmins = new List<string> { "chkhetianisandro@gmail.com", "admin@system.com" };
    currentUser = new User
    {
        Email = inputEmail,
        FirstName = inputEmail.Split('@')[0],
        IsAdmin = authorizedAdmins.Any(e => e.Equals(inputEmail, StringComparison.OrdinalIgnoreCase)),
        IsVerified = true
    };
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid credentials.");
    Console.ResetColor();
    return;
}

// 4. Setup
var systemAdmin = new User { FirstName = "System", IsAdmin = true };
SeedMovies(systemAdmin, adminService, userService);

// 5. Main Loop
bool keepRunning = true;
while (keepRunning)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("=== Welcome, ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(currentUser.FirstName);

    if (currentUser.IsAdmin)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" [ADMIN]");
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(" ===");
    Console.ResetColor();

    Console.WriteLine("1: Sort & Export Movie List");
    Console.WriteLine("2: Write a Movie Review");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("S: Search Movies & Actors");
    Console.ResetColor();

    if (currentUser.IsAdmin)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("A: Admin Dashboard");
        Console.ResetColor();
    }

    Console.WriteLine("3: Change Password");
    Console.WriteLine("4: Change Name");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("5: Exit");
    Console.ResetColor();
    Console.Write("\nSelection: ");
    string mainChoice = Console.ReadLine()?.ToUpper() ?? "";

    switch (mainChoice)
    {
        case "1": RunExportLogic(currentUser, movieDb, userService); break;
        case "2": RunReviewLogic(currentUser, movieDb, userService); break;
        case "S": RunSearchPanel(searchService); break;
        case "A": if (currentUser.IsAdmin) RunAdminPanel(currentUser, movieDb, actorDb, adminService); break;
        case "3": RunPasswordChange(authService, currentUser); break;
        case "4":
            Console.Write("New Name: "); currentUser.FirstName = Console.ReadLine() ?? "User";
            break;
        case "5": keepRunning = false; break;
    }
}

// --- HELPER METHODS ---

void RunSearchPanel(SearchService searchSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("=== MOVIE & ACTOR SEARCH ENGINE ===");
    Console.ResetColor();
    Console.Write("Enter keyword (Title, Year, or Actor Name): ");
    string query = Console.ReadLine() ?? "";

    var (movies, actors) = searchSvc.GlobalSearch(query);

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n================ SEARCH RESULTS ================");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nMovies Found ({movies.Count}):");
    Console.ResetColor();

    if (!movies.Any())
    {
        Console.WriteLine("  No movies found matching your query.");
    }
    else
    {
        foreach (var m in movies)
        {
            double avg = m.Reviews.Any() ? m.Reviews.Average(r => r.Rating) : 0.0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  • {m.Title.ToUpper()}");
            Console.ResetColor();
            Console.WriteLine($" ({m.ReleaseYear}) - Rating: {avg:F1}/10 | {m.Duration.TotalMinutes} mins");
            if (m.Actors.Any())
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"    Cast: {string.Join(", ", m.Actors.Select(a => a.FirstName))}");
                Console.ResetColor();
            }
        }
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"\nActors Found ({actors.Count}):");
    Console.ResetColor();

    if (!actors.Any())
    {
        Console.WriteLine("  No actors found matching your query.");
    }
    else
    {
        foreach (var a in actors)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"  • {a.FirstName}");
            Console.ResetColor();
            Console.WriteLine($" (Age: {a.Age})");
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("\n================================================");
    Console.ResetColor();
    Console.WriteLine("Press any key to return to the main menu...");
    Console.ReadKey();
}

void RunAdminPanel(User user, List<Movie> mDb, List<Actor> aDb, AdminService adminSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("=== ADMIN DASHBOARD ===");
    Console.ResetColor();
    Console.WriteLine("1: Add Movie | 2: Remove Movie | 3: Manage Actors | 4: Back");
    string choice = Console.ReadLine() ?? "";

    if (choice == "1")
    {
        Console.Write("Title: "); string t = Console.ReadLine() ?? "";
        Console.Write("Year: "); int.TryParse(Console.ReadLine(), out int y);
        Console.Write("Duration (min): "); int.TryParse(Console.ReadLine(), out int d);
        var newMovie = new Movie { Title = t, ReleaseYear = y, Duration = TimeSpan.FromMinutes(d) };
        adminSvc.AddMovie(user, newMovie);
        if (!mDb.Contains(newMovie)) mDb.Add(newMovie);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[SUCCESS] Movie added.");
        Console.ResetColor();
    }
    else if (choice == "2")
    {
        Console.Write("Title to delete: "); string dt = Console.ReadLine() ?? "";
        var m = mDb.FirstOrDefault(x => x.Title.Equals(dt, StringComparison.OrdinalIgnoreCase));
        if (m != null)
        {
            mDb.Remove(m);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[SUCCESS] Movie removed.");
            Console.ResetColor();
        }
    }
    else if (choice == "3")
    {
        Console.WriteLine("1: Add Actor to Movie | 2: Remove Actor from Movie");
        string actC = Console.ReadLine() ?? "";
        Console.Write("Enter Movie Title to manage cast: ");
        string targetM = Console.ReadLine() ?? "";
        var movie = mDb.FirstOrDefault(m => m.Title.Equals(targetM, StringComparison.OrdinalIgnoreCase));

        if (movie == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] Movie not found.");
            Console.ResetColor();
        }
        else if (actC == "1")
        {
            Console.Write("Actor Name: "); string n = Console.ReadLine() ?? "";
            Console.Write("Age: "); int.TryParse(Console.ReadLine(), out int age);
            var newActor = new Actor { FirstName = n, Age = age };
            movie.Actors.Add(newActor);
            aDb.Add(newActor);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SUCCESS] {n} added to {movie.Title}.");
            Console.ResetColor();
        }
        else if (actC == "2")
        {
            Console.Write("Actor Name to remove: "); string an = Console.ReadLine() ?? "";
            var act = movie.Actors.FirstOrDefault(a => a.FirstName.Equals(an, StringComparison.OrdinalIgnoreCase));
            if (act != null)
            {
                movie.Actors.Remove(act);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[SUCCESS] {an} removed.");
                Console.ResetColor();
            }
        }
    }
    Console.ReadKey();
}

void RunReviewLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.Write("Movie Title: "); string t = Console.ReadLine() ?? "";
    var m = db.FirstOrDefault(x => x.Title.Equals(t, StringComparison.OrdinalIgnoreCase));
    if (m != null)
    {
        Console.Write("Score (1-10): "); double.TryParse(Console.ReadLine(), out double s);
        Console.Write("Comment: "); string c = Console.ReadLine() ?? "";
        uSvc.LeaveReview(user, m, s, c);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[SUCCESS] Review saved.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[ERROR] Movie not found.");
        Console.ResetColor();
    }
    Console.ReadKey();
}

void RunExportLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.WriteLine("\nSort: 1:Title|2:Year|3:Rating|4:Duration|5:Cast|6:Alpha Actors|7:Cast Age|8:EXPORT ALL");
    string choice = Console.ReadLine() ?? "1";
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("====================================================================================");
    sb.AppendLine($"FULL MOVIE DATABASE EXPORT | User: {user.Email} | {DateTime.Now}");
    sb.AppendLine("====================================================================================");

    if (choice == "8")
    {
        string[] labels = { "Title", "Year", "Rating", "Duration", "Cast", "Alpha Actors", "Cast Age" };
        for (int i = 1; i <= 7; i++)
        {
            sb.AppendLine($"\n>>> CATEGORY: {labels[i - 1].ToUpper()} <<<");
            BuildExportString(sb, db, uSvc, i.ToString());
            sb.AppendLine(new string('=', 80));
        }
    }
    else { BuildExportString(sb, db, uSvc, choice); }

    try
    {
        string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Movies");
        Directory.CreateDirectory(path);
        File.WriteAllText(Path.Combine(path, "ExportedMovieData.txt"), sb.ToString());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n--- CONSOLE EXPORT DISPLAY ---");
        Console.ResetColor();

        Console.WriteLine(sb.ToString());

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("--------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[SUCCESS] Full export saved to Desktop/Movies.");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ResetColor();
    }
    Console.ReadKey();
}

void BuildExportString(StringBuilder sb, List<Movie> db, UserService uSvc, string choice)
{
    var sorted = choice == "7"
        ? db.OrderByDescending(m => m.Actors.Any() ? m.Actors.Average(a => (double)a.Age) : 0).ToList()
        : uSvc.SortMovies(db, choice);

    foreach (var m in sorted)
    {
        var actors = choice == "6" ? m.Actors.OrderBy(a => a.FirstName).ToList() : m.Actors;
        double avg = m.Reviews.Any() ? m.Reviews.Average(r => r.Rating) : 0.0;

        sb.AppendLine($"\nTITLE: {m.Title.ToUpper()}");
        sb.AppendLine($"Year: {m.ReleaseYear} | Duration: {m.Duration.TotalMinutes} min | Avg Rating: {avg:F1}/10");
        sb.AppendLine($"Cast: {string.Join(", ", actors.Select(a => $"{a.FirstName} ({a.Age})"))}");

        if (m.Reviews.Any())
        {
            sb.AppendLine($"Reviews ({m.Reviews.Count}):");
            foreach (var rev in m.Reviews)
                sb.AppendLine($"  - [{rev.Rating}/10] {rev.Comment} (User: {rev.UserEmail})");
        }
        else { sb.AppendLine("Reviews: No reviews yet."); }
        sb.AppendLine(new string('-', 50));
    }
}

void RunPasswordChange(AuthService authSvc, User user)
{
    Console.Write("Current Pass: "); string op = Console.ReadLine() ?? "";
    Console.Write("New Pass: "); string np = Console.ReadLine() ?? "";
    if (authSvc.ChangePassword(user.Email, op, np)) Environment.Exit(0);
}

void SeedMovies(User adminUser, AdminService adminSvc, UserService userSvc)
{
    foreach (var entry in MovieLibrary.GetSeedData())
    {
        if (!movieDb.Any(m => m.Title == entry.Movie.Title))
        {
            entry.Movie.Actors = entry.Cast;
            adminSvc.AddMovie(adminUser, entry.Movie);
            userSvc.LeaveReview(adminUser, entry.Movie, (double)entry.Rating, "System Seed");
        }
    }
}