using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductReviewAungAndBryant.Server.Data;
using ProductReviewAungAndBryant.Shared.Domain;

namespace ProductReviewAungAndBryant.Server.Controllers
{
    public class PcPartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PcPartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PcParts
        public async Task<IActionResult> Index()
        {
              return _context.PcParts != null ? 
                          View(await _context.PcParts.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.PcParts'  is null.");
        }

        // GET: PcParts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PcParts == null)
            {
                return NotFound();
            }

            var pcPart = await _context.PcParts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pcPart == null)
            {
                return NotFound();
            }

            return View(pcPart);
        }

        // GET: PcParts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PcParts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PcPartName,PcPartPrice,ReviewId,CategoryId,Id,DateCreated,DateUpdated,CreatedBy,UpdatedBy")] PcPart pcPart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pcPart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pcPart);
        }

        // GET: PcParts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PcParts == null)
            {
                return NotFound();
            }

            var pcPart = await _context.PcParts.FindAsync(id);
            if (pcPart == null)
            {
                return NotFound();
            }
            return View(pcPart);
        }

        // POST: PcParts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PcPartName,PcPartPrice,ReviewId,CategoryId,Id,DateCreated,DateUpdated,CreatedBy,UpdatedBy")] PcPart pcPart)
        {
            if (id != pcPart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pcPart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PcPartExists(pcPart.Id))
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
            return View(pcPart);
        }

        // GET: PcParts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PcParts == null)
            {
                return NotFound();
            }

            var pcPart = await _context.PcParts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pcPart == null)
            {
                return NotFound();
            }

            return View(pcPart);
        }

        // POST: PcParts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.PcParts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PcParts'  is null.");
            }
            var pcPart = await _context.PcParts.FindAsync(id);
            if (pcPart != null)
            {
                _context.PcParts.Remove(pcPart);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PcPartExists(int id)
        {
          return (_context.PcParts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
