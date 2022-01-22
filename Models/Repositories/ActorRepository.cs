using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMovies.Data;

namespace WebApplicationMovies.Models.Repositories
{
    public class ActorRepository : IRepository<Actor>
    {
        private readonly ApplicationDbContext _repository;


        public ActorRepository(ApplicationDbContext repository)
        {
            _repository = repository;
        }

        public void Create(Actor item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Actor Get(int id)
        {
            return _repository.Actors.Find(id);
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            return await _repository.Actors.ToListAsync();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Actor item)
        {
            throw new NotImplementedException();
        }
    }
}
