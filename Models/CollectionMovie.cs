using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class CollectionMovie
    {
        [Key]
        public int CollectionMovieID { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public double Score { get; set; }

        public bool IsPublic { get; set; }

        //User
        public int UserID { get; set; }

        //Movie
        public List<Movie> Movies { get; set; }
    }
}
