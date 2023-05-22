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
    public class IndexModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public IndexModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<AvaluoEstatus> AvaluoEstatus { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.AvaluoEstatus != null)
            {
                AvaluoEstatus = await _context.AvaluoEstatus.ToListAsync();
            }
        }
    }
}
