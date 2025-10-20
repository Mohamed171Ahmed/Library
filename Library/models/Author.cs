using System.ComponentModel.DataAnnotations;

namespace Library.models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Bio { get; set; }

        public ICollection<Book> books { get; set; }

    }
}
