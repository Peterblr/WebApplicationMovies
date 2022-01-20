using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMovies.Data;
using WebApplicationMovies.Models;

namespace WebApplicationMovies.Controllers
{
    public class CollectionMoviesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CollectionMoviesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CollectionMovies
        public async Task<IActionResult> Index()
        {
            return View(await _context.CollectionMovies.ToListAsync());
        }

        // GET: CollectionMovies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectionMovie = await _context.CollectionMovies
                .FirstOrDefaultAsync(m => m.CollectionMovieID == id);
            if (collectionMovie == null)
            {
                return NotFound();
            }

            return View(collectionMovie);
        }

        // GET: CollectionMovies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CollectionMovies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CollectionMovieID,ImageURL,Description,Score,IsPublic,UserID")] CollectionMovie collectionMovie)
        {
            if (ModelState.IsValid)
            {
                _context.Add(collectionMovie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(collectionMovie);
        }

        // GET: CollectionMovies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectionMovie = await _context.CollectionMovies.FindAsync(id);
            if (collectionMovie == null)
            {
                return NotFound();
            }
            return View(collectionMovie);
        }

        // POST: CollectionMovies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CollectionMovieID,ImageURL,Description,Score,IsPublic,UserID")] CollectionMovie collectionMovie)
        {
            if (id != collectionMovie.CollectionMovieID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(collectionMovie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CollectionMovieExists(collectionMovie.CollectionMovieID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(collectionMovie);
        }

        // GET: CollectionMovies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var collectionMovie = await _context.CollectionMovies
                .FirstOrDefaultAsync(m => m.CollectionMovieID == id);
            if (collectionMovie == null)
            {
                return NotFound();
            }

            return View(collectionMovie);
        }

        // POST: CollectionMovies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var collectionMovie = await _context.CollectionMovies.FindAsync(id);
            _context.CollectionMovies.Remove(collectionMovie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CollectionMovieExists(int id)
        {
            return _context.CollectionMovies.Any(e => e.CollectionMovieID == id);
        }
    }
}
