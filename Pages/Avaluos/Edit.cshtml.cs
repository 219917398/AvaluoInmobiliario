using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AvaluoInmobiliario.Data;
using AvaluoInmobiliario.Models;

namespace AvaluoInmobiliario.Pages.Avaluos
{
    public class EditModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public EditModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Avaluo Avaluo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Avaluos == null)
            {
                return NotFound();
            }

            var avaluo =  await _context.Avaluos.FirstOrDefaultAsync(m => m.Id == id);
            if (avaluo == null)
            {
                return NotFound();
            }
            Avaluo = avaluo;
           ViewData["EstatusAvaluoId"] = new SelectList(_context.AvaluoEstatus, "Id", "Descripcion");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Avaluo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaluoExists(Avaluo.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvaluoExists(int id)
        {
          return (_context.Avaluos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
