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

namespace AvaluoInmobiliario.Pages.EstatusAvaluo
{
    public class EditModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public EditModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AvaluoEstatus AvaluoEstatus { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AvaluoEstatus == null)
            {
                return NotFound();
            }

            var avaluoestatus =  await _context.AvaluoEstatus.FirstOrDefaultAsync(m => m.Id == id);
            if (avaluoestatus == null)
            {
                return NotFound();
            }
            AvaluoEstatus = avaluoestatus;
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

            _context.Attach(AvaluoEstatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvaluoEstatusExists(AvaluoEstatus.Id))
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

        private bool AvaluoEstatusExists(int id)
        {
          return (_context.AvaluoEstatus?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
