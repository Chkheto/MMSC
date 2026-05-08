using MovieManagementSystem.Models;
using MovieManagementSystem.Services;
using System.Text;

// 1. Initializations
var movieDb = new List<Movie>();
var actorDb = new List<Actor>();
var userService = new UserService();
var adminService = new AdminService(movieDb, actorDb);
var emailService = new EmailService();
var authService = new AuthService();
User? currentUser = null;

Console.WriteLine("=== Movie Management System ===");
Console.WriteLine("1: Login");
Console.WriteLine("2: Create Account");
Console.Write("Selection: ");
string authChoice = Console.ReadLine() ?? "";

// 2. Authentication Flow
if (authChoice == "2")
{
    Console.WriteLine("\n--- Register New Account ---");
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
            Console.WriteLine($"\n[System] Sending verification code to {newEmail}...");
            emailService.SendVerificationEmail(newEmail, fName, verificationCode);

            Console.WriteLine("\n--- Verification Required ---");
            Console.WriteLine("Enter the 4-digit code OR type 'RESEND' to get a new one.");
            Console.Write("Input: ");
            string input = Console.ReadLine() ?? "";

            if (input.Equals("RESEND", StringComparison.OrdinalIgnoreCase)) continue;

            if (input == verificationCode)
            {
                verified = true;
                Console.WriteLine("[SUCCESS] Account verified! You may now login.");
            }
            else
            {
                Console.WriteLine("[ERROR] Invalid code. 1: Try Again | 2: Resend | 3: Cancel");
                string failChoice = Console.ReadLine() ?? "";
                if (failChoice == "2") continue;
                if (failChoice == "3") return;
            }
        }
    }
}

Console.WriteLine("\n--- Login ---");
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
else { Console.WriteLine("Invalid credentials."); return; }


// 4. Setup
var systemAdmin = new User { FirstName = "System", IsAdmin = true };
SeedMovies(systemAdmin, adminService, userService);

// 5. Main Loop
bool keepRunning = true;
while (keepRunning)
{
    Console.Clear();
    string badge = currentUser.IsAdmin ? " [ADMIN]" : "";
    Console.WriteLine($"=== Welcome, {currentUser.FirstName}{badge} ===");
    Console.WriteLine("1: Sort & Export Movie List\n2: Write a Movie Review");
    if (currentUser.IsAdmin) Console.WriteLine("A: Admin Dashboard");
    Console.WriteLine("3: Change Password\n4: Change Name\n5: Exit");
    Console.Write("\nSelection: ");
    string mainChoice = Console.ReadLine()?.ToUpper() ?? "";

    switch (mainChoice)
    {
        case "1": RunExportLogic(currentUser, movieDb, userService); break;
        case "2": RunReviewLogic(currentUser, movieDb, userService); break;
        case "A": if (currentUser.IsAdmin) RunAdminPanel(currentUser, movieDb, actorDb, adminService); break;
        case "3": RunPasswordChange(authService, currentUser); break;
        case "4":
            Console.Write("New Name: "); currentUser.FirstName = Console.ReadLine() ?? "User";
            break;
        case "5": keepRunning = false; break;
    }
}

// --- HELPER METHODS ---

void RunAdminPanel(User user, List<Movie> mDb, List<Actor> aDb, AdminService adminSvc)
{
    Console.Clear();
    Console.WriteLine("=== ADMIN DASHBOARD ===");
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
        Console.WriteLine("[SUCCESS] Movie added.");
    }
    else if (choice == "2")
    {
        Console.Write("Title to delete: "); string dt = Console.ReadLine() ?? "";
        var m = mDb.FirstOrDefault(x => x.Title.Equals(dt, StringComparison.OrdinalIgnoreCase));
        if (m != null) mDb.Remove(m);
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
            Console.WriteLine("[ERROR] Movie not found.");
        }
        else if (actC == "1")
        {
            Console.Write("Actor Name: "); string n = Console.ReadLine() ?? "";
            Console.Write("Age: "); int.TryParse(Console.ReadLine(), out int age);
            var newActor = new Actor { FirstName = n, Age = age };
            movie.Actors.Add(newActor);
            aDb.Add(newActor);
            Console.WriteLine($"[SUCCESS] {n} added to {movie.Title}.");
        }
        else if (actC == "2")
        {
            Console.Write("Actor Name to remove: "); string an = Console.ReadLine() ?? "";
            var act = movie.Actors.FirstOrDefault(a => a.FirstName.Equals(an, StringComparison.OrdinalIgnoreCase));
            if (act != null) movie.Actors.Remove(act);
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

        Console.WriteLine("\n--- CONSOLE PREVIEW (Partial Export) ---");
        string preview = sb.ToString();
        Console.WriteLine(preview.Length > 800 ? preview.Substring(0, 800) + "..." : preview);
        Console.WriteLine("\n[SUCCESS] Export saved to Desktop/Movies.");
    }
    catch (Exception ex) { Console.WriteLine(ex.Message); }
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