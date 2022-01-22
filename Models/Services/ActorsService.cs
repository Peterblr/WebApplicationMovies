using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMovies.Data;
using WebApplicationMovies.Models.Repositories;

namespace WebApplicationMovies.Models.Services
{
    public class ActorsService : BaseRepository<Actor>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context)
        {

        }
    }
}
