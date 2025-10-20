using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.models
{
    [Index(nameof(Title),IsUnique = true)]
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(300)] 
        public string Description { get; set; }
        [Required]
        public int CopiesAvailable { get; set; }

        public DateTime PublishedDate { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [ForeignKey("GenreId")]
        public int GenreId { get; set; }

        public ICollection<Author> authors { get; set; }

        public ICollection<Borrowing> borrowings { get; set; }



    }
}
