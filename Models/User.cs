using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public enum Role
    {
        Guest, User, Admin
    }

    public class User
    {
        public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageURL { get; set; }

        public DateTime DayOfBirth { get; set; }

        public Role Role { get; set; }

        //Score

        //UserMovies

        //Comments
    }
}
