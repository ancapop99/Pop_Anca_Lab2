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
    public class IndexModel : PageModel
    {
        private readonly Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context _context;

        public IndexModel(Pop_Anca_LAb2.Data.Pop_Anca_LAb2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
            }
        }
    }
}
