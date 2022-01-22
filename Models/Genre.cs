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

        [Required, StringLength(30, MinimumLength = 3)]
        public string GenreName { get; set; }

        //Relationships
        //Movies
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
