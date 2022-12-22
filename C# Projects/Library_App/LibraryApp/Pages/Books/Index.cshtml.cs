using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Data;
using LibraryApp.Data.Entities;
using System.Security.Claims;

namespace LibraryApp.Pages.Books;

public class IndexModel : PageModel
{
    private readonly LibraryApp.Data.ApplicationDbContext _context;

    public IndexModel(LibraryApp.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Book> Book { get;set; } = default!;

    public async Task OnGetAsync()
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (_context.Books != null) 
        {
            Book = await _context.Books.Where(l => l.UserId == userId).ToListAsync();
        }
    }
}
