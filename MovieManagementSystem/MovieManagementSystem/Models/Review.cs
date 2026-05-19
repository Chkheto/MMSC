using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementSystem.Models
{
    internal class Review
    {
      
        public string UserEmail { get; set; } = string.Empty;
        public double Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public DateTime DatePosted { get; set; }
    }
}
