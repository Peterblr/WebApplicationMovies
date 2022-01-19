using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        //Relationships
        //Role
        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }

        //Score
        public List<Score> Scores { get; set; }

        //CollectionMovie
        public List<CollectionMovie> CollectionMovies { get; set; }

        //Comment
        public List<Comment> Comments { get; set; }
    }
}
