using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pop_Anca_LAb2.Data;
using Pop_Anca_LAb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pop_Anca_LAb2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context _context;

        public DetailsModel(Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                Book = book;
            }
            return Page();
        }
    }
}
