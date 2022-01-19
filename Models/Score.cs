using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Score
    {
        [Key]
        public int ScoreID { get; set; }

        public double ScoreNumber { get; set; }

        //User
        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        //Movies
        public int MovieID { get; set; }

        [ForeignKey("MovieID")]
        public Movie Movie { get; set; }
    }
}
