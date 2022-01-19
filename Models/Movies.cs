using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public enum Rating
    {
        G, PG, PG13, R, NC17
    }

    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Rating Rating { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        //Genre

        //Movies_Actors

        //Producer

        //Comments

        //Score

        //CollectionMovie

    }
}
