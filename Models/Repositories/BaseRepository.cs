using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMovies.Data;

namespace WebApplicationMovies.Models.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);

            EntityEntry entityEntry = _context.Entry<T>(item);

            entityEntry.State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
        //{
        //    return await _context.Set<T>().ToListAsync();
        //}

        public async Task<T> GetByIdAsync(int id) => await _context.Set<T>().FindAsync(id);
        //{
        //    //return await _context.Set<T>().FirstOrDefaultAsync(m => m.Equals(id));
        //    return await _context.Set<T>().FindAsync(id);
        //}

        public async Task UpdateAsync(int id, T item)
        {
            EntityEntry entityEntry = _context.Entry<T>(item);

            entityEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}
