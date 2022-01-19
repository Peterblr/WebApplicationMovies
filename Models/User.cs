using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{

    public class User
    {
        [Key]
        public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageURL { get; set; }

        public DateTime DayOfBirth { get; set; }

        //Roles

        //Score

        //CollectionMovies

        //Comments
    }
}
