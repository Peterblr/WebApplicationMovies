using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class CollectionMovies
    {
        [Key]
        public int CollectionMoviesID { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public double Score { get; set; }

        public bool IsPublic { get; set; }

        //User

        //Movies
    }
}
