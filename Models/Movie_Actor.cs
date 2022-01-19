using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Movie_Actor
    {
        //Movies
        public int MovieID { get; set; }

        public Movie Movie { get; set; }
        //Actors 
        public int ActorID { get; set; }
        public Actor Actor { get; set; }
    }
}
