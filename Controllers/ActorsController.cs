using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationMovies.Data;
using WebApplicationMovies.Models;
using WebApplicationMovies.Models.Repositories;

namespace WebApplicationMovies.Controllers
{
    public class ActorsController : Controller
    {
        private IRepository<Actor> _repository = null;

        public ActorsController(IRepository<Actor> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var model = _repository.GetAll();
            return View(model);
        }
        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Actor model)
        {
            if (ModelState.IsValid)
            {
                _repository.Insert(model);
                _repository.Save();
                return RedirectToAction("Index", "Actors");
            }
            return View();
        }
        [HttpGet]
        public ActionResult EditEmployee(int EmployeeId)
        {
            Actor model = _repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult EditEmployee(Actor model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                _repository.Save();
                return RedirectToAction("Index", "Actors");
            }
            else
            {
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
            Actor model = _repository.GetById(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _repository.Delete(EmployeeID);
            _repository.Save();
            return RedirectToAction("Index", "Employee");
        }

        //private readonly ApplicationDbContext _context;

        //private readonly IRepository<Actor> _service;


        //public ActorsController(IRepository<Actor> service)
        //{
        //    _service = service;
        //}

        //// GET: Actors
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _service.GetAllAsync());
        //}

        //// GET: Actors/Details/5
        //public async Task<IActionResult> Details(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actor);
        //}

        //// GET: Actors/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Actors/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ActorID,FirstName,LastName,ImageURL,DayOfBirth")] Actor actor)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        await _service.AddAsync(actor);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(actor);
        //}

        //// GET: Actors/Edit/5
        //public async Task<IActionResult> Edit(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(actor);
        //}

        //// POST: Actors/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("ActorID,FirstName,LastName,ImageURL,DayOfBirth")] Actor actor)
        //{
        //    if (id != actor.ActorID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        //try
        //        //{
        //        //    await _service.UpdateAsync(id, actor);
        //        //}
        //        //catch (DbUpdateConcurrencyException)
        //        //{
        //        //    if (!ActorExists(actor.ActorID))
        //        //    {
        //        //        return NotFound();
        //        //    }
        //        //    else
        //        //    {
        //        //        throw;
        //        //    }
        //        //}
        //        await _service.UpdateAsync(id, actor);

        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(actor);
        //}

        //// GET: Actors/Delete/5
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);
        //    if (actor == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(actor);
        //}

        //// POST: Actors/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var actor = await _service.GetByIdAsync(id);

        //    await _service.DeleteAsync(id);

        //    return RedirectToAction(nameof(Index));
        //}

        ////private bool ActorExists(int id)
        ////{
        ////    return _service.Actors.Any(e => e.ActorID == id);
        ////}
    }
}
