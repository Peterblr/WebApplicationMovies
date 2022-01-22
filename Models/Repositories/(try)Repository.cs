using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMovies.Data;

namespace WebApplicationMovies.Models.Repositories
{
    public class Repository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        protected DbSet<T> DbSet { get; set; }

        public Repository()
        {
            DbSet = _context.Set<T>();
        }

        public List<T> GetAll()
        {
            return DbSet.ToList();
        }

        public T Get(int id)
        {
            return DbSet.Find(id);
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
