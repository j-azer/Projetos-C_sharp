using LibraryApp.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LibraryApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly LibraryApp.Data.ApplicationDbContext _context;

        public IndexModel(LibraryApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get; set; } = default!;

        public async Task OnGetAsync()
        {          

            if (_context.Books != null)
            {
                Book = await _context.Books.ToListAsync();
            }
        }
    }
}
