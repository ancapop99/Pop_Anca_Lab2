using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Anca_LAb2.Data;
using Pop_Anca_LAb2.Models;

namespace Pop_Anca_LAb2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context _context;

        public DetailsModel(Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
