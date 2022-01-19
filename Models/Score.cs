using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        //Movies
    }
}
