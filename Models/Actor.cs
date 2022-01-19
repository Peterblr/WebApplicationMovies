using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ImageURL { get; set; }

        public DateTime DayOfBirth { get; set; }

        //Relationship
        //Movie
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
