using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }

        [Required, StringLength(300, MinimumLength = 3)]
        public string CommentItem { get; set; }

        public DateTime CreateDate { get; set; }

        public string Author { get; set; }

        //Movie
        public int MovieID { get; set; }

        //User
        public int UserID { get; set; }
    }
}
