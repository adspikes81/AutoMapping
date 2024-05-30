using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public record CreateBookDTO (
        [Required(ErrorMessage = "Book title is required")] 
        string BookTitle, 
        
        string BookDescription, 
        
        [Required(ErrorMessage = "Author is required")] 
        int AuthorId
    ) {

    }

    public record UpdateBookDTO(
        int Id,
       [Required(ErrorMessage = "Book title is required")]
        string BookTitle,

       string BookDescription,

       [Required(ErrorMessage = "Author is required")]
        int AuthorId
   )
    {

    }
}
