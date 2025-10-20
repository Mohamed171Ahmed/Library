using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Library.models
{
    [Index(nameof(Name),IsUnique = true)]
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        
    }
}
