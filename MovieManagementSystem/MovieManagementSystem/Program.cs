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

    if (authService.Register(newEmail, newPassword))
    {
        // 2FA - ONLY RUNS DURING REGISTRATION
        string verificationCode = new Random().Next(1000, 9999).ToString();
        Console.WriteLine($"\n[System] Sending verification code to {newEmail}...");
        emailService.SendVerificationEmail(newEmail, fName, verificationCode);

        Console.Write("Enter your 4-digit verification code: ");
        string inputCode = Console.ReadLine() ?? "";

        if (inputCode != verificationCode)
        {
            Console.WriteLine("\n[ERROR] Invalid verification code. Registration failed.");
            return;
        }
        Console.WriteLine("[SUCCESS] Account verified! You may now login.");
    }
    else
    {
        Console.WriteLine("[ERROR] Email already exists.");
        return;
    }
}

Console.WriteLine("\n--- Login ---");
Console.Write("Email: ");
string inputEmail = Console.ReadLine() ?? "";
Console.Write("Password: ");
string inputPassword = Console.ReadLine() ?? "";

if (authService.ValidateLogin(inputEmail, inputPassword))
{
    // PRO-TIP: Centralized Admin List
    var authorizedAdmins = new List<string>
    {
        "chkhetianisandro@gmail.com",
        "admin@system.com",
        "manager@system.com"
    };

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
    Console.WriteLine("\n[ERROR] Invalid credentials.");
    return;
}

// 4. Main Application Setup
var systemAdmin = new User { FirstName = "System", IsAdmin = true };
SeedMovies(systemAdmin, adminService, userService);

// 5. THE MAIN MENU
bool keepRunning = true;
while (keepRunning)
{
    Console.Clear();
    string adminBadge = currentUser.IsAdmin ? " [ADMIN]" : "";
    Console.WriteLine($"=== Welcome, {currentUser.FirstName}{adminBadge} ===");
    Console.WriteLine("1: Sort & Export Movie List");
    Console.WriteLine("2: Write a Movie Review");

    if (currentUser.IsAdmin) Console.WriteLine("A: Admin Dashboard (Manage Data)");

    Console.WriteLine("3: Change Account Password");
    Console.WriteLine("4: Change Account Name");
    Console.WriteLine("5: Exit");
    Console.Write("\nSelection: ");
    string mainChoice = Console.ReadLine()?.ToUpper() ?? "";

    switch (mainChoice)
    {
        case "1": RunExportLogic(currentUser, movieDb, userService); break;
        case "2": RunReviewLogic(currentUser, movieDb, userService); break;
        case "A": if (currentUser.IsAdmin) RunAdminPanel(movieDb); break;
        case "3": RunPasswordChange(authService, currentUser); break;
        case "4":
            Console.Write("\nEnter new account name: ");
            currentUser.FirstName = Console.ReadLine() ?? "User";
            Console.WriteLine("[SUCCESS] Name updated! Press any key.");
            Console.ReadKey();
            break;
        case "5": keepRunning = false; break;
    }
}

// --- HELPER METHODS ---

void RunAdminPanel(List<Movie> db)
{
    Console.Clear();
    Console.WriteLine("=== ADMIN DASHBOARD ===");
    Console.WriteLine("1: Remove a Movie");
    Console.WriteLine("2: Moderate Reviews (Delete)");
    Console.WriteLine("3: Back");
    Console.Write("Selection: ");
    string choice = Console.ReadLine() ?? "";

    if (choice == "1")
    {
        Console.Write("Enter Title to DELETE: ");
        string title = Console.ReadLine() ?? "";
        var movie = db.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (movie != null)
        {
            db.Remove(movie);
            Console.WriteLine($"[SUCCESS] '{movie.Title}' deleted.");
        }
        else Console.WriteLine("[ERROR] Not found.");
    }
    else if (choice == "2")
    {
        Console.Write("Enter Movie Title to moderate: ");
        string title = Console.ReadLine() ?? "";
        var movie = db.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (movie != null && movie.Reviews.Any())
        {
            for (int i = 0; i < movie.Reviews.Count; i++)
                Console.WriteLine($"{i + 1}: [{movie.Reviews[i].Rating}/10] {movie.Reviews[i].UserEmail}: {movie.Reviews[i].Comment}");

            Console.Write("\nDelete Review #: ");
            if (int.TryParse(Console.ReadLine(), out int idx) && idx > 0 && idx <= movie.Reviews.Count)
            {
                movie.Reviews.RemoveAt(idx - 1);
                Console.WriteLine("[SUCCESS] Review removed.");
            }
        }
        else Console.WriteLine("No reviews found.");
    }
    Console.WriteLine("\nPress any key...");
    Console.ReadKey();
}

void RunReviewLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.Clear();
    Console.Write("Enter exact Movie Title to review: ");
    string title = Console.ReadLine() ?? "";
    var movie = db.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

    if (movie != null)
    {
        Console.Write("Score (1-10): ");
        if (double.TryParse(Console.ReadLine(), out double score) && score >= 1 && score <= 10)
        {
            Console.Write("Comment: ");
            string comment = Console.ReadLine() ?? "";
            uSvc.LeaveReview(user, movie, score, comment);
            Console.WriteLine("[SUCCESS] Review added!");
        }
    }
    else Console.WriteLine("[ERROR] Movie not found.");
    Console.ReadKey();
}

void RunExportLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.WriteLine("\nSort: 1:Title|2:Year|3:Rating|4:Duration|5:Cast|6:Alpha Actors|7:Cast Age");
    string choice = Console.ReadLine() ?? "1";

    var sorted = choice == "7"
        ? db.OrderByDescending(m => m.Actors.Any() ? m.Actors.Average(a => a.Age) : 0).ToList()
        : uSvc.SortMovies(db, choice);

    StringBuilder sb = new StringBuilder();
    sb.AppendLine("====================================================================================");
    sb.AppendLine($"USER EXPORT: {user.Email} | {DateTime.Now}");
    sb.AppendLine("====================================================================================");

    foreach (var m in sorted)
    {
        var actors = choice == "6" ? m.Actors.OrderBy(a => a.FirstName).ToList() : m.Actors;
        sb.AppendLine($"\n{m.Title.ToUpper()} ({m.ReleaseYear}) | {m.AverageRating:F1}/10");
        sb.AppendLine($"Cast: {string.Join(", ", actors.Select(a => $"{a.FirstName} (Age: {a.Age})"))}");
        if (m.Reviews.Any()) sb.AppendLine($"Latest Review: \"{m.Reviews.Last().Comment}\"");
        sb.AppendLine(new string('-', 50));
    }

    string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Movies");
    Directory.CreateDirectory(path);
    File.WriteAllText(Path.Combine(path, "Export.txt"), sb.ToString());

    Console.WriteLine($"\n[SUCCESS] Saved to Desktop/Movies/Export.txt");
    Console.WriteLine("--- Preview ---");
    Console.WriteLine(sb.ToString());
    Console.ReadKey();
}

void RunPasswordChange(AuthService authSvc, User user)
{
    Console.Write("Current Password: ");
    string oldP = Console.ReadLine() ?? "";
    Console.Write("New Password: ");
    string newP = Console.ReadLine() ?? "";
    if (authSvc.ChangePassword(user.Email, oldP, newP))
    {
        Console.WriteLine("Success! App exiting.");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Fail. Incorrect credentials.");
        Console.ReadKey();
    }
}

void SeedMovies(User adminUser, AdminService adminSvc, UserService userSvc)
{
    foreach (var entry in MovieLibrary.GetSeedData())
    {
        entry.Movie.Actors = entry.Cast;
        adminSvc.AddMovie(adminUser, entry.Movie);
        userSvc.LeaveReview(adminUser, entry.Movie, entry.Rating, "IMDb Initial Seed");
    }
}