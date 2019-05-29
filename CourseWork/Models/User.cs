using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
      
    }

    public class UserContext : DbContext
    {
        public UserContext() : base("DefaultConnection")

        {

        }

        public DbSet<User> Users { get; set; }
    }


}
