using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using AvaluoInmobiliario.Data;
using AvaluoInmobiliario.Models;

namespace AvaluoInmobiliario.Pages.Avaluos
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;

        public IndexModel(IConfiguration configuration, AvaluoInmobiliario.Data.ApplicationDbContext context)
        {
            _configuration = configuration;
            _context = context;
        }

        public IList<Avaluo> Avaluo { get; set; } = default!;

        public async Task OnGetAsync()
        {
            string currentUserEmail = User.Identity.Name;

            if (_context.Avaluos != null)
            {
                if (!string.IsNullOrEmpty(currentUserEmail))
                {
                    string[] configuredEmails = _configuration["EmailAsesores"].Split(';');

                    if (configuredEmails.Contains(currentUserEmail))
                    {
                        Avaluo = await _context.Avaluos.Include(a => a.EstatusAvaluo).ToListAsync();
                    }
                    else
                    {
                        Avaluo = await _context.Avaluos
                            .Where(a => a.UsuarioId == currentUserEmail)
                            .Include(a => a.EstatusAvaluo)
                            .ToListAsync();
                    }
                }
                else
                {
                    Avaluo = await _context.Avaluos.Include(a => a.EstatusAvaluo).ToListAsync();
                }
            }
        }
    }
}
