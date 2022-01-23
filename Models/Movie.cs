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

        [Display(Name = "Title"), StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DisplayFormat(NullDisplayText = "No Rating")]
        public Rating? Rating { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        //Relationship
        //Actor
        public virtual ICollection<Actor> Actors { get; set; }

        //Genre
        public int GenreID { get; set; }

        public virtual Genre Genre { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        //Producer
        public int ProducerID { get; set; }

        public virtual Producer Producer { get; set; }

        //Comment
        [ForeignKey("Comment")]
        public virtual ICollection<Comment> Comments { get; set; }

        //Score
        [ForeignKey("Score")]
        public virtual ICollection<Score> Scores { get; set; }

        //CollectionMovie
        public int CollectionMovieID { get; set; }

        public virtual CollectionMovie CollectionMovie { get; set; }
    }
}
