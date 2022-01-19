using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public enum Rating
    {
        G, PG, PG13, R, NC17
    }

    public class Movie
    {
        [Key]
        public int MovieID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public Rating Rating { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        //Relationship
        //Actor
        public virtual ICollection<Actor> Actors { get; set; }

        //Genre
        public int GenreID { get; set; }

        //Producer
        public int ProducerID { get; set; }

        //Comment
        public int CommentID { get; set; }

        //Score
        public int ScoreID { get; set; }

        //CollectionMovie
        public int CollectionMovieID { get; set; }
    }
}
