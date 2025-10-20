using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.models
{
    public class Borrowing
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; } = "Borrowed";
        [Required]
        public User Users { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }


        public Book book { get; set; }
        [ForeignKey(nameof(Book))]
        [Required]
        public int BookId { get; set; }

     
    }
}
