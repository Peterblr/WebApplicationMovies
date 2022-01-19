﻿using System;
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

        [ForeignKey("GenreID")]
        public Genre Genre { get; set; }

        //Producer
        public int ProducerID { get; set; }

        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }

        //Comment
        public virtual ICollection<Comment> Comments { get; set; }

        //Score
        public virtual ICollection<Score> Scores { get; set; }

        //CollectionMovie
        public int CollectionMovieID { get; set; }

        [ForeignKey("CollectionMovieID")]
        public CollectionMovie CollectionMovie { get; set; }
    }
}
