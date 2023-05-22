using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaluoInmobiliario.Data;
using AvaluoInmobiliario.Models;

namespace AvaluoInmobiliario.Pages.EstatusAvaluo
{
    public class DetailsModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public DetailsModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public AvaluoEstatus AvaluoEstatus { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.AvaluoEstatus == null)
            {
                return NotFound();
            }

            var avaluoestatus = await _context.AvaluoEstatus.FirstOrDefaultAsync(m => m.Id == id);
            if (avaluoestatus == null)
            {
                return NotFound();
            }
            else 
            {
                AvaluoEstatus = avaluoestatus;
            }
            return Page();
        }
    }
}
