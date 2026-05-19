using MovieManagementSystem.Models;
using MovieManagementSystem.Services;
using MovieManagementSystem.Validators;
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

// 2. Main Authentication & Guard Loop
while (currentUser == null)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("=== MOVIE MANAGEMENT SYSTEM ===");
    Console.WriteLine("---------------------------------");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Create Account");
    Console.WriteLine("3. Exit Application");
    Console.WriteLine("---------------------------------");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Selection: ");
    Console.ResetColor();
    string authChoice = Console.ReadLine() ?? "";

    if (authChoice == "3") return;

    // --- REGISTRATION FLOW ---
    if (authChoice == "2")
    {
        bool registrationSuccessful = false;
        while (!registrationSuccessful)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- REGISTER NEW ACCOUNT ---");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("First Name: ");
            string fName = Console.ReadLine() ?? "";
            Console.Write("Email: ");
            string newEmail = Console.ReadLine() ?? "";
            Console.Write("Password: ");
            string newPassword = Console.ReadLine() ?? "";

            var userValidation = UserValidator.ValidateRegistration(fName, newEmail, newPassword);
            if (!userValidation.IsValid)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[ERROR] {userValidation.ErrorMessage}");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to correct your inputs...");
                Console.ReadKey();
                continue;
            }

            if (authService.Register(newEmail, newPassword, fName))
            {
                bool verified = false;
                bool abortVerification = false;

                while (!verified && !abortVerification)
                {
                    string verificationCode = new Random().Next(1000, 9999).ToString();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"[System] Verification token dispatched to {newEmail}.");
                    Console.ResetColor();
                    emailService.SendVerificationEmail(newEmail, fName, verificationCode);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n--- VERIFICATION REQUIRED ---");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("(Enter 4-digit code or type 'RESEND')");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Input: ");
                    Console.ResetColor();
                    string input = Console.ReadLine() ?? "";

                    if (input.Equals("RESEND", StringComparison.OrdinalIgnoreCase)) continue;

                    if (input == verificationCode)
                    {
                        verified = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\n[SUCCESS] Account verified successfully!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("Press any key to go straight to the login screen...");
                        Console.ReadKey();

                        registrationSuccessful = true;
                        authChoice = "1";
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n[ERROR] Incorrect code.");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("1: Try Again | 2: Resend Code | 3: Cancel Registration");
                        Console.Write("Choice: ");
                        string failChoice = Console.ReadLine() ?? "";
                        if (failChoice == "2") continue;
                        if (failChoice == "3") abortVerification = true;
                    }
                }
                if (abortVerification) break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n[ERROR] This email is already registered to an account.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                break;
            }
        }
    }

    // --- LOGIN FLOW ---
    if (authChoice == "1")
    {
        int maxAttempts = 3;
        int currentAttempt = 0;

        while (currentUser == null && currentAttempt < maxAttempts)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--- ACCOUNT LOGIN ---");
            Console.ResetColor();
            Console.WriteLine();

            if (currentAttempt > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[WARNING] Invalid email or password. Attempts remaining: {maxAttempts - currentAttempt}");
                Console.ResetColor();
                Console.WriteLine();
            }

            Console.Write("Email: ");
            string inputEmail = Console.ReadLine() ?? "";
            Console.Write("Password: ");
            string inputPassword = Console.ReadLine() ?? "";

            if (authService.ValidateLogin(inputEmail, inputPassword))
            {
                var authorizedAdmins = new List<string> { "chkhetianisandro@gmail.com", "admin@system.com" };

                var registeredUser = authService.GetUser(inputEmail);

                currentUser = new User
                {
                    Email = inputEmail,
                    FirstName = registeredUser != null ? registeredUser.FirstName : inputEmail.Split('@')[0],
                    IsAdmin = authorizedAdmins.Any(e => e.Equals(inputEmail, StringComparison.OrdinalIgnoreCase)),
                    IsVerified = true
                };
            }
            else
            {
                currentAttempt++;
                if (currentAttempt >= maxAttempts)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n[ERROR] Too many failed attempts. Returning to the main screen.");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }
    }
}

// 3. Setup / Movie Seeding
var systemAdmin = new User { FirstName = "System", IsAdmin = true, Email = "system@database.local" };
SeedMovies(systemAdmin, adminService, userService);
Console.Clear();

// 4. Main Menu Application Loop
bool keepRunning = true;
while (keepRunning)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("=== WELCOME BACK, ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(currentUser.FirstName.ToUpper());

    if (currentUser.IsAdmin)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" [ADMIN] ===");
    }
    else
    {
        Console.Write(" ===");
    }
    Console.WriteLine();
    Console.WriteLine("---------------------------------");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("1. Sort & Export Movies");
    Console.WriteLine("2. Leave a Movie Review");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("S. Search");
    Console.ResetColor();

    if (currentUser.IsAdmin)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("A. Admin Dashboard");
        Console.ResetColor();
    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("3. Change Password");
    Console.WriteLine("4. Update Display Name");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("5. Exit");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nSelection: ");
    Console.ResetColor();
    string mainChoice = Console.ReadLine()?.ToUpper() ?? "";

    switch (mainChoice)
    {
        case "1": RunExportLogic(currentUser, movieDb, userService); break;
        case "2": RunReviewLogic(currentUser, movieDb, userService); break;
        case "S": RunSearchPanel(searchService); break;
        case "A": if (currentUser.IsAdmin) RunAdminPanel(currentUser, movieDb, actorDb, adminService); break;
        case "3": RunPasswordChange(authService, currentUser); break;
        case "4":
            Console.Write("\nEnter New Display Name: ");
            currentUser.FirstName = Console.ReadLine() ?? "User";
            break;
        case "5": keepRunning = false; break;
    }
}

return;

// --- HELPER METHODS ---

void RunSearchPanel(SearchService searchSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("=== MOVIE & ACTOR SEARCH ===");
    Console.WriteLine("-------------------------------------------");
    Console.ResetColor();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Search Criteria (Title, Year, or Actor Name): ");
    Console.ResetColor();
    string query = Console.ReadLine() ?? "";

    var (movies, actors) = searchSvc.GlobalSearch(query);

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n----------------------- MATCHING ENTRIES -----------------------");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"\nMOVIES FOUND ({movies.Count}):");
    Console.ResetColor();

    if (!movies.Any())
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  No movies found matching your search.");
        Console.ResetColor();
    }
    else
    {
        foreach (var m in movies)
        {
            double avg = m.Reviews.Any() ? m.Reviews.Average(r => r.Rating) : 0.0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"* {m.Title.ToUpper()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" ({m.ReleaseYear})");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" [{avg:F1}/10 Stars]");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" - {m.Duration.TotalMinutes} mins");
            Console.ResetColor();

            if (m.Actors.Any())
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine($"  Cast Data: {string.Join(", ", m.Actors.Select(a => $"{a.FirstName} {a.LastName}"))}");
                Console.ResetColor();
            }

            if (m.Reviews.Any())
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("  User Reviews:");
                foreach (var r in m.Reviews)
                {
                    Console.WriteLine($"    - [{r.Rating}/10] \"{r.Comment}\" ({r.UserEmail})");
                }
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine($"\nACTORS FOUND ({actors.Count}):");
    Console.ResetColor();

    if (!actors.Any())
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("  No actors found matching your search.");
        Console.ResetColor();
    }
    else
    {
        foreach (var a in actors)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"* {a.FirstName} {a.LastName}");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($" (Age: {a.Age})");
            Console.ResetColor();
        }
    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\n-----------------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("Press any key to return to the main menu...");
    Console.ResetColor();
    Console.ReadKey();
}

void RunAdminPanel(User user, List<Movie> mDb, List<Actor> aDb, AdminService adminSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("=== ADMINISTRATOR CONTROL BLOCK ===");
    Console.WriteLine("-----------------------------------");
    Console.ResetColor();
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("1. Add Movie");
    Console.WriteLine("2. Remove Movie");
    Console.WriteLine("3. Manage Cast List (Quick Direct Edit)");
    Console.WriteLine("4. Delete a User Review");
    Console.WriteLine("5. Update Movie Details (Alter Name, Year, Duration, Cast)");
    Console.WriteLine("6. Return to Main Menu");
    Console.WriteLine("-----------------------------------");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Selection: ");
    Console.ResetColor();
    string choice = Console.ReadLine() ?? "";

    if (choice == "1")
    {
        Console.Write("\nMovie Title: "); string t = Console.ReadLine() ?? "";
        Console.Write("Release Year: "); int.TryParse(Console.ReadLine(), out int y);
        Console.Write("Runtime (Minutes): "); int.TryParse(Console.ReadLine(), out int d);
        var newMovie = new Movie { Title = t, ReleaseYear = y, Duration = TimeSpan.FromMinutes(d) };
        adminSvc.AddMovie(user, newMovie);
        if (!mDb.Contains(newMovie)) mDb.Add(newMovie);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n[SUCCESS] Movie added to the database.");
        Console.ResetColor();
    }
    else if (choice == "2")
    {
        Console.Write("\nMovie Title to Remove: "); string dt = Console.ReadLine() ?? "";
        var m = mDb.FirstOrDefault(x => x.Title.Equals(dt, StringComparison.OrdinalIgnoreCase));
        if (m != null)
        {
            mDb.Remove(m);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[SUCCESS] Movie removed from the database.");
            Console.ResetColor();
        }
    }
    else if (choice == "3")
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--- Cast Management ---");
        Console.WriteLine("1: Add Actor to Movie");
        Console.WriteLine("2: Remove Actor from Movie");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Selection: ");
        Console.ResetColor();
        string actC = Console.ReadLine() ?? "";

        Console.Write("Movie Title: ");
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
            Console.Write("Actor First Name: "); string fn = Console.ReadLine() ?? "";
            Console.Write("Actor Last Name: "); string ln = Console.ReadLine() ?? "";
            Console.Write("Actor Age: "); int.TryParse(Console.ReadLine(), out int age);

            var newActor = new Actor { FirstName = fn, LastName = ln, Age = age };
            movie.Actors.Add(newActor);
            aDb.Add(newActor);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[SUCCESS] {fn} {ln} added to {movie.Title}.");
            Console.ResetColor();
        }
        else if (actC == "2")
        {
            Console.Write("Actor First Name to Remove: "); string rfn = Console.ReadLine() ?? "";
            Console.Write("Actor Last Name to Remove: "); string rln = Console.ReadLine() ?? "";

            var act = movie.Actors.FirstOrDefault(a =>
                a.FirstName.Equals(rfn, StringComparison.OrdinalIgnoreCase) &&
                a.LastName.Equals(rln, StringComparison.OrdinalIgnoreCase));

            if (act != null)
            {
                movie.Actors.Remove(act);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"[SUCCESS] {rfn} {rln} removed from cast list.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] Actor not found in this movie's cast.");
                Console.ResetColor();
            }
        }
    }
    else if (choice == "4")
    {
        Console.Write("\nMovie Title: ");
        string targetM = Console.ReadLine() ?? "";
        var movie = mDb.FirstOrDefault(m => m.Title.Equals(targetM, StringComparison.OrdinalIgnoreCase));

        if (movie == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] That movie does not exist in the database.");
            Console.ResetColor();
        }
        else if (!movie.Reviews.Any())
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("This movie has no reviews yet.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n--- CURRENT MOVIE REVIEWS ---");
            Console.ResetColor();
            for (int i = 0; i < movie.Reviews.Count; i++)
            {
                Console.WriteLine($"[{i}] User: {movie.Reviews[i].UserEmail} | Rating: {movie.Reviews[i].Rating}/10\n  \"{movie.Reviews[i].Comment}\"");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nSelect Review Number to Delete: ");
            Console.ResetColor();
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < movie.Reviews.Count)
            {
                movie.Reviews.RemoveAt(index);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[SUCCESS] Review deleted successfully.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[ERROR] Invalid selection number.");
                Console.ResetColor();
            }
        }
    }
    // --- MOVIE UPDATE SYSTEM (OPTION 5) ---
    else if (choice == "5")
    {
        Console.Write("\nEnter exact Title of the movie to update: ");
        string searchTitle = Console.ReadLine() ?? "";
        var targetMovie = mDb.FirstOrDefault(m => m.Title.Equals(searchTitle, StringComparison.OrdinalIgnoreCase));

        if (targetMovie == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[ERROR] Movie matching that title was not found.");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n--- EDIT PROPERTIES FOR: {targetMovie.Title.ToUpper()} ---");
            Console.ResetColor();
            Console.WriteLine("(Leave input blank and press Enter to keep current value)");


            Console.Write($"New Title [{targetMovie.Title}]: ");
            string inputtedTitle = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(inputtedTitle)) targetMovie.Title = inputtedTitle;


            Console.Write($"New Release Year [{targetMovie.ReleaseYear}]: ");
            string inputtedYearStr = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(inputtedYearStr) && int.TryParse(inputtedYearStr, out int parsedYear))
            {
                targetMovie.ReleaseYear = parsedYear;
            }

            Console.Write($"New Duration in Minutes [{targetMovie.Duration.TotalMinutes} min]: ");
            string inputtedDurStr = Console.ReadLine() ?? "";
            if (!string.IsNullOrWhiteSpace(inputtedDurStr) && int.TryParse(inputtedDurStr, out int parsedMins))
            {
                targetMovie.Duration = TimeSpan.FromMinutes(parsedMins);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n--- CAST MODIFICATION PANEL ---");
            Console.WriteLine("1: Clear and completely rewrite the cast list");
            Console.WriteLine("2: Keep current cast listing as is");
            Console.Write("Selection: ");
            Console.ResetColor();
            string castOption = Console.ReadLine() ?? "";

            if (castOption == "1")
            {
                targetMovie.Actors.Clear();
                Console.Write("\nHow many actors are in this new cast? ");
                int.TryParse(Console.ReadLine(), out int countOfActors);

                for (int i = 0; i < countOfActors; i++)
                {
                    Console.WriteLine($"\nActor #{i + 1}:");
                    Console.Write("  First Name: "); string fName = Console.ReadLine() ?? "";
                    Console.Write("  Last Name: "); string lName = Console.ReadLine() ?? "";
                    Console.Write("  Age: "); int.TryParse(Console.ReadLine(), out int actorAge);

                    var freshActor = new Actor { FirstName = fName, LastName = lName, Age = actorAge };
                    targetMovie.Actors.Add(freshActor);

                    if (!aDb.Any(a => a.FirstName.Equals(fName, StringComparison.OrdinalIgnoreCase) &&
                                      a.LastName.Equals(lName, StringComparison.OrdinalIgnoreCase)))
                    {
                        aDb.Add(freshActor);
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[SUCCESS] Movie profile settings updated in memory!");
            Console.ResetColor();
        }
    }
    Console.ReadKey();
}

void RunReviewLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--- WRITE A MOVIE REVIEW ---");
    Console.ResetColor();
    Console.WriteLine();

    Console.Write("Movie Title: "); string t = Console.ReadLine() ?? "";
    var m = db.FirstOrDefault(x => x.Title.Equals(t, StringComparison.OrdinalIgnoreCase));

    if (m != null)
    {
        Console.Write("Rating Score (0-10): "); double.TryParse(Console.ReadLine(), out double s);
        Console.Write("Write a review: "); string c = Console.ReadLine() ?? "";

        var reviewValidation = ReviewValidator.ValidateReview(m, user.Email, s, c);
        if (!reviewValidation.IsValid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n[ERROR] Review Rejected: {reviewValidation.ErrorMessage}");
            Console.ResetColor();
        }
        else
        {
            uSvc.LeaveReview(user, m, s, c);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n[SUCCESS] Review added successfully!");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n[ERROR] Movie not found.");
        Console.ResetColor();
    }
    Console.ReadKey();
}

void RunExportLogic(User user, List<Movie> db, UserService uSvc)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--- SORT & EXPORT MOVIES ---");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("1:Title | 2:Year | 3:Rating | 4:Duration | 5:Cast");
    Console.WriteLine("6:Actors from A to Z | 7:Cast Age | 8:EXPORT ALL");
    Console.WriteLine("-------------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Selection Type: ");
    Console.ResetColor();

    string choice = Console.ReadLine() ?? "1";
    StringBuilder sb = new StringBuilder();
    sb.AppendLine("====================================================================================");
    sb.AppendLine($"FULL MOVIE DATABASE EXPORT | User: {user.Email} | {DateTime.Now}");
    sb.AppendLine("====================================================================================");

    if (choice == "8")
    {
        string[] labels = { "Title", "Year", "Rating", "Duration", "Cast", "Actors from A to Z", "Cast Age" };
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
        Console.WriteLine("\n------------------- CONSOLE STREAM DISPLAY -------------------");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine(sb.ToString());
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("-----------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[SUCCESS] File saved successfully to your Desktop.");
        Console.ResetColor();
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[ERROR] Could not save file: {ex.Message}");
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
        var actors = choice == "6" ? m.Actors.OrderBy(a => a.FirstName).ThenBy(a => a.LastName).ToList() : m.Actors;
        double avg = m.Reviews.Any() ? m.Reviews.Average(r => r.Rating) : 0.0;

        sb.AppendLine($"\nTITLE: {m.Title.ToUpper()}");
        sb.AppendLine($"Year: {m.ReleaseYear} | Duration: {m.Duration.TotalMinutes} min | Avg Rating: {avg:F1}/10");

        sb.AppendLine($"Cast: {string.Join(", ", actors.Select(a => $"{a.FirstName} {a.LastName} ({a.Age})"))}");

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
    Console.Clear();
    Console.WriteLine();
    Console.Write("Enter Current Password: "); string op = Console.ReadLine() ?? "";
    Console.Write("Enter New Password: "); string np = Console.ReadLine() ?? "";
    if (authSvc.ChangePassword(user.Email, op, np)) Environment.Exit(0);
}

void SeedMovies(User adminUser, AdminService adminSvc, UserService userSvc)
{
    foreach (var entry in MovieLibrary.GetSeedData())
    {
        if (!movieDb.Any(m => m.Title == entry.Movie.Title))
        {
            entry.Movie.Actors = entry.Cast.ToList();
            adminSvc.AddMovie(adminUser, entry.Movie);
            userSvc.LeaveReview(adminUser, entry.Movie, (double)entry.Rating, "System Seed");

            foreach (var actor in entry.Cast)
            {
                if (!actorDb.Any(a =>
                    a.FirstName.Equals(actor.FirstName, StringComparison.OrdinalIgnoreCase) &&
                    a.LastName.Equals(actor.LastName, StringComparison.OrdinalIgnoreCase)))
                {
                    actorDb.Add(actor);
                }
            }
        }
    }
}