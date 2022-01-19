using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApplicationMovies.Models;

namespace WebApplicationMovies.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<CollectionMovie> CollectionMovies { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Score> Scores { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
