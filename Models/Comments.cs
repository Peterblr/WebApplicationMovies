﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMovies.Models
{
    public class Comments
    {
        [Key]
        public int CommentID { get; set; }

        public string Comment { get; set; }

        //Movies

        //User
    }
}
