using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MovieManagementSystem.Models;

namespace MovieManagementSystem.Services
{
    internal class AuthService
    {
        private readonly string _filePath;
        private List<User> _users = new();

        public AuthService()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "Movies");
            _filePath = Path.Combine(folderPath, "Users.json");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            LoadUsers();
        }

        public bool Register(string email, string password, string firstName)
        {
            email = email.ToLower().Trim();

            if (_users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
                return false;

            var newUser = new User
            {
                Email = email,
                Password = password.Trim(),
                FirstName = firstName.Trim(),
                IsVerified = true
            };

            _users.Add(newUser);
            SaveUsers();
            return true;
        }

        public bool ValidateLogin(string email, string password)
        {
            email = email.ToLower().Trim();
            string cleanPass = password.Trim();

            return _users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)
                                 && u.Password == cleanPass);
        }
        public User? GetUser(string email)
        {
            return _users.FirstOrDefault(u => u.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        private void LoadUsers()
        {
            if (File.Exists(_filePath))
            {
                try
                {
                    string json = File.ReadAllText(_filePath);
                    _users = JsonSerializer.Deserialize<List<User>>(json) ?? new();
                }
                catch { _users = new(); }
            }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(_users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            var user = _users.FirstOrDefault(u => u.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user != null && user.Password == oldPassword.Trim())
            {
                user.Password = newPassword.Trim();
                SaveUsers();
                return true;
            }
            return false;
        }

    }
}