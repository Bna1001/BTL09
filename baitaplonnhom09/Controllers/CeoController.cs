using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using baitaplonnhom09.Models;
using baitaplonnhom09.Models.Process;

namespace baitaplonnhom09.Controllers
{
    public class CeoController : Controller
    {
        StringProcess strPro = new StringProcess();
        private readonly ApplicationDbContext _context;

        public CeoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Ceo
        public async Task<IActionResult> Index()
        {
              return _context.Ceo != null ? 
                          View(await _context.Ceo.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Ceo'  is null.");
        }

        // GET: Ceo/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Ceo == null)
            {
                return NotFound();
            }

            var ceo = await _context.Ceo
                .FirstOrDefaultAsync(m => m.CeoID == id);
            if (ceo == null)
            {
                return NotFound();
            }

            return View(ceo);
        }

        // GET: Ceo/Create
        public IActionResult Create()
        {   
            var newID = "";
            if (_context.Ceo.Count() == 0)
            {
                //khoi tao 1 ma moi
                newID = "CEO0001";
            }
            else
            {
                var id = _context.Ceo.OrderByDescending(m => m.CeoID).First().CeoID;
                newID = strPro.AutoGenerateKey(id);
            }
            ViewBag.CeoID = newID;
            return View();
        }

        // POST: Ceo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CeoID,CeoName,CeoPosition,CeoEarn,CeoPhoneNumber,CeoAddress,CeoBirth,CeoSex,CeoBank,CeoStart,CeoEnd")] Ceo ceo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ceo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ceo);
        }

        // GET: Ceo/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Ceo == null)
            {
                return NotFound();
            }

            var ceo = await _context.Ceo.FindAsync(id);
            if (ceo == null)
            {
                return NotFound();
            }
            return View(ceo);
        }

        // POST: Ceo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CeoID,CeoName,CeoPosition,CeoEarn,CeoPhoneNumber,CeoAddress,CeoBirth,CeoSex,CeoBank,CeoStart,CeoEnd")] Ceo ceo)
        {
            if (id != ceo.CeoID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ceo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CeoExists(ceo.CeoID))
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
            return View(ceo);
        }

        // GET: Ceo/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Ceo == null)
            {
                return NotFound();
            }

            var ceo = await _context.Ceo
                .FirstOrDefaultAsync(m => m.CeoID == id);
            if (ceo == null)
            {
                return NotFound();
            }

            return View(ceo);
        }

        // POST: Ceo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Ceo == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Ceo'  is null.");
            }
            var ceo = await _context.Ceo.FindAsync(id);
            if (ceo != null)
            {
                _context.Ceo.Remove(ceo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CeoExists(string id)
        {
          return (_context.Ceo?.Any(e => e.CeoID == id)).GetValueOrDefault();
        }
    }
}
