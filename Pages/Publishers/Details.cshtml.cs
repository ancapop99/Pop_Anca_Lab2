using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Anca_LAb2.Data;
using Pop_Anca_LAb2.Models;

namespace Pop_Anca_LAb2.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context _context;

        public DetailsModel(Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
