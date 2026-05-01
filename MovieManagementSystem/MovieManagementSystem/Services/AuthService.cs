using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MovieManagementSystem.Services
{
    internal class AuthService
    {
        private string _filePath = @"C:\Users\PC\Desktop\Movies\Users.json";
        private Dictionary<string, string> _users = new();

        public AuthService()
        {
            LoadUsers();
        }

        public bool Register(string email, string password)
        {
            email = email.ToLower().Trim();
            if (_users.ContainsKey(email)) return false;
            _users.Add(email, password.Trim());
            SaveUsers();
            return true;
        }

        public bool ValidateLogin(string email, string password)
        {
            email = email.ToLower().Trim();
            string cleanPass = password.Trim();
            return _users.ContainsKey(email) && _users[email] == cleanPass;
        }

        private void LoadUsers()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _users = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new();
            }
        }

        private void SaveUsers()
        {
            string directory = Path.GetDirectoryName(_filePath)!;
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            string json = JsonSerializer.Serialize(_users);
            File.WriteAllText(_filePath, json);
        }
        public bool ChangePassword(string email, string oldPassword, string newPassword)
        {
            email = email.ToLower().Trim();
            if (_users.ContainsKey(email) && _users[email] == oldPassword.Trim())
            {
                _users[email] = newPassword.Trim();
                SaveUsers(); 
                return true;
            }
            return false;
        }
    }
}
