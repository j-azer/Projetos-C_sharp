using Microsoft.AspNetCore.Identity;
using Microsoft.Exchange.WebServices.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace LibraryApp.Data.Entities;

public class Book
{
    public int Id { get; set; }
    
    [Required(ErrorMessage ="O campo {0} é de preenchimento obrigatório.")]
    [MaxLength(256)]    
    public string Title { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    [MaxLength(128)]    
    public string Author { get; set; }

    [Required(ErrorMessage = "O campo {0} é de preenchimento obrigatório.")]
    [MaxLength(128)]    
    public string Editor { get; set; }
   
    public int? Edition { get; set; }
    
    public DateTime Created { get; set; }

    public IdentityUser User { get; set; }
    public string UserId { get; set; }
}
