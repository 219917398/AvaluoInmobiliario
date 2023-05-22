using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaluoInmobiliario.Data;
using AvaluoInmobiliario.Models;

namespace AvaluoInmobiliario.Pages.Avaluos
{
    public class DeleteModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public DeleteModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
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

            var avaluo = await _context.Avaluos.FirstOrDefaultAsync(m => m.Id == id);

            if (avaluo == null)
            {
                return NotFound();
            }
            else 
            {
                Avaluo = avaluo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Avaluos == null)
            {
                return NotFound();
            }
            var avaluo = await _context.Avaluos.FindAsync(id);

            if (avaluo != null)
            {
                Avaluo = avaluo;
                _context.Avaluos.Remove(Avaluo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
