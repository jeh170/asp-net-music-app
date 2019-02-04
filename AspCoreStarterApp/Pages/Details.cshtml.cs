using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AspCoreStarterApp.Models;

namespace AspCoreStarterApp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly AspCoreStarterApp.Models.AspCoreStarterAppContext _context;

        public DetailsModel(AspCoreStarterApp.Models.AspCoreStarterAppContext context)
        {
            _context = context;
        }

        public Album Album { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Album = await _context.Album.FirstOrDefaultAsync(m => m.id == id);

            if (Album == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
