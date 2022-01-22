using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMovies.Models.Repositories;

namespace WebApplicationMovies.Models.Services
{
    public interface IActorsService : IRepository<Actor>
    {
    }
}
