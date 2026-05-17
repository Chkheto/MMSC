using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementSystem.Models
{
internal class User
{
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = ""; 
        public bool IsAdmin { get; set; } = false;
        public bool IsVerified { get; set; } = false;
    }
}