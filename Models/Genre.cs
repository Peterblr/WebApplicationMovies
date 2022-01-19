using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }

        public string GenreName { get; set; }

        //Relationships
        //Movies
        public List<Movie> Movies { get; set; }
    }
}
