using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Practice_1_ASP.Data;
using Practice_1_ASP.Entities;

namespace Practice_1_ASP.Controllers
{
    public class FilmController : Controller
    {
        private readonly FilmDbContext _context;

        public FilmController()
        {
            _context = new FilmDbContext();
        }

        // GET: Film
        public async Task<IActionResult> Index()
        {
            return View(await _context.Films.ToListAsync());
        }

        // GET: Film/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmModel = await _context.Films
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmModel == null)
            {
                return NotFound();
            }

            return View(filmModel);
        }

        // GET: Film/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Film/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Photo,Year,Description,Genre,Country,DurationMinutes")] FilmModel filmModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(filmModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filmModel);
        }

        // GET: Film/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmModel = await _context.Films.FindAsync(id);
            if (filmModel == null)
            {
                return NotFound();
            }
            return View(filmModel);
        }

        // POST: Film/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Photo,Year,Description,Genre,Country,DurationMinutes")] FilmModel filmModel)
        {
            if (id != filmModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filmModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmModelExists(filmModel.Id))
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
            return View(filmModel);
        }

        // GET: Film/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmModel = await _context.Films
                .FirstOrDefaultAsync(m => m.Id == id);
            if (filmModel == null)
            {
                return NotFound();
            }

            return View(filmModel);
        }

        // POST: Film/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var filmModel = await _context.Films.FindAsync(id);
            if (filmModel != null)
            {
                _context.Films.Remove(filmModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmModelExists(int id)
        {
            return _context.Films.Any(e => e.Id == id);
        }
    }
}
