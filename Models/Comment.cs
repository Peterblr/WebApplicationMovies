using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        public string CommentItem { get; set; }

        public DateTime CreateDate { get; set; }

        public string Author { get; set; }

        //Movie
        public int MovieID { get; set; }

        public Movie Movie { get; set; }

        //User
        public int UserID { get; set; }

        public User User { get; set; }
    }
}
