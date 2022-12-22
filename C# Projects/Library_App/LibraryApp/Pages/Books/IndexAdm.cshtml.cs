using LibraryApp.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LibraryApp.Pages.Books;

[Authorize (Roles = "admin")]
public class IndexAdmModel : PageModel
{
    private readonly LibraryApp.Data.ApplicationDbContext _context;

    
    public IndexAdmModel(LibraryApp.Data.ApplicationDbContext context)
    {
        _context = context;
    }

    public IList<Book> Book { get; set; } = default!;

    public async Task OnGetAsync()
    {       
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (_context.Books != null)
        {
            Book = await _context.Books.ToListAsync();
        }
    }
}
