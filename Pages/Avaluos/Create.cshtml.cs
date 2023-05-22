using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AvaluoInmobiliario.Data;
using AvaluoInmobiliario.Models;
using Microsoft.AspNetCore.Identity;

namespace AvaluoInmobiliario.Pages.Avaluos
{
    public class CreateModel : PageModel
    {
        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(AvaluoInmobiliario.Data.ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult OnGet()
        {
            ViewData["EstatusAvaluoId"] = new SelectList(_context.AvaluoEstatus, "Id", "Descripcion");
            return Page();
        }

        [BindProperty]
        public Avaluo Avaluo { get; set; } = new Avaluo();

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Avaluos == null || Avaluo == null)
            {
                return Page();
            }

            // Get the current user's Id
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser != null)
            {
                Avaluo.UsuarioId = currentUser.Email;
            }
            _context.Avaluos.Add(Avaluo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using AvaluoInmobiliario.Data;
//using AvaluoInmobiliario.Models;
//using Microsoft.AspNetCore.Identity;

//namespace AvaluoInmobiliario.Pages.Avaluos
//{
//    public class CreateModel : PageModel
//    {
//        private readonly AvaluoInmobiliario.Data.ApplicationDbContext _context;


//        public CreateModel(AvaluoInmobiliario.Data.ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        public IActionResult OnGet()
//        {

//            ViewData["EstatusAvaluoId"] = new SelectList(_context.AvaluoEstatus, "Id", "Descripcion");
//            return Page();
//        }

//        [BindProperty]
//        public Avaluo Avaluo { get; set; } = default!;


//        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
//        public async Task<IActionResult> OnPostAsync()
//        {
//            if (!ModelState.IsValid || _context.Avaluos == null || Avaluo == null)
//            {
//                return Page();
//            }




//            _context.Avaluos.Add(Avaluo);
//            await _context.SaveChangesAsync();

//            return RedirectToPage("./Index");
//        }
//    }
//}
